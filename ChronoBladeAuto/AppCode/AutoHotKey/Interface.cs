using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace ChronoBladeAuto.AppCode.AutoHotKey
{
    public class Interface
    {
        //string ControlClickFilePath = @"\AutoHotKey\Common\ControlClickInterface.txt";
        string AutoHotKeyFilePath = @"\AutoHotKey";
        string FullPath;

        public Interface()
        {
            FullPath = Path.GetDirectoryName(Application.ExecutablePath);
        }

        public void StartAotuHotKey(string fileName)
        {
            
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.UseShellExecute = true;
            
            //pi.LoadUserProfile = true;
            //pi.RedirectStandardOutput = true;
            

            pi.FileName = FullPath + AutoHotKeyFilePath.Replace(".", "") + @"\" + fileName + ".ahk";
            pi.Verb = "runas";

            //p.StartInfo = pi;

            try
            {
                Process.Start(pi);// p.Start();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void ControlClick(string fileName, string ClickPoint)
        {
            try
            {
                AppCode.FileIO.FileIO fileIO = new AppCode.FileIO.FileIO();
                fileIO.FileWrite(fileName, ClickPoint);
                StartAotuHotKey(fileName);    
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string 모험 = "x571 y371";
        //public string 모험지역선택 = "x480 y345";
        //public string 모험시작 = "x480 y345";
        public string 공지종료 = "x633 y34";
        public string 출석보상 = "x589 y58";
        public string 네트워크불안정 = "x252 y263";

        
    }
}
