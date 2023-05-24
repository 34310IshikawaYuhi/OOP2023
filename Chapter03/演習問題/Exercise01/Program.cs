﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);
        }

        private static void Exercise1_1(List<int> numbers) {

            var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            if (exist)
                Console.WriteLine("存在しています");
            else
                Console.WriteLine("存在していません");

        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(s => Console.WriteLine(s / 2.0));
        }

        private static void Exercise1_3(List<int> numbers) {
            numbers.Where(n=>n>=50).ToList().ForEach(Console.WriteLine) ;
            //var datas = numbers.Where(s => s>=50);
            //foreach (var item in datas) {
            //   Console.WriteLine(item);
            //}
        }

        private static void Exercise1_4(List<int> numbers) {
            numbers.Select(n => n * 2).ToList().ForEach(Console.WriteLine);

            //var list = numbers.Select(n => n * 2).ToList();
            //foreach (var item in list) {
            //    Console.WriteLine(item);
            //}
        }
    }
}
