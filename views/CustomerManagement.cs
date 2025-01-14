using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement.dao;
using UserManagement.models;

namespace UserManagement
{
    public partial class CustomerManagement : Form
    {
        private string selectedCustomerId;

        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Id = selectedCustomerId;
            customer.Name = txtName.Text;
            customer.LastName = txtLastname.Text;
            customer.Celphone = txtCelphone.Text;
            customer.CreditCard = txtCreditCard.Text;

            ClientDao clientDb = new ClientDao();
            clientDb.Save(customer);
            refreshList();

            txtName.Clear();
            txtLastname.Clear();
            txtCelphone.Clear();
            txtCreditCard.Clear();
            selectedCustomerId = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = (Customer)listCustomers.SelectedItem;

            ClientDao clientDb = new ClientDao();
            clientDb.Delete(selectedCustomer);
            refreshList();

        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = (Customer)listCustomers.SelectedItem;
            txtName.Text = selectedCustomer.Name;
            txtLastname.Text = selectedCustomer.LastName;
            txtCelphone.Text = selectedCustomer.Celphone;
            txtCreditCard.Text = selectedCustomer.CreditCard;

            selectedCustomerId = selectedCustomer.Id;


            lblStateActionCustomer.Text = "Edit Customer";
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        private void refreshList()
        {
            ClientDao dataBase = new ClientDao();
            List<Customer> listDb = dataBase.GetAllCustomers();

            listCustomers.Items.Clear();
            for (int i = 0; i < listDb.Count; i++)
            {
                Customer customer = listDb[i];
                listCustomers.Items.Add(customer);
            }
        }

    }
}
