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
    public partial class Confirmation : Form
    {
        public int? id;
        public Confirmation(int? id=null)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (InventoryEntities db = new InventoryEntities())
            {
                items oItem = db.items.Find(id);
                db.items.Remove(oItem);
                db.SaveChanges();

                this.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
