using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC.ENTITY;
using ABC.Logic;

namespace MainForm
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }


          // Insert Client
        private void button1_Click(object sender, EventArgs e) 
        {
            Clients clients = new Clients();
            clients.ClientID = int.Parse(txtID.Text);
            clients.ClientName = txtName.Text;
            clients.ClientPhone = txtPhone.Text;

            // call the service
            ABCServices service = new ABCServices();
            StateEnum result = service.SaveClient(clients);

            // check the result
            switch (result)
            {
                case StateEnum.Fail:
                    MessageBox.Show("Sorry Can't Add Client");
                    break;
                case StateEnum.Success:
                    MessageBox.Show("Client Added Thank you");
                    break;

            }
            // Refresh List after add

            RefreshList();
            // Clear the form after save brand
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] arrClients = ListClient.SelectedItem.ToString().Split(' ');
                txtID.Text = arrClients[0];
                // call the service
                ABCServices services = new ABCServices();
                Clients clients = services.SearchClientByID(int.Parse(arrClients[0]));
                // check the result
                if (clients == null)
                {
                    MessageBox.Show("Client Not Found");
                }
                else
                {
                    txtName.Text = clients.ClientName;
                    txtPhone.Text = clients.ClientPhone;
                }
            }
            catch { }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please Select Client from List for update");
            }
            else
            {

                Clients clients = new Clients();
                clients.ClientID = int.Parse(txtID.Text);
                clients.ClientName = txtName.Text;
                clients.ClientPhone = txtPhone.Text;

                //call the service
                ABCServices service = new ABCServices();
                StateEnum result = service.UpdateClientDetails(clients);
                // check the result
                switch (result)
                {
                    case StateEnum.Fail:
                        MessageBox.Show("Sorry Can't update Client");
                        break;
                    case StateEnum.Success:
                        MessageBox.Show("Clients Details Updated- Thank You");
                        break;

                }
                RefreshList();

            }
        }
       
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.ClientID = int.Parse(txtID.Text);
            clients.ClientName = txtName.Text;
            clients.ClientPhone = txtPhone.Text;

            ABCServices services = new ABCServices();
            StateEnum result = services.DeleteClient(clients);
            switch (result)
            {
                case StateEnum.Fail:
                    MessageBox.Show("Can't Delete Client");
                    break;
                case StateEnum.Success:
                    MessageBox.Show("Client Deleted");
                    break;
            }
            RefreshList();
        }

        //Event to display brands by clientID
        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please select Client from the List");
            }
            else
            {
                BrandsForm b = new BrandsForm();
                b.Show();
                b.BrandByClientID(int.Parse(txtID.Text));
            }
        }


        public void RefreshList()
        {
            ABCServices services = new ABCServices();
            List<Clients> clients = services.FindAllClients();

            // WHY IS FOLLOWING LINES?????????
            List<int> myintlist = new List<int>();
            myintlist.Add(11);
            myintlist.Add(1001);
            myintlist.Add(10021);
            myintlist.Add(10013);
            myintlist.Add(10014);
            myintlist.Where(o => o > 999).Count();
            ListClient.Items.Clear();
            foreach (var item in clients)
            {
                ListClient.Items.Add(item.ClientID+ "  - "+ item.ClientName+ "  - "+ item.ClientPhone);

            }

        }

        // Form onload Event 
        private void ClientsForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            int cid = int.Parse(txtID.Text);
            ABCServices aBCServices = new ABCServices();
            Clients foundClient = aBCServices.SearchClientByID(cid);
            //switch (foundClient.StateResult)
            //{
            //    case StateEnum.Fail:
            //        MessageBox.Show("Error");
            //        break;
            //    case StateEnum.Success:
                    if (foundClient == null)
                    {
                        MessageBox.Show("Employee Not Found");
                    }
                    else
                    {
                        txtID.Text = foundClient.ClientID.ToString();
                        txtName.Text = foundClient.ClientName;
                        txtPhone.Text = foundClient.ClientPhone;
                    }
                   // break;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    