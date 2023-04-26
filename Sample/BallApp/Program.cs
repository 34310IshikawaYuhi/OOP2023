﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {

        private Timer moveTimer; //タイマー用
        private PictureBox pb;  //画像を表示するコントロール
        int Ballcnt = 0;

        private List<Obj> balls = new List<Obj>();    //ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();      //表示用

        static void Main(string[] args) {
            Application.Run(new Program());
        }
        public Program() { 
            this.Size = new Size(800, 600);
            this.BackColor = Color.Aqua;
            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;

            moveTimer = new Timer();
            moveTimer.Interval = 1;//タイマーのインターバル(ms)
            moveTimer.Tick += MoveTimer_Tick; //デリゲート登録
        }
        //キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
            
        }

        //マウスクリック時のイベントハンドラー
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            Obj ballObj = null;
            pb = new PictureBox();

            if (e.Button == MouseButtons.Left)
            {
                ballObj = new SoccerBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(50, 50); //画像の表示サイズ
                
            }
            else if(e.Button == MouseButtons.Right)
            {
                ballObj = new TennisBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(25, 25); //画像の表示サイズ
                
            }

            pb.Image = ballObj.Image;
            pb.Location = new Point((int)ballObj.PosX, (int)ballObj.PosY);    // 画像の位置 
            pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pb.Parent = this;

            balls.Add(ballObj);
            pbs.Add(pb);

            this.Text = "BallGame Soccer Ball:" + SoccerBall.Count1 + "TennisBall:" + TennisBall.Count;

            moveTimer.Start();//タイマースタート
        }
        //タイマータイムアウト時のイベントハンドラー
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move();//移動
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);//画像の位置

            }

        }
    }
}
