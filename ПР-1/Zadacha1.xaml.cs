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
using System.Windows.Shapes;

namespace ПР_1
{
    /// <summary>
    /// Логика взаимодействия для Zadacha1.xaml
    /// </summary>
    public partial class Zadacha1 : Window
    {
        public Zadacha1()
        {
            InitializeComponent();
        }

        public int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }

        private void bt_vp_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(tb_vvod.Text) > 100)
            {
                MessageBox.Show("Введите значение меньше 100 или равному 100");
            }
            else
            {
                lb_result.Content = (Factorial(Convert.ToInt32(tb_vvod.Text)) * 2);
            }
        }

        private void tb_vvod_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if ((e.Text) == null || !(e.Text).All(char.IsDigit))
            {
                e.Handled = true;
            }
        }
    }
}
