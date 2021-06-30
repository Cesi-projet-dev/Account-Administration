using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Ces_it.CONTROLLER.Design
{
    class DesignInterfaceController
    {
        // VARIABLE DECLARATION --> 


        // CONTROLLER DECLARATION --> 
        private readonly MODEL.DataBase.ConnectionModel _connectionModel = new MODEL.DataBase.ConnectionModel();

        /// <summary>
        /// Function used to fill the DatraGridView with an sqlDataAdapter
        /// </summary>
        /// <returns></returns>
        public MySqlDataAdapter ListFillDataGrid()
        {
            MySqlCommand sqlCmdDataDataGrid = new MySqlCommand();
            var connection = new MySqlConnection(_connectionModel.ConnectionBdd());
            sqlCmdDataDataGrid.Connection = connection;
            sqlCmdDataDataGrid.CommandType = CommandType.Text;
            sqlCmdDataDataGrid.CommandText = "SELECT ID,Login,Email,Phone FROM `tb_user`";
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCmdDataDataGrid);

            return sqlDataAdapter;
        }

        /// <summary>
        /// Function used to fill the ComboBox with an Adapter
        /// </summary>
        /// <returns></returns>
        public MySqlDataAdapter AdapterFillComboBox()
        {
            MySqlCommand sqlCmdComboBox = new MySqlCommand();
            var connection = new MySqlConnection(_connectionModel.ConnectionBdd());
            sqlCmdComboBox.Connection = connection;
            sqlCmdComboBox.CommandType = CommandType.Text;
            sqlCmdComboBox.CommandText = "SELECT tb_type.TYPE FROM `tb_user` JOIN tb_type ON tb_user.Credential = tb_type.ID ";
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCmdComboBox);

            return sqlDataAdapter;
        }
    }
}
