using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");
            var amountPerStore = sales.GetPerStoreSales();

            Console.WriteLine("**売上集計**");
            Console.WriteLine("1.店舗別売上");
            Console.WriteLine("2.商品カテゴリー別売上");
            Console.Write(">");
            string num = Console.ReadLine();
            if (int.Parse(num) == 1) {
                sales.GetPerStoreSales();
            }
            else if (int.Parse(num)==2) {

            }
            foreach (var obj in amountPerStore) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);

            }
        }
    }
}
