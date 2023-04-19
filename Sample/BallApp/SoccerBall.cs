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

        private double moveX = 10; //移動量
        private double moveY = 10;
        //コンストラクタ
        public SoccerBall() {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = 0.0;
            PosY = 0.0;
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
