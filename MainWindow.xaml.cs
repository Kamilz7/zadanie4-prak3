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

namespace zadanie4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(textBoxA.Text);
            int b = Convert.ToInt32(textBoxB.Text);
            int c = Convert.ToInt32(textBoxC.Text);

            int M = (a + b) / (2 * c);
            int k = M % 3;

            double y;
            switch (k)
            {
                case 0:
                    y = Math.Log((double)a / b);
                    break;
                case 1:
                    y = Math.Exp(M + c);
                    break;
                case 2:
                    y = Math.Sqrt(Math.Abs(Math.Pow(a + b, 2) + c));
                    break;
                default:
                    y = 0;
                    break;
            }

            ResultLabel.Content = $"Значение функции:{y:f2} ";
        }
        }
    }
  

