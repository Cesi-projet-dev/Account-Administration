using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ces_it.VIEW.INTERFACE
{
    public partial class UserPage : Form
    {
        // VARIABLE DECLARATION --> 
        private const int WmNchittest = 0x0084;
        private const int Htclient = 1;
        private const int Htcaption = 2;
        public string IdUser;
        private int tempComboBox = 1;

        // CONTROLLER DECLARATION --> 
        private readonly CONTROLLER.LogController _logClassControl = new CONTROLLER.LogController();
        private readonly CONTROLLER.DataBase.ConnectionController _connectClassControl = new CONTROLLER.DataBase.ConnectionController();
        private readonly CONTROLLER.User.UserController _userClassControl = new CONTROLLER.User.UserController();
        private readonly CONTROLLER.Design.DesignInterfaceController _designClassControl = new CONTROLLER.Design.DesignInterfaceController();


        /// <summary>
        /// Loading component
        /// </summary>
        public UserPage()
        {
            InitializeComponent();
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
        /// Function used when the form is loading ( Design and show data ) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserPage_Load(object sender, EventArgs e)
        {

            TitleName_Label.Text += " " + _userClassControl.GetInfoUser(IdUser).Item1.ToString();
            TitleSurname_Label.Text += " " + _userClassControl.GetInfoUser(IdUser).Item2.ToString();
            TitleEmail_Name.Text += " " + _userClassControl.GetInfoUser(IdUser).Item3.ToString();
            TitlePhone_Label.Text += " " + _userClassControl.GetInfoUser(IdUser).Item4.ToString();
            TitleAge_Label.Text += " " + _userClassControl.GetInfoUser(IdUser).Item5.ToString();
            TitleAdress_Label.Text += " " + _userClassControl.GetInfoUser(IdUser).Item6.ToString();
            LastLoginTile_Label.Text += " " + _userClassControl.GetInfoUser(IdUser).Item7.ToString();
            TitleCity_Label.Text += " " + _userClassControl.GetCityByUser(IdUser).ToString();

            DataTable dt = new DataTable();
            _designClassControl.AdapterFillComboBox().Fill(dt);

            //Insert the Default Item to DataTable.
            DataRow row = dt.NewRow();
            row[0] = _userClassControl.GetValueDefaultComboBox(IdUser);
            dt.Rows.InsertAt(row, 0);

            Credential_ComboBox.DataSource = dt;
            Credential_ComboBox.DisplayMember = "TYPE";
            Credential_ComboBox.ValueMember = "TYPE";
            tempComboBox = 2;


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
        /// Function used when the text in the ComboBox is changing, means the TYPE of the user was changed by the Admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Credential_ComboBox_TextChanged(object sender, EventArgs e)
        {
            if (tempComboBox == 2)
            {
                _designClassControl.UpdateTypeUser(_userClassControl.GetTypeValueById(Credential_ComboBox.Text), IdUser);
                Credential_ComboBox.Refresh();

            }
            else
            {

            }
            
        }
    }
}
