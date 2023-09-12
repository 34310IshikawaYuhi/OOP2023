using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        static int mode = 0;

        //設定情報保存用オブジェクト
        Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
            //dgvCarReports.DataSource = CarReports;
        }

        //ステータスラベルのテキスト表示・非表示（引数なしはメッセージ非表示）
        private void statasLabelDisp(string msg = "") {
            tsInfoText.Text = msg;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLabelDisp();
            if (cbAuthor.Text.Equals("")) {
                statasLabelDisp("記録者を入力してください");
                return;
            }
            else if (cbCarName.Text.Equals("")) {
                statasLabelDisp("車名を入力してください");
                return;
            }


            DataRow newRow = infosys202333DataSet.CarReportTable.NewRow();
            newRow[1] = dtpDate.Value;
            newRow[2] = cbAuthor.Text;
            newRow[3] = getSelectedMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbCarImage.Image);

            infosys202333DataSet.CarReportTable.Rows.Add(newRow);
            //this.carReportTableTableAdapter.Update(infosys202333DataSet.CarReportTable);

            setCbAuthor(cbAuthor.Text); //記録者登録
            setCbCarName(cbCarName.Text);//車名登録

            editItemsClear();
        }
        //記録者コンボボックス履歴追加
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }

        //項目クリア処理
        private void editItemsClear() {
            cbAuthor.Text = "";
            setSelectedMaker("トヨタ");
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;

            dgvCarReports.ClearSelection();     //選択解除
            btModifyReport.Enabled = false;     
            btDeleteReport.Enabled = false;     
        }

        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(string makerGroup) {
            switch (makerGroup) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "スズキ":
                    rbSuzuki.Checked = true;
                    break;
                case "ダイハツ":
                    rbDaihatsu.Checked = true;
                    break;
                case "輸入車":
                    rbImported.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            tsInfoText.Text = "";//情報表示領域のテキストを初期化
            //tsTime.Text = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒");
            tsTime.BackColor = Color.Black;
            tsTime.ForeColor = Color.White;
            tmTimeUpdate.Start();

            
            dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
            btModifyReport.Enabled = false;
            btDeleteReport.Enabled = false;


            //設定ファイルを逆シリアル化して背景を設定
            using (var reader = XmlReader.Create("Settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                settings = serializer.Deserialize(reader) as Settings;
                BackColor = Color.FromArgb(settings.MainFormColor);
            }
        }

        //削除ボタンイベントハンドラ
        private void btDeleteReport_Click(object sender, EventArgs e) {

            dgvCarReports.Rows.RemoveAt(dgvCarReports.CurrentRow.Index);
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202333DataSet);
            editItemsClear();
        }

        
        //修正ボタンイベントハンドラ
        private void btModifyReport_Click(object sender, EventArgs e) {

            dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[3].Value = getSelectedMaker();
            dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[6].Value = pbCarImage.Image;

            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202333DataSet);

            

        }

        //終了メニュー選択時のイベントハンドラ
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイヤログとして表示
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }


        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if(cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settings.MainFormColor = cdColor.Color.ToArgb();
            }
           
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            mode = mode < 4 ?((mode==1)?3: ++mode) : 0; //AutoSize(2)を除去
            pbCarImage.SizeMode = (PictureBoxSizeMode)mode;
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            //設定ファイルのシリアル化
            using (var writer = XmlWriter.Create("Settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer,settings);
            }

        }
        private void tmTimeUpdate_Tick(object sender, EventArgs e) {
            tsTime.Text = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒");
        }

        //レコードの選択時
        private void dgvCarReports_Click(object sender, EventArgs e) {
            if (dgvCarReports.RowCount != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[1].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();
                setSelectedMaker(dgvCarReports.CurrentRow.Cells[3].Value.ToString());
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString();
                pbCarImage.Image = !dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)
                                    &&  ((Byte[])dgvCarReports.CurrentRow.Cells[6].Value).Length !=0 ?
                                   ByteArrayToImage((Byte[])dgvCarReports.CurrentRow.Cells[6].Value) : null;
                /*if (!dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)) {
                    pbCarImage.Image = ByteArrayToImage((Byte[])dgvCarReports.CurrentRow.Cells[6].Value);
                }
                else {
                    pbCarImage.Image = null;
                }*/
                

                btModifyReport.Enabled = true;
                btDeleteReport.Enabled = true;
            }

        }


        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }


        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202333DataSet);

        }

        private void 接続CtoolStripMenuItem1_Click(object sender, EventArgs e) {
            dbConnection();
        }
        private void dbConnection() {
            // TODO: このコード行はデータを 'infosys202333DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202333DataSet.CarReportTable);
            dgvCarReports.ClearSelection();

            foreach (var carReport in infosys202333DataSet.CarReportTable) {
                setCbAuthor(carReport.Author);
                setCbCarName(carReport.CarName);
            }
        }

        private void btASearch_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByAuthor(this.infosys202333DataSet.CarReportTable, tbAuthorSearch.Text);
        }

        private void btCSearch_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByCarName(this.infosys202333DataSet.CarReportTable, tbCarNameSearch.Text);
        }

        private void btDSearch_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByDateToDate(this.infosys202333DataSet.CarReportTable, dtpDateSearch.Text,dtpDateSearch2.Text);
        }

        private void btReset_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.Fill(this.infosys202333DataSet.CarReportTable);
            tbAuthorSearch.Text = null;
            tbCarNameSearch.Text = null;
        }

    }
}
