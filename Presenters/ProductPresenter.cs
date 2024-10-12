﻿using Supermarket_mvp.Models;
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

            this.view.SetProductListBildingSource(productBindingSource);
            LoadAllProductList();

            this.view.Show();

        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductNombre = "";
            view.ProductPrice = "";
            view.ProductStock = "";
        }
        private void SaveProduct(object? sender, EventArgs e)
        {
            var product = new ProductModel();
            product.Id = Convert.ToInt32(view.ProductId);
            product.Name = view.ProductNombre;
            product.Stock = Convert.ToInt32(view.ProductStock);
            product.Price = Convert.ToInt32(view.ProductPrice);
            

            try
            {


                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product edited successfuly";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllProductList();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productBindingSource.Current;

                repository.Delete(product.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfuly";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete product";
            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {

            var product = (ProductModel)productBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductNombre = product.Name;
            view.ProductPrice = product.Price.ToString();
            view.ProductStock = product.Stock.ToString();
            view.IsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
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
