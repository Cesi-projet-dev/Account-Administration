using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Ces_it.CONTROLLER.DataBase
{
    class ConnectionController
    {
        // VARIABLE DECLARATION --> 


        // MODEL DECLARATION --> 
        private readonly MODEL.DataBase.ConnectionModel _connectionModel = new MODEL.DataBase.ConnectionModel();

        // CONTROLER DECLARATION --> 
        private readonly LogController _logClassControl = new LogController();

        /// <summary>
        /// TryConnect will check if the user which want to access at the database can or can't use her.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pw"></param>
        /// <returns>Return boolean explicit answer YES OR NOT</returns>
        public bool TryConnect(string id, string pw)
        {
            var statutConnexion = false;
            var connection = new MySqlConnection(_connectionModel.ConnectionBdd());

            try
            {
                var cmd = new MySqlCommand(_connectionModel.ConnectUser(), connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pw", pw);
                connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    statutConnexion = true;
                }
                reader.Close();
                connection.Close();
            }
            catch ( Exception erroConnectionDataBase)
            {
                _logClassControl.WriteLog("[ERROR]-[ConnectionController]-[TryConnect]-[CATCH] : " + erroConnectionDataBase);
            }
            

            return statutConnexion;
        }

    }
}
