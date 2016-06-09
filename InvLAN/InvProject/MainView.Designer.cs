namespace InvProject
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invitemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.invitemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.testdataDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testdataDataSet = new InvProject.testdataDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new InvProject.testdataDataSetTableAdapters.inventoryTableAdapter();
            this.itemskuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemskuDataGridViewTextBoxColumn,
            this.itemdescDataGridViewTextBoxColumn,
            this.itemcategoryDataGridViewTextBoxColumn,
            this.itemquantityDataGridViewTextBoxColumn,
            this.itemcostDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.itemdiffDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(200, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(880, 520);
            this.dataGridView1.TabIndex = 0;
            // 
            // invitemsBindingSource1
            // 
            this.invitemsBindingSource1.DataMember = "invitems";
            // 
            // invitemsBindingSource
            // 
            this.invitemsBindingSource.DataMember = "invitems";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(846, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(440, 575);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Inventory Items";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(660, 645);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "Edit Inventory Items";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // testdataDataSet
            // 
            this.testdataDataSet.DataSetName = "testdataDataSet";
            this.testdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.testdataDataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // itemskuDataGridViewTextBoxColumn
            // 
            this.itemskuDataGridViewTextBoxColumn.DataPropertyName = "item_sku";
            this.itemskuDataGridViewTextBoxColumn.HeaderText = "item_sku";
            this.itemskuDataGridViewTextBoxColumn.Name = "itemskuDataGridViewTextBoxColumn";
            this.itemskuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemdescDataGridViewTextBoxColumn
            // 
            this.itemdescDataGridViewTextBoxColumn.DataPropertyName = "item_desc";
            this.itemdescDataGridViewTextBoxColumn.HeaderText = "item_desc";
            this.itemdescDataGridViewTextBoxColumn.Name = "itemdescDataGridViewTextBoxColumn";
            this.itemdescDataGridViewTextBoxColumn.Width = 240;
            // 
            // itemcategoryDataGridViewTextBoxColumn
            // 
            this.itemcategoryDataGridViewTextBoxColumn.DataPropertyName = "item_category";
            this.itemcategoryDataGridViewTextBoxColumn.HeaderText = "item_category";
            this.itemcategoryDataGridViewTextBoxColumn.Name = "itemcategoryDataGridViewTextBoxColumn";
            // 
            // itemquantityDataGridViewTextBoxColumn
            // 
            this.itemquantityDataGridViewTextBoxColumn.DataPropertyName = "item_quantity";
            this.itemquantityDataGridViewTextBoxColumn.HeaderText = "item_quantity";
            this.itemquantityDataGridViewTextBoxColumn.Name = "itemquantityDataGridViewTextBoxColumn";
            // 
            // itemcostDataGridViewTextBoxColumn
            // 
            this.itemcostDataGridViewTextBoxColumn.DataPropertyName = "item_cost";
            this.itemcostDataGridViewTextBoxColumn.HeaderText = "item_cost";
            this.itemcostDataGridViewTextBoxColumn.Name = "itemcostDataGridViewTextBoxColumn";
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "item_price";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            // 
            // itemdiffDataGridViewTextBoxColumn
            // 
            this.itemdiffDataGridViewTextBoxColumn.DataPropertyName = "item_diff";
            this.itemdiffDataGridViewTextBoxColumn.HeaderText = "item_diff";
            this.itemdiffDataGridViewTextBoxColumn.Name = "itemdiffDataGridViewTextBoxColumn";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource invitemsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource testdataDataSet1BindingSource;
        private System.Windows.Forms.BindingSource invitemsBindingSource1;
        private System.Windows.Forms.BindingSource invitemsBindingSource2;
        private testdataDataSet testdataDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private testdataDataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemskuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdiffDataGridViewTextBoxColumn;
    }
}