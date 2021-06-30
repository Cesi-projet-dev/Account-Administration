using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ces_it.VIEW.INTERFACE
{
    public partial class SetttingsPage : Form
    {
        private const int WmNchittest = 0x0084;
        private const int Htclient = 1;
        private const int Htcaption = 2;
        public SetttingsPage()
        {
            InitializeComponent();
        }

        // --> All the Event about the Active form
        #region WindowsEvent
        private void SetttingsPage_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Move the Active Form
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != WmNchittest) return;
            if (m.Result == (IntPtr)Htclient)
            {
                m.Result = (IntPtr)Htcaption;
            }
        }

        /// <summary>
        /// Function used to close this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Closed_PictureBox_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Refresh all composant about this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh_PictureBox_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        /// <summary>
        /// Function used to reduce the windows in the taskbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reduce_PictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion   


    }
}
