﻿using System;
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
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            setColor();
        }

        private void setColor() {
            Color color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value , (byte)bSlider.Value);
            ColorArea.Background = new SolidColorBrush(color);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            stockList.Items.Add($"R:{rValue.Text} G:{gValue.Text} B:{bValue.Text}");
            
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectColor = (MyColor)((ComboBox)sender).SelectedItem;
            rValue.Text = selectColor.Color.R.ToString();
            gValue.Text = selectColor.Color.G.ToString();
            bValue.Text = selectColor.Color.B.ToString();
        }
    }


    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
