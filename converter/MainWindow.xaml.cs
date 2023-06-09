using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] mainItems = { "Длина", "Масса", "Время"};

        string[] items0 = { "Сантиметры", "Метры", "Километры" };
        string[] items1 = { "Граммы", "Килограммы", "Тонна" };
        string[] items2 = { "Секунды", "Минуты", "Часы" };

        public MainWindow()
        {
            InitializeComponent();
            ListBox1.ItemsSource = mainItems;
        }

      

        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Count();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)){
                this.Count();
            }
            
        }

        private void Count()
        {
            string text = textBox1.Text;
            int selectedItem1 = ListBox1.SelectedIndex;
            int selectedItem2 = listBox2.SelectedIndex;
            
        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedItem = ListBox1.SelectedIndex;

            switch (selectedItem)
            {
                case 1:
                    listBox2.ItemsSource = items1;
                    listBox3.ItemsSource = items1;
                    break;

                case 2:
                    listBox2.ItemsSource = items2;
                    listBox3.ItemsSource = items2;
                    break;

                default:
                    listBox2.ItemsSource = items0;
                    listBox3.ItemsSource = items0;
                    break;
            }
            this.Count();

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int selectedItem0 = ListBox1.SelectedIndex;
            int selectedItem1 = listBox2.SelectedIndex;
            int selectedItem2 = listBox3.SelectedIndex;
            switch (selectedItem0)
            {
                case 0:
                    switch (selectedItem1)
                    {
                        case 0:
                            switch (selectedItem2) { case 0: textBox2.Text = textBox1.Text; break; case 1: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) / 100); break; case 2: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) / 100000); break; }

                            break;
                        case 1: switch (selectedItem2) { case 0: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 100); break; case 1: textBox2.Text = textBox1.Text; break; case 2: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) / 1000); break; } break;
                        case 2: switch (selectedItem2) { case 0: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 100000); break; case 1: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000); break; case 2: textBox2.Text = textBox1.Text; break; } break;
                    }
                    break;
                case 1:
                    switch (selectedItem1)
                    {
                        case 0:
                            switch (selectedItem2) { case 0: textBox2.Text = textBox1.Text; break; case 1: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) / 1000); break; case 2: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) / 1000000); break; }

                            break;
                        case 1: switch (selectedItem2) { case 0: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000); break; case 1: textBox2.Text = textBox1.Text; break; case 2: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) / 1000); break; } break;
                        case 2: switch (selectedItem2) { case 0: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000000); break; case 1: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 1000); break; case 2: textBox2.Text = textBox1.Text; break; } break;
                    }
                    break;
                case 2:
                    switch (selectedItem1)
                    {
                        case 0:
                            switch (selectedItem2) { case 0: textBox2.Text = textBox1.Text; break; case 1: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) / 60); break; case 2: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) / 3600); break; }

                            break;
                        case 1: switch (selectedItem2) { case 0: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 60); break; case 1: textBox2.Text = textBox1.Text; break; case 2: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) / 60); break; } break;
                        case 2: switch (selectedItem2) { case 0: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 3600); break; case 1: textBox2.Text = Convert.ToString(double.Parse(textBox1.Text) * 60); break; case 2: textBox2.Text = textBox1.Text; break; } break;
                    }
                    break;
            }
            
            
        }
    }
}
