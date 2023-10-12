﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var price = Library.Books.Where(b=>b.Price == Library.Books.Max(p=>p.Price));
            foreach (var book in price) {
                Console.WriteLine("{0}:{1} {2}円 {3}年",book.Title,book.CategoryId,book.Price,book.PublishedYear);
            }
        }

        private static void Exercise1_3() {
            var books = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(group=>group.Key);
            foreach (var g in books) {
                Console.WriteLine($"{g.Key}年:{g.Count()}");
            }
        }

        private static void Exercise1_4() {
            
        }

        private static void Exercise1_5() {

        }

        private static void Exercise1_6() {

        }

        private static void Exercise1_7() {

        }

        private static void Exercise1_8() {

        }
    }
}
