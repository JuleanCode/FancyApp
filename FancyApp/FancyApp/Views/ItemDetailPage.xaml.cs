using FancyApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FancyApp.Views
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