using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DingTalkRobot
{
    public class DingLink
    {
       /// <summary>
       /// 消息内容,如果太长只会显示部分
       /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 消息标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 图片URL
        /// </summary>
        public string picUrl { get; set; }
        /// <summary>
        /// 点击消息跳转的URL
        /// </summary>
        public string messageUrl { get; set; }
    }
}
