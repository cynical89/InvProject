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
        //Public Search by description Function reference
        public static Func<string, DataTable> Search = Info;
        //Public Search by sky function reference
        public static Func<int, DataTable> SkuLookup = SkuInfo;
        //Public Update function reference
        public static Action<int, string, string, int, float, float, float> Update = UpdateInfo;
        //Public Add to db function reference
        public static Action<string, string, int, float, float, float> AddNew = AddInfo;
        //Place holder to query SQL
        static string queryText;
        //This is the info to connect to the SQL server remotely
        protected static SqlConnection myCon = new SqlConnection(@"Data Source=datasourceiphere;Initial Catalog=testdata;User ID=userhere;Password=passhere");

        //This function returns whether or not the user name and password combination are correct or not.
        static string UserLogin(string _user, string _pass)
        {
            //this is the query string to allow us to check the user and password against the database
            queryText = @"SELECT Count(*) FROM [testdata].[dbo].[login] 
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

        //This searches our item_desc database for a string in the item's description and returns all rows will the string.
        static DataTable Info(string s)
        {
            //query string for our data we want to return
            queryText = "SELECT * FROM inventory WHERE (item_desc LIKE '%"+s+"%')";
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

        //This searches our item_desc database for a string in the item's description and returns all rows will the string.
        static void AddInfo(string s, string c, int i, float x, float y, float z)
        {
            //query string for our data we want to return
            queryText = "INSERT INTO inventory (item_desc,item_category,item_quantity,item_cost,item_price,item_diff) VALUES (@val1, @val2, @val3, @val4, @val5, @val6)";
            
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
            queryText = "SELECT * FROM inventory WHERE (item_sku LIKE '%" + sku + "%')";
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

        static void UpdateInfo(int s, string d, string c, int i, float x, float y, float z)
        {

            //query string for our data we want to return
            queryText = "UPDATE inventory SET item_desc = @val1, item_category = @val2, item_quantity = @val3, item_cost = @val4, item_price = @val5, item_diff = @val6 WHERE item_sku = @val7";
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
    }
}
