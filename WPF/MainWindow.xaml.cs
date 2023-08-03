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

/* <Grid.RowDefinitions>
    <RowDefinition  Height="50"/>
    <RowDefinition Height="350"/>
    <RowDefinition  Height="50"/>
</Grid.RowDefinitions>
   <!--  menu bar -->
<Rectangle Grid.Row="0" Fill="Blue"/>
   <!-- Content panel-->
<Grid Grid.Row="1">
    <Grid.ColumnDefinitions >
        <ColumnDefinition Width="20*" />
        <ColumnDefinition Width="60*"/>
        <ColumnDefinition Width="20*"/>
    </Grid.ColumnDefinitions>
    <Rectangle Fill="DarkBlue"/>
    <Rectangle Grid.Column="1" Fill="DarkGray"/>
    <Rectangle  Grid.Column="2" Fill="DarkBlue"/>
</Grid>
   <!--  Footer -->
<Rectangle Grid.Row="2" Fill="Beige"/>


*/


}
}
