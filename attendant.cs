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


namespace ShopRite_System
{
    public partial class attendant : Form
    {
        public attendant()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junior\Documents\shoprite.mdf;Integrated Security=True;Connect Timeout=30");
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                string query = $"insert into attendantd values ( '{aid.Text}', '{aname.Text}', '{aage.Text}', '{aphone.Text}', '{apass.Text}')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendant Added");
                Con.Close();
                populate();
                aid.Text = ""; aname.Text = ""; aage.Text = ""; aphone.Text = ""; apass.Text = "";
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
                if (aid.Text == "" || aname.Text == "" || aage.Text == "" || aphone.Text == "" || apass.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update attendantd set NAME='" + aname.Text + "', AGE=" + aage.Text + ", PHONE=" + aphone.Text + ", PASSWORD=" + apass.Text + " where ID=" + aid.Text + ""; 
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendant Updated");
                    Con.Close();
                    populate();
                }
                aid.Text = ""; aname.Text = ""; aage.Text = ""; aphone.Text = ""; apass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (aid.Text == "")
                {
                    MessageBox.Show("Select The Attendant to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from attendantd where ID=" + aid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendant Deleted");
                    Con.Close();
                    populate();
                }
                aid.Text = ""; aname.Text = ""; aage.Text = ""; aphone.Text = ""; apass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from attendantd";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            attDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void attendant_Load(object sender, EventArgs e)
        {
           populate();
        }

        private void attDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;

            aid.Text = attDGV.Rows[rowIndex].Cells[0].Value.ToString();
            aname.Text = attDGV.Rows[rowIndex].Cells[1].Value.ToString();
            aage.Text = attDGV.Rows[rowIndex].Cells[2].Value.ToString();
            aphone.Text = attDGV.Rows[rowIndex].Cells[3].Value.ToString();
            apass.Text = attDGV.Rows[rowIndex].Cells[4].Value.ToString();
        }
    }
    }

