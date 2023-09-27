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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContApp
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=conapp; Integrated Security=true");

        private void Form7_Load(object sender, EventArgs e)//on load
        {
            try
            {
                richTextBox2.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from cp", con);
                SqlDataReader com = cmd.ExecuteReader();
                while (com.Read())
                {
                    richTextBox2.Text = richTextBox2.Text + "ID : " + com.GetValue(0) + "\nName : " + com.GetValue(1) + "\nPhobe Number : " + com.GetValue(2) + "\nAlternate Number : " + com.GetValue(3) + "\nStatus Level :  " + com.GetValue(4) + "\nRelationship : " + com.GetValue(5) + "\nAddress : " + com.GetValue(6) + "\nFavourite : " + com.GetValue(7) + "\n-----------------------------------------------\n";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
