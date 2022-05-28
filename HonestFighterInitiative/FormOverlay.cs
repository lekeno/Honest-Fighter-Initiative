using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonestFighterInitiative
{
    public partial class FormOverlay : Form
    {
        const double pingInterval = 1000;
        const int jitter_latency_samples_count = 15;
        const int line_max_char_count = 20;

        private DateTime currentDateTimeUtc;

        private MakeMovable _move;

        private const uint WS_EX_LAYERED = 0x00080000;
        private const uint WS_EX_TRANSPARENT = 0x00000020;

        public enum GWL
        {
            ExStyle = -20
        }

        System.Timers.Timer timer_ping_de = new System.Timers.Timer(pingInterval);
        System.Timers.Timer timer_ping_uk = new System.Timers.Timer(pingInterval);
        System.Timers.Timer timer_ping_usw = new System.Timers.Timer(pingInterval);
        System.Timers.Timer timer_ping_use = new System.Timers.Timer(pingInterval);
        System.Timers.Timer timer_ping_au = new System.Timers.Timer(pingInterval);

        System.Timers.Timer timer_clock_request = new System.Timers.Timer(10000);
        System.Timers.Timer timer_clock = new System.Timers.Timer(1000);

        /*
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong(HandleRef hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        */

        [DllImport("user32.dll")]
        public static extern uint GetWindowLong(IntPtr hWnd, GWL nIndex);

        [DllImport("user32.dll")]
        public static extern uint SetWindowLong(IntPtr hWnd, GWL nIndex, uint dwNewLong);


        public FormOverlay()
        {
            /*
                the way of programming is deliberately kept simple and not too nested 
                to give also non-professional programmers the possibility to better understand the code
            */

            InitializeComponent();
            
            _move = new MakeMovable(this);
            _move.SetMovable(pcb_Logo);

            ClickThrough_Enable();

            this.AllowTransparency = true;
            this.BackColor = Color.Black;
            this.TransparencyKey = this.BackColor;

            #region StartPosition
        
            int? config_startPositionX = string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["startPositionX"]) ? null : Convert.ToInt32(ConfigurationManager.AppSettings["startPositionX"]);
            int? config_startPositionY = string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["startPositionY"]) ? null : Convert.ToInt32(ConfigurationManager.AppSettings["startPositionY"]);

            if (config_startPositionX == null || config_startPositionY == null)
            {
                Rectangle workingArea = Screen.GetWorkingArea(this);
                this.Location = new Point(workingArea.Left + 10, workingArea.Bottom - Size.Height - (Convert.ToInt32(workingArea.Height * 0.3)));
            }
            else
            {
                this.Location = new Point((int)config_startPositionX, (int)config_startPositionY);
            }

            #endregion

            var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
            lbl_SerialNumber.Text = $"{assemblyVersion.Major}{assemblyVersion.Minor}{assemblyVersion.Build}{assemblyVersion.Revision}";

            #region Timers

            timer_ping_de.Elapsed += Timer_ping_de_Elapsed;
            timer_ping_uk.Elapsed += Timer_ping_uk_Elapsed;
            timer_ping_usw.Elapsed += Timer_ping_usw_Elapsed;
            timer_ping_use.Elapsed += Timer_ping_use_Elapsed;
            timer_ping_au.Elapsed += Timer_ping_au_Elapsed;

            timer_clock_request.Elapsed += Timer_clock_request_Elapsed;
            timer_clock.Elapsed += Timer_clock_Elapsed;

            timer_ping_de.AutoReset = true;
            timer_ping_uk.AutoReset = true;
            timer_ping_usw.AutoReset = true;
            timer_ping_use.AutoReset = true;
            timer_ping_au.AutoReset = true;

            timer_clock_request.AutoReset = true;
            timer_clock.AutoReset = true;

            timer_ping_de.Start();
            timer_ping_uk.Start();
            timer_ping_usw.Start();
            timer_ping_use.Start();
            timer_ping_au.Start();

            DateTime? dateTimeFromUtcServer = Utils.GetUtcTimeFromServer();
            currentDateTimeUtc = dateTimeFromUtcServer ?? DateTime.UtcNow;

            timer_clock_request.Start();
            timer_clock.Start();

            #endregion
        }

        private void Timer_clock_request_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                DateTime? dateTimeFromUtcServer = Utils.GetUtcTimeFromServer();

                currentDateTimeUtc = dateTimeFromUtcServer ?? DateTime.UtcNow;

                this.Invoke(new Action(() =>
                {
                    lbl_Clock.Text = currentDateTimeUtc.ToString("HH:mm:ss");

                    if (lbl_Banner.Visible == true)
                    {
                        lbl_Banner.Visible = false;
                    }
                }));
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private void Timer_clock_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (currentDateTimeUtc == default)
                {
                    currentDateTimeUtc = DateTime.UtcNow;
                }
                else
                {
                    currentDateTimeUtc += TimeSpan.FromSeconds(1);
                }

                this.Invoke(new Action(() =>
                {
                    lbl_Clock.Text = currentDateTimeUtc.ToString("HH:mm:ss");
                }));
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private async void Timer_ping_au_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                long? roundtripTime = await PingRoundtrip(StaticData_Const.Ping_Host_AU);

                string newText_Ping = roundtripTime == null || roundtripTime <= 0 ? "X" : $"{(long)roundtripTime} ms";

                StaticData.latencies_AU.Add(Convert.ToDouble(roundtripTime));
                if (StaticData.latencies_AU.Count > jitter_latency_samples_count)
                {
                    StaticData.latencies_AU.RemoveAt(0);
                }

                double? jitter_value = JitterCalc(ref StaticData.latencies_AU);

                string newText_Jitter = jitter_value == null ? "X" : $"{string.Format("{0:n2}", jitter_value)}";

                this.Invoke(new Action(() =>
                {
                    lbl_Ping_AU.Text = newText_Ping;
                    //Debug.Print(lbl_Ping_AU.Text);
                    lbl_Jitter_AU.Text = newText_Jitter;

                    string lts = LatencyTextLine((long)roundtripTime);
                    lbl_Line_AU.Text = lts;
                    if (lts.Count() == line_max_char_count)
                    {
                        lbl_Line_AU.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_Line_AU.ForeColor = Color.White;
                    }
                    //DrawLine(ref pcb_Graphic_AU, (long)roundtripTime);
                }));
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private string LatencyTextLine(long pingValue)
        {
            string lineText = "";

            try
            {
                int textLineCharCount = pingValue > StaticData_Const.max_ping_ok || pingValue <= 0 ? line_max_char_count : Convert.ToInt32(Convert.ToDouble(pingValue) / Convert.ToDouble(StaticData_Const.max_ping_ok) * line_max_char_count);

                for (int i = 0; i < textLineCharCount; i++)
                {
                    lineText += "-";
                }

                return lineText;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }

            return "X";
        }

        private void DrawLine(ref PictureBox control, long pingValue)
        {
            try
            {
                control.Image?.Dispose();
                //.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics g = control.CreateGraphics())
                {
                    Pen pen = pingValue > StaticData_Const.max_ping_ok ? new Pen(Color.Red, 2) : new Pen(Color.White, 2);
                    //pen.Width = 2;

                    double maxHeight = Convert.ToDouble(g.DpiY);
                    double maxWidth = Convert.ToDouble(g.DpiX);

                    double lineWidth = pingValue > StaticData_Const.max_ping_ok ? maxWidth : Convert.ToDouble(pingValue) / Convert.ToDouble(StaticData_Const.max_ping_ok) * maxWidth;

                    Point startPoint = new Point(0, Convert.ToInt32(maxHeight / 2));

                    Point endPoint = new Point(Convert.ToInt32(lineWidth), Convert.ToInt32(maxHeight / 2));

                    g.DrawLine(pen, startPoint, endPoint);
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private async void Timer_ping_use_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                long? roundtripTime = await PingRoundtrip(StaticData_Const.Ping_Host_USE);

                string newText_Ping = roundtripTime == null || roundtripTime <= 0 ? "X" : $"{(long)roundtripTime} ms";

                StaticData.latencies_USE.Add(Convert.ToDouble(roundtripTime));
                if (StaticData.latencies_USE.Count > jitter_latency_samples_count)
                {
                    StaticData.latencies_USE.RemoveAt(0);
                }

                double? jitter_value = JitterCalc(ref StaticData.latencies_USE);

                string newText_Jitter = jitter_value == null ? "X" : $"{string.Format("{0:n2}", jitter_value)}";

                this.Invoke(new Action(() =>
                {
                    lbl_Ping_USE.Text = newText_Ping;
                    lbl_Jitter_USE.Text = newText_Jitter;

                    string lts = LatencyTextLine((long)roundtripTime);
                    lbl_Line_USE.Text = lts;
                    if (lts.Count() == line_max_char_count)
                    {
                        lbl_Line_USE.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_Line_USE.ForeColor = Color.White;
                    }
                }));
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private async void Timer_ping_usw_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                long? roundtripTime = await PingRoundtrip(StaticData_Const.Ping_Host_USW);

                string newText_Ping = roundtripTime == null || roundtripTime <= 0 ? "X" : $"{(long)roundtripTime} ms";

                StaticData.latencies_USW.Add(Convert.ToDouble(roundtripTime));
                if (StaticData.latencies_USW.Count > jitter_latency_samples_count)
                {
                    StaticData.latencies_USW.RemoveAt(0);
                }

                double? jitter_value = JitterCalc(ref StaticData.latencies_USW);

                string newText_Jitter = jitter_value == null ? "X" : $"{string.Format("{0:n2}", jitter_value)}";

                this.Invoke(new Action(() =>
                {
                    lbl_Ping_USW.Text = newText_Ping;
                    lbl_Jitter_USW.Text = newText_Jitter;

                    string lts = LatencyTextLine((long)roundtripTime);
                    lbl_Line_USW.Text = lts;
                    if (lts.Count() == line_max_char_count)
                    {
                        lbl_Line_USW.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_Line_USW.ForeColor = Color.White;
                    }
                }));
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private async void Timer_ping_uk_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                long? roundtripTime = await PingRoundtrip(StaticData_Const.Ping_Host_UK);

                string newText_Ping = roundtripTime == null || roundtripTime <= 0  ? "X" : $"{(long)roundtripTime} ms";

                StaticData.latencies_UK.Add(Convert.ToDouble(roundtripTime));
                if (StaticData.latencies_UK.Count > jitter_latency_samples_count)
                {
                    StaticData.latencies_UK.RemoveAt(0);
                }

                double? jitter_value = JitterCalc(ref StaticData.latencies_UK);

                string newText_Jitter = jitter_value == null ? "X" : $"{string.Format("{0:n2}", jitter_value)}";

                this.Invoke(new Action(() =>
                {
                    lbl_Ping_UK.Text = newText_Ping;
                    lbl_Jitter_UK.Text = newText_Jitter;

                    string lts = LatencyTextLine((long)roundtripTime);
                    lbl_Line_UK.Text = lts;
                    if (lts.Count() == line_max_char_count)
                    {
                        lbl_Line_UK.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_Line_UK.ForeColor = Color.White;
                    }
                }));
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private async void Timer_ping_de_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                long? roundtripTime = await PingRoundtrip(StaticData_Const.Ping_Host_DE);

                string newText_Ping = roundtripTime == null || roundtripTime <= 0 ? "X" : $"{(long)roundtripTime} ms";

                StaticData.latencies_DE.Add(Convert.ToDouble(roundtripTime));
                if (StaticData.latencies_DE.Count > jitter_latency_samples_count)
                {
                    StaticData.latencies_DE.RemoveAt(0);
                }

                double? jitter_value = JitterCalc(ref StaticData.latencies_DE);

                string newText_Jitter = jitter_value == null ? "X" : $"{string.Format("{0:n2}", jitter_value)}";

                this.Invoke(new Action(() =>
                {
                    lbl_Ping_DE.Text = newText_Ping;
                    lbl_Jitter_DE.Text = newText_Jitter;

                    string lts = LatencyTextLine((long)roundtripTime);
                    lbl_Line_DE.Text = lts;
                    if (lts.Count() == line_max_char_count)
                    {
                        lbl_Line_DE.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_Line_DE.ForeColor = Color.White;
                    }
                }));
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private void Label_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Utils.Text_Paint(sender, e);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private async Task<long?> PingRoundtrip(string host)
        {
            try
            {
                PingService pingService = new PingService();
                PingReply reply = await pingService.PingTo(host);

                long roundtripTime = reply.RoundtripTime;

                return roundtripTime;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }

            return null;
        }

        public double? JitterCalc(ref List<double> pLatencies)
        {
            //https://www.pingman.com/kb/article/what-is-jitter-57.html#:~:text=To%20measure%20Jitter,%20we%20take,them,%20divide%20by%205).
            try
            {
                double? jitterValue = null;

                List<double> latenciesDifferences = new List<double>();

                for (int i = 0; i < pLatencies.Count - 1; i++)
                {
                    double diff = pLatencies[i + 1] - pLatencies[i];
                    latenciesDifferences.Add(diff);
                }

                jitterValue = latenciesDifferences.Sum() / latenciesDifferences.Count;

                return jitterValue;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }

            return null;
        }

        private void ClickThrough_Enable()
        {
            //https://stackoverflow.com/questions/25743982/setwindowlong-enable-disable-click-through-form
            try
            {
                uint ex_style = GetWindowLong(this.Handle, GWL.ExStyle);
                SetWindowLong(this.Handle, GWL.ExStyle, ex_style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
                this.TransparencyKey = this.BackColor;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private void ClickThrough_Disable()
        {
            //https://stackoverflow.com/questions/25743982/setwindowlong-enable-disable-click-through-form
            try
            {
                uint ex_style = GetWindowLong(this.Handle, GWL.ExStyle);
                SetWindowLong(this.Handle, GWL.ExStyle, ex_style & ~WS_EX_LAYERED & ~WS_EX_TRANSPARENT);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private void FormOverlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["startPositionX"].Value = this.Location.X.ToString();
                config.AppSettings.Settings["startPositionY"].Value = this.Location.Y.ToString();
                config.Save(ConfigurationSaveMode.Minimal);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private void enableRelocatingmodeToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch (enableRelocatingmodeToolStripMenuItem.Checked)
                {
                    case true:
                        {
                            ClickThrough_Disable();
                        }
                        break;
                    case false:
                        {
                            ClickThrough_Enable();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAbout formAbout = new FormAbout();
                formAbout.ShowDialog();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }
    }
}
