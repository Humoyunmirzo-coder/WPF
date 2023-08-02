using System.Windows;

namespace WPF
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nmhello.Text = "Hello world 2 ";
            btrun.Content = "stop"; 
        }
    }
}
