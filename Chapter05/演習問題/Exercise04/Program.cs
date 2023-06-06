using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            string[] s = line.Split(';');
            string[] replaced = { "", "", "" };
           
            replaced[0] = s[0].Replace("Novelist=", "作家　:");
            replaced[1] = s[1].Replace("BestWork=", "代表作:");
            replaced[2] = s[2].Replace("Born=", "誕生年:");

            foreach (var novel in replaced) {
                Console.WriteLine(novel);
            }
             
        }
    }
}
