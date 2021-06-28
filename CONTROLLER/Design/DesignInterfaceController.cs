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
        private readonly MODEL.DataBase.ConnectionModel connectionModel = new MODEL.DataBase.ConnectionModel();


        public MySqlDataAdapter ListFillDataGrid()
        {
            MySqlCommand sqlCmdDataDataGrid = new MySqlCommand();
            var connection = new MySqlConnection(connectionModel.ConnectionBdd());
            sqlCmdDataDataGrid.Connection = connection;
            sqlCmdDataDataGrid.CommandType = CommandType.Text;
            sqlCmdDataDataGrid.CommandText = "SELECT Login,Email,Phone FROM `tb_user`";
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCmdDataDataGrid);

            return sqlDataAdapter;
        }
    }
}
