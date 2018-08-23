using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DingTalkRobot
{
    public class DingMsgMarkdown:DingMsgBase
    {
        public DingMarkdown markdown { get; set; } = new DingMarkdown();
        public DingAt at { get; set; } = new DingAt();
        public DingMsgMarkdown()
        {
            this.msgtype = "markdown";
        }
        public static DingMsgMarkdown DefaultDemo()
        {
            DingMsgMarkdown dingMsgMarkdown = new DingMsgMarkdown();
            dingMsgMarkdown.markdown.title = "markdown格式标题";
            dingMsgMarkdown.markdown.text = "## 测试标题";
            return dingMsgMarkdown;
        }
    }
}
