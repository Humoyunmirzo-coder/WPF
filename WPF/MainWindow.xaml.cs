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

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("Hello, world!");
            }
        

    }
}


