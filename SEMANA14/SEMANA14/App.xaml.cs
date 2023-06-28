using SEMANA14.DataContext;
using SEMANA14.Models;
using SEMANA14.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEMANA14
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProductInsert();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        internal static AppDbContext GetContext()
        {
            throw new NotImplementedException();
        }
    }
}
