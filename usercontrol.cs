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
    public partial class usercontrol : Form
    {
        public usercontrol()
        {
            InitializeComponent();
        }

        private void usercontrol_Load(object sender, EventArgs e)
        {
            label1.Text = MainView._user + ", you can change your email and password here.";
            SetEmailData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeTrue();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            database.EditEmail(MainView._user, textBox1.Text);
            MakeFalse();
            SetEmailData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            s = database.Login(MainView._user, textBox2.Text);
            int i = Convert.ToInt32(s);
            if (i > 0)
            {
                database.EditPass(MainView._user, textBox3.Text);
            }
            else
            {
                MessageBox.Show("Your Old Password must match the password on your account!");
            }
            MakeFalse();
        }

        void MakeTrue()
        {
            label3.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button2.Visible = true;
        }

        void MakeFalse()
        {
            label3.Visible = false;
            label4.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button2.Visible = false;
            ClearText();
        }

        void ClearText()
        {
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        void SetEmailData()
        {
            DataTable dt = new DataTable();
            dt = database.UserEmail(MainView._user);
            textBox1.Text = dt.Rows[0]["user_email"].ToString();
        }
    }
}
