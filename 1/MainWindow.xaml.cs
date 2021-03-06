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
using ClassLibrary1;

namespace _1
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
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнила студентка группы ИСП-31 Васинкина Анастасия\n" +
                "Вычислить разницу целых случайных чисел, распределенных в диапазоне от 2 до 10, " +
                "пока эта разница не станет меньше некоторого числа K(K < 0).Вывести на экран сгенерированные числа, " +
                "значение суммы, и количество сгенерированных чисел.");
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            int k = Convert.ToInt32(ZnK.Text); //Вводим к
            if (k < 0)
            {
                Class1.Start(k, out string str, out int raznost, out int kol); //используем функцию
                Zn.Text = str; //вывод сгенерированных чисел
                Raznost.Text = Convert.ToString(raznost); //вывод sum
                Kol.Text = Convert.ToString(kol); //вывод kol
            }else MessageBox.Show("Неверно ввели к!", "Ошибка");
        }
        private void Drzn_TextChanged(object sender, TextChangedEventArgs e)
        {
            Zn.Text = null;
            Raznost.Text = null;
            Kol.Text = null;
        }
    }
}
