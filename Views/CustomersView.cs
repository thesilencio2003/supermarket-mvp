﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class CustomersView : Form, ICustomersView
    {
        public CustomersView()
        {
            InitializeComponent();

            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCustomersDetail);
            BtnClose.Click += delegate { this.Close(); };
        }


        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public string CustomersId
        {
            get { return TxtCustomersId.Text; }
            set { TxtCustomersId.Text = value; }
        }


        public string CustomersDocument
        {
            get { return TxtCustomersDocument.Text; }
            set { TxtCustomersDocument.Text = value; }
        }


        public string CustomersFirstName
        {
            get { return TxtCustomersFirstName.Text; }
            set { TxtCustomersFirstName.Text = value; }
        }

        public string CustomersLastName
        {
            get { return TxtCustomersLastName.Text; }
            set { TxtCustomersLastName.Text = value; }
        }

        public string CustomersAddress
        {
            get { return TxtCustomersAddress.Text; }
            set { TxtCustomersAddress.Text = value; }
        }



        public string CustomersEmail
        {
            get { return TxtCustomersEmail.Text; }
            set { TxtCustomersEmail.Text = value; }
        }

        public string CustomersPhone
        {
            get { return TxtCustomersPhone.Text; }
            set { TxtCustomersPhone.Text = value; }
        }

        public string CustomersDate
        {
            get { return TxtCustomersDate.Text; }
            set { TxtCustomersDate.Text = value; }
        }

        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }



        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCustomersListBildingSource(BindingSource customersList)
        {

            DgCustomers.DataSource = customersList;
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

        }
    }
}
