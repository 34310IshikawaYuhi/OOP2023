using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
#if NoArray
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            string[] s = line.Split(';');
            string[] replaced = { "", "", "" };
           
            replaced[0] = s[0].Replace("Novelist=", "作家　:");
            replaced[1] = s[1].Replace("BestWork=", "代表作:");
            replaced[2] = s[2].Replace("Born=", "誕生年:");

            foreach (var novel in replaced) {
                Console.WriteLine(novel);
            }
#elif StringArray
             string[] lines = {
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
            };
            for (int i = 0; i < lines.Length; i++) {
                string[] s = lines[i].Split(';');
                string[] replaced = { "", "", "" };

                replaced[0] = s[0].Replace("Novelist=", "作家　:");
                replaced[1] = s[1].Replace("BestWork=", "代表作:");
                replaced[2] = s[2].Replace("Born=", "誕生年:");
                foreach (var novel in replaced) {
                    Console.WriteLine(novel);                   
                }
                Console.WriteLine();
            }
           
            

            
#endif
        }
    }
}
