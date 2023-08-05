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
              private void btnAdd_Click (object sender, RoutedEventArgs e)
        {
            Leavenst.Items.Add(txtenty.Text);
        }


    }
}
