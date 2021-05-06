using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryApp.Models;

namespace InventoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        #region HELPER
        private void RefreshData() {
            using (InventoryEntities db = new InventoryEntities())
            {
                var lst = from d in db.items
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }

        private void FilterByName()
        {
            using (InventoryEntities db = new InventoryEntities())
            {
                var lst = from d in db.items
                          where d.PRODUCT.ToLower().Contains(NameFilterBox.Text.ToLower())
                          select d;
                dataGridView1.DataSource = lst.ToList();
                minimum.Value = 1;
                maximum.Value = 1;
            }
        }

        private void FilterByQuantity()
        {
            using (InventoryEntities db = new InventoryEntities())
            {
                var lst = from d in db.items
                          where d.QUANTITY >= minimum.Value && d.QUANTITY <= maximum.Value
                          select d;
                dataGridView1.DataSource = lst.ToList();
                NameFilterBox.Text = "";
            }
        }

        private void FilterByDate()
        {
            using (InventoryEntities db = new InventoryEntities())
            {
                var lst = from d in db.items
                          where d.MODIFIED_DATE >= FromFilter.Value && d.MODIFIED_DATE <= ToFilter.Value
                          select d;
                dataGridView1.DataSource = lst.ToList();
                NameFilterBox.Text = "";
                minimum.Value = 1;
                maximum.Value = 1;
            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            View.AddForm oAddForm = new View.AddForm();
            oAddForm.ShowDialog();

            RefreshData();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null){
                View.AddForm oAddForm = new View.AddForm(id);
                oAddForm.ShowDialog();
                RefreshData();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                View.Confirmation confirm = new View.Confirmation(id);
                confirm.ShowDialog();
                RefreshData();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NameFilterBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToFilter_ValueChanged(object sender, System.EventArgs e)
        {
        }

        private void FromFilter_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void maximum_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void minimum_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void ProductFilter_Click(object sender, EventArgs e)
        {
            if(NameFilterBox.Text != "")
                FilterByName();
        }

        private void QuantityFilter_Click(object sender, EventArgs e)
        {
            if(minimum.Value < maximum.Value)
                FilterByQuantity();
        }


        private void DateFilter_Click(object sender, EventArgs e)
        {
            if (FromFilter.Value < ToFilter.Value)
                Console.Write(FromFilter.Value);
                FilterByDate();
        }
    }
}
