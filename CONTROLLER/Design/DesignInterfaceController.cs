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
        

        // MODEL DECLARATION --> 
        private readonly MODEL.DataBase.ConnectionModel _connectionModel = new MODEL.DataBase.ConnectionModel();
        private readonly MODEL.Design.DesignInterfaceModel _designModel = new MODEL.Design.DesignInterfaceModel();

        /// <summary>
        /// Function used to fill the DatraGridView with an sqlDataAdapter
        /// </summary>
        /// <returns>sqlDataAdapter</returns>
        public MySqlDataAdapter ListFillDataGrid()
        {
            MySqlCommand sqlCmdDataDataGrid = new MySqlCommand();
            var connection = new MySqlConnection(_connectionModel.ConnectionBdd());
            sqlCmdDataDataGrid.Connection = connection;
            sqlCmdDataDataGrid.CommandType = CommandType.Text;
            sqlCmdDataDataGrid.CommandText = _designModel.GetDataGridView();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCmdDataDataGrid);

            return sqlDataAdapter;
        }

        /// <summary>
        /// Function used to fill the ComboBox with an Adapter
        /// </summary>
        /// <returns>sqlDataAdapter</returns>
        public MySqlDataAdapter AdapterFillComboBox()
        {
            MySqlCommand sqlCmdComboBox = new MySqlCommand();
            var connection = new MySqlConnection(_connectionModel.ConnectionBdd());
            sqlCmdComboBox.Connection = connection;
            sqlCmdComboBox.CommandType = CommandType.Text;
            sqlCmdComboBox.CommandText = _designModel.GetFillCombobox();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCmdComboBox);

            return sqlDataAdapter;
        }

        /// <summary>
        /// Function used to 
        /// </summary>
        /// <returns></returns>
        public bool UpdateTypeUser (string newCredential,string userID)
        {
            bool succesUpdateType = false;

            MySqlCommand sqlUpdateTypeUser = new MySqlCommand();
            var connection = new MySqlConnection(_connectionModel.ConnectionBdd());
            sqlUpdateTypeUser.Connection = connection;
            sqlUpdateTypeUser.CommandType = CommandType.Text;
            sqlUpdateTypeUser.CommandText = _designModel.GetUpdateUser();  
            sqlUpdateTypeUser.Parameters.AddWithValue("@id", userID);
            sqlUpdateTypeUser.Parameters.AddWithValue("@nCredential", newCredential);

            connection.Open();
            sqlUpdateTypeUser.ExecuteNonQuery();
            connection.Close();

            return succesUpdateType;
        }
    }
}
