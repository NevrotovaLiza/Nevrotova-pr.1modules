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
    /// Логика взаимодействия для Zadacha4.xaml
    /// </summary>
    public partial class Zadacha4 : Window
    {
        public Zadacha4()
        {
            InitializeComponent();
        }

        private void bt_vp_Click(object sender, RoutedEventArgs e)
        {
            const int size = 10;
            const int min = -100, max = 100;
            int b = Convert.ToInt32(tb_vvod.Text);

            int[] a = new int[size];

            Random rnd = new Random();

            for (int i = 0; i < size; i++) a[i] = rnd.Next(min, max);


            for (int i = 0; i < a.Length; i++)
            {
                tb_min.Text += a[i].ToString() + "\r\n";
            };

            lb_b.Content = b;

            Array.Sort(a);

            for (int i = 0; i < a.Length; i++)
            {
                tb_max.Text += a[i].ToString() + "\r\n";
            };
        }
    }
}
