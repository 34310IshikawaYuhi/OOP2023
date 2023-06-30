using Section03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            //コンストラクタ呼び出し
            var abbrs = new Abbreviations();

            //Addメソッド
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核拡散防止条約");

            //7.2.3
            //上のAddメソッドで、２つのオブジェクトを追加しているので読み込んだ単語
            int count = abbrs.Count;
            Console.WriteLine(count);
            //7.2.3(Removeの呼び出し)
            abbrs.Remove("IOC");
        }
    }
}
