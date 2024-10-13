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

            this.view.SearchEvent += SearchCustomers;
            this.view.AddNewEvent += AddNewCustomers;
            this.view.EditEvent += LoadSelectCustomersToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomers;
            this.view.SaveEvent += SaveCustomers;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomersListBildingSource(customersBindingSource);
            LoadAllCustomersList();

            this.view.Show();
        }

        private void LoadAllCustomersList()
        {
            customersModelList = repository.GetAll();
            customersBindingSource.DataSource = customersModelList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {

            CleanViewFields();
        }

        private void SaveCustomers(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(view.CustomersId) ||
        string.IsNullOrWhiteSpace(view.CustomersDocument) ||
        string.IsNullOrWhiteSpace(view.CustomersFirstName) ||
        string.IsNullOrWhiteSpace(view.CustomersLastName) ||
        string.IsNullOrWhiteSpace(view.CustomersAddress) ||
        string.IsNullOrWhiteSpace(view.CustomersPhone) ||
        string.IsNullOrWhiteSpace(view.CustomersEmail) ||
        string.IsNullOrWhiteSpace(view.CustomersDate))
            {
                view.Message = "Please fill in all required fields.";
                return;
            }

            var customers = new CustomersModel();

            try
            {
                customers.Id = Convert.ToInt32(view.CustomersId);
                customers.Document = view.CustomersDocument;
                customers.FirstName = view.CustomersFirstName;
                customers.lastName = view.CustomersLastName;
                customers.Address = view.CustomersAddress;
                customers.Date = Convert.ToDateTime(view.CustomersDate);
                customers.PhoneNumber = view.CustomersPhone;
                customers.Email = view.CustomersEmail;

                new Common.ModelDataValidation().Validate(customers);
                if (view.IsEdit)
                {
                    repository.Edit(customers);
                    view.Message = "customers edited successfuly";
                }
                else
                {
                    repository.Add(customers);
                    view.Message = "customers added successfuly";
                }
                view.IsSuccessful = true;
                LoadAllCustomersList();
                CleanViewFields();
            }
            catch (FormatException ex)
            {
                view.Message = "La fecha ingresada no es válida. Por favor, ingrese una fecha en el formato yyyy-MM-dd.";
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CustomersId = "0";
            view.CustomersDocument = "";
            view.CustomersFirstName = "";
            view.CustomersLastName = "";
            view.CustomersAddress = "";
            view.CustomersDate = "";
            view.CustomersPhone= "";
            view.CustomersEmail = "";
        }

        private void DeleteSelectedCustomers(object? sender, EventArgs e)
        {
            try
            {
                var customers = (CustomersModel)customersBindingSource.Current;

                repository.Delete(customers.Id);
                view.IsSuccessful = true;
                view.Message = "Customers deleted successfuly";
                LoadAllCustomersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Customers";
            }

        }

        private void LoadSelectCustomersToEdit(object? sender, EventArgs e)
        {

            var customers = (CustomersModel)customersBindingSource.Current;

            view.CustomersId = customers.Id.ToString();
            view.CustomersDocument = customers.Document.ToString();
            view.CustomersFirstName = customers.FirstName;
            view.CustomersLastName = customers.lastName;
            view.CustomersAddress = customers.Address;
            view.CustomersDate = customers.Date.ToString("yyyy-MM-dd");
            view.CustomersPhone = customers.PhoneNumber.ToString();
            view.CustomersEmail = customers.Email;
            view.IsEdit = true;
        }

        private void AddNewCustomers(object? sender, EventArgs e)
        {

            view.IsEdit = false;
        }

        private void SearchCustomers(object? sender, EventArgs e)
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
