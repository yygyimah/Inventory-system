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
using System.Drawing.Printing;
using System.Xml.Linq;


namespace ShopRite_System
{
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junior\Documents\shoprite.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select NAME,PRICE from productd";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populatebills()
        {
            Con.Open();
            string query = "select * from billsd";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            billsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            FillCategory();
            lattend.Text = Form1.NAME;
            ldate.Text = DateTime.Now.ToShortDateString();
        }
        //int flag = 0;
        private void prodDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            pnamet.Text = prodDGV1.Rows[rowIndex].Cells[0].Value.ToString();
            ppricet.Text = prodDGV1.Rows[rowIndex].Cells[1].Value.ToString();
        }
        private void FillCategory()
        {
            //This Method will bind the Combobox with the Database
            /*Con.Open();
            SqlCommand cmd = new SqlCommand("select NAME from categoryd", Con);
            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                catcb.Items.Add(rdr.GetString(0));
            }

            /*DataTable dt = new DataTable();
            dt.Columns.Add("NAME", typeof(string));
            dt.Load(rdr);
            catcb.ValueMember = "NAME";
            catcb.DataSource = dt;
            *
            rdr.Close();
            Con.Close();*/


            Con.Open();
            SqlCommand cmd = new SqlCommand("Select NAME from categoryd", Con);
            SqlDataReader rdr = cmd.ExecuteReader();

        
            DataTable dt = new DataTable();
            dt.Columns.Add("NAME", typeof(string));
            dt.Load(rdr);

            catcb.ValueMember = "NAME";
            catcb.DisplayMember = "NAME";
            catcb.DataSource = dt;
          
            Con.Close();
        }

        int grdtotal = 0, n = 0;

        private void addpl_Click(object sender, EventArgs e)
        {
            if (pnamet.Text == "" || pqtyt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int total = Convert.ToInt32(ppricet.Text) * Convert.ToInt32(pqtyt.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(orderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = pnamet.Text;
                newRow.Cells[2].Value = pqtyt.Text;
                newRow.Cells[3].Value = ppricet.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ppricet.Text) * Convert.ToInt32(pqtyt.Text);
                orderDGV.Rows.Add(newRow);
                n++;
                grdtotal = grdtotal + total;
                ttl.Text = "$" + grdtotal;
            }
        }

        private void printb_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("pprnm", 285, 600);
                printDocument1.Print();
            }
        }

        private void billsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //flag = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            e.Graphics.DrawString("Order Details", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Firebrick, new Point(230));
            e.Graphics.DrawString("ID:" + billsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80,100));
            e.Graphics.DrawString("Attendant:" + billsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 133));
            e.Graphics.DrawString("Date:" + billsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("Total $:" + billsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 199));
            e.Graphics.DrawString("SHOP RITE GHANA LTD", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Firebrick, new Point(230,250));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void catcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select NAME,QUANTITY from productd where CATEGORY='" + catcb.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void billsDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
            {
                printDocument2.DefaultPageSettings.PaperSize = new PaperSize("pprnm", 285, 600);
                printDocument2.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)

        {
         
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            e.Graphics.DrawString("Oder Details", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Firebrick, new Point(230));
            e.Graphics.DrawString("ID:" + orderDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 100));
            e.Graphics.DrawString("Name:" + orderDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 133));
            e.Graphics.DrawString("Quantity:" + orderDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("Price:" + orderDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 199));
            e.Graphics.DrawString("Total $:" + orderDGV.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 232));
            e.Graphics.DrawString("SHOP RITE GHANA LTD", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Firebrick, new Point(230, 350));




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pidt.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into billsd values(" + pidt.Text + ",'" + lattend.Text + "','" + ldate.Text + "'," + ttl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added");
                    Con.Close();
                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

                      //private void addpl_Click(object sender, EventArgs e)
        
               
                
        }
        
        }
    } 
