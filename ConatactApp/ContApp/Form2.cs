using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string fav; 
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=conapp; Integrated Security=true");
        private void button1_Click(object sender, EventArgs e)//save button
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into cp(name, phone, alphone, statuslevel, relationship, address, favourite) values('" + textBox1.Text + "'," + textBox2.Text + "," + textBox3.Text + ",'" + comboBox1.Text + "','" + textBox4.Text + "','" + richTextBox1.Text + "','" + fav + "')", con);
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " record saved");

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fav = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fav = radioButton2.Text;
        }
    }
}
