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
using SecondWpf.lib;

namespace SecondWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //btnTh.Margin = new Thickness(100, 100, 100, 100);

            //Border border = new Border();
            //border.Margin = new Thickness(10);
            //border.BorderBrush = new SolidColorBrush(Colors.Red);
            //border.BorderThickness = new Thickness(20);
            //border.Width = 200;
            //border.Height = 200;

            //MyWrap.Children.Add(border);


        }

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string text = tbxText.Text;
            int size = 0;
            foreach (RadioButton rb in spSize.Children)
            {
                if((bool)rb.IsChecked)
                {
                    size = Convert.ToInt32(rb.Content);
                    break;
                }
            }
            Qr.genQR(size,text);
        }

        //private void Button_click(object sender, RoutedEventArgs e)
        //{
        //    foreach (Border item in MyWrap.Children)
        //    {
        //        item.BorderBrush = new SolidColorBrush(Colors.Green);
        //    }
        //}
    }
}
