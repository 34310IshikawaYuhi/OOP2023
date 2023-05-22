using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("**売上集計**");
            Console.WriteLine("1.店舗別売上");
            Console.WriteLine("2.商品カテゴリー別売上");
            Console.Write(">");
            string num = Console.ReadLine();
            var sales = new SalesCounter(@"data\sales.csv");

            IDictionary<string, int> amountPerStore;

            if (int.Parse(num) == 1) {
                amountPerStore = sales.GetPerStoreSales();
            }
            else if (int.Parse(num)==2) {
                amountPerStore = sales.GetPerCategoeySales();
            }
            foreach (var obj in amountPerStore) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);

            }
        }
    }
}
