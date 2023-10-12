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
            var books = Library.Books.Where(b => b.PublishedYear == 2016)
                                        .Join(Library.Categories,
                                              book => book.CategoryId,
                                              category => category.Id,
                                              (book, category) => category.Name)
                                        .Distinct();
            foreach (var name in books) {
                Console.WriteLine(name);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Books.Join(Library.Categories,
                                          book => book.CategoryId,
                                          category => category.Id,
                                          (book, category) => new {
                                              Category = category.Name,
                                              Title = book.Title
                                          }
                                      )
                                     .GroupBy(g=>g.Category)
                                     .OrderBy(b=>b.Key);
            foreach (var name in groups) {
                Console.WriteLine("#{0}",name.Key);
                foreach (var book in name) {
                    Console.WriteLine(" {0}",book.Title);
                }
            }
                                     
        }

        private static void Exercise1_7() {
            var group = Library.Books.Join(Library.Categories,
                                          book => book.CategoryId,
                                          category => category.Id,
                                          (book, category) => new {
                                              Category = category.Name,
                                              Title = book.Title,
                                              PublishedYear = book.PublishedYear
                                          }
                                      )
                                      .GroupBy(g => new { g.Category, g.PublishedYear })
                                      .OrderBy(n=>n.Key.PublishedYear)
                                      .Where(b => b.Key.Category.Equals("Development"));
                                     
            foreach (var g in group) {
                Console.WriteLine("#{0}", g.Key.PublishedYear);
                foreach (var book in g) {
                    Console.WriteLine(" {0}", book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var group = Library.Categories
                               .GroupJoin(Library.Books,
                                          c => c.Id,
                                          b => b.CategoryId,
                                          (c, books) => new {
                                              Category = c.Name,
                                              Count = books.Count(),
                                          });
            foreach (var obj in group) {
                if (obj.Count>=4) {
                    Console.WriteLine(obj.Category);
                }
            }
        }
    }
}
