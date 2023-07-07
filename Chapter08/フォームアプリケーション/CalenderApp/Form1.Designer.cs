
namespace CalenderApp {
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.yearAfter = new System.Windows.Forms.Button();
            this.yearBefore = new System.Windows.Forms.Button();
            this.monthBefore = new System.Windows.Forms.Button();
            this.monthAfter = new System.Windows.Forms.Button();
            this.dayAfter = new System.Windows.Forms.Button();
            this.dayBefore = new System.Windows.Forms.Button();
            this.tbTimeNow = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(86, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 31);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayCalc.Location = new System.Drawing.Point(86, 67);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(127, 54);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(316, 12);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(407, 252);
            this.tbMessage.TabIndex = 3;
            // 
            // yearAfter
            // 
            this.yearAfter.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yearAfter.Location = new System.Drawing.Point(195, 139);
            this.yearAfter.Name = "yearAfter";
            this.yearAfter.Size = new System.Drawing.Size(91, 37);
            this.yearAfter.TabIndex = 5;
            this.yearAfter.Text = "+年";
            this.yearAfter.UseVisualStyleBackColor = true;
            // 
            // yearBefore
            // 
            this.yearBefore.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yearBefore.Location = new System.Drawing.Point(86, 139);
            this.yearBefore.Name = "yearBefore";
            this.yearBefore.Size = new System.Drawing.Size(91, 37);
            this.yearBefore.TabIndex = 5;
            this.yearBefore.Text = "-年";
            this.yearBefore.UseVisualStyleBackColor = true;
            this.yearBefore.Click += new System.EventHandler(this.yearBefore_Click);
            // 
            // monthBefore
            // 
            this.monthBefore.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.monthBefore.Location = new System.Drawing.Point(86, 182);
            this.monthBefore.Name = "monthBefore";
            this.monthBefore.Size = new System.Drawing.Size(91, 37);
            this.monthBefore.TabIndex = 5;
            this.monthBefore.Text = "ー月";
            this.monthBefore.UseVisualStyleBackColor = true;
            // 
            // monthAfter
            // 
            this.monthAfter.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.monthAfter.Location = new System.Drawing.Point(195, 182);
            this.monthAfter.Name = "monthAfter";
            this.monthAfter.Size = new System.Drawing.Size(91, 37);
            this.monthAfter.TabIndex = 5;
            this.monthAfter.Text = "＋月";
            this.monthAfter.UseVisualStyleBackColor = true;
            // 
            // dayAfter
            // 
            this.dayAfter.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dayAfter.Location = new System.Drawing.Point(195, 227);
            this.dayAfter.Name = "dayAfter";
            this.dayAfter.Size = new System.Drawing.Size(91, 37);
            this.dayAfter.TabIndex = 5;
            this.dayAfter.Text = "＋日";
            this.dayAfter.UseVisualStyleBackColor = true;
            // 
            // dayBefore
            // 
            this.dayBefore.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dayBefore.Location = new System.Drawing.Point(86, 227);
            this.dayBefore.Name = "dayBefore";
            this.dayBefore.Size = new System.Drawing.Size(91, 37);
            this.dayBefore.TabIndex = 5;
            this.dayBefore.Text = "ー日";
            this.dayBefore.UseVisualStyleBackColor = true;
            // 
            // tbTimeNow
            // 
            this.tbTimeNow.AutoSize = true;
            this.tbTimeNow.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTimeNow.Location = new System.Drawing.Point(12, 314);
            this.tbTimeNow.Name = "tbTimeNow";
            this.tbTimeNow.Size = new System.Drawing.Size(118, 24);
            this.tbTimeNow.TabIndex = 0;
            this.tbTimeNow.Text = "現在時刻：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 314);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 41);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 367);
            this.Controls.Add(this.dayBefore);
            this.Controls.Add(this.dayAfter);
            this.Controls.Add(this.monthAfter);
            this.Controls.Add(this.monthBefore);
            this.Controls.Add(this.yearBefore);
            this.Controls.Add(this.yearAfter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbTimeNow);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "カレンダーアプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button yearAfter;
        private System.Windows.Forms.Button yearBefore;
        private System.Windows.Forms.Button monthBefore;
        private System.Windows.Forms.Button monthAfter;
        private System.Windows.Forms.Button dayAfter;
        private System.Windows.Forms.Button dayBefore;
        private System.Windows.Forms.Label tbTimeNow;
        private System.Windows.Forms.TextBox textBox1;
    }
}

