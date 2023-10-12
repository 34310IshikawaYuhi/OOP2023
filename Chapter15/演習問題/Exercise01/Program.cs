using System;
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
            foreach (var book in books) {
                Console.WriteLine($"{book.Key}年:{book.Count()}");
            }
        }

        private static void Exercise1_4() {
            var books = Library.Books.OrderByDescending(b => b.PublishedYear)
                                    .ThenByDescending(p => p.Price)
                                    .Join(Library.Categories,
                                            book=>book.CategoryId,
                                            category=>category.Id,
                                            (book,category)=>new {
                                            Category = category.Name,
                                            Title = book.Title,
                                            Price = book.Price,
                                            PublishedYear = book.PublishedYear
                                            }
                                     );
            foreach (var book in books) {
                Console.WriteLine("{0}年 {1}円 {2}({3})", book.PublishedYear, book.Price, book.Title,book.Category);
            }
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
