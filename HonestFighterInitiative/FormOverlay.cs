using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonestFighterInitiative
{
    public partial class FormOverlay : Form
    {
        const double pingInterval = 1000;
        const int jitter_latency_samples_count = 5;

        System.Timers.Timer timer_ping_de = new System.Timers.Timer(pingInterval);
        System.Timers.Timer timer_ping_uk = new System.Timers.Timer(pingInterval);
        System.Timers.Timer timer_ping_usw = new System.Timers.Timer(pingInterval);
        System.Timers.Timer timer_ping_use = new System.Timers.Timer(pingInterval);
        System.Timers.Timer timer_ping_au = new System.Timers.Timer(pingInterval);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong(HandleRef hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);


        public FormOverlay()
        {
            InitializeComponent();

            #region Enable click-through
            //https://stackoverflow.com/questions/2798245/click-through-in-c-sharp-form
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(new HandleRef(this, this.Handle), -20, initialStyle | 0x80000 | 0x20); 
            
            #endregion

            this.AllowTransparency = true;
            this.BackColor = Color.Red;
            this.TransparencyKey = this.BackColor;

            #region Timers

            timer_ping_de.Elapsed += Timer_ping_de_Elapsed;
            timer_ping_uk.Elapsed += Timer_ping_uk_Elapsed;
            timer_ping_usw.Elapsed += Timer_ping_usw_Elapsed;
            timer_ping_use.Elapsed += Timer_ping_use_Elapsed;
            timer_ping_au.Elapsed += Timer_ping_au_Elapsed;

            timer_ping_de.AutoReset = true;
            timer_ping_uk.AutoReset = true;
            timer_ping_usw.AutoReset = true;
            timer_ping_use.AutoReset = true;
            timer_ping_au.AutoReset = true;

            timer_ping_de.Start();
            timer_ping_uk.Start();
            timer_ping_usw.Start();
            timer_ping_use.Start();
            timer_ping_au.Start(); 

            #endregion
        }

        private async void Timer_ping_au_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                long? roundtripTime = await PingRoundtrip(StaticData_Const.Ping_Host_AU);

                string newText_Ping = roundtripTime == null ? "NO INFO" : $"{((long)roundtripTime).ToString("N")}ms";

                StaticData.latencies_AU.Add(Convert.ToDouble(roundtripTime));
                if (StaticData.latencies_AU.Count > jitter_latency_samples_count)
                {
                    StaticData.latencies_AU.RemoveAt(0);
                }

                double? jitter_value = JitterCalc(ref StaticData.latencies_AU);

                string newText_Jitter = jitter_value == null ? "NO INFO" : $"{string.Format("{0:n2}", jitter_value)}";

                this.Invoke(new Action(() => {
                    lbl_Ping_AU.Text = newText_Ping;
                    lbl_Jitter_AU.Text = newText_Jitter;
                }));
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

                string newText_Ping = roundtripTime == null ? "NO INFO" : $"{((long)roundtripTime).ToString("N")}ms";

                StaticData.latencies_USE.Add(Convert.ToDouble(roundtripTime));
                if (StaticData.latencies_USE.Count > jitter_latency_samples_count)
                {
                    StaticData.latencies_USE.RemoveAt(0);
                }

                double? jitter_value = JitterCalc(ref StaticData.latencies_USE);

                string newText_Jitter = jitter_value == null ? "NO INFO" : $"{string.Format("{0:n2}", jitter_value)}";

                this.Invoke(new Action(() => {
                    lbl_Ping_USE.Text = newText_Ping;
                    lbl_Jitter_USE.Text = newText_Jitter;
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

                string newText_Ping = roundtripTime == null ? "NO INFO" : $"{((long)roundtripTime).ToString("N")}ms";

                StaticData.latencies_USW.Add(Convert.ToDouble(roundtripTime));
                if (StaticData.latencies_USW.Count > jitter_latency_samples_count)
                {
                    StaticData.latencies_USW.RemoveAt(0);
                }

                double? jitter_value = JitterCalc(ref StaticData.latencies_USW);

                string newText_Jitter = jitter_value == null ? "NO INFO" : $"{string.Format("{0:n2}", jitter_value)}";

                this.Invoke(new Action(() => {
                    lbl_Ping_USW.Text = newText_Ping;
                    lbl_Jitter_USW.Text = newText_Jitter;
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

                string newText_Ping = roundtripTime == null ? "NO INFO" : $"{((long)roundtripTime).ToString("N")}ms";

                StaticData.latencies_UK.Add(Convert.ToDouble(roundtripTime));
                if (StaticData.latencies_UK.Count > jitter_latency_samples_count)
                {
                    StaticData.latencies_UK.RemoveAt(0);
                }

                double? jitter_value = JitterCalc(ref StaticData.latencies_UK);

                string newText_Jitter = jitter_value == null ? "NO INFO" : $"{string.Format("{0:n2}", jitter_value)}";

                this.Invoke(new Action(() => {
                    lbl_Ping_UK.Text = newText_Ping;
                    lbl_Jitter_UK.Text = newText_Jitter;
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

                string newText_Ping = roundtripTime == null ? "NO INFO" : $"{((long)roundtripTime).ToString("N")}ms";

                StaticData.latencies_DE.Add(Convert.ToDouble(roundtripTime));
                if (StaticData.latencies_DE.Count > jitter_latency_samples_count)
                {
                    StaticData.latencies_DE.RemoveAt(0);
                }

                double? jitter_value = JitterCalc(ref StaticData.latencies_DE);

                string newText_Jitter = jitter_value == null ? "NO INFO" : $"{string.Format("{0:n2}", jitter_value)}";

                this.Invoke(new Action(() => {
                    lbl_Ping_DE.Text = newText_Ping;
                    lbl_Jitter_DE.Text = newText_Jitter;
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

                for (int i = 0; i < pLatencies.Count-1; i++)
                {
                    double diff = pLatencies[i+1] - pLatencies[i];
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
    }
}
