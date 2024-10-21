﻿using System;
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

namespace PR_23._106.Danilovavariant1
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
  

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    string num = Ninetext.Text;
                    int num1s = 1;
                    int num2_sum = 1;
                    if (num.Length != 12)
                    {
                        MessageBox.Show("неверная длина числа");
                        return;
                    }
                    string num1 = num.Substring(0, 3);
                    string num2 = num.Substring(3, num.Length - 3);

                    for (int i = 0; i < num1.Length; i++)
                    {
                        num1s = num1s * Convert.ToInt32(Convert.ToString(num1[i]));
                        //textbox2.Text += $"{Convert.ToInt32(num1[i])}\n";
                    }
                    for (int i = 0; i < num2.Length; i++)
                    {
                        num2_sum = num2_sum * Convert.ToInt32(Convert.ToString(num2[i]));
                    }
                    if (num1s == num2_sum)
                    {
                        textbox1.Text = "произведение 3 первых цифр равно произведению 9 последних цифр";
                        //textbox2.Text = $"{num1_sum}\n{num2_sum}";
                    }
                    else
                    {
                        textbox1.Text = "произведение 3 первых цифр не равно произведению 9 последних цифр";
                        //textbox2.Text = $"{num1_sum}\n{num2_sum}";
                    }
                }
                catch
                {
                    MessageBox.Show("ошибка");
                    return;
                }

            
        }
}
