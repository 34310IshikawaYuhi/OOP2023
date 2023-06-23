using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            /*var flowerDict = new Dictionary<string, int>() {
                ["sunflower"]=400,
                ["pansy"] = 300,
                ["tulip"] = 350,
                ["rose"] = 500,
                ["dahlia"] = 450,
            };
            //morning glory(あさがお)[250円]を追加 
            flowerDict["morning glory"] = 250;
            Console.WriteLine("ひまわりの価格は{0}円です。",flowerDict["sunflower"]);
            Console.WriteLine("チューリップの価格は{0}円です。",flowerDict["tulip"]);
            Console.WriteLine("あさがおの価格は{0}円です。",flowerDict["morning glory"]);
*/
            var prefDict = new Dictionary<string,CityInfo>();
            string pref, city;
            int population = 0;

            Console.WriteLine("県庁所在地の登録");
            while (true) {
                Console.Write("県名：");
                pref = Console.ReadLine();
                if (pref.Equals("999")) {
                    break;
                }
                Console.Write("所在地：");
                city = Console.ReadLine();
                Console.Write("人口：");
                population = int.Parse(Console.ReadLine());

                if (prefDict.ContainsKey(pref)) {
                    Console.WriteLine("既に県名が登録されています");
                    Console.Write("上書きしますか？(y,n):");
                    if (Console.ReadLine() != "y") {
                        continue;
                    }
                }
                prefDict[pref] = new CityInfo {
                    City = city,
                    Population = population,
                };
                
            }
            Console.WriteLine();
            Console.WriteLine("1:一覧表示 \n2:県名指定");
            string sel = Console.ReadLine();
            if (sel.Equals("1")) {
                foreach (var item in prefDict.OrderByDescending(p=>p.Value.Population)) {
                    Console.WriteLine("{0}【{1}(人口：{2}人)】", item.Key,item.Value.City,item.Value.Population);
                }
            }
            else if(sel.Equals("2")) {
                Console.Write("県名を入力：");
                pref = Console.ReadLine();
                Console.WriteLine("【{0}(人口：{1}人)】", prefDict[pref].City,prefDict[pref].Population);
            }
            
        }
    }
    class CityInfo {
        public string City { get; set; }    //都市
        public int Population { get; set; } //人口
    }
}
