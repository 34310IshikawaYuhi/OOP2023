using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall : Obj {

        //フィールド
        private static int count = 0;
        Random rnd = new Random();//乱数生成

        //コンストラクタ
        public TennisBall(double xp, double yp)
            : base(xp, yp, @"pic\tennis_ball.png") {

            int rndX = rnd.Next(-20, 20);
            int rndY = rnd.Next(-20, 20);
            MoveX = (rndX != 0 ? rndX : 10);//乱数で移動量を設定
            MoveY = (rndY != 0 ? rndY : -10);//乱数で移動量を設定
            Count++;
        }

        public static int Count { get => count; set => count = value; }

        public override void Move(PictureBox pbBar, PictureBox pbBall) {

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y,
                                           pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y,
                                          pbBall.Width, pbBall.Height);


            if (PosX > 700 || PosX < 0 || rBar.IntersectsWith(rBall))
            {
                MoveX = -MoveX;
            }
            if (PosY > 500 || PosY < 0 || rBar.IntersectsWith(rBall))
            {
                MoveY = -MoveY;
            }
            PosX += MoveX;
            PosY += MoveY;
        }
        public override void Move(Keys direction) {
            ;
        }

    }
    
}
