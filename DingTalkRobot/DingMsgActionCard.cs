using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DingTalkRobot
{
    public class DingMsgActionCard:DingMsgBase
    {
        public DingActionCard actionCard { get; set; } = new DingActionCard();
        public DingMsgActionCard()
        {
            this.msgtype = "actionCard";
        }
        public static DingMsgActionCard DefaultDemo()
        {
            DingMsgActionCard dingMsgActionCard = new DingMsgActionCard();
            dingMsgActionCard.actionCard.title = "整体跳转";
            dingMsgActionCard.actionCard.text = "测试内容";
            dingMsgActionCard.actionCard.hideAvatar = "0";
            dingMsgActionCard.actionCard.btnOrientation = "0";
            dingMsgActionCard.actionCard.singleTitle = "阅读全文";
            dingMsgActionCard.actionCard.singleURL = "http://regscada.haiwell.com/";
            return dingMsgActionCard;
        }
    }
}
