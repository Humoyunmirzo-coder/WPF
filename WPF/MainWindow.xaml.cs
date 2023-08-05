using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Controls;
using System.ComponentModel;

namespace WPF
{

    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
          
                InitializeComponent();
         
            }
          private void btnset_Click (object sender, RoutedEventArgs e)
        {
           // MessageBox.Show(" Could not open file" , "EROR", MessageBoxButton.YesNo , MessageBoxImage.Error);
           MessageBoxResult result =  MessageBox.Show(" Do you agre ? " , "Agrement", 
               MessageBoxButton.YesNo , MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                trbInfo.Text = "Agreed";
            }
            else
            {
                trbInfo.Text = "Not Agre";
            }
        }

    }
}
