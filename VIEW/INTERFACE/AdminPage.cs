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
        private const int WmNchittest = 0x0084;
        private const int Htclient = 1;
        private const int Htcaption = 2;
        public string typeInterface;

        // CONTROLLER DECLARATION --> 
        private readonly CONTROLLER.LogController _logClassControl = new CONTROLLER.LogController();
        private readonly CONTROLLER.DataBase.ConnectionController _connectClassControl = new CONTROLLER.DataBase.ConnectionController();
        private readonly CONTROLLER.User.UserController _userClassControl = new CONTROLLER.User.UserController();
        private readonly CONTROLLER.Design.DesignInterfaceController _designClassControl = new CONTROLLER.Design.DesignInterfaceController();
   
        /// <summary>
        /// Loading component AdminPage
        /// </summary>
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
            if (m.Msg != WmNchittest) return;
            if (m.Result == (IntPtr)Htclient)
            {
                m.Result = (IntPtr)Htcaption;
            }
        }

        /// <summary>
        /// All action used while the form is loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminPage_Load(object sender, EventArgs e)
        {
            // Design 
            TypeInterface_Label.Text = typeInterface.ToString();

            // Show Data In DGV
            var dtRecordColumn = new DataTable();
            _designClassControl.ListFillDataGrid().Fill(dtRecordColumn);
            User_DataGridView.DataSource = dtRecordColumn;
            User_DataGridView.Columns["ID"].Visible = false;




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

        /// <summary>
        /// Function used when the user is douleclicking on a specific person in the DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_DataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserPage userPage = new UserPage
            {
                IdUser = User_DataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString()

            };
            userPage.Show();
         
        }

        private void Role_ContextMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TEST : " );
        }

        /// <summary>
        /// Specific user is deleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_ContextMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DELETE USER : \n\n" + User_DataGridView.Rows[0].Cells[0].Value + " OU ALORS \n\n" + User_DataGridView.CurrentRow.Cells[0].Value.ToString()); ;
        }
    }
    
}
