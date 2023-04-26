﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    //抽象クラス
   abstract class Obj {

        //フィールド
        private Image image;//画像データ

        private double posX;//x座標
        private double posY;//y座標
        private double moveX; //移動量
        private double moveY;//移動量

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }
        
        public double MoveX { get => moveX; set => moveX = value; }
        public double MoveY { get => moveY; set => moveY = value; }
       
        //コンストラクタ
        public Obj(double PosX,double PosY, string path) {

            this.posX = PosX;
            this.posY = PosY;
            Image = Image.FromFile(path);

            //後ほど追加あり
        }

        //移動メソッド（抽象メソッド）
        public abstract void Move();

    }
}
