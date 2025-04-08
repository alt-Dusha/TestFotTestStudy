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

namespace TestFotTestStudy
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

        void checkIfInputDigits(object sender, TextCompositionEventArgs e)
        {
            if (((TextBox)sender).Text == "0")
            {
                MessageBox.Show("Нельзя начинать писать вещественные числа с нуля", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Warning);
                ((TextBox)sender).Clear();
            }

            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
