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

namespace InventoryApp.View
{
    public partial class AddForm : Form
    {
        public int? id;
        items oItems = null;
        public AddForm(int? id=null)
        {
            InitializeComponent();

            this.id = id;
            if(id!=null)
                LoadDataFields();
        }

        private void LoadDataFields()
        {
            using (InventoryEntities db = new InventoryEntities())
            {
                oItems = db.items.Find(id);
                ProductName.Text = oItems.PRODUCT;
                quantity.Value = oItems.QUANTITY;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(InventoryEntities db = new InventoryEntities())
            {

                if (id == null)
                    oItems = new items();

                oItems.PRODUCT = ProductName.Text;
                oItems.QUANTITY = Convert.ToInt32(quantity.Value);
                oItems.MODIFIED_DATE = DateTime.Now;

                if (id==null)
                    db.items.Add(oItems); 
                else
                {
                db.Entry(oItems).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();

                this.Close();
            }


        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
