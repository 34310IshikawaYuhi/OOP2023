using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUmitConverter {
    //メートル単位を表すクラス
    public class GrumUnit : DistanceUnit{
        private static List<GrumUnit> units = new List<GrumUnit> {
            new GrumUnit{Name="g",Coefficient=1,},
            new GrumUnit{Name="kg",Coefficient=1000,},
           
        };
        public static ICollection<GrumUnit> Units { get { return units; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit">グラム単位</param>
        /// <param name="value">値</param>
        /// <returns>変換値</returns>
        public double FromPoundUnit(PoundUnit unit, double value) {
            return (value * unit.Coefficient) * 28.35 / this.Coefficient;
        }
    }
}
