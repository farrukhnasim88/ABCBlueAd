using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ABCBlueForm : Form
    {
        public ABCBlueForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientsForm c = new ClientsForm();
            c.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            ManagersForm m = new ManagersForm();
            m.ShowDialog();
        }

        private void btnAdverts_Click(object sender, EventArgs e)
        {
            AdvertsForm a = new AdvertsForm();
            a.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm r = new ReportsForm();
            r.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrandsForm b = new BrandsForm();
            b.ShowDialog();
        }
    }
}
