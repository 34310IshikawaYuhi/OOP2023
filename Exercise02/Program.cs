﻿using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var ym = new YearMonth(2023, 5);
            var c21 = ym.Is21Century;
            var ymNextMonth = ym.AddOneMonth();

            Console.WriteLine(ym);//○○年△月
            Console.WriteLine(ymNextMonth);
        }
    }
}
