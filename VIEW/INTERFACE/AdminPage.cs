using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ces_it.VIEW.INTERFACE
{
    public partial class AdminPage : Form
    {
        // VARIABLE DECLARATION --> 
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        // CONTROLLER DECLARATION --> 
        private readonly CONTROLLER.LogController logClassControl = new CONTROLLER.LogController();
        private readonly CONTROLLER.DataBase.ConnectionController connectClassControl = new CONTROLLER.DataBase.ConnectionController();
        private readonly CONTROLLER.User.UserController userClassControl = new CONTROLLER.User.UserController();
        private readonly CONTROLLER.Design.DesignInterfaceController designClassControl = new CONTROLLER.Design.DesignInterfaceController();
   
        public AdminPage()
        {
            InitializeComponent();
        }

        // --> All the Event about the Active form
        #region WindowsEvents

        /// <summary>
        /// Move the Active Form
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
            {
                if (m.Result == (IntPtr)HTCLIENT)
                {
                    m.Result = (IntPtr)HTCAPTION;
                }
            }
        }

        /// <summary>
        /// All action used while the form is loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminPage_Load(object sender, EventArgs e)
        {
            DataTable dtRecordColumn = new DataTable();
            designClassControl.ListFillDataGrid().Fill(dtRecordColumn);
            User_DataGridView.DataSource = dtRecordColumn;


        }

        /// <summary>
        /// Function used to close this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Closed_PictureBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Refresh all composant about this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh_PictureBox_Click(object sender, EventArgs e)
        {
            this.Refresh();
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
