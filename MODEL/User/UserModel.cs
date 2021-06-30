using System;
using System.Collections.Generic;
using System.Text;

namespace Ces_it.MODEL.User
{
    class UserModel
    {
        /// <summary>
        /// Return Brut SQL Query to get Credntial number 
        /// </summary>
        /// <returns></returns>
        public string GetCredentialUser()
        {
            const string sqlQueryCredential = "SELECT `Credential` FROM `tb_user` WHERE Login=@id AND Password=@pw";

            return sqlQueryCredential;
        }

        /// <summary>
        /// Return Brut SQL Query to get name of User 
        /// </summary>
        /// <returns></returns>
        public string GetNameUser()
        {
            const string sqlQueryNameUser = "SELECT `Name` FROM `tb_user` WHERE ID=@id ";

            return sqlQueryNameUser;
        }

        /// <summary>
        /// Return Brut SQL Query to get Surname of User 
        /// </summary>
        /// <returns></returns>
        public string GetSurnameUser()
        {
            const string sqlQueryNameUser = "SELECT `Surname` FROM `tb_user` WHERE ID=@id ";

            return sqlQueryNameUser;
        }

        /// <summary>
        /// Return Brut SQL Query to get Surname of User 
        /// </summary>
        /// <returns></returns>
        public string GetEmailUser()
        {
            const string sqlQueryNameEmail = "SELECT `Email` FROM `tb_user` WHERE ID=@id ";

            return sqlQueryNameEmail;
        }

        /// <summary>
        /// Return Brut SQL Query to get Phone of User 
        /// </summary>
        /// <returns></returns>
        public string GetPhoneUser()
        {
            const string sqlQueryNameEmail = "SELECT `Phone` FROM `tb_user` WHERE ID=@id ";

            return sqlQueryNameEmail;
        }

        /// <summary>
        /// Return Brut SQL Query to get Age of User 
        /// </summary>
        /// <returns></returns>
        public string GetAgeUser()
        {
            const string sqlQueryAgeUser = "SELECT `Age` FROM `tb_user` WHERE ID=@id ";

            return sqlQueryAgeUser;
        }

        /// <summary>
        /// Return Brut SQL Query to get Age of User 
        /// </summary>
        /// <returns></returns>
        public string GetAdressUser()
        {
            const string sqlQueryGetAdressUser = "SELECT `Adress` FROM `tb_user` WHERE ID=@id ";

            return sqlQueryGetAdressUser;
        }

        /// <summary>
        /// Return Brut SQL Query to get GetLastConnection of User 
        /// </summary>
        /// <returns></returns>
        public string GetLastConnection()
        {
            const string sqlQueryLastConnection = "SELECT `LastLogin` FROM `tb_user` WHERE ID=@id ";

            return sqlQueryLastConnection;
        }

        /// <summary>
        /// Return Brut SQL Query to get FirstLogin of User 
        /// </summary>
        /// <returns></returns>
        public string GetFirstConnection()
        {
            const string sqlQueryFirstConnection = "SELECT `FirstLogin` FROM `tb_user` WHERE ID=@id ";

            return sqlQueryFirstConnection;
        }

        /// <summary>
        /// Return Brut SQL Query to get Credential of User 
        /// </summary>
        /// <returns></returns>
        public string GetCredentialValue()
        {
            const string sqlQueryFirstConnection = "SELECT tb_type.TYPE FROM `tb_user` JOIN tb_type ON tb_user.Credential = tb_type.ID WHERE tb_user.ID=@id ";

            return sqlQueryFirstConnection;
        }
    }
}
