using System.Windows;
using WPF.Viuw1;
namespace WPF
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();

        }
        public void btnNormal_Click(object sender, RoutedEventArgs e)
        {
           Close();
        }
        public void btnModal_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}


