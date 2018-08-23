using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DingTalkRobot
{
    public class DingFeedCard
    {
        public List<LinkModel> links { get; set; } = new List<LinkModel>();
    }
    public class LinkModel
    {
        public string title { get; set; }
        public string messageURL { get; set; }
        public string picURL { get; set; }
    }
}
