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
    }
}
