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
        public HomePage()
        {
            InitializeComponent();
        }

        #region WindowControl

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
        /// Refresh all the windows
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


        #endregion

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
        /// Used to connect to an interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connection_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
