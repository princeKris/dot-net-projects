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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=conapp; Integrated Security=true");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)//on load
        {
            try
            {
                richTextBox1.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from cp where favourite='Yes'", con);
                SqlDataReader com = cmd.ExecuteReader();
                while (com.Read())
                {
                    richTextBox1.Text = richTextBox1.Text + "ID : " + com.GetValue(0) + "\nName : " + com.GetValue(1) + "\nPhobe Number : " + com.GetValue(2) + "\nAlternate Number : " + com.GetValue(3) + "\nStatus Level :  " + com.GetValue(4) + "\nRelationship : " + com.GetValue(5) + "\nAddress : " + com.GetValue(6) + "\nFavourite : " + com.GetValue(7) + "\n-----------------------------------------------\n";
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
    }
}
