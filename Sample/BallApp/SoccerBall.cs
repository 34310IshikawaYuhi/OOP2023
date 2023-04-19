using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image;//画像データ

        private double posX;//x座標
        private double posY;//y座標

        private double moveX; //移動量
        private double moveY;

        Random rnd = new Random();//乱数生成

        //コンストラクタ
        public SoccerBall(double xp ,double yp) {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = xp;
            PosY = yp;

            int rndX = rnd.Next(-20, 20);
            int rndY = rnd.Next(-20, 20);
            moveX = (rndX != 0 ? rndX : 10);//乱数で移動量を設定
            moveY = (rndY != 0 ? rndY : -10);//乱数で移動量を設定
        }
        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }
       

        //メソッド
        public void Move() {


          if(posX > 700 || posX < 0)
            {
                moveX = -moveX;
            }
          if(posY > 500 || posY < 0 )
            {
                moveY = -moveY;
            }
            posX += moveX;
            posY += moveY;
        }
    }
}
