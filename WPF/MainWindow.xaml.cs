using System.Windows;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Controls;
using System.ComponentModel;

namespace WPF
{

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
      
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
         
        }
        private string  boundText ;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string  BoundText 
        {
            get { return boundText; }
            set { 
                boundText = value;
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs("BoundText") );
            }
        }

    }
}
