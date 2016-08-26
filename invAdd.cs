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
    public partial class invAdd : Form
    {
        MainView _owner;

        public invAdd(MainView owner)
        {
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.invAdd_FormClosing);
            InitializeComponent();
        }

        private void invAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.PerformRefresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //invItems addItem = new invItems(textBox1.Text, int.Parse(textBox2.Text), float.Parse(textBox3.Text), float.Parse(textBox4.Text));
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all data!");
                return;
            }

            float diff = (float.Parse(textBox4.Text) - float.Parse(textBox3.Text));
            database.AddNew(textBox1.Text, comboBox1.SelectedItem.ToString(), int.Parse(textBox2.Text), float.Parse(textBox3.Text), float.Parse(textBox4.Text), diff);
            this.Close();
        }
    }
}
