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
        // VARIABLE DECLARATION --> 
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        // CONTROLLER DECLARATION --> 
        private readonly CONTROLLER.LogController logClassControl = new CONTROLLER.LogController();
        private readonly CONTROLLER.DataBase.ConnectionController connectClassControl = new CONTROLLER.DataBase.ConnectionController();
        private readonly CONTROLLER.User.UserController userClassControl = new CONTROLLER.User.UserController();


        // CODE PAGE --> 

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

            logClassControl.CheckFileLog();

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
            logClassControl.WriteLog("                                                                        --- SOFTWARE CLOSED AT : " + DateTime.Now.ToString() + " ---\n \n");
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
            try
            {
                INTERFACE.SetttingsPage settingsForm = new INTERFACE.SetttingsPage
                {

                };
                settingsForm.Show();
                logClassControl.WriteLog("[SUCCESS]-[HomePage]-[Settings_PictureBox_Click]-[TRY] : ");
            }
            catch (Exception catchErrorOpenSettings)
            {
                logClassControl.WriteLog("[ERROR]-[HomePage]-[Settings_PictureBox_Click]-[CATCH] : " + catchErrorOpenSettings);
            }
            
           
        }
        #endregion


        /// <summary>
        /// Used to connect to an interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connection_Button_Click(object sender, EventArgs e)
        {
            if ( connectClassControl.TryConnect(User_TextBox.Text,Password_TextBox.Text) == true ) // Check if the User can be connected to the SoftWare
            {
                switch ( userClassControl.GetCredential(User_TextBox.Text, Password_TextBox.Text)) // Switch used to show the interface according to the user's role
                {
                    case 1: // ADMIN INTERFACE /----/
                        MessageBox.Show("ADMIN CONNEXION");
                        try
                        {
                            INTERFACE.AdminPage adminForm = new INTERFACE.AdminPage
                            {

                            };
                            adminForm.Show();
                            logClassControl.WriteLog("[SUCCESS]-[HomePage]-[Connection_Button_Click]-[TRY] : " + User_TextBox.Text + " : ");
                        }
                        catch (Exception catchErrorOpenInterface)
                        {
                            logClassControl.WriteLog("[ERROR]-[HomePage]-[Connection_Button_Click]-[CATCH] : " + User_TextBox.Text + " : ERROR : " + catchErrorOpenInterface);
                        }
                        MessageBox.Show("CONNECTED");
                        break;
                    case 2:// COMMERCIAL INTERFACE /----/
                        MessageBox.Show("COMMERCIAL CONNEXION");
                        break;
                    case 3:// LIVREUR INTERFACE /----/
                        MessageBox.Show("LIVREUR CONNEXION");
                        break;
                    case 4:// RESTAURATEUR INTERFACE /----/
                        MessageBox.Show("RESTAURATEUR CONNEXION");
                        break;
                    case 5:// CLIENT INTERFACE /----/
                        MessageBox.Show("CLIENT CONNEXION");
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
                logClassControl.WriteLog("[ERROR]-[HomePage]-[Connection_Button_Click]-[ELSE] : " + User_TextBox.Text + " : ERROR : " );
                MessageBox.Show("ERROR");
            }
            
        }

       
    }
}
