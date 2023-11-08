
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrower = new System.Windows.Forms.WebBrowser();
            this.btfav = new System.Windows.Forms.Button();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.rbJP = new System.Windows.Forms.RadioButton();
            this.rbin = new System.Windows.Forms.RadioButton();
            this.rbeco = new System.Windows.Forms.RadioButton();
            this.tbfavName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.favUrl = new System.Windows.Forms.Label();
            this.tbfavUrl = new System.Windows.Forms.TextBox();
            this.favList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(29, 28);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(794, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(829, 28);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(29, 64);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(188, 544);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrower
            // 
            this.wbBrower.Location = new System.Drawing.Point(223, 65);
            this.wbBrower.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrower.Name = "wbBrower";
            this.wbBrower.ScriptErrorsSuppressed = true;
            this.wbBrower.Size = new System.Drawing.Size(600, 543);
            this.wbBrower.TabIndex = 3;
            // 
            // btfav
            // 
            this.btfav.Location = new System.Drawing.Point(942, 259);
            this.btfav.Name = "btfav";
            this.btfav.Size = new System.Drawing.Size(75, 31);
            this.btfav.TabIndex = 4;
            this.btfav.Text = "登録";
            this.btfav.UseVisualStyleBackColor = true;
            this.btfav.Click += new System.EventHandler(this.btfav_Click);
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(829, 65);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(33, 16);
            this.rbIT.TabIndex = 5;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            this.rbIT.CheckedChanged += new System.EventHandler(this.rbIT_CheckedChanged);
            // 
            // rbJP
            // 
            this.rbJP.AutoSize = true;
            this.rbJP.Location = new System.Drawing.Point(879, 65);
            this.rbJP.Name = "rbJP";
            this.rbJP.Size = new System.Drawing.Size(47, 16);
            this.rbJP.TabIndex = 6;
            this.rbJP.TabStop = true;
            this.rbJP.Text = "国内";
            this.rbJP.UseVisualStyleBackColor = true;
            this.rbJP.CheckedChanged += new System.EventHandler(this.rbJP_CheckedChanged);
            // 
            // rbin
            // 
            this.rbin.AutoSize = true;
            this.rbin.Location = new System.Drawing.Point(829, 87);
            this.rbin.Name = "rbin";
            this.rbin.Size = new System.Drawing.Size(47, 16);
            this.rbin.TabIndex = 7;
            this.rbin.TabStop = true;
            this.rbin.Text = "国際";
            this.rbin.UseVisualStyleBackColor = true;
            this.rbin.CheckedChanged += new System.EventHandler(this.rbin_CheckedChanged);
            // 
            // rbeco
            // 
            this.rbeco.AutoSize = true;
            this.rbeco.Location = new System.Drawing.Point(879, 87);
            this.rbeco.Name = "rbeco";
            this.rbeco.Size = new System.Drawing.Size(47, 16);
            this.rbeco.TabIndex = 8;
            this.rbeco.TabStop = true;
            this.rbeco.Text = "経済";
            this.rbeco.UseVisualStyleBackColor = true;
            this.rbeco.CheckedChanged += new System.EventHandler(this.rbeco_CheckedChanged);
            // 
            // tbfavName
            // 
            this.tbfavName.Location = new System.Drawing.Point(871, 209);
            this.tbfavName.Name = "tbfavName";
            this.tbfavName.Size = new System.Drawing.Size(146, 19);
            this.tbfavName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(829, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "名前:";
            // 
            // favUrl
            // 
            this.favUrl.AutoSize = true;
            this.favUrl.Location = new System.Drawing.Point(829, 241);
            this.favUrl.Name = "favUrl";
            this.favUrl.Size = new System.Drawing.Size(29, 12);
            this.favUrl.TabIndex = 11;
            this.favUrl.Text = "URL:";
            // 
            // tbfavUrl
            // 
            this.tbfavUrl.Location = new System.Drawing.Point(871, 234);
            this.tbfavUrl.Name = "tbfavUrl";
            this.tbfavUrl.Size = new System.Drawing.Size(146, 19);
            this.tbfavUrl.TabIndex = 12;
            // 
            // favList
            // 
            this.favList.FormattingEnabled = true;
            this.favList.ItemHeight = 12;
            this.favList.Location = new System.Drawing.Point(871, 296);
            this.favList.Name = "favList";
            this.favList.Size = new System.Drawing.Size(146, 292);
            this.favList.TabIndex = 13;
            this.favList.SelectedIndexChanged += new System.EventHandler(this.favList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1043, 620);
            this.Controls.Add(this.favList);
            this.Controls.Add(this.tbfavUrl);
            this.Controls.Add(this.favUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbfavName);
            this.Controls.Add(this.rbeco);
            this.Controls.Add(this.rbin);
            this.Controls.Add(this.rbJP);
            this.Controls.Add(this.rbIT);
            this.Controls.Add(this.btfav);
            this.Controls.Add(this.wbBrower);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrower;
        private System.Windows.Forms.Button btfav;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbJP;
        private System.Windows.Forms.RadioButton rbin;
        private System.Windows.Forms.RadioButton rbeco;
        private System.Windows.Forms.TextBox tbfavName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label favUrl;
        private System.Windows.Forms.TextBox tbfavUrl;
        private System.Windows.Forms.ListBox favList;
    }
}

