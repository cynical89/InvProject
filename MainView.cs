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

        public static string _user;

        private void MainView_Load(object sender, EventArgs e)
        {
            this.inventoryTableAdapter1.Fill(this.testdataDataSet3.inventory);
            //hiding buttons. Do not need at this current time. TODO: remove buttons all together.
            button2.Visible = false;
            button3.Visible = false;

            string cred = String.Empty;
            DataTable dt = new DataTable();
            dt = database.UserCredential(_user);
            foreach(DataRow row in dt.Rows)
            {
                cred = row["level"].ToString();
            }
            int level = Convert.ToInt32(cred);
            dt.Clear();
            if (level >= 80)
            {
                linkLabel2.Visible = true;
            }
            if(level <= 50)
            {
                linkLabel4.Enabled = false;
                linkLabel5.Enabled = false;
            }
            
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
            this.inventoryTableAdapter1.Fill(this.testdataDataSet3.inventory);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form add = new invAdd(this);
            add.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form edit = new invEdit(this);
            edit.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form adm = new admin();
            adm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form user = new usercontrol();
            user.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

    }
}
