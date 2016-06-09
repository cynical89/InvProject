using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvProject
{
    public partial class invEdit : Form
    {
        MainView _owner;

        public invEdit(MainView owner)
        {
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.invEdit_FormClosing);
            InitializeComponent();
        }

        private void invEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.PerformRefresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = database.SkuLookup(int.Parse(textBox1.Text));
            foreach (DataRow row in dt.Rows)
            {
                textBox2.Text = row["item_desc"].ToString();
                textBox3.Text = row["item_category"].ToString();
                textBox4.Text = row["item_quantity"].ToString();
                textBox5.Text = row["item_cost"].ToString();
                textBox6.Text = row["item_price"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float diff = (float.Parse(textBox6.Text) - float.Parse(textBox5.Text));
            database.Update(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), float.Parse(textBox5.Text), float.Parse(textBox6.Text), diff);
            this.Close();
        }
    }
}
