using SEMANA14.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEMANA14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductInsert : ContentPage
    {
        public ProductInsert()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ProductList());
            };
            this.BindingContext = new ViewModelProduct();
        }
    }
}