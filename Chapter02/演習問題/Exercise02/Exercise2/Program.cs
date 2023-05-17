using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom") {
                    PrintInchToMeterList(1, 10);
            }
            else {
                    PrintMeterToFeetList(1, 10);
            }
        }
        //フィートからメートルへの対応表を出力
        static void PrintInchToMeterList(int start, int stop) {
           for (int inch = 1; inch <= 10; inch++) {
               double meter = InchConverter.ToMeter(inch);
               Console.WriteLine("{0} inch = {1:0.000}m", inch, meter);
           }
        }
        //メートルからフィートへの対応表を出力
        static void PrintMeterToFeetList(int start, int stop) {
            for (int meter = 1; meter <= 10; meter++) {
                double inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.000}inch", meter, inch);
            }
        }
    }
}
