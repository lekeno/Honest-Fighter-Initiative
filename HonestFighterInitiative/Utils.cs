using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonestFighterInitiative
{
    internal static class Utils
    {
        internal static void Text_Paint(object sender, PaintEventArgs e)
        {
            //Clean paint
            try
            {
                e.Graphics.Clear(((Control)sender).BackColor);

                using (var sf = new StringFormat())
                using (var br = new SolidBrush(((Control)sender).ForeColor))
                {
                    sf.Alignment = sf.LineAlignment = sender is Label ? GetStringAlignment((Label)sender) : StringAlignment.Center;
                    e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
                    e.Graphics.DrawString(((Control)sender).Text, ((Control)sender).Font, br,
                        ((Control)sender).ClientRectangle, sf);
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private static StringAlignment GetStringAlignment(Label sender)
        {
            var result = StringAlignment.Center;

            try
            {
                switch (sender.TextAlign)
                {
                    case ContentAlignment.TopLeft:
                        result = StringAlignment.Near;
                        break;
                    case ContentAlignment.TopCenter:
                        result = StringAlignment.Center;
                        break;
                    case ContentAlignment.TopRight:
                        result = StringAlignment.Far;
                        break;
                    case ContentAlignment.MiddleLeft:
                        result = StringAlignment.Near;
                        break;
                    case ContentAlignment.MiddleCenter:
                        result = StringAlignment.Center;
                        break;
                    case ContentAlignment.MiddleRight:
                        result = StringAlignment.Far;
                        break;
                    case ContentAlignment.BottomLeft:
                        result = StringAlignment.Near;
                        break;
                    case ContentAlignment.BottomCenter:
                        result = StringAlignment.Center;
                        break;
                    case ContentAlignment.BottomRight:
                        result = StringAlignment.Far;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }

            return result;
        }
    }
}
