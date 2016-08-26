using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;

namespace InvProject
{
    //This class holds all of the sql database functions for the program.
    class database
    {
        //Public Login Function reference
        public static Func<string, string, String> Login = UserLogin;
        //checks the users level for access to admin features.
        public static Func<string, DataTable> UserCredential = UserPrivledge;
        //returns users for admin controls
        public static Func<DataTable> Users = UserInfoAdmin;
        //Public Search by description Function reference
        public static Func<string, DataTable> Search = Info;
        //Public Search by sku function reference
        public static Func<int, DataTable> SkuLookup = SkuInfo;
        //Public display email function reference
        public static Func<string, DataTable> UserEmail = DisplayUserEmail;
        //Public Update function reference
        public static Action<int, string, string, int, float, float, float> Update = UpdateInfo;
        //Public Add to db function reference
        public static Action<string, string, int, float, float, float> AddNew = AddInfo;
        //Public Reset password function reference
        public static Action<string> ResetPassword = ResetPasswordAdmin;
        // Public delete user function reference
        public static Action<string> DeleteUser = DeleteUserAdmin;
        //Update info from admin control public function reference
        public static Action<string, string, int> EditUserInfo = UpdateUserAdmin;
        //Add user from admin public function reference
        public static Action<string, string, string, int> AddUser = AddUserAdmin;
        //;Edit email public function reference
        public static Action<string, string> EditEmail = UpdateUserEmail;
        //edit pass public function reference
        public static Action<string, string> EditPass = UpdateUserPass;
        //Place holder to query SQL
        static string queryText;
        //This is the info to connect to the SQL server remotely
        readonly static SqlConnection myCon = new SqlConnection("Data Source = ipaddress; Initial Catalog = testdata; User ID = user; Password=password");
        //default password for users
        readonly static string _defaultPass = "default123";

        //This function returns whether or not the user name and password combination are correct or not.
        static string UserLogin(string _user, string _pass)
        {
            //this is the query string to allow us to check the user and password against the database
            queryText = @"SELECT Count(*) FROM login
                             WHERE user_name = @Username AND user_password = @Password";
            //Open the SQL connection check for the user and pass, returns an int to string and is handled in the Login form.
            using (SqlCommand cmd = new SqlCommand(queryText, myCon))
            {
                //Open the connection to SQL server.
                myCon.Open();
                //Add the parameters for the Scalar to check against
                cmd.Parameters.AddWithValue("@Username", _user);
                cmd.Parameters.AddWithValue("@Password", _pass);
                //Is the username/pass combo correct?
                int result = (int)cmd.ExecuteScalar();
                //Close the connection to SQL server.
                    myCon.Close();
                //Returns our value to a string
                    return result.ToString();
            }
        }
        //This will take the username from the login query and return the level of the user to allow display of controls or not
        static DataTable UserPrivledge(string _user)
        {
            //this is the query string to allow us to check the user against the database
            queryText = @"SELECT level FROM login
                             WHERE (user_name LIKE '%" + _user + "%')";
            //Open the connection to SQL server.
            myCon.Open();
            //Declare our Data Table to return to the user
            DataTable dt = new DataTable();
            //declare the SQL data adapter to adapt data from SQL to the Data Table.
            SqlDataAdapter sda = new SqlDataAdapter(queryText, myCon);
            //Fill our DataTable with the SQL info
            sda.Fill(dt);
            //Close the connection to SQL server
            myCon.Close();
            //return the table to the user to be displayed.
            return dt;
        }
        //This searches all users
        static DataTable Info(string s)
        {
            //query string for our data we want to return
            queryText = "SELECT * FROM dbo.inventory WHERE (item_desc LIKE '%"+s+"%')";
            //Open the connection to SQL server.
                myCon.Open();
            //Declare our Data Table to return to the user
                DataTable dt = new DataTable();
            //declare the SQL data adapter to adapt data from SQL to the Data Table.
                SqlDataAdapter sda = new SqlDataAdapter(queryText, myCon);
            //Fill our DataTable with the SQL info
                sda.Fill(dt);
            //Close the connection to SQL server
                myCon.Close();
            //return the table to the user to be displayed.
                return dt;
        }
        //This adds new items to the database
        static void AddInfo(string s, string c, int i, float x, float y, float z)
        {
            //query string for our data we want to return
            queryText = "INSERT INTO dbo.inventory (item_desc,item_category,item_quantity,item_cost,item_price,item_diff) VALUES (@val1, @val2, @val3, @val4, @val5, @val6)";

            using(SqlCommand cmd = new SqlCommand(queryText, myCon))
            {
                cmd.Parameters.AddWithValue("@val1", s);
                cmd.Parameters.AddWithValue("@val2", c);
                cmd.Parameters.AddWithValue("@val3", i);
                cmd.Parameters.AddWithValue("@val4", x);
                cmd.Parameters.AddWithValue("@val5", y);
                cmd.Parameters.AddWithValue("@val6", z);

                try
                {
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    myCon.Close();
                }
            }
        }
        //This searches our item_desc database for a number in the item sku and returns all rows will the string.
        static DataTable SkuInfo(int sku)
        {
            //query string for our data we want to return
            queryText = "SELECT * FROM dbo.inventory WHERE (item_sku LIKE '%" + sku + "%')";
            //Open the connection to SQL server.
            myCon.Open();
            //Declare our Data Table to return to the user
            DataTable dt = new DataTable();
            //declare the SQL data adapter to adapt data from SQL to the Data Table.
            SqlDataAdapter sda = new SqlDataAdapter(queryText, myCon);
            //Fill our DataTable with the SQL info
            sda.Fill(dt);
            //Close the connection to SQL server
            myCon.Close();
            //return the table to the user to be displayed.
            return dt;
        }
        //This updates the info after the info has been edited by the user
        static void UpdateInfo(int s, string d, string c, int i, float x, float y, float z)
        {

            //query string for our data we want to update
            queryText = "UPDATE dbo.inventory SET item_desc = @val1, item_category = @val2, item_quantity = @val3, item_cost = @val4, item_price = @val5, item_diff = @val6 WHERE item_sku = @val7";
            using(SqlCommand cmd = new SqlCommand(queryText, myCon))
            {
                cmd.Parameters.AddWithValue("@val1", d);
                cmd.Parameters.AddWithValue("@val2", c);
                cmd.Parameters.AddWithValue("@val3", i);
                cmd.Parameters.AddWithValue("@val4", x);
                cmd.Parameters.AddWithValue("@val5", y);
                cmd.Parameters.AddWithValue("@val6", z);
                cmd.Parameters.AddWithValue("@val7", s);

                try
                {
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    myCon.Close();
                }
            }
        }
        //returns users for admin controls
        static DataTable UserInfoAdmin()
        {
            //query string for our data we want to return
            queryText = "SELECT * FROM login";
            //Open the connection to SQL server.
            myCon.Open();
            //Declare our Data Table to return to the user
            DataTable dt = new DataTable();
            //declare the SQL data adapter to adapt data from SQL to the Data Table.
            SqlDataAdapter sda = new SqlDataAdapter(queryText, myCon);
            //Fill our DataTable with the SQL info
            sda.Fill(dt);
            //Close the connection to SQL server
            myCon.Close();
            //return the table to the user to be displayed.
            return dt;
        }
        //This updates the password to a default
        static void ResetPasswordAdmin(string s)
        {

            //query string for our data we want to update
            queryText = "UPDATE login SET user_password = @val2 WHERE user_name = @val1";
            using (SqlCommand cmd = new SqlCommand(queryText, myCon))
            {
                cmd.Parameters.AddWithValue("@val1", s);
                cmd.Parameters.AddWithValue("@val2", _defaultPass);

                try
                {
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    myCon.Close();
                    MessageBox.Show("Password reset to '" + _defaultPass + "'!");
                }
            }
        }
        //This updates the password to a default
        static void DeleteUserAdmin(string s)
        {

            //query string for our data we want to update
            queryText = "DELETE FROM login WHERE user_name = @val1";
            using (SqlCommand cmd = new SqlCommand(queryText, myCon))
            {
                cmd.Parameters.AddWithValue("@val1", s);

                try
                {
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    myCon.Close();
                    MessageBox.Show("User Removed!");
                }
            }
        }
        //This updates the info after the info has been edited by the user
        static void UpdateUserAdmin(string s, string a, int b)
        {

            //query string for our data we want to update
            queryText = "UPDATE login SET user_email = @val1, level = @val2 WHERE user_name = @val3";
            using (SqlCommand cmd = new SqlCommand(queryText, myCon))
            {
                cmd.Parameters.AddWithValue("@val1", a);
                cmd.Parameters.AddWithValue("@val2", b);
                cmd.Parameters.AddWithValue("@val3", s);

                try
                {
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    myCon.Close();
                }
            }
        }
        //This adds new items to the database
        static void AddUserAdmin(string s, string c, string i, int x)
        {
            //query string for our data we want to return
            queryText = "INSERT INTO login (user_name,user_password,user_email,level) VALUES (@val1, @val2, @val3, @val4)";

            using (SqlCommand cmd = new SqlCommand(queryText, myCon))
            {
                cmd.Parameters.AddWithValue("@val1", s);
                cmd.Parameters.AddWithValue("@val2", c);
                cmd.Parameters.AddWithValue("@val3", i);
                cmd.Parameters.AddWithValue("@val4", x);

                try
                {
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    myCon.Close();
                    MessageBox.Show("User Added Successfully!");
                }
            }
        }
        //This updates the user email after the info has been edited by the user
        static void UpdateUserEmail(string d, string c)
        {

            //query string for our data we want to update
            queryText = "UPDATE login SET user_email = @val1 WHERE user_name = @val2";
            using (SqlCommand cmd = new SqlCommand(queryText, myCon))
            {
                cmd.Parameters.AddWithValue("@val1", c);
                cmd.Parameters.AddWithValue("@val2", d);

                try
                {
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    myCon.Close();
                    MessageBox.Show("You changed your email!");
                }
            }
        }
        //This updates the user password after the info has been edited by the user
        static void UpdateUserPass(string d, string c)
        {

            //query string for our data we want to update
            queryText = "UPDATE login SET user_password = @val1 WHERE user_name = @val2";
            using (SqlCommand cmd = new SqlCommand(queryText, myCon))
            {
                cmd.Parameters.AddWithValue("@val1", c);
                cmd.Parameters.AddWithValue("@val2", d);

                try
                {
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    myCon.Close();
                    MessageBox.Show("You changed your password!");
                }
            }
        }
        //This displays user email address in user controls
        static DataTable DisplayUserEmail(string s)
        {
            //query string for our data we want to return
            queryText = @"SELECT user_email FROM login
                             WHERE (user_name LIKE '%" + s + "%')";
            //Open the connection to SQL server.
            myCon.Open();
            //Declare our Data Table to return to the user
            DataTable dt = new DataTable();
            //declare the SQL data adapter to adapt data from SQL to the Data Table.
            SqlDataAdapter sda = new SqlDataAdapter(queryText, myCon);
            //Fill our DataTable with the SQL info
            sda.Fill(dt);
            //Close the connection to SQL server
            myCon.Close();
            //return the table to the user to be displayed.
            return dt;
        }
    }
}
