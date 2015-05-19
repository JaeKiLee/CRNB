using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ChronoBladeAuto.AppCode.FileIO
{
    class FileIO
    {
        string AutoHotKeyFilePath = @"\AutoHotKey";
        string FullPath;

        public FileIO()
        {
            FullPath = Path.GetDirectoryName(Application.ExecutablePath);
        }

        ~FileIO()
        {

        }

        public void FileWrite(string fileName, string value)
        {
            try
            {

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(FullPath + AutoHotKeyFilePath + @"\" + fileName + ".txt"))
                {
                    file.WriteLine(value);
                    file.Close();
                    file.Dispose();
                    //File.WriteAllText();
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string FileRead(string fileName)
        {
            string value = "";
            try
            {
                value = System.IO.File.ReadAllText(FullPath + AutoHotKeyFilePath + @"\" + fileName + ".txt", Encoding.Default);
                return value;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
