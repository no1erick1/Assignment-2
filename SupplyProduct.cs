using Assignment_2.Resources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class SupplyProduct : Form
    {
        
        public static List<SupplyFood> listSupplyFood { get; set; }
      
        public SupplyFood SupplyFoodSelected { get; set; }
        public SupplyProduct()
        {
            InitializeComponent();

            SupplyProduct.listSupplyFood = new List<SupplyFood>(); 
            CreateDataSupplyFood(); 
            InitListView();
            LoadSupplyFood(); 
        
        }
        public void InitListView()
        {
            ListFood.Columns.Add("Id");
            ListFood.Columns.Add("Food&&Water");
            ListFood.Columns.Add("Category Food");
            ListFood.Columns.Add("Patient");

            ListFood.AutoArrange = true;
            ListFood.GridLines = true;
            ListFood.FullRowSelect = true;
            ListFood.View = View.Details;
        }
        public void LoadSupplyFood()
        {
            ListFood.Items.Clear();
           SupplyFood temp;
            for (int i = 0; i < SupplyProduct.listSupplyFood.Count; i++)
            {
                ListViewItem subItem = new ListViewItem();
                temp = (SupplyFood)SupplyProduct.listSupplyFood[i];
                subItem.Text = i.ToString();
                subItem.SubItems.Add(temp.FoodWater.ToString());
                subItem.SubItems.Add(temp.CategoryFood.ToString());
                subItem.SubItems.Add(temp.Patient.ToString());
                ListFood.Items.Add(subItem);
            }
        }
        public void CreateDataSupplyFood()
        {
            SupplyFood d1 = new SupplyFood("0","Braised pork with eggs", "Non - vegetarian food","Huỳnh Thanh Dương");
            SupplyFood d2 = new SupplyFood("1","Pickled Scallion head", "Vegetarian food", "Lý Tiểu Long");
            listSupplyFood.Add(d1);
            listSupplyFood.Add(d2);        
        }
        private void SupplyProduct_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD formAdd = new ADD();
            formAdd.ShowDialog();
            if(ADD.Food != null)
            {
                SupplyFood a = new SupplyFood(ADD.Food);

                if (string.IsNullOrEmpty(a.FoodWater.ToString()) || string.IsNullOrEmpty(a.CategoryFood.ToString()) || string.IsNullOrEmpty(a.Patient.ToString()))
                {
                }
                else
                {
                    listSupplyFood.Add(a);
                    MessageBox.Show("Add successful", "Notification");
                    LoadSupplyFood();
                }
            }
        }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count == 1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                int index = Convert.ToInt32(item.Text);
                SupplyFoodSelected = (SupplyFood)SupplyProduct.listSupplyFood[index];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                
                SupplyProduct.listSupplyFood.Remove(this.SupplyFoodSelected);
                LoadSupplyFood();
                MessageBox.Show("Delete successful", "Notification");
            }
        }
    }
}
