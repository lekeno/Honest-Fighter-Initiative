using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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
                    sf.Alignment = sf.LineAlignment = StringAlignment.Center;
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

    }
}
