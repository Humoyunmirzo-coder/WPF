using System.Windows;

namespace WPF
{

    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();
         
        }
        private void Runbuttom(object sender , RoutedEventArgs e)
        {
            if (running)
            {
                // stop 
                nmhello.Text = "stoping";
                btrun.Content = "Run";
            }
            else
            {
                // run
                nmhello.Text = "Running";
                btrun.Content = "stop";
            }

            running =! running;

                
        }
    }
}
