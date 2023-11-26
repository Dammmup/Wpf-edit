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

namespace editwpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox tb = new TextBox { Text = "Ваше число: " };
        Label lbl = new Label { Content = "результат да/нет" };
        Button btn = new Button() { Content = "Проверить простое или нет" };

        TextBox tb1 = new TextBox { Text = "Введите строчку: " };
        ComboBox cb = new ComboBox();
        Button btn1 = new Button { Content = "посчитать" };
        

        CheckBox cb1 = new CheckBox() { Content = "цифры" };
        CheckBox cb2 = new CheckBox() { Content = "заглавные латинские буквы" };
        CheckBox cb3 = new CheckBox() { Content = "прописные латинские буквы" };
        CheckBox cb4 = new CheckBox() { Content = "спец символы" };
        Button btn2 = new Button { Content = "сгенерировать надежный пароль" };
        Label lbl2 = new Label { Content = "рандомный пароль" };

        TextBox txt3 = new TextBox() { Text = "Число один" };
        TextBox txt4 = new TextBox() { Text = "Число два" };
        RadioButton rd1 = new RadioButton { Content = "сумма" };
        RadioButton rd2 = new RadioButton { Content = "разница" };
        RadioButton rd3 = new RadioButton { Content = "умножение" };
        RadioButton rd4 = new RadioButton { Content = "деление" };
        Button btn3 = new Button { Content = "посчитать" };

        TextBox txt5 = new TextBox() { Text = "Первое" };
        TextBox txt6 = new TextBox() { Text = "Второе" };
        TextBox txt7 = new TextBox() { Text = "Третье" };
        TextBox txt8 = new TextBox() { Text = "Четвертое" };
        TextBox txt9 = new TextBox() { Text = "Пятое" };
        TextBox txt10 = new TextBox() { Text = "Шестое" };
        Button btn4 = new Button { Content = "создать массив" };
        Button btn5 = new Button { Content = "сумма элементов" };
        Button btn6 = new Button { Content = "произведение элементов" };
        Button btn7 = new Button { Content = "мин элемент" };
        Button btn8 = new Button { Content = "макс элемент" };
        public MainWindow()
        {

            InitializeComponent();

            Grid mygrid = new Grid();

            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.RowDefinitions.Add(new RowDefinition());
            mygrid.ColumnDefinitions.Add(new ColumnDefinition());
            mygrid.ColumnDefinitions.Add(new ColumnDefinition());
            mygrid.ColumnDefinitions.Add(new ColumnDefinition());
            mygrid.ColumnDefinitions.Add(new ColumnDefinition());

            btn.Click += MyButton_click;
            btn.Margin = new Thickness(5);
            tb.Margin = new Thickness(5);
            lbl.Margin = new Thickness(5);

            Grid.SetRow(tb, 0);
            Grid.SetRow(lbl, 0);
            Grid.SetRow(btn, 1);
            Grid.SetColumn(tb, 0);
            Grid.SetColumn(lbl, 1);
            Grid.SetColumn(btn, 0);

            mygrid.Children.Add(tb);
            mygrid.Children.Add(lbl);
            mygrid.Children.Add(btn);

            tb1.Margin = new Thickness(5);
            cb.Margin = new Thickness(5);
            btn1.Margin = new Thickness(5);
            cb.Items.Add("посчитать гласные");
            cb.Items.Add("посчитать согласные");
            cb.Items.Add("посчитать цифры");
            cb.Items.Add("посчитать слова");

            Grid.SetRow(tb1, 2);
            Grid.SetRow(cb, 3);
            Grid.SetRow(btn1, 4);
            Grid.SetColumn(tb1, 0);
            Grid.SetColumn(cb, 0);
            Grid.SetColumn(btn1, 0);

            mygrid.Children.Add(tb1);
            mygrid.Children.Add(cb);
            mygrid.Children.Add(btn1);

            cb1.Margin = new Thickness(7);
            cb2.Margin = new Thickness(7);
            cb3.Margin = new Thickness(7);
            cb4.Margin = new Thickness(7);
            lbl2.Margin = new Thickness(7);

            Grid.SetRow(cb1, 5);
            Grid.SetRow(cb2, 6);
            Grid.SetRow(cb3, 7);
            Grid.SetRow(cb4, 5);
            Grid.SetRow(btn2, 8);
            Grid.SetRow(lbl2, 9);
            Grid.SetColumn(cb1, 0);
            Grid.SetColumn(cb2, 0);
            Grid.SetColumn(cb3, 0);
            Grid.SetColumn(cb4, 1);
            Grid.SetColumn(btn2, 0);
            Grid.SetColumn(lbl2, 0);

            mygrid.Children.Add(cb1);
            mygrid.Children.Add(cb2);
            mygrid.Children.Add(cb3);
            mygrid.Children.Add(cb4);
            mygrid.Children.Add(btn2);
            mygrid.Children.Add(lbl2);

            txt3.Margin = new Thickness(10);
            txt4.Margin = new Thickness(10);
            rd1.Margin = new Thickness(10);
            rd2.Margin = new Thickness(10);
            rd3.Margin = new Thickness(10);
            rd4.Margin = new Thickness(10);
            btn3.Margin = new Thickness(10);

            Grid.SetRow(txt3, 0); Grid.SetColumn(txt3, 2);
            Grid.SetRow(txt4, 0); Grid.SetColumn(txt4, 3);
            Grid.SetRow(rd1, 1); Grid.SetColumn(rd1, 2);
            Grid.SetRow(rd2, 1); Grid.SetColumn(rd2, 3);
            Grid.SetRow(rd3, 2); Grid.SetColumn(rd3, 2);
            Grid.SetRow(rd4, 2); Grid.SetColumn(rd4, 3);
            Grid.SetRow(btn3, 3); Grid.SetColumn(btn3, 2);

            mygrid.Children.Add(txt3);
            mygrid.Children.Add(txt4);
            mygrid.Children.Add(rd1);
            mygrid.Children.Add(rd2);
            mygrid.Children.Add(rd3);
            mygrid.Children.Add(rd4);
            mygrid.Children.Add(btn3);


            txt5.Margin = new Thickness(10);
            txt6.Margin = new Thickness(10);
            txt7.Margin = new Thickness(10);
            txt8.Margin = new Thickness(10);
            txt9.Margin = new Thickness(10);
            txt10.Margin = new Thickness(10);
            btn4.Margin = new Thickness(10);
            btn5.Margin = new Thickness(10);
            btn6.Margin = new Thickness(10);
            btn7.Margin = new Thickness(10);
            btn8.Margin = new Thickness(10);

            Grid.SetRow(txt5, 4); Grid.SetColumn(txt5, 2);
            Grid.SetRow(txt6, 4); Grid.SetColumn(txt6, 3);
            Grid.SetRow(txt7, 5); Grid.SetColumn(txt7, 2);
            Grid.SetRow(txt8, 5); Grid.SetColumn(txt8, 3);
            Grid.SetRow(txt9, 6); Grid.SetColumn(txt9, 2);
            Grid.SetRow(txt10, 6); Grid.SetColumn(txt10, 3);
            Grid.SetRow(btn4, 7); Grid.SetColumn(btn4, 2);
            Grid.SetRow(btn5, 8); Grid.SetColumn(btn5, 2);
            Grid.SetRow(btn6, 9); Grid.SetColumn(btn6, 2);
            Grid.SetRow(btn7, 10); Grid.SetColumn(btn7, 2);
            Grid.SetRow(btn8, 10); Grid.SetColumn(btn8, 3);

            mygrid.Children.Add(txt5);
            mygrid.Children.Add(txt6);
            mygrid.Children.Add(txt7);
            mygrid.Children.Add(txt8);
            mygrid.Children.Add(txt9);
            mygrid.Children.Add(txt10);
            mygrid.Children.Add(btn4);
            mygrid.Children.Add(btn5);
            mygrid.Children.Add(btn6);
            mygrid.Children.Add(btn7);
            mygrid.Children.Add(btn8);

            btn.Click += MyButton_click;
            btn1.Click += MyButton_click1;
            btn2.Click += MyButton_click2;
            btn3.Click += MyButton_click3;
            btn4.Click += MyButton_click4;
            btn5.Click += MyButton_click5;
            btn6.Click += MyButton_click6;
            btn7.Click += MyButton_click7;
            btn8.Click += MyButton_click8;


            this.Content = mygrid;


        }
        private void MyButton_click(object sender, RoutedEventArgs e)
        {
            int number;
            if (!Int32.TryParse(tb.Text, out number))
            {
                lbl.Content = "Некорректный ввод";
                return;
            }
            bool isPrime = IsPrime(number);
            lbl.Content = isPrime ? "да" : "нет";
        }
        private bool IsPrime(int number)
        {

            if (number < 2)
                return false;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        private void MyButton_click1(object sender, RoutedEventArgs e)
        {
            string selectedItem = (string)cb.SelectedItem;
            string inputString = tb1.Text;
            int count = 0;

            if (selectedItem == "посчитать гласные")
            {
                // Count vowels
                foreach (char c in inputString)
                {
                    if ("aeiouAEIOU".Contains(c))
                    {
                        count++;
                    }
                }
            }
            else if (selectedItem == "посчитать согласные")
            {
                // Count consonants
                foreach (char c in inputString)
                {
                    if (char.IsLetter(c) && !"aeiouAEIOU".Contains(c))
                    {
                        count++;
                    }
                }
            }
            else if (selectedItem == "посчитать цифры")
            {
                // Count digits
                foreach (char c in inputString)
                {
                    if (char.IsDigit(c))
                    {
                        count++;
                    }
                }
            }
            else if (selectedItem == "посчитать слова")
            {
                // Count words
                count = inputString.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }
            else
            {
                MessageBox.Show("You haven't chosen any item.");
                return;
            }

            MessageBox.Show($"Количество {selectedItem}: {count}");
        }
        private void MyButton_click2(object sender, RoutedEventArgs e)
        {
            
                bool includeDigits = cb1.IsChecked ?? false;
                bool includeUppercase = cb2.IsChecked ?? false;
                bool includeLowercase = cb3.IsChecked ?? false;
                bool includeSpecialChars = cb4.IsChecked ?? false;

                if (!includeDigits && !includeUppercase && !includeLowercase && !includeSpecialChars)
                {
                    MessageBox.Show("Выберите хотя бы один параметр для генерации пароля.");
                    return;
                }

                string passwordCharacters = "";
                string digits = "0123456789";
                string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
                string specialChars = "!@#$%^&*()_-+=<>?";

                if (includeDigits)
                    passwordCharacters += digits;
                if (includeUppercase)
                    passwordCharacters += uppercaseLetters;
                if (includeLowercase)
                    passwordCharacters += lowercaseLetters;
                if (includeSpecialChars)
                    passwordCharacters += specialChars;

                Random rnd = new Random();
                string generatedPassword = "";

                for (int i = 0; i < 10; i++)
                {
                    int index = rnd.Next(0, passwordCharacters.Length);
                    generatedPassword += passwordCharacters[index];
                }

                lbl2.Content = generatedPassword;
            
        }
        private void MyButton_click3(object sender, RoutedEventArgs e)
        {
            int num1 = Int32.Parse(txt3.Text);
            int num2 = Int32.Parse(txt4.Text);
            int result;
            if (rd1.IsChecked == true)
            {
                result = num1 + num2;
                MessageBox.Show(result.ToString());
            }
            else if (rd2.IsChecked == true)
            {
                result = num1 - num2;
                MessageBox.Show(result.ToString());
            }
            else if (rd3.IsChecked == true)
            {
                result = num1 * num2;
                MessageBox.Show(result.ToString());
            }
            else if (rd4.IsChecked == true)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    MessageBox.Show(result.ToString());
                }
                else
                {
                    MessageBox.Show("Cannot divide by zero.");
                }
            }
            else
            {
                MessageBox.Show("Please select an operation.");
            }
        }
        private int[] numbers;

        private void MyButton_click4(object sender, RoutedEventArgs e)
        {
            numbers = new int[6];

            if (TryParseAndAssign(txt5.Text, out numbers[0]) &&
                TryParseAndAssign(txt6.Text, out numbers[1]) &&
                TryParseAndAssign(txt7.Text, out numbers[2]) &&
                TryParseAndAssign(txt8.Text, out numbers[3]) &&
                TryParseAndAssign(txt9.Text, out numbers[4]) &&
                TryParseAndAssign(txt10.Text, out numbers[5]))
            {
                MessageBox.Show("Массив создан успешно.");
            }
            else
            {
                MessageBox.Show("Ошибка ввода. Введите целые числа.");
            }
        }

        private void MyButton_click5(object sender, RoutedEventArgs e)
        {
            if (numbers != null)
            {
                MessageBox.Show($"Сумма элементов: {numbers.Sum()}");
            }
            else
            {
                MessageBox.Show("Массив не создан. Сначала создайте массив.");
            }
        }

        private void MyButton_click6(object sender, RoutedEventArgs e)
        {
            if (numbers != null)
            {
                int product = 1;

                foreach (int num in numbers)
                {
                    product *= num;
                }

                MessageBox.Show($"Произведение элементов: {product}");
            }
            else
            {
                MessageBox.Show("Массив не создан. Сначала создайте массив.");
            }
        }

        private void MyButton_click7(object sender, RoutedEventArgs e)
        {
            if (numbers != null)
            {
                int minElement = numbers.Min();
                MessageBox.Show($"Минимальный элемент: {minElement}");
            }
            else
            {
                MessageBox.Show("Массив не создан. Сначала создайте массив.");
            }
        }

        private void MyButton_click8(object sender, RoutedEventArgs e)
        {
            if (numbers != null)
            {
                int maxElement = numbers.Max();
                MessageBox.Show($"Максимальный элемент: {maxElement}");
            }
            else
            {
                MessageBox.Show("Массив не создан. Сначала создайте массив.");
            }
        }

        private bool TryParseAndAssign(string input, out int result)
        {
            return int.TryParse(input, out result);
        }
    }
}