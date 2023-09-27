using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string fav;
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=conapp; Integrated Security=true");

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//save button
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update cp set name='" + textBox1.Text + "', phone=" + textBox2.Text + ", alphone=" + textBox3.Text + ", statuslevel='" + comboBox1.Text + "', relationship='" + textBox4.Text + "', address='" + richTextBox1.Text + "', favourite='" + fav + "' where id=" + textBox5.Text + "", con);
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

        private void Form3_Load(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)//delete button
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete cp where id=" + textBox5.Text + "", con);
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " record deleted");

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("invalid data");
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
