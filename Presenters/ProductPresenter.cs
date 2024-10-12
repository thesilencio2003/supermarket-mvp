using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {

        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productModeList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(productBindingSource);
            LoadAllProductList();

            this.view.Show();

        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emotyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emotyValue == false)
            {
                productModeList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productModeList = repository.GetAll();
            }
            productBindingSource.DataSource = productModeList;
        }

        private void LoadAllProductList()
        {
            productModeList = repository.GetAll();
            productBindingSource.DataSource = productModeList;
        }
    }
}
