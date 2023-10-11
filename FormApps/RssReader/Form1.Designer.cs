
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
            this.wbBrower.Size = new System.Drawing.Size(681, 543);
            this.wbBrower.TabIndex = 3;
            // 
            // btfav
            // 
            this.btfav.Location = new System.Drawing.Point(922, 28);
            this.btfav.Name = "btfav";
            this.btfav.Size = new System.Drawing.Size(75, 31);
            this.btfav.TabIndex = 4;
            this.btfav.Text = "登録";
            this.btfav.UseVisualStyleBackColor = true;
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(922, 66);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(33, 16);
            this.rbIT.TabIndex = 5;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            // 
            // rbJP
            // 
            this.rbJP.AutoSize = true;
            this.rbJP.Location = new System.Drawing.Point(922, 89);
            this.rbJP.Name = "rbJP";
            this.rbJP.Size = new System.Drawing.Size(47, 16);
            this.rbJP.TabIndex = 6;
            this.rbJP.TabStop = true;
            this.rbJP.Text = "国内";
            this.rbJP.UseVisualStyleBackColor = true;
            // 
            // rbin
            // 
            this.rbin.AutoSize = true;
            this.rbin.Location = new System.Drawing.Point(922, 112);
            this.rbin.Name = "rbin";
            this.rbin.Size = new System.Drawing.Size(47, 16);
            this.rbin.TabIndex = 7;
            this.rbin.TabStop = true;
            this.rbin.Text = "国際";
            this.rbin.UseVisualStyleBackColor = true;
            // 
            // rbeco
            // 
            this.rbeco.AutoSize = true;
            this.rbeco.Location = new System.Drawing.Point(922, 135);
            this.rbeco.Name = "rbeco";
            this.rbeco.Size = new System.Drawing.Size(47, 16);
            this.rbeco.TabIndex = 8;
            this.rbeco.TabStop = true;
            this.rbeco.Text = "経済";
            this.rbeco.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1043, 620);
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
    }
}

