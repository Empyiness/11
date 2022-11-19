using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace _11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Regex regex;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Task1(object sender, RoutedEventArgs e)
        {
            StringBox.Text = "a1a a22a a333a a4444a a55555a aba aca";
            RegexBox.Text = @"a\d+a";
        }
        private void Task2(object sender, RoutedEventArgs e)
        {
            StringBox.Text = "aba aea aca aza axa a-a a#a";
            RegexBox.Text = @"\ba[^be]a\b";
        }
        private void Find(object sender, RoutedEventArgs e)
        {
            regex = new Regex(RegexBox.Text);
            ResultBox.Text = String.Join(" ", regex.Matches(StringBox.Text));
        }
        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дана строка 'a1a a22a a333a a4444a a55555a aba aca'. Напишите регулярное выражение, которое найдет строки, в которых по краям стоят буквы 'a', а между ними любое количество цифр. Дана строка 'aba aea aca aza axa a-a a#a'. Напишите регулярное выражение, которое найдет строки следующего вида: по краям стоят буквы 'a', а между ними - не 'e' и не 'x'");
        }
        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
