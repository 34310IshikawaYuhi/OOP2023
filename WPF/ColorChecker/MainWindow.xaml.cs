using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        private MyColor selectColor = new MyColor();
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
            setColor();
           
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            setColor();
        }

        private void setColor() {
            Color color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value , (byte)bSlider.Value);
            ColorArea.Background = new SolidColorBrush(color);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            selectColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);

            var colorName = GetColorList().Where(c => c.Color.R == selectColor.Color.R
                                                && c.Color.G == selectColor.Color.G
                                                && c.Color.B == selectColor.Color.B).FirstOrDefault()?.Name;
            stockList.Items.Insert(0,( colorName == "" || colorName == null) ? selectColor.ToString():colorName);

            //stockList.Items.Add($"R:{rValue.Text} G:{gValue.Text} B:{bValue.Text}");
            
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            selectColor = (MyColor)((ComboBox)sender).SelectedItem;
            rValue.Text = selectColor.Color.R.ToString();
            gValue.Text = selectColor.Color.G.ToString();
            bValue.Text = selectColor.Color.B.ToString();
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var data = stockList.Items[stockList.SelectedIndex];
            var color = GetColorList().Where(c => c.Name.Equals(data)).FirstOrDefault();
            string[] RGB = data.ToString().Split( );
            if (color == null) {
                rSlider.Value = double.Parse(RGB[0].Replace("R:",""));
                gSlider.Value = double.Parse(RGB[1].Replace("G:", ""));
                bSlider.Value = double.Parse(RGB[2].Replace("B:", ""));
            }
            else {
                rSlider.Value = color.Color.R;
                gSlider.Value = color.Color.G;
                bSlider.Value = color.Color.B;
            }
        }
    }


    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
        public override string ToString() {
            return $"R:{Color.R} G:{Color.G} B:{Color.B}";
        }
    }
}
