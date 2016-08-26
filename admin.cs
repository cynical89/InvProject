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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        int i = 0;
        bool isEditing = false;
        bool isAdding = false;

        private void admin_Load(object sender, EventArgs e)
        {
            SetCBData();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = comboBox1.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                isAdding = false;
                FieldReadOnly();
            }
            if (isEditing)
            {
                isEditing = false;
                button4.Visible = false;
                ClearText();
            }
            if (comboBox1.SelectedValue.ToString() == MainView._user)
            {
                MessageBox.Show("Cannot remove yourself. Please select a new user");
            }
            else if(comboBox1.SelectedValue.ToString() == "admin")
            {
                MessageBox.Show("Cannot remove the Administrator. Please select a new user");
            }
            else
            {
                string toDelete = dt.Rows[i]["user_name"].ToString();
                database.DeleteUser(toDelete);
                SetCBData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() == MainView._user)
            {
                MessageBox.Show("You can't make changes to your own account. Please visit 'User Controls' to make changes.");
            }
            else if (comboBox1.SelectedValue.ToString() == "admin")
            {
                MessageBox.Show("Cannot edit the Administrator. Please select a new user");
            }
            else
            {
                if (isAdding)
                {
                    isAdding = false;
                    FieldReadOnly();
                }
                isEditing = true;
                button4.Visible = true;
                button5.Visible = true;
                textBox1.Text = dt.Rows[i]["user_name"].ToString();
                textBox2.Text = dt.Rows[i]["user_password"].ToString();
                textBox3.Text = dt.Rows[i]["user_email"].ToString();
                textBox4.Text = dt.Rows[i]["level"].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            database.ResetPassword(dt.Rows[i]["user_name"].ToString());
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                database.EditUserInfo(textBox1.Text, textBox3.Text, int.Parse(textBox4.Text));
                isEditing = false;
                button4.Visible = false;
            }
            if(isAdding)
            {
                database.AddUser(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text));
                isAdding = false;
            }
            button5.Visible = false;
            ClearText();
            SetCBData();
            FieldReadOnly();
        }

        void ClearText()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
        }

        void SetCBData()
        {
            dt = database.Users();
            comboBox1.DisplayMember = "user_name";
            comboBox1.ValueMember = "user_name";
            comboBox1.DataSource = dt;
        }

        void FieldReadOnly()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                isEditing = false;
                button4.Visible = false;
                ClearText();
            }
            isAdding = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            button5.Visible = true;
        }
    }
}
