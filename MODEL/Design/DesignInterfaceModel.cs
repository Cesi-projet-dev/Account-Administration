using System;
using System.Collections.Generic;
using System.Text;

namespace Ces_it.MODEL.Design
{
    class DesignInterfaceModel
    {
        /// <summary>
        /// Function used to return an sql brut query
        /// </summary>
        /// <returns></returns>
        public string GetDataGridView()
        {
            const string sqlQueryFillDataGridView = "SELECT ID,Login,Email,Phone FROM `tb_user`";

            return sqlQueryFillDataGridView;
        }

        /// <summary>
        /// Function used to return an sql brut query
        /// </summary>
        /// <returns></returns>
        public string GetFillCombobox()
        {
            const string sqlQueryGetFillCombobox = "SELECT tb_type.TYPE FROM `tb_type`  ";
            // "SELECT tb_type.TYPE FROM `tb_user` JOIN tb_type ON tb_user.Credential = tb_type.ID "

            return sqlQueryGetFillCombobox;
        }

        /// <summary>
        /// Function used to return an sql brut query
        /// </summary>
        /// <returns></returns>
        public string GetUpdateUser()
        {
            const string sqlQueryGetFillCombobox = "UPDATE tb_user SET Credential = @nCredential WHERE ID = @id";

            return sqlQueryGetFillCombobox;
        }
    }
}
