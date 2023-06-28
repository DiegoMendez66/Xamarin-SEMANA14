using SEMANA14.Models;
using SEMANA14.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SEMANA14.ViewModels
{
    public class ViewModelProduct: BaseViewModel
    {
        Product product = new Product();

        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }


        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Product> products;
        public List<Product> Products
        {
            get { return this.products; }
            set { SetValue(ref this.products, value); }
        }

        private string name;
        public string Name
        {
            get { return this.name; }
        }

        private string description;
        public string Description
        {
            get { return this.description; }
        }

        private string price;
        public string Price
        {
            get { return this.price; }
        }

        private string fechav;
        public string Fechav
        {
            get { return this.fechav; }
        }

        public ICommand SearchCommand { get; set; }
        public ICommand InsertCommand { get; set; }

        public ViewModelProduct()
        {

            SearchCommand = new Command(() =>
            {
                ProductService service = new ProductService();
                Products = service.GetByText(Filter);
                if (Products.Count > 3)
                    Color = "Red";
                else
                    Color = "Blue";

            });

            InsertCommand = new Command(() => 
            {
                ProductService service = new ProductService();
                
                
            });

        }


    }
}
