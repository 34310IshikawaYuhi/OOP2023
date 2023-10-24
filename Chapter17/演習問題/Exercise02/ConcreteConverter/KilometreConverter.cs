using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.ConcreteConverter {
    class KilometreConverter : Framework.ConverterBase{
        public override bool IsMyUnit(string name) {
            return name.ToLower() == "kilometre" || name == UnitName;
        }
        protected override double Ratio { get { return 1000; } }
        public override string UnitName { get { return "キロメートル"; } }
    }
}
