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
    public partial class BrandsForm : Form
    {

        

        public BrandsForm()
        {
            InitializeComponent();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] arrBrands = brandList.SelectedItem.ToString().Split(' ');
                txtBId.Text = arrBrands[0];
                // call the service
                ABCServices services = new ABCServices();
                Brands brands = services.SearchBrandByID(int.Parse(arrBrands[0]));
                // check the result
                if (brands == null)
                {
                    MessageBox.Show("Brands Not Found");
                }
                else
                {
                    txtbName.Text = brands.BrandName;
                    txtbcid.Text = brands.ClientID.ToString();
                    txtbMangID.Text = brands.ManagerID.ToString();
                }
            }
            catch { }
        }


        public void BrandByClientID(int id)
        {
            

            
            txtbcid.Text = id.ToString();
            
            ABCServices services = new ABCServices();

            List<Brands> brands = services.SearchBrandByClientID(id);

            //    // WHY IS FOLLOWING LINES?????????
            List<int> myintlist = new List<int>();
            myintlist.Add(11);
            myintlist.Add(1001);
            myintlist.Add(10021);
            myintlist.Add(10013);
            myintlist.Add(10014);
            myintlist.Where(o => o > 999).Count();
            brandList.Items.Clear();
            foreach (var item in brands)
            {
                brandList.Items.Add(item.BrandID + "  -  " + item.BrandName + "  -  " + item.ManagerID);

            }


        }
        private void BrandsForm_Load(object sender, EventArgs e)
        {
            RefreshBrandList();

        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            brands.BrandID = int.Parse(txtBId.Text);
            brands.BrandName = txtbName.Text;
            brands.ClientID =int.Parse(txtbcid.Text);
            brands.ManagerID =int.Parse(txtbMangID.Text);

            // call the service
            ABCServices service = new ABCServices();
            StateEnum result = service.SaveBrand(brands);

            // check the result
            switch (result)
            {
                case StateEnum.Fail:
                    MessageBox.Show("Sorry Can't Add Brand");
                    break;
                case StateEnum.Success:
                    MessageBox.Show("New Brand Added - Thank you");
                    break;

            }
            // Refresh List after add

             RefreshBrandList();

            // Clear the form after save brand
            Clear();
        }

        public void RefreshBrandList()
        {
            ABCServices services = new ABCServices();
            List<Brands> brands = services.FindAllBrands();

            // WHY IS FOLLOWING LINES?????????
            List<int> myintlist = new List<int>();
            myintlist.Add(11);
            myintlist.Add(1001);
            myintlist.Add(10021);
            myintlist.Add(10013);
            myintlist.Add(10014);
            myintlist.Where(o => o > 999).Count();
            brandList.Items.Clear();
            foreach (var item in brands)
            {
                brandList.Items.Add(item.BrandID + "  - " + item.BrandName + "  - " + item.ClientID + " - "+ item.ManagerID);

            }

        }
        //Find Brand By ID
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int bid = int.Parse(txtBId.Text);
            ABCServices aBCServices = new ABCServices();
            Brands foundBrand = aBCServices.SearchBrandByID(bid);
            //switch (foundClient.StateResult)
            //{
            //    case StateEnum.Fail:
            //        MessageBox.Show("Error");
            //        break;
            //    case StateEnum.Success:
            if (foundBrand == null)
            {
                MessageBox.Show("Employee Not Found");
            }
            else
            {
                txtBId.Text = foundBrand.BrandID.ToString();
                txtbName.Text = foundBrand.BrandName;
                txtbcid.Text = foundBrand.ClientID.ToString();
                txtbMangID.Text = foundBrand.ManagerID.ToString();
            }
            // break;

        }

        public void Clear()
        {
         txtBId.Text = txtbName.Text = txtbcid.Text = txtbMangID.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

            Clear();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (txtBId.Text == "")
            {
                MessageBox.Show("Please Select Brand from List for update");
            }
            else
            {

                Brands brands = new Brands();
                brands.BrandID = int.Parse(txtBId.Text);
                brands.BrandName = txtbName.Text;
                brands.ClientID =int.Parse(txtbcid.Text);
                brands.ManagerID =int.Parse(txtbMangID.Text);

                //call the service
                ABCServices service = new ABCServices();
                StateEnum result = service.UpdateBrandDetails(brands);
                // check the result
                switch (result)
                {
                    case StateEnum.Fail:
                        MessageBox.Show("Sorry Can't update Brand");
                        break;
                    case StateEnum.Success:
                        MessageBox.Show("Brand Updated- Thank You");
                        break;

                }
                RefreshBrandList();

            }
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            Brands brands = new Brands();
            brands.BrandID = int.Parse(txtBId.Text);
            brands.BrandName = txtbName.Text;
            brands.ClientID = int.Parse(txtbcid.Text);
            brands.ManagerID = int.Parse(txtbMangID.Text);

            ABCServices services = new ABCServices();
            StateEnum result = services.DeleteBrand(brands);
            switch (result)
            {
                case StateEnum.Fail:
                    MessageBox.Show("Can't Delete Brand");
                    break;
                case StateEnum.Success:
                    MessageBox.Show("Brand Deleted");
                    break;
            }
            RefreshBrandList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBId.Text == "")
            {
                MessageBox.Show("Please select Brand from the List");
            }
            else
            {
                AdvertsForm a = new AdvertsForm();
                a.Show();
             //   a.SearchAdvertsByBrandID(int.Parse(txtBId.Text));
            }
        }
    }
}
