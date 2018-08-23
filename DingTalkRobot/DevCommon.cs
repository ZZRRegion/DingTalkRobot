using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DingTalkRobot
{
    public static class DevCommon
    {
        public static string Version => "1.0.0.0";
        public static string VersionTime => "2018-08-22 14:34:00";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="this"></param>
        /// <param name="msg"></param>
        public static void MsgBox(this Control @this, string msg)
        {
            MessageBox.Show(@this, msg);
        }
    }
}
