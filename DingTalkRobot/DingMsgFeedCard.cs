using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DingTalkRobot
{
    public class DingMsgFeedCard:DingMsgBase
    {
        public DingFeedCard feedCard { get; set; } = new DingFeedCard();
        public DingMsgFeedCard()
        {
            this.msgtype = "feedCard";
        }
        public static DingMsgFeedCard DefaultDemo()
        {
            DingMsgFeedCard dingMsgFeedCard = new DingMsgFeedCard();
            dingMsgFeedCard.feedCard.links.Add(new LinkModel() { title = "时代的火车向前开1", messageURL = "http://regscada.haiwell.com/", picURL = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1535037728672&di=dc67355eb9a018c52667f1d6edbb9f5e&imgtype=0&src=http%3A%2F%2Fimg.zcool.cn%2Fcommunity%2F0117e2571b8b246ac72538120dd8a4.jpg%401280w_1l_2o_100sh.jpg" });
            dingMsgFeedCard.feedCard.links.Add(new LinkModel() { title = "时代的火车向前开2", messageURL = "http://regscada.haiwell.com/", picURL = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1535037728671&di=b406109ec280c90b12f9e3332d85ed83&imgtype=0&src=http%3A%2F%2Fimg07.tooopen.com%2Fimages%2F20170316%2Ftooopen_sy_201956178977.jpg" });
            dingMsgFeedCard.feedCard.links.Add(new LinkModel() { title = "时代的火车向前开3", messageURL = "http://regscada.haiwell.com/", picURL = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1535039589968&di=c1bab54e076cfc54021b6e130ecc787a&imgtype=jpg&src=http%3A%2F%2Fimg3.imgtn.bdimg.com%2Fit%2Fu%3D387787958%2C3481528619%26fm%3D214%26gp%3D0.jpg" });
            return dingMsgFeedCard;
        }
    }
}
