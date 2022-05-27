using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonestFighterInitiative
{
    public partial class FormAbout : Form
    {
        public System.Diagnostics.Process p = new System.Diagnostics.Process();

        public FormAbout()
        {
            InitializeComponent();
        }

        private void rtb_Text_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                p = System.Diagnostics.Process.Start(e.LinkText);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }
    }
}
