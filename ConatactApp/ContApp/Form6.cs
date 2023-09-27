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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=conapp; Integrated Security=true");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)//on load
        {
            try
            {
                richTextBox2.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from cp", con);
                SqlDataReader com = cmd.ExecuteReader();
                while (com.Read())
                {
                    richTextBox2.Text = richTextBox2.Text + "ID : " + com.GetValue(0) + "   Name : " + com.GetValue(1) + "    Phobe Number : " + com.GetValue(2) + "\n----------------------------------------------------------------------------------\n";
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
