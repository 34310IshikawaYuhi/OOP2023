using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalenderApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var now = DateTime.Now;

            tbMessage.Text = "入力した日から"+(now-dtp).Days+"日経過しています。";
        }

        private void yearBefore_Click(object sender, EventArgs e) {
            
        }
    }
}
