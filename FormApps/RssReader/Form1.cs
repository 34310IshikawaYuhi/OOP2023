using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        List<ItemData> ItemDatas = new List<ItemData>();

        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.Text =="")
                return;

            lbRssTitle.Items.Clear();

            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                ItemDatas = xdoc.Root.Descendants("item")
                                     .Select(x => new ItemData {
                                         Title = (string)x.Element("title"),
                                         Link = (string)x.Element("link"),
                                     }).ToList();

                foreach (var node in ItemDatas) {
                   
                    lbRssTitle.Items.Add(node.Title);
                }
                
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbRssTitle.SelectedIndex == -1) 
                return;

            var index = lbRssTitle.SelectedIndex;
            wbBrower.Navigate(ItemDatas[index].Link);
            
        }
        private void rbIT_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
        }

        private void rbJP_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/domestic.xml";
        }

        private void rbin_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/world.xml";
        }

        private void rbeco_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/business.xml";
        }

        private void btfav_Click(object sender, EventArgs e) {
            tbfavName.Text = "";
            tbfavUrl.Text = "";
            if (tbfavName.Text.Equals("")|| tbfavUrl.Text.Equals(""))
                return;


        }

        private void favList_SelectedIndexChanged(object sender, EventArgs e) {
            var num = favList.SelectedIndex;
            if (favList.SelectedIndex == -1) 
                return;
            tbUrl.Text = favList.SelectedItems.ToString();
        }
    }
}
