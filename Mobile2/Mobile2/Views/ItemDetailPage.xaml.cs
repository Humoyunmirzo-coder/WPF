using Mobile2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Mobile2.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}