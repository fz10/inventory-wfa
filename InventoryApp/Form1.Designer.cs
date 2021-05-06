namespace InventoryApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ToFilter = new System.Windows.Forms.DateTimePicker();
            this.FromFilter = new System.Windows.Forms.DateTimePicker();
            this.DateFilter = new System.Windows.Forms.Button();
            this.maximum = new System.Windows.Forms.NumericUpDown();
            this.minimum = new System.Windows.Forms.NumericUpDown();
            this.QuantityFilter = new System.Windows.Forms.Button();
            this.ProductFilter = new System.Windows.Forms.Button();
            this.NameFilterBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.ToFilter);
            this.splitContainer1.Panel1.Controls.Add(this.FromFilter);
            this.splitContainer1.Panel1.Controls.Add(this.DateFilter);
            this.splitContainer1.Panel1.Controls.Add(this.maximum);
            this.splitContainer1.Panel1.Controls.Add(this.minimum);
            this.splitContainer1.Panel1.Controls.Add(this.QuantityFilter);
            this.splitContainer1.Panel1.Controls.Add(this.ProductFilter);
            this.splitContainer1.Panel1.Controls.Add(this.NameFilterBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.delete);
            this.splitContainer1.Panel1.Controls.Add(this.Edit_button);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(867, 398);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // ToFilter
            // 
            this.ToFilter.Location = new System.Drawing.Point(692, 27);
            this.ToFilter.Name = "ToFilter";
            this.ToFilter.Size = new System.Drawing.Size(155, 20);
            this.ToFilter.TabIndex = 15;
            this.ToFilter.Value = new System.DateTime(2021, 5, 6, 23, 59, 0, 0);
            this.ToFilter.ValueChanged += new System.EventHandler(this.ToFilter_ValueChanged);
            // 
            // FromFilter
            // 
            this.FromFilter.Location = new System.Drawing.Point(692, 5);
            this.FromFilter.Name = "FromFilter";
            this.FromFilter.Size = new System.Drawing.Size(155, 20);
            this.FromFilter.TabIndex = 14;
            this.FromFilter.Value = new System.DateTime(2021, 5, 6, 0, 0, 0, 0);
            this.FromFilter.ValueChanged += new System.EventHandler(this.FromFilter_ValueChanged);
            // 
            // DateFilter
            // 
            this.DateFilter.Location = new System.Drawing.Point(610, 9);
            this.DateFilter.Name = "DateFilter";
            this.DateFilter.Size = new System.Drawing.Size(40, 39);
            this.DateFilter.TabIndex = 13;
            this.DateFilter.Text = "Date";
            this.DateFilter.UseVisualStyleBackColor = true;
            this.DateFilter.Click += new System.EventHandler(this.DateFilter_Click);
            // 
            // maximum
            // 
            this.maximum.Location = new System.Drawing.Point(538, 36);
            this.maximum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.maximum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maximum.Name = "maximum";
            this.maximum.Size = new System.Drawing.Size(51, 20);
            this.maximum.TabIndex = 12;
            this.maximum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maximum.ValueChanged += new System.EventHandler(this.maximum_ValueChanged);
            // 
            // minimum
            // 
            this.minimum.Location = new System.Drawing.Point(481, 36);
            this.minimum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.minimum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(51, 20);
            this.minimum.TabIndex = 11;
            this.minimum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimum.ValueChanged += new System.EventHandler(this.minimum_ValueChanged);
            // 
            // QuantityFilter
            // 
            this.QuantityFilter.Location = new System.Drawing.Point(499, 8);
            this.QuantityFilter.Name = "QuantityFilter";
            this.QuantityFilter.Size = new System.Drawing.Size(74, 24);
            this.QuantityFilter.TabIndex = 10;
            this.QuantityFilter.Text = "Quantity";
            this.QuantityFilter.UseVisualStyleBackColor = true;
            this.QuantityFilter.Click += new System.EventHandler(this.QuantityFilter_Click);
            // 
            // ProductFilter
            // 
            this.ProductFilter.Location = new System.Drawing.Point(392, 8);
            this.ProductFilter.Name = "ProductFilter";
            this.ProductFilter.Size = new System.Drawing.Size(59, 24);
            this.ProductFilter.TabIndex = 9;
            this.ProductFilter.Text = "Product";
            this.ProductFilter.UseVisualStyleBackColor = true;
            this.ProductFilter.Click += new System.EventHandler(this.ProductFilter_Click);
            // 
            // NameFilterBox
            // 
            this.NameFilterBox.Location = new System.Drawing.Point(387, 36);
            this.NameFilterBox.Name = "NameFilterBox";
            this.NameFilterBox.Size = new System.Drawing.Size(72, 20);
            this.NameFilterBox.TabIndex = 5;
            this.NameFilterBox.TextChanged += new System.EventHandler(this.NameFilterBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter by:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(237, 12);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 35);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(130, 12);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(90, 35);
            this.Edit_button.TabIndex = 1;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(867, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "To:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 398);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameFilterBox;
        private System.Windows.Forms.Button QuantityFilter;
        private System.Windows.Forms.Button ProductFilter;
        private System.Windows.Forms.NumericUpDown maximum;
        private System.Windows.Forms.NumericUpDown minimum;
        private System.Windows.Forms.Button DateFilter;
        private System.Windows.Forms.DateTimePicker ToFilter;
        private System.Windows.Forms.DateTimePicker FromFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

