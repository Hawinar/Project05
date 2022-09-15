using System;
using System.Windows;
namespace Project05
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    // 3.1	Лабораторная работа №1. Тема: «Качественное ПО» Вариант №22 https://github.com/Hawinar

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btFind_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double localMemoryX = 3;
                double localMemoryY = 1;

                double localMemoryZ = 0;
                double localMemoryB = 0;
                //К сожалению, чтобы все арифметические действия выполнялись чётко, пришлось ввести столько новых переменных

                double number = double.Parse(numberToFind.Text);
                localMemoryB = number;
                for (double i = number; localMemoryB >= 0;)
                {
                    if (number == 0 || number == 1)
                    {
                        localMemoryZ = Math.Pow(i, localMemoryY / localMemoryX);
                        MessageBox.Show(localMemoryZ.ToString());
                        break;
                    }
                    localMemoryB -= 2;
                    i += localMemoryB;
                    localMemoryZ = Math.Pow(i, localMemoryY / localMemoryX);
                    localMemoryZ = Math.Round(localMemoryZ, 6);
                    if (localMemoryZ % 1 == 0)
                    {
                        MessageBox.Show(localMemoryZ.ToString());
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Убедитесь, что число натуральное");
            }
        }
    }
}
