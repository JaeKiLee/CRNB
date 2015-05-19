using ChronoBladeAuto.AppCode.FileIO;
using ChronoBladeAuto.AppCode.Flow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChronoBladeAuto
{
    public partial class Form1 : Form
    {
        private ThreadStart _ts = null;                          //  ThreadStart 선언
        private Thread _t = null;                                  //  Thread 선언

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame startGame = new StartGame();

            if (_ts == null)
            {
                _ts = new ThreadStart(WhereIs);
                _t = new Thread(_ts);
                _t.Start();
            }
            else
            {
                MessageBox.Show("이미 실행중입니다.");
            }

            
            //string fileName = @"Common\ControlClick";
            //string ClickPoint = "x45 y366";

            //AppCode.AutoHotKey.Interface inf = new AppCode.AutoHotKey.Interface();
            //inf.ControlClick(fileName, ClickPoint);
            
        }

        private void WhereIs()
        {
            while (true)
            {
                string fileName = @"Common\FindTitle";
                //string ClickPoint = "x45 y366";
                string ClickPoint = "";

                AppCode.AutoHotKey.Interface inf = new AppCode.AutoHotKey.Interface();
                inf.ControlClick(fileName, ClickPoint);
                Thread.Sleep(3000);

                FileIO fileIO = new FileIO();
                string title = fileIO.FileRead(@"Common\FindTitle");
                lbl_Whereis.Invoke((MethodInvoker)(() => lbl_Whereis.Text = title.Replace(".png", "")));

                string WhereIs = lbl_Whereis.Text;
                fileName = @"Common\ControlClick";
                
                if (WhereIs.Equals("공지사항"))
                {
                    ClickPoint = inf.공지종료;
                    inf.ControlClick(fileName, ClickPoint);
                }
                else if (WhereIs.Equals("출석보상"))
                {
                    ClickPoint = inf.출석보상;
                    inf.ControlClick(fileName, ClickPoint);
                }
                else if (WhereIs.Equals("네트워크불안정"))
                {
                    ClickPoint = inf.네트워크불안정;
                    inf.ControlClick(fileName, ClickPoint);
                }

                //Thread.Sleep(3000);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   // 폼닫을때 Thread 도 종료하기위함
        {
            _t.Abort();
            _t_adv.Abort();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = @"Common\FindTitle";
            //string ClickPoint = "x45 y366";
            string ClickPoint = "";

            AppCode.AutoHotKey.Interface inf = new AppCode.AutoHotKey.Interface();
            inf.ControlClick(fileName, ClickPoint);
        }

        ThreadStart _ts_adv = null;
        Thread _t_adv = null;

        private void btn_Adventure_Click(object sender, EventArgs e)
        {
            if (_ts_adv == null)
            {
                _ts_adv = new ThreadStart(StartAdventure);
                _t_adv = new Thread(_ts_adv);
                _t_adv.Start();
            }
            else
            {
                MessageBox.Show("이미 실행중입니다.");
            }
        }

        private void StartAdventure()
        {
            string Pre_WhereIs = "";
            while (true)
            {
                string WhereIs = lbl_Whereis.Text;
                string fileName = @"Common\ControlClick";
                string ClickPoint = "";

                if (WhereIs != Pre_WhereIs)
                {

                    if (WhereIs.Equals("메인화면"))
                    {

                        //string ClickPoint = "x45 y366";


                        AppCode.AutoHotKey.Interface inf = new AppCode.AutoHotKey.Interface();
                        ClickPoint = inf.모험;
                        inf.ControlClick(fileName, ClickPoint);
                    }
                    else if (WhereIs.IndexOf("모험지역선택")>-1)
                    {
                        AppCode.AutoHotKey.Interface inf = new AppCode.AutoHotKey.Interface();
                        ClickPoint = "x272 y240";
                        inf.ControlClick(fileName, ClickPoint);
                    }
                    else if (WhereIs.Equals("모험시작"))
                    {
                        AppCode.AutoHotKey.Interface inf = new AppCode.AutoHotKey.Interface();
                        ClickPoint = inf.모험시작;
                        inf.ControlClick(fileName, ClickPoint);
                    }

                    Pre_WhereIs = WhereIs;
                }

                
            }
        }

        
    }
}
