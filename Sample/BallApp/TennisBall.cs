using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override void Move() {


            if (PosX > 700 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            if (PosY > 500 || PosY < 0)
            {
                MoveY = -MoveY;
            }
            PosX += MoveX;
            PosY += MoveY;
        }
        
    }
    
}
