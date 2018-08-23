using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DingTalkRobot
{
    public class DingMsgLink:DingMsgBase
    {
        public DingLink link { get; set; } = new DingLink();
        public DingMsgLink()
        {
            this.msgtype = "link";
        }
        public static DingMsgLink DefaultDemo()
        {
            DingMsgLink dingMsgLink = new DingMsgLink();
            dingMsgLink.link.text = "测试内容";
            dingMsgLink.link.title = "测试的标题";
            dingMsgLink.link.messageUrl = "http://www.baidu.com";
            dingMsgLink.link.picUrl = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1535037728672&di=dc67355eb9a018c52667f1d6edbb9f5e&imgtype=0&src=http%3A%2F%2Fimg.zcool.cn%2Fcommunity%2F0117e2571b8b246ac72538120dd8a4.jpg%401280w_1l_2o_100sh.jpg";
            return dingMsgLink;
        }
    }
}
