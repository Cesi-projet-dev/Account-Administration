using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ces_it.CONTROLLER.User
{
    class UserController
    {
        // VARIABLE DECLARATION --> 
        

        // CONTROLLER DECLARATION --> 
        private readonly MODEL.DataBase.ConnectionModel connectionModel = new MODEL.DataBase.ConnectionModel();
        private readonly MODEL.User.UserModel userClassModel = new MODEL.User.UserModel();

        /// <summary>
        /// Function used to get Credential number of the connected user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        public int GetCredential(string id, string pw)
        {

            var credentialValue = 0;
            var connection = new MySqlConnection(connectionModel.ConnectionBdd());

            var cmd = new MySqlCommand(userClassModel.GetCredentialUser(), connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pw", pw);
            connection.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                var lecture = reader.Read();
                while (lecture)
                {
                    credentialValue = reader.GetInt32(0);
                    lecture = reader.Read();
                }
            }
            reader.Close();
            connection.Close();

            return credentialValue;
        }
    }
}
