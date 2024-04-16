using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            //this.Close();
        }

        private void Button_Click_ID_Student(object sender, RoutedEventArgs e)
        {
            Window1 nwc = new Window1();
            Hide();
            nwc.Show();
        }

        private void Krestiki_Noliki_Click(object sender, RoutedEventArgs e)
        {
            Window2 nwc = new Window2();
            Hide();
            nwc.Show();

        }

        private void Culc_All_Click(object sender, RoutedEventArgs e)
        {
            Window3 nwc = new Window3();
            Hide();
            nwc.Show();

        }

        private void Autor_Click(object sender, RoutedEventArgs e)
        {
            Window4 nwc = new Window4();
            Hide();
            nwc.Show();

        }
    }
}