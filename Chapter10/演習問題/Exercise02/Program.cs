using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Pickup3DigitNumber("sample.txt");
        }

        private static void Pickup3DigitNumber(string file) {

            var lists = new List<string>();
            var regex = new Regex(@"^[0-9]{3,}$");

            foreach (var line in File.ReadLines(file)) {

                string[] str = line.Split(' ');
                lists.AddRange(str);

            }
            foreach (var list in lists) {

                var isMatch = regex.IsMatch(list);
                if (isMatch)
                    Console.WriteLine(list);

            }


        }
    }
}
