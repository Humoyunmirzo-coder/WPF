using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Controls;
using System.ComponentModel;
using Microsoft.Win32;

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
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            bool? seccess = fileDialog.ShowDialog();
            if (seccess != null)
            {
                string  path = fileDialog.FileName;
                trbInfo.Text = path;
            }
            else
            {
                // did pik enything 
            }
        }

    }
}
