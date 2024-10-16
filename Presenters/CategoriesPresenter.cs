﻿using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;

        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.categoriesBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriesListBildingSource(categoriesBindingSource);
            LoadAllPayModeList();

            this.view.Show();

        }

        private void LoadAllPayModeList()
        {
            categoriesList = repository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            var categories = new CategoriesModel();
            categories.Id = Convert.ToInt32(view.CategoriesId);
            categories.Name = view.CategoriesName;
            categories.Description = view.CategoriesDescription;

            try
            {


                new Common.ModelDataValidation().Validate(categories);
                if (view.IsEdit)
                {
                    repository.Edit(categories);
                    view.Message = "Categories edited successfuly";
                }
                else
                {
                    repository.Add(categories);
                    view.Message = "Categories added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllPayModeList();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void CleanViewFields()
        {
            view.CategoriesId = "0";
            view.CategoriesName = "";
            view.CategoriesDescription = "";
        }
        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            try
            {
                var categories = (CategoriesModel)categoriesBindingSource.Current;

                repository.Delete(categories.Id);
                view.IsSuccessful = true;
                view.Message = "Categories deleted successfuly";
                LoadAllPayModeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Categories";
            }
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {

            var payMode = (CategoriesModel)categoriesBindingSource.Current;

            view.CategoriesId = payMode.Id.ToString();
            view.CategoriesName = payMode.Name;
            view.CategoriesDescription = payMode.Description;

            view.IsEdit = true;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {

            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {

            bool emotyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emotyValue == false)
            {
                categoriesList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoriesList = repository.GetAll();
            }
            categoriesBindingSource.DataSource = categoriesList;
        }

    }
}
