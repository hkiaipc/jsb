using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Xdgk.Common;

namespace gwlman
{
    /// <summary>
    /// 
    /// </summary>
    class App : AppBase 
    {
        /// <summary>
        /// 
        /// </summary>
        public override Form MainForm
        {
            get
            {
                if (_frmMain == null)
                {
                    _frmMain = new frmMain();
                }
                return _frmMain;
            }
        } private frmMain _frmMain;
    }

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            new App().Run();
        }
    }
}
