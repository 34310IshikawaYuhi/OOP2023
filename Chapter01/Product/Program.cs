using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {
            #region P２６のサンプルプログラム
            //インスタンス生成
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daifuku = new Product(235, "大福もち", 160);

            //Console.WriteLine("税込み価格" + karinto.GetPriceIncludingTax());
            //Console.WriteLine("税込み価格" + daifuku.GetPriceIncludingTax());
            #endregion

            //DateTime date = new DateTime(2023, 5, 8);
            DateTime date = DateTime.Today;
            Console.WriteLine("今日の日付：" + date.ToString("yyyy年MM月dd日"));

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            Console.WriteLine("10日後:" + daysAfter10.ToString("yyyy年MM月dd日"));

            //10日前を求める
            DateTime daybefore10 = date.AddDays(-10);
            Console.WriteLine("10日前:" + daybefore10.ToString("yyyy年MM月dd日"));
        }
    }
}
