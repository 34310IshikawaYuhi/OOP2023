using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
            var prefDict = new Dictionary<string, List<CityInfo>>();
            string pref, city;
            int population;
            

            Console.WriteLine("都市の登録");
            while (true) {
                Console.Write("県名：");
                pref = Console.ReadLine();
                if (pref.Equals("999")) {
                    break;
                }
                Console.Write("都市：");
                city = Console.ReadLine();
                Console.Write("人口：");
                population = int.Parse(Console.ReadLine());

                var cityinfo = new CityInfo {
                    City = city,
                    Population = population,
                };
                if (!prefDict.ContainsKey(pref)) {

                    prefDict[pref] = new List<CityInfo>();
                }
                prefDict[pref].Add(cityinfo);

            }
            Console.WriteLine();
            Console.WriteLine("1:一覧表示 \n2:県名指定");
            string sel = Console.ReadLine();
            if (sel.Equals("1")) {
                foreach (var prefData in prefDict) {
                    foreach (var cityData in prefData.Value) {
                        Console.WriteLine("{0}【{1}(人口：{2}人)】", prefData.Key, cityData.City, cityData.Population);
                    }                  
                }
            }
            else if (sel.Equals("2")) {
                Console.Write("県名を入力：");
                var inputpref = Console.ReadLine();
                foreach (var cityData in prefDict[inputpref]) {
                    Console.WriteLine("{0}【{1}(人口：{2}人)】", inputpref, cityData.City,cityData.Population);
                }
            }
        }
    }
    class CityInfo {
        public string City { get; set; }    //都市
        public int Population { get; set; } //人口
    }
}
