using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace ShopRite_System
{
    public partial class Form1 : Form
    {
        //int attempt = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public static string NAME = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junior\Documents\shoprite.mdf;Integrated Security=True;Connect Timeout=30");
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Uname.Text == "" || Pass.Text == "")
            {
                MessageBox.Show("Please Enter the Username and Password");
            }
            else
            {
                if (Role.SelectedIndex > -1)
                {
                    if (Role.SelectedItem.ToString() == "Admin")
                    {
                        if (Uname.Text == "Admin" && Pass.Text == "Admin")
                        {
                           Form2 pd = new Form2();
                            pd.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are Admin, Enter the Correct Username and Password");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("You are in the Seller Section");
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select count(*) from attendantd where NAME='" + Uname.Text + "' and PASSWORD='" + Pass.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            NAME = Uname.Text;
                            sales sell = new sales();
                            sell.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username and Password");
                        }
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select the Role to Login");
                }
            }
        }
        
            

        private void button1_Click(object sender, EventArgs e)
        {
            Uname.Text = "";
            Pass.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Pass.UseSystemPasswordChar = false;
            }
            else
            {
                Pass.UseSystemPasswordChar = true;
            }    
        }
    }
}
         
        
        
