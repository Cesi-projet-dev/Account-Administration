using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Ces_it.CONTROLLER.User
{
    class UserController
    {
        // VARIABLE DECLARATION --> 
        

        // CONTROLLER DECLARATION --> 
        private readonly MODEL.DataBase.ConnectionModel _connectionModel = new MODEL.DataBase.ConnectionModel();
        private readonly MODEL.User.UserModel _userClassModel = new MODEL.User.UserModel();

        /// <summary>
        /// Function used to get Credential number of the connected user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        public int GetCredential(string id, string pw)
        {

            var credentialValue = 0;
            var connection = new MySqlConnection(_connectionModel.ConnectionBdd());

            var cmd = new MySqlCommand(_userClassModel.GetCredentialUser(), connection);
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

        /// <summary>
        /// Tuple used to Get all the info about a specific user 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Tuple <string,string,string,string,int,string,string> GetInfoUser(string id)
        {
            var connection = new MySqlConnection(_connectionModel.ConnectionBdd());
            connection.Open();

            #region GetName
            // Get Name of User
            var name = "";

            var cmd = new MySqlCommand(_userClassModel.GetNameUser(), connection);
            cmd.Parameters.AddWithValue("@id", id);
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                var lecture = reader.Read();
                while (lecture)
                {
                    name = reader.GetString(0);
                    lecture = reader.Read();
                }
            }
            reader.Close();
            #endregion

            #region GetSurname
            // Get Surname of User
            var surname = "";


            var cmdSurname = new MySqlCommand(_userClassModel.GetSurnameUser(), connection);
            cmdSurname.Parameters.AddWithValue("@id", id);
            var readerSurname = cmdSurname.ExecuteReader();
            if (readerSurname.HasRows)
            {
                var lecture = readerSurname.Read();
                while (lecture)
                {
                    surname = readerSurname.GetString(0);
                    lecture = readerSurname.Read();
                }
            }
            readerSurname.Close();
            #endregion

            #region GetEmail
            // Get Email of User
            var email = "";

            var cmdEmail = new MySqlCommand(_userClassModel.GetEmailUser(), connection);
            cmdEmail.Parameters.AddWithValue("@id", id);
            var readeEmail = cmdEmail.ExecuteReader();
            if (readeEmail.HasRows)
            {
                var lecture = readeEmail.Read();
                while (lecture)
                {
                    email = readeEmail.GetString(0);
                    lecture = readeEmail.Read();
                }
            }
            readeEmail.Close();

            #endregion

            #region GetPhone
            // Get Phone of User
            var phone = "";

            var cmdPhone = new MySqlCommand(_userClassModel.GetPhoneUser(), connection);
            cmdPhone.Parameters.AddWithValue("@id", id);
            var readerPhone = cmdPhone.ExecuteReader();
            if (readerPhone.HasRows)
            {
                var lecture = readerPhone.Read();
                while (lecture)
                {
                    phone = readerPhone.GetString(0);
                    lecture = readerPhone.Read();
                }
            }
            readerPhone.Close();
            #endregion

            #region GetAge
            // Get Age of User
            int age = 0;

            var cmdAge = new MySqlCommand(_userClassModel.GetAgeUser(), connection);
            cmdAge.Parameters.AddWithValue("@id", id);
            var readerAge = cmdAge.ExecuteReader();
            if (readerAge.HasRows)
            {
                var lecture = readerAge.Read();
                while (lecture)
                {
                    age = readerAge.GetInt32(0);
                    lecture = readerAge.Read();
                }
            }
            readerAge.Close();
            #endregion

            #region GetAdress
            // Get Adress of User
            var adress = "";

            var cmdAdress = new MySqlCommand(_userClassModel.GetAdressUser(), connection);
            cmdAdress.Parameters.AddWithValue("@id", id);
            var readerAdress = cmdAdress.ExecuteReader();
            if (readerAdress.HasRows)
            {
                var lecture = readerAdress.Read();
                while (lecture)
                {
                    adress = readerAdress.GetString(0);
                    lecture = readerAdress.Read();
                }
            }
            readerAdress.Close();
            #endregion

            #region GetLastConnection
            // Get Last Connection of User
            var lastConnection = "";

            var cmdLastConnection = new MySqlCommand(_userClassModel.GetLastConnection(), connection);
            cmdLastConnection.Parameters.AddWithValue("@id", id);
            var readerLastConnection = cmdLastConnection.ExecuteReader();
            if (readerLastConnection.HasRows)
            {
                var lecture = readerLastConnection.Read();
                while (lecture)
                {
                    lastConnection = readerLastConnection.GetString(0);
                    lecture = readerLastConnection.Read();
                }
            }
            readerLastConnection.Close();
            #endregion

            

            connection.Close();
            return new Tuple<string, string, string,string,int,string,string>(name, surname, email, phone, age, adress, lastConnection);
        }

        /// <summary>
        /// Function used to fill the ComboBox default value for a specific User
        /// </summary>
        /// <returns></returns>
        public string GetValueDefaultComboBox(string userID)
        {
            string valueTYPE = "";
            MySqlCommand sqlCmdComboBox = new MySqlCommand();
            var connection = new MySqlConnection(_connectionModel.ConnectionBdd());
            sqlCmdComboBox.Connection = connection;
            sqlCmdComboBox.CommandType = CommandType.Text;
            sqlCmdComboBox.CommandText = _userClassModel.GetCredentialValue();
            sqlCmdComboBox.Parameters.AddWithValue("@id", userID);
            connection.Open();
            var reader = sqlCmdComboBox.ExecuteReader();
            if (reader.HasRows)
            {
                var lecture = reader.Read();
                while (lecture)
                {
                    valueTYPE = reader.GetString(0);
                    lecture = reader.Read();
                }
            }
            reader.Close();
            connection.Close();

            return valueTYPE;
        }

        /// <summary>
        /// Function Used to get Value of Credential by ID.Credential
        /// </summary>
        /// <param name="nameType"></param>
        /// <returns></returns>
        public string GetTypeValueById(string nameType)
        {
            string id = "";

            MySqlCommand sqlCommandGetTypeName = new MySqlCommand();
            var connection = new MySqlConnection(_connectionModel.ConnectionBdd());
            sqlCommandGetTypeName.Connection = connection;
            sqlCommandGetTypeName.CommandType = CommandType.Text;
            sqlCommandGetTypeName.CommandText = _userClassModel.GetCredentialValueById() ;
            sqlCommandGetTypeName.Parameters.AddWithValue("@nameType", nameType);
            connection.Open();
            var reader = sqlCommandGetTypeName.ExecuteReader();
            if (reader.HasRows)
            {
                var lecture = reader.Read();
                while (lecture)
                {
                    id = reader.GetString(0);
                    lecture = reader.Read();
                }
            }
            reader.Close();
            connection.Close();

            return id;
        }

        /// <summary>
        /// Get the Name Of city by User
        /// </summary>
        /// <returns></returns>
        public string GetCityByUser(string idUser)
        {
            string specificCity = "";

            MySqlCommand sqlCommandGetCityName = new MySqlCommand();
            var connection = new MySqlConnection(_connectionModel.ConnectionBdd());
            sqlCommandGetCityName.Connection = connection;
            sqlCommandGetCityName.CommandType = CommandType.Text;
            sqlCommandGetCityName.CommandText = _userClassModel.GetCityOfUser();
            sqlCommandGetCityName.Parameters.AddWithValue("@id", idUser);
            connection.Open();
            var reader = sqlCommandGetCityName.ExecuteReader();
            if (reader.HasRows)
            {
                var lecture = reader.Read();
                while (lecture)
                {
                    specificCity = reader.GetString(0);
                    lecture = reader.Read();
                }
            }
            reader.Close();
            connection.Close();

            return specificCity;
        }


    }
}
