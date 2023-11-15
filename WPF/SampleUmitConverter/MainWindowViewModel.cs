using SampleUnitConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUmitConverter {
    public class MainWindowViewModel : ViewModel{
        private double metricValue, imperialValue;

        public  double GrumValue {
            get { return this.metricValue; }
            set {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }

        public double PoundValue {
            get { return this.imperialValue; }
            set {
                this.imperialValue = value;
                this.OnPropertyChanged();
            }
        }

        //上のComboBoxで選択されている値（単位）
        public GrumUnit CurrentMetricUnit { get; set; }

        //下のComboBoxで選択されている値（単位）
        public PoundUnit CurrentImperialUnit { get; set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }

        //▼ボタンで呼ばれるコマンド
        public ICommand MetricToImperialUnit { get;private set; }

        //コンストラクタ
        public MainWindowViewModel() {
            this.CurrentMetricUnit = GrumUnit.Units.First();
            this.CurrentImperialUnit = PoundUnit.Units.First();

            this.MetricToImperialUnit = new DelegateCommand(
                () => this.PoundValue = this.CurrentImperialUnit.FromGrumUnit(
                    this.CurrentMetricUnit, this.GrumValue));

            this.ImperialUnitToMetric = new DelegateCommand(
                () => this.GrumValue = this.CurrentMetricUnit.FromPoundUnit(
                    this.CurrentImperialUnit, this.imperialValue));
        }
    }
}
