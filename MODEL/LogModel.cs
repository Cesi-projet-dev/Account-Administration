using System;
using System.Collections.Generic;
using System.Text;

namespace Ces_it.MODEL
{
    class LogModel
    {
        /// <summary>
        /// Return de pathFile of File
        /// </summary>
        /// <returns></returns>
        public string FilePath()
        {
            string pathFile = @"..\Log\Log.txt";

            return pathFile;
        }

        /// <summary>
        /// Return de pathFile of Directory
        /// </summary>
        /// <returns></returns>
        public string FileDirectory()
        {
            string pathDirectrory = @"..\Log";

            return pathDirectrory;
        }
    }
}
