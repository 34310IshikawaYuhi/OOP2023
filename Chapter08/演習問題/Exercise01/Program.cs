using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            //2019/1/15/ 19時48分32秒
            var s1 = dateTime.ToString("yyyy/MM/dd HH時mm分ss秒");
            Console.WriteLine(s1);
            Console.WriteLine();

        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            //2019年1月15日19時48分32秒
            var s2 = dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            Console.WriteLine(s2);
            Console.WriteLine();
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            //平成31年1月15日（火曜日）
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var s3 = dateTime.ToString("ggyy年M月d日(ddd曜日)",culture);
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
        }
    }
}
