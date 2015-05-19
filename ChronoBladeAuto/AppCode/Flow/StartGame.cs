using System;
using System.Collections.Generic;
using System.Text;

namespace ChronoBladeAuto.AppCode.Flow
{
    public class StartGame : AppCode.AutoHotKey.Interface
    {
        public StartGame()
        {
            StartAotuHotKey(@"StartGame\StartGame");
        }
    }
}
