using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ces_it.CONTROLLER
{
    class LogController
    {
        private readonly MODEL.LogModel logClassModel = new MODEL.LogModel();
        /// <summary>
        /// Check if the directory "Log" exist in the project (Directory : bin)
        /// </summary>
        public void CheckFileLog ()
        {
        
            if (Directory.Exists(logClassModel.FileDirectory()) == true)
            {
                CreationLogFile();
            }
            else
            {
                Directory.CreateDirectory(logClassModel.FileDirectory());
           
            }


        }

        /// <summary>
        /// Create Log directory if doesn't exist
        /// </summary>
        private void CreationLogFile ()
        {
            try
            {
                if (File.Exists(logClassModel.FilePath()))
                {
                    File.AppendAllText(logClassModel.FilePath(), "\n \n CONNEXION SOFTWARE : " + DateTime.Now);
                    
                }
                else
                {
                    using (FileStream fileStr = File.Create(logClassModel.FilePath()))
                    {
                        Byte[] text = new UTF8Encoding(true).GetBytes("                                                                        --- LOG FILE CREATION : " + DateTime.Now.ToString() + " ---\n \n");
                        fileStr.Write(text, 0, text.Length);
                    }
                    File.AppendAllText(logClassModel.FilePath(), "\n \n CONNEXION SOFTWARE : " + DateTime.Now);
                }




            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Function used to write a line of log in a text file
        /// </summary>
        /// <param name="textWritting"></param>
        /// <returns></returns>
        public bool WriteLog (string textWritting)
        {
            try
            {
                File.AppendAllText(logClassModel.FilePath(), "\n"+ textWritting + " --> " + DateTime.Now);
                return true;
            }
            catch ( Exception catchWriteLogError)
            {
                File.AppendAllText(logClassModel.FilePath(), "\n" + "[ERROR]-[LogController]-[WirteLog]-[CATCH] : " + catchWriteLogError + " --> " + DateTime.Now);
                return false;
            }
        }

    }
}
