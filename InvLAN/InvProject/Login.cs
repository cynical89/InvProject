using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace InvProject
{
    public partial class Login : Form
    {
        string _user;
        protected string _pass;
        string returnedInfo;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _user = textBox1.Text;
            _pass = textBox2.Text;

            Form warning = new loginWarn();

            returnedInfo = database.Login(_user, _pass);

            if(Convert.ToInt32(returnedInfo) > 0)
            {
                DialogResult = DialogResult.OK;
    
            }
            else
            {
                textBox2.Text = String.Empty;
                this.Enabled = false;
                DialogResult result;
                using (var warn = new loginWarn())
                    result = warn.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Enabled = true;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
