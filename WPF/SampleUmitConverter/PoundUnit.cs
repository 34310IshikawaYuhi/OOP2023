﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUmitConverter {
    //ヤード単位を表すクラス
    public class PoundUnit
        : DistanceUnit {
        private static List<PoundUnit> units = new List<PoundUnit> {
            new PoundUnit{Name="oz",Coefficient=1,},
            new PoundUnit{Name="lb",Coefficient=16,},
           
        };
        public static ICollection<PoundUnit> Units { get { return units; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">値</param>
        /// <returns>変換値</returns>
        public double FromGrumUnit(GrumUnit unit, double value) {
            return (value * unit.Coefficient) / 28.35 / this.Coefficient;
        }
    }
}
