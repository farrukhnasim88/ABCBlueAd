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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //private void DisplayForm_Load(object sender, EventArgs e)
        //{
        //    ABCServices service = new ABCServices();
        //    State<List<Clients>> result = service.FindAllClients();
        //    switch (result.StateResult)
        //    {
        //        case StateEnum.Fail:
        //            MessageBox.Show("ERROR");
        //            break;
        //        case StateEnum.Success:
        //            dataGridView1.DataSource = result.Data;
        //            break;
        //    }
        //}
    }
}