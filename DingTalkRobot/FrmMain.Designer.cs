namespace DingTalkRobot
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(92, 15);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(727, 21);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://oapi.dingtalk.com/robot/send?access_token=d5dc95d2de594596222ea432e9a735a" +
    "b6d82bd00af3d89e1937757df546de505";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(12, 92);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(807, 190);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPost.Location = new System.Drawing.Point(12, 288);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(807, 43);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "推送";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(10, 15);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(59, 12);
            this.lblURL.TabIndex = 3;
            this.lblURL.Text = "推送地址:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(12, 57);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(262, 24);
            this.cboType.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 335);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "钉钉机器人应用";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.ComboBox cboType;
    }
}

