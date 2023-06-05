using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            
        }

        private static void Exercise3_1(string text) {
            int count = text.Count(n => n == ' ');
            Console.WriteLine("空白数："+count);

        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            string[] count = text.Split(' ');
            Console.WriteLine("単語数"+count.Length);
        }

        private static void Exercise3_4(string text) {
            string[] words = text.Split(' ');
            foreach (var word in words) {
                if (word.Length<=4) {
                    Console.WriteLine(word);
                }
            }
        }

        private static void Exercise3_5(string text) {
            string[] words = text.Split(' ');
            if (words.Length > 0) {
                var sb = new StringBuilder(words[0]);

                foreach (var word in words.Skip(1)) {
                    //sb.Append(word+' ');
                    sb.Append(' ');
                    sb.Append(word);
                }
                var t = sb.ToString();
                Console.WriteLine(t);
            }
        }
    }
}
