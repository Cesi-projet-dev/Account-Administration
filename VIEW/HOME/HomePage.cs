using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ces_it.Properties;

namespace Ces_it.VIEW.HOME
{
    public partial class HomePage : Form
    {
        // VARIABLE DECLARATION --> 
        private const int WmNchittest = 0x0084;
        private const int Htclient = 1;
        private const int Htcaption = 2;

        // CONTROLLER DECLARATION --> 
        private readonly CONTROLLER.LogController _logClassControl = new CONTROLLER.LogController();
        private readonly CONTROLLER.DataBase.ConnectionController _connectClassControl = new CONTROLLER.DataBase.ConnectionController();
        private readonly CONTROLLER.User.UserController _userClassControl = new CONTROLLER.User.UserController();


        // CODE PAGE --> 

        /// <summary>
        /// Loading component of HomePage
        /// </summary>
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
            if (m.Msg != WmNchittest) return;
            if ( m.Result == (IntPtr )Htclient )
            {
                m.Result = (IntPtr )Htcaption;
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

            _logClassControl.CheckFileLog();

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
            _logClassControl.WriteLog("                                                                        --- SOFTWARE CLOSED AT : " + DateTime.Now.ToString() + " ---");
        }

        /// <summary>
        /// Function used to hide password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HidePw_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Password_TextBox.UseSystemPasswordChar = HidePw_CheckBox.Checked != true;
        }

        /// <summary>
        /// Function used to open settingsPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_PictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                var settingsForm = new INTERFACE.SetttingsPage
                {

                };
                settingsForm.Show();
                _logClassControl.WriteLog("[SUCCESS]-[HomePage]-[Settings_PictureBox_Click]-[TRY] : ");
            }
            catch (Exception catchErrorOpenSettings)
            {
                _logClassControl.WriteLog("[ERROR]-[HomePage]-[Settings_PictureBox_Click]-[CATCH] : " + catchErrorOpenSettings);
            }
            
           
        }
        #endregion


        /// <summary>
        /// Used to connect to an interface
        /// </summary>S
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connection_Button_Click(object sender, EventArgs e)
        {
            if ( _connectClassControl.TryConnect(User_TextBox.Text,Password_TextBox.Text) == true ) // Check if the User can be connected to the SoftWare
            {
                switch ( _userClassControl.GetCredential(User_TextBox.Text, Password_TextBox.Text)) // Switch used to show the interface according to the user's role
                {
                    case 1: // ADMIN INTERFACE /----/
                        try
                        {
                            INTERFACE.AdminPage adminForm = new INTERFACE.AdminPage
                            {
                                typeInterface = Properties.ViewRsx.Resources.NameInterfaceAdmin
                            };
                            adminForm.Show();
                            _logClassControl.WriteLog(Properties.ViewRsx.Resources.SucessHomePageConnectionAdminLog + User_TextBox.Text + " : ");
                        }
                        catch (Exception catchErrorOpenInterface)
                        {
                            _logClassControl.WriteLog(Properties.ViewRsx.Resources.SucessHomePageConnectionAdminLog + User_TextBox.Text + " : ERROR : " + catchErrorOpenInterface);
                        }
                        break;
                    case 2:// COMMERCIAL INTERFACE /----/
                        try
                        {
                            INTERFACE.AdminPage adminForm = new INTERFACE.AdminPage
                            {
                                typeInterface = Properties.ViewRsx.Resources.NameInterfaceCommercial
                            };
                            adminForm.Show();
                            _logClassControl.WriteLog(Properties.ViewRsx.Resources.SucessHomePageConnectionCommercialLog + User_TextBox.Text + " : ");
                        }
                        catch (Exception catchErrorOpenInterface)
                        {
                            _logClassControl.WriteLog("[ERROR]-[HomePage]-[Connection_Button_Click]-[CATCH] : " + User_TextBox.Text + " : ERROR : " + catchErrorOpenInterface);
                        }
                        break;
                    case 3:// LIVREUR INTERFACE /----/
                        MessageBox.Show("Vous n'avez pas accès à la gestion des comptes", "INTERFACE LIVREUR");
                        break;
                    case 4:// RESTAURATEUR INTERFACE /----/
                        MessageBox.Show("Vous n'avez pas accès à la gestion des comptes", "INTERFACE RESTAURATEUR");
                        break;
                    case 5:// CLIENT INTERFACE /----/
                        MessageBox.Show("Vous n'avez pas accès à la gestion des comptes", "INTERFACE CLIENT");
                        break;
                    default:
                        MessageBox.Show("ERREUR CONNEXION");
                        break;

                        
                }
                User_TextBox.Clear();
                Password_TextBox.Clear();
            }
            else
            {
                _logClassControl.WriteLog(Properties.ViewRsx.Resources.ErrorSwitchCaseConnection + User_TextBox.Text + " : ERROR : " );
                MessageBox.Show("Erreur de connexion MySql. \n" +
                    "Consultez les logs pour plus d'informations","Erreur connexion MySql");
            }
            
        }

       
    }
}
