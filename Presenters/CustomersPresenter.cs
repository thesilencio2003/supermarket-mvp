using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CustomersPresenter
    {
        private ICustomersView view;
        private ICustomersRepository repository;
        private BindingSource customersBindingSource;
        private IEnumerable<CustomersModel> customersModelList;

        public CustomersPresenter(ICustomersView view, ICustomersRepository repository)
        {
            this.customersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomersListBildingSource(customersBindingSource);
            LoadAllPayModeList();

            this.view.Show();
        }

        private void LoadAllPayModeList()
        {
            customersModelList = repository.GetAll();
            customersBindingSource.DataSource = customersModelList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {

            bool emotyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emotyValue == false)
            {
                customersModelList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customersModelList = repository.GetAll();
            }
            customersBindingSource.DataSource = customersModelList;
        }
    }
}
