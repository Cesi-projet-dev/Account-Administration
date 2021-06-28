using System;
using System.Collections.Generic;
using System.Text;

namespace Ces_it.MODEL.DataBase
{
    class ConnectionModel
    {
        /// <summary>
        /// Path to the Database
        /// </summary>
        /// <returns>Return the query explicit string</returns>
        public string ConnectionBdd()
        {
            const string connexionBdd = "SERVER=localhost; DATABASE=ces'eat; UID=root; PASSWORD=";

            return connexionBdd;
        }

       /// <summary>
       /// Return brut SQL Query to log in the database
       /// </summary>
       /// <returns></returns>       
       public string ConnectUser()
        {
            const string connectionUser = " SELECT * FROM `tb_user` WHERE login=@id AND Password=@pw";

            return connectionUser;
        }
    }
}
