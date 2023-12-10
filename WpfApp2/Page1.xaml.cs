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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void AA_TextChanged(object sender, TextChangedEventArgs e)
        {
            int a = int.Parse(AA.Text);
            int ed = a % 10;
            int des = a / 10;
            if ((ed + des) % 2 == 1)
            {
                MessageBox.Show($"Сумма чисел является нечетной", "ответ");
            }
            else
            {
                MessageBox.Show($" Нет ", "ответ");
            }
        }
    }
}
