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
            this.itemskuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testdataDataSet3 = new InvProject.testdataDataSet3();
            this.testdataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invitemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.invitemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.testdataDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testdataDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter1 = new InvProject.testdataDataSet3TableAdapters.inventoryTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSet1BindingSource1)).BeginInit();
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
            this.dataGridView1.DataSource = this.inventoryBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(200, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(880, 520);
            this.dataGridView1.TabIndex = 0;
            // 
            // itemskuDataGridViewTextBoxColumn
            // 
            this.itemskuDataGridViewTextBoxColumn.DataPropertyName = "item_sku";
            this.itemskuDataGridViewTextBoxColumn.HeaderText = "SKU Number";
            this.itemskuDataGridViewTextBoxColumn.Name = "itemskuDataGridViewTextBoxColumn";
            this.itemskuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemdescDataGridViewTextBoxColumn
            // 
            this.itemdescDataGridViewTextBoxColumn.DataPropertyName = "item_desc";
            this.itemdescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.itemdescDataGridViewTextBoxColumn.Name = "itemdescDataGridViewTextBoxColumn";
            this.itemdescDataGridViewTextBoxColumn.Width = 240;
            // 
            // itemcategoryDataGridViewTextBoxColumn
            // 
            this.itemcategoryDataGridViewTextBoxColumn.DataPropertyName = "item_category";
            this.itemcategoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.itemcategoryDataGridViewTextBoxColumn.Name = "itemcategoryDataGridViewTextBoxColumn";
            // 
            // itemquantityDataGridViewTextBoxColumn
            // 
            this.itemquantityDataGridViewTextBoxColumn.DataPropertyName = "item_quantity";
            this.itemquantityDataGridViewTextBoxColumn.HeaderText = "Quantity on hand";
            this.itemquantityDataGridViewTextBoxColumn.Name = "itemquantityDataGridViewTextBoxColumn";
            // 
            // itemcostDataGridViewTextBoxColumn
            // 
            this.itemcostDataGridViewTextBoxColumn.DataPropertyName = "item_cost";
            this.itemcostDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.itemcostDataGridViewTextBoxColumn.Name = "itemcostDataGridViewTextBoxColumn";
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "Retail Price";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            // 
            // itemdiffDataGridViewTextBoxColumn
            // 
            this.itemdiffDataGridViewTextBoxColumn.DataPropertyName = "item_diff";
            this.itemdiffDataGridViewTextBoxColumn.HeaderText = "Markup Amount";
            this.itemdiffDataGridViewTextBoxColumn.Name = "itemdiffDataGridViewTextBoxColumn";
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "inventory";
            this.inventoryBindingSource1.DataSource = this.testdataDataSet3;
            // 
            // testdataDataSet3
            // 
            this.testdataDataSet3.DataSetName = "testdataDataSet3";
            this.testdataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // inventoryTableAdapter1
            // 
            this.inventoryTableAdapter1.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1198, 129);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(1108, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(144, 16);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Administrative Controls";
            this.linkLabel2.Visible = false;
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(1163, 39);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(89, 16);
            this.linkLabel3.TabIndex = 8;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "User Controls";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(1134, 69);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(118, 16);
            this.linkLabel4.TabIndex = 9;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Add Inventory Item";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.Location = new System.Drawing.Point(1136, 99);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(116, 16);
            this.linkLabel5.TabIndex = 10;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Edit Inventory Item";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdataDataSet1BindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.BindingSource testdataDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource testdataDataSetBindingSource;
        private testdataDataSet3 testdataDataSet3;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private testdataDataSet3TableAdapters.inventoryTableAdapter inventoryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemskuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdiffDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
    }
}