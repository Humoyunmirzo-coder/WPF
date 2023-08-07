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
           Normal normal = new Normal();
            normal.Show();
        }
        public void btnModal_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }
    }
}


