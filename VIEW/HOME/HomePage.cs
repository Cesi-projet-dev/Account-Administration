using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ces_it.VIEW.HOME
{
    public partial class HomePage : Form
    {
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;
        public HomePage()
        {
            InitializeComponent();
        }

        // --> All the Event about the Active form
        #region WindowControl

        /// <summary>
        /// Move the Active Form
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc( ref Message m )
        {
            base.WndProc(ref m );
            if ( m.Msg == WM_NCHITTEST )
            {
                if ( m.Result == (IntPtr )HTCLIENT )
                {
                    m.Result = (IntPtr )HTCAPTION;
                }
            }
        }

        /// <summary>
        /// Function used while the windows is loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomePage_Load(object sender, EventArgs e)
        {
            Password_TextBox.UseSystemPasswordChar = true;
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

        /// <summary>
        /// Refresh all this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh_PictureBox_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        /// <summary>
        /// Function used to close the windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Closed_PictureBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Function used to hide password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HidePw_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ( HidePw_CheckBox.Checked == true )
            {
                Password_TextBox.UseSystemPasswordChar = false;
            }
            else
            {
                Password_TextBox.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Function used to open settingsPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_PictureBox_Click(object sender, EventArgs e)
        {
            INTERFACE.SetttingsPage settingsForm = new INTERFACE.SetttingsPage
            {

            };
            settingsForm.Show();
           
        }
        #endregion


        /// <summary>
        /// Used to connect to an interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connection_Button_Click(object sender, EventArgs e)
        {
            try
            {
                INTERFACE.AdminPage adminForm = new INTERFACE.AdminPage
                {

                };
                adminForm.Show();
                

            }
            catch
            {

            }
        }

        
    }
}
