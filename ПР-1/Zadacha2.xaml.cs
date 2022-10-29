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
using System.Text.RegularExpressions;
using System.Globalization;

namespace ПР_1
{
    /// <summary>
    /// Логика взаимодействия для Zadacha2.xaml
    /// </summary>
    public partial class Zadacha2 : Window
    {
        public Zadacha2()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();

        private void bt_vp_Click(object sender, RoutedEventArgs e)
        {
            foreach (string item in tb_vvod.Text.Split(' '))
            {
                if (item != "") list.Add(item.Trim());
            }

            list.Reverse();

            foreach (string str in list)
            {
                tb_result.Text = tb_result.Text + " " + str;
            }

        }

        private void tb_vvod_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Text = new string(textBox.Text.Where(ch => ch == '+' || ch == '-' || (ch >= '0' && ch <= '9') || (ch >= 'а' && ch <= 'я') || (ch >= 'А' && ch <= 'Я') || ch == 'ё' || ch == 'Ё' || ch == ' ').ToArray());
            }
        }
    }
}
