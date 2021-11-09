using AutoKraftMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AutoKraftMobile.Views
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