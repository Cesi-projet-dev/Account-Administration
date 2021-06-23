using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ces_it.CONTROLLER
{
    class LogController
    {
        public bool CheckFileLog ()
        {
            //C:\Users\cl-me\Documents\Ces'it_Elective\Ces'it
            string path = @".\Users\cl-me\Documents\Ces'it_Elective\Ces'it\Log";
            
            if (Directory.Exists(path) == true)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
