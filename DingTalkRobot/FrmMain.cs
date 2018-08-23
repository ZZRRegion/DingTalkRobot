using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections;
using System.IO;
using System.Net;

namespace DingTalkRobot
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string type = this.cboType.SelectedItem as string;
            string content = string.Empty;
            switch (type)
            {
                case "文本格式":
                    DingMsgText msgText = new DingMsgText();
                    msgText.text.content = this.rtbContent.Text;
                    msgText.at.atMobiles.Add("18959296933");
                    content = JsonConvert.SerializeObject(msgText);
                    break;
                case "Link类型":
                    DingMsgLink dingMsgLink = new DingMsgLink();
                    dingMsgLink.link.text = this.rtbContent.Text;
                    dingMsgLink.link.title = "测试的标题";
                    dingMsgLink.link.messageUrl = "http://www.baidu.com";
                    dingMsgLink.link.picUrl = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1535037728672&di=dc67355eb9a018c52667f1d6edbb9f5e&imgtype=0&src=http%3A%2F%2Fimg.zcool.cn%2Fcommunity%2F0117e2571b8b246ac72538120dd8a4.jpg%401280w_1l_2o_100sh.jpg";
                    content = JsonConvert.SerializeObject(dingMsgLink);
                    break;
                case "markdown类型":
                    DingMsgMarkdown dingMsgMarkdown = new DingMsgMarkdown();
                    dingMsgMarkdown.markdown.title = "markdown格式标题";
                    dingMsgMarkdown.markdown.text = this.rtbContent.Text;
                    content = JsonConvert.SerializeObject(dingMsgMarkdown);
                    break;
                case "整体跳转ActionCard类型":
                    DingMsgActionCard dingMsgActionCard = new DingMsgActionCard();
                    dingMsgActionCard.actionCard.title = "整体跳转";
                    dingMsgActionCard.actionCard.text = this.rtbContent.Text;
                    dingMsgActionCard.actionCard.hideAvatar = "0";
                    dingMsgActionCard.actionCard.btnOrientation = "0";
                    dingMsgActionCard.actionCard.singleTitle = "阅读全文";
                    dingMsgActionCard.actionCard.singleURL = "http://regscada.haiwell.com/";
                    content = JsonConvert.SerializeObject(dingMsgActionCard);
                    break;
                case "FeedCard类型":
                    DingMsgFeedCard dingMsgFeedCard = new DingMsgFeedCard();
                    dingMsgFeedCard.feedCard.links.Add(new LinkModel() { title = "时代的火车向前开1", messageURL = "http://regscada.haiwell.com/", picURL = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1535037728672&di=dc67355eb9a018c52667f1d6edbb9f5e&imgtype=0&src=http%3A%2F%2Fimg.zcool.cn%2Fcommunity%2F0117e2571b8b246ac72538120dd8a4.jpg%401280w_1l_2o_100sh.jpg" });
                    dingMsgFeedCard.feedCard.links.Add(new LinkModel() { title = "时代的火车向前开2", messageURL = "http://regscada.haiwell.com/", picURL = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1535037728671&di=b406109ec280c90b12f9e3332d85ed83&imgtype=0&src=http%3A%2F%2Fimg07.tooopen.com%2Fimages%2F20170316%2Ftooopen_sy_201956178977.jpg" });
                    dingMsgFeedCard.feedCard.links.Add(new LinkModel() { title = "时代的火车向前开3", messageURL = "http://regscada.haiwell.com/", picURL = "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1535039589968&di=c1bab54e076cfc54021b6e130ecc787a&imgtype=jpg&src=http%3A%2F%2Fimg3.imgtn.bdimg.com%2Fit%2Fu%3D387787958%2C3481528619%26fm%3D214%26gp%3D0.jpg" });
                    content = JsonConvert.SerializeObject(dingMsgFeedCard);
                    break;
            }
            string respon = StCloud.Post(this.txtUrl.Text, content);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.cboType.SelectedIndexChanged += CboType_SelectedIndexChanged;
            this.LoadType();
        }

        private void CboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = this.cboType.SelectedItem as string;
            switch (type)
            {
                case "文本格式":
                    this.rtbContent.Text = JsonConvert.SerializeObject(DingMsgText.DefaultDemo());
                    break;
                case "Link类型":
                    this.rtbContent.Text = JsonConvert.SerializeObject(DingMsgLink.DefaultDemo());
                    break;
                case "markdown类型":
                    this.rtbContent.Text = JsonConvert.SerializeObject(DingMsgMarkdown.DefaultDemo());
                    break;
                case "整体跳转ActionCard类型":
                    this.rtbContent.Text = JsonConvert.SerializeObject(DingMsgActionCard.DefaultDemo());
                    break;
                case "FeedCard类型":
                    this.rtbContent.Text = JsonConvert.SerializeObject(DingMsgFeedCard.DefaultDemo());
                    break;
            }
        }

        private void LoadType()
        {
            List<string> lst = new List<string>()
            {
                "文本格式",
                "Link类型",
                "markdown类型",
                "整体跳转ActionCard类型",
                //"独立跳转ActionCard类型",
                "FeedCard类型"
            };
            lst.ForEach(item =>
            {
                this.cboType.Items.Add(item);
            });
            this.cboType.SelectedIndex = 0;
        }
    }
}
