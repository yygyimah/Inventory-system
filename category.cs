using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopRite_System
{
    public partial class category : Form
    {
        public category() 
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junior\Documents\shoprite.mdf;Integrated Security=True;Connect Timeout=30");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                //string query = "insert into CategoryTb1 values (" + catid.Text + ",'" + catname.Text + "','" + catdesc.Text + "')";
                string query = $"insert into categoryd values ( '{catidt.Text}', '{catnamet.Text}', '{catdesct.Text}')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added");
                Con.Close();
                populate();
                catidt.Text = ""; catnamet.Text = ""; catdesct.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from categoryd";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            catDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void category_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void catDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
         
            catidt.Text = catDGV.Rows[rowIndex].Cells[0].Value.ToString();
            catnamet.Text = catDGV.Rows[rowIndex].Cells[1].Value.ToString();
            catdesct.Text = catDGV.Rows[rowIndex].Cells[2].Value.ToString();
            
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (catidt.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from categoryd where ID=" + catidt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted");
                    Con.Close();
                    populate();
                }
                catidt.Text = ""; catnamet.Text = ""; catdesct.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (catidt.Text == "" || catnamet.Text == "" || catdesct.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update categoryd set NAME='" + catnamet.Text + "', DESCRIPTION='" + catdesct.Text + "' where ID=" + catidt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated");
                    Con.Close();
                    populate();
                }
                catidt.Text = ""; catnamet.Text = ""; catdesct.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }
    }
}
