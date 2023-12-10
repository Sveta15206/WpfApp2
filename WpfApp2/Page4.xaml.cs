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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void BB_TextChanged(object sender, TextChangedEventArgs e)
        {
            double x = double.Parse(AA.Text);
            double k = double.Parse(BB.Text);
            double y = 0;

            if (k == 3)
            {
                y = Sin(x) + 2;
            }
            else if (k == 20)
            {
                Cos(x * x);
            }
            else if (k == 10 || k == 15)
            {
                y = Tan(x) + Sin(x);
            }
            else { MessageBox.Show("переменная k не подходит"); }

            MessageBox.Show($"y = {y}", "Ответ");
        }

        private void Cos(double v)
        {
            throw new NotImplementedException();
        }

        private int Tan(double x)
        {
            throw new NotImplementedException();
        }

        private int Sin(double x)
        {
            throw new NotImplementedException();
        }
    }
}
