using System.Windows;

namespace WPF.Viuw1
{
   
    public partial class Modal : Window
    {
        private object txt;

        public bool Success { get; set; }
        public string Input { get; set; }
        public Modal()
        {
            InitializeComponent();
        }
        public void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
     

        }
        public void btnCansel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
