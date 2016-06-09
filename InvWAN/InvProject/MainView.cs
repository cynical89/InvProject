using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvProject
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testdataDataSet1.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter1.Fill(this.testdataDataSet1.inventory);
            // TODO: This line of code loads data into the 'testdataDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.testdataDataSet.inventory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = database.Search(textBox1.Text);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form edit = new invEdit(this);
            edit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form add = new invAdd(this);
            add.Show();  
        }

        public void PerformRefresh()
        {
            this.inventoryTableAdapter.Fill(this.testdataDataSet.inventory);
        }
    }
}
