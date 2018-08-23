using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DingTalkRobot
{
    public class DingMsgText:DingMsgBase
    {
        public DingText text { get; set; } = new DingText();
        public DingAt at { get; set; } = new DingAt();
        public DingMsgText()
        {
            this.msgtype = "text";
        }
        public static DingMsgText DefaultDemo()
        {
            DingMsgText dingMsgText = new DingMsgText();
            dingMsgText.text.content = "这是简单文本类型(text)";
            return dingMsgText;
        }
    }
}
