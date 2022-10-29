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

namespace ПР_1
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

        private void bt_zadacha1_Click(object sender, RoutedEventArgs e)
        {
            Zadacha1 f = new Zadacha1();
            f.Show();
        }

        private void bt_zadacha2_Click(object sender, RoutedEventArgs e)
        {
            Zadacha2 f = new Zadacha2();
            f.Show();
        }

        private void bt_zadacha3_Click(object sender, RoutedEventArgs e)
        {
            Zadacha3 f = new Zadacha3();
            f.Show();
        }

        private void bt_zadacha4_Click(object sender, RoutedEventArgs e)
        {
            Zadacha4 f = new Zadacha4();
            f.Show();
        }

        private void bt_zadacha5_Click(object sender, RoutedEventArgs e)
        {
            Zadacha5 f = new Zadacha5();
            f.Show();
        }
    }
}
