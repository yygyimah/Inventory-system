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
using System.Text.RegularExpressions;

namespace ShopRite_System
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junior\Documents\shoprite.mdf;Integrated Security=True;Connect Timeout=30");
        private void prodDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;

            pidt.Text = prodDGV.Rows[rowIndex].Cells[0].Value.ToString();
            pnamet.Text = prodDGV.Rows[rowIndex].Cells[1].Value.ToString();
            pqtyt.Text = prodDGV.Rows[rowIndex].Cells[2].Value.ToString();
            ppricet.Text = prodDGV.Rows[rowIndex].Cells[3].Value.ToString();
            catcb.Text = prodDGV.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select NAME from categoryd", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NAME", typeof(string));
            dt.Load(rdr);
            catcb.ValueMember = "NAME";
            catcb.DataSource = dt;
            scb.ValueMember = "NAME";
            scb.DataSource = dt;
            Con.Close();
        }

        private void product_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                //string query = "insert into CategoryTb1 values (" + catid.Text + ",'" + catname.Text + "','" + catdesc.Text + "')";
                string query = $"insert into productd values ( '{pidt.Text}', '{pnamet.Text}', '{pqtyt.Text}', '{ppricet.Text}', '{catcb.SelectedValue.ToString()}')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added");
                Con.Close();
                populate();
                pidt.Text = ""; pnamet.Text = ""; pqtyt.Text = ""; ppricet.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from productd";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (pidt.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from productd where ID=" + pidt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted");
                    Con.Close();
                    populate();
                }
                pidt.Text = ""; pnamet.Text = ""; ppricet.Text = ""; pqtyt.Text = "";
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
                if (pidt.Text == "" || pnamet.Text == "" || pqtyt.Text == "" || ppricet.Text == "" || catcb.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update productd set NAME='" + pnamet.Text + "', QUANTITY=" + pqtyt.Text + ", PRICE =" + ppricet.Text + ", CATEGORY= '" + catcb.SelectedValue.ToString() + "' where ID=" + pidt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated");
                    Con.Close();
                    populate();
                }
                pidt.Text = ""; pnamet.Text = ""; pqtyt.Text = ""; ppricet.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void scb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from productd where CATEGORY='" + scb.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
