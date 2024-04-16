using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();

            foreach (UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }

            }
        }
      
       
        private void Button_Click(object sender, RoutedEventArgs e)
            {
                string str = (string)((Button)e.OriginalSource).Content;

                if (str == "C")
                    TextLabel.Text = "";
                else if (str == "=")
                {
                    string value = new DataTable().Compute(TextLabel.Text, null).ToString();
                    TextLabel.Text = value;
                }
                else
                    TextLabel.Text += str;
            }











            private void GoToMainWin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw;
            mw = new MainWindow();
            Hide();
            mw.Show();

        }

    }
}
