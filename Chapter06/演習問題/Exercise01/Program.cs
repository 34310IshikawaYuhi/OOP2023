using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            var MaxNumber = numbers.Max();
            Console.WriteLine(MaxNumber);
        }

        private static void Exercise1_2(int[] numbers) {
            int[] last2 = numbers.Skip(numbers.Length - 2).ToArray();
            foreach (var num in last2) {
                Console.WriteLine(num);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            var sNum = numbers.Select(x => x.ToString());
            foreach (var item in sNum) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            int[] minNum = numbers.OrderBy(x => x).Take(3).ToArray();
            foreach (var item in minNum) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            var cnt = numbers.Distinct().Where(x => x > 10);
            Console.WriteLine(cnt.Count());
        }
    }
}
