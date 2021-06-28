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
    }
}
