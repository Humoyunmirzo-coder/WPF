using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Controls;

namespace WPF
{

    public partial class MainWindow : Window
    {
       // bool running = false;
        public MainWindow()
        {
            InitializeComponent();
         
        }
   /*     private void Runbuttom(object sender , RoutedEventArgs e)
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

                   /*< TextBox   Name = "nmhello"  Text = "hello world" FontSize = "35" />
        < Button  Name = "btrun" Width = "100" Height = "50" VerticalAlignment = "Center"
                 HorizontalAlignment = "Center"  Content = "Run"  FontSize = "20" Click = "Runbuttom" />
         

        }*/
    }
}
