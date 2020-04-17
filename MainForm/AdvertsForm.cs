using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC.Logic;
using ABC.ENTITY;

namespace MainForm
{
    public partial class AdvertsForm : Form
    {
        public AdvertsForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adverts_Load(object sender, EventArgs e)
        {

        }

        //public void SearchAdvertsByBrandID(int id)
        //{

        //    txtAdBId.Text = id.ToString();

        //    ABCServices services = new ABCServices();
           
        //     List<AdvertsForm> adverts = services.SearchAdvertByBrandID(id);

        //    //    // WHY IS FOLLOWING LINES?????????
        //    List<int> myintlist = new List<int>();
        //    myintlist.Add(11);
        //    myintlist.Add(1001);
        //    myintlist.Add(10021);
        //    myintlist.Add(10013);
        //    myintlist.Add(10014);
        //    myintlist.Where(o => o > 999).Count();
        //    ListAdv.Items.Clear();
        //    foreach (var item in adverts)
        //    {

        //        ListAdv.Items.Add(item. + "  -  " + item. + "  -  " + item.Ad_Start_Date);

        //    }
        //}

        private void btnAdvAdd_Click(object sender, EventArgs e)
        {

        }
    }
}