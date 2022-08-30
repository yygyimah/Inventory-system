namespace ShopRite_System
{
    partial class sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.catcb = new System.Windows.Forms.ComboBox();
            this.ppricet = new System.Windows.Forms.TextBox();
            this.pqtyt = new System.Windows.Forms.TextBox();
            this.pnamet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pidt = new System.Windows.Forms.TextBox();
            this.billsDGV = new System.Windows.Forms.DataGridView();
            this.prodDGV1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.addpl = new System.Windows.Forms.Button();
            this.ldate = new System.Windows.Forms.Label();
            this.totallb = new System.Windows.Forms.Label();
            this.ttl = new System.Windows.Forms.Label();
            this.lattend = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 55);
            this.panel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(716, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "x";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "SHOPRITE MANAGEMENT SYSTEM";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Firebrick;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(583, 475);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 44;
            this.button5.Text = "LOGOUT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(205, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 43;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // orderDGV
            // 
            this.orderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDGV.BackgroundColor = System.Drawing.Color.White;
            this.orderDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.orderDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.pname,
            this.pqty,
            this.pprice,
            this.total});
            this.orderDGV.Location = new System.Drawing.Point(354, 106);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.ReadOnly = true;
            this.orderDGV.RowTemplate.Height = 25;
            this.orderDGV.Size = new System.Drawing.Size(374, 117);
            this.orderDGV.TabIndex = 42;
            // 
            // pid
            // 
            this.pid.HeaderText = "ID";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            // 
            // pname
            // 
            this.pname.HeaderText = "NAME";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            // 
            // pqty
            // 
            this.pqty.HeaderText = "QUANTITY";
            this.pqty.Name = "pqty";
            this.pqty.ReadOnly = true;
            // 
            // pprice
            // 
            this.pprice.HeaderText = "PRICE";
            this.pprice.Name = "pprice";
            this.pprice.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // printb
            // 
            this.printb.AutoSize = true;
            this.printb.BackColor = System.Drawing.Color.Firebrick;
            this.printb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printb.ForeColor = System.Drawing.Color.White;
            this.printb.Location = new System.Drawing.Point(502, 475);
            this.printb.Name = "printb";
            this.printb.Size = new System.Drawing.Size(75, 27);
            this.printb.TabIndex = 40;
            this.printb.Text = "PRINT";
            this.printb.UseVisualStyleBackColor = false;
            this.printb.Click += new System.EventHandler(this.printb_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(421, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 39;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // catcb
            // 
            this.catcb.BackColor = System.Drawing.SystemColors.Window;
            this.catcb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catcb.ForeColor = System.Drawing.Color.Firebrick;
            this.catcb.FormattingEnabled = true;
            this.catcb.Location = new System.Drawing.Point(12, 300);
            this.catcb.Name = "catcb";
            this.catcb.Size = new System.Drawing.Size(187, 25);
            this.catcb.TabIndex = 38;
            this.catcb.Text = "Select Category";
            this.catcb.SelectionChangeCommitted += new System.EventHandler(this.catcb_SelectionChangeCommitted);
            // 
            // ppricet
            // 
            this.ppricet.Enabled = false;
            this.ppricet.Location = new System.Drawing.Point(129, 195);
            this.ppricet.Name = "ppricet";
            this.ppricet.Size = new System.Drawing.Size(151, 23);
            this.ppricet.TabIndex = 37;
            // 
            // pqtyt
            // 
            this.pqtyt.Location = new System.Drawing.Point(129, 149);
            this.pqtyt.Name = "pqtyt";
            this.pqtyt.Size = new System.Drawing.Size(151, 23);
            this.pqtyt.TabIndex = 36;
            // 
            // pnamet
            // 
            this.pnamet.Enabled = false;
            this.pnamet.Location = new System.Drawing.Point(129, 106);
            this.pnamet.Name = "pnamet";
            this.pnamet.Size = new System.Drawing.Size(151, 23);
            this.pnamet.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "PRICE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "QUANTITY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(523, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID";
            // 
            // pidt
            // 
            this.pidt.Location = new System.Drawing.Point(579, 293);
            this.pidt.Name = "pidt";
            this.pidt.Size = new System.Drawing.Size(151, 23);
            this.pidt.TabIndex = 29;
            // 
            // billsDGV
            // 
            this.billsDGV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.billsDGV.AllowUserToAddRows = false;
            this.billsDGV.AllowUserToDeleteRows = false;
            this.billsDGV.AllowUserToResizeColumns = false;
            this.billsDGV.AllowUserToResizeRows = false;
            this.billsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billsDGV.BackgroundColor = System.Drawing.Color.White;
            this.billsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsDGV.Location = new System.Drawing.Point(356, 327);
            this.billsDGV.Name = "billsDGV";
            this.billsDGV.ReadOnly = true;
            this.billsDGV.RowTemplate.Height = 25;
            this.billsDGV.Size = new System.Drawing.Size(374, 129);
            this.billsDGV.TabIndex = 46;
            this.billsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billsDGV_CellContentClick);
            this.billsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billsDGV_CellContentClick_1);
            // 
            // prodDGV1
            // 
            this.prodDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodDGV1.BackgroundColor = System.Drawing.Color.White;
            this.prodDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDGV1.Location = new System.Drawing.Point(12, 338);
            this.prodDGV1.Name = "prodDGV1";
            this.prodDGV1.ReadOnly = true;
            this.prodDGV1.RowHeadersVisible = false;
            this.prodDGV1.RowTemplate.Height = 25;
            this.prodDGV1.Size = new System.Drawing.Size(268, 152);
            this.prodDGV1.TabIndex = 47;
            this.prodDGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDGV1_CellContentClick);
            this.prodDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDGV1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(296, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "SALES";
            // 
            // addpl
            // 
            this.addpl.AutoSize = true;
            this.addpl.BackColor = System.Drawing.Color.Firebrick;
            this.addpl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addpl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addpl.ForeColor = System.Drawing.Color.White;
            this.addpl.Location = new System.Drawing.Point(178, 235);
            this.addpl.Name = "addpl";
            this.addpl.Size = new System.Drawing.Size(102, 27);
            this.addpl.TabIndex = 49;
            this.addpl.Text = "ADD PRODUCT";
            this.addpl.UseVisualStyleBackColor = false;
            this.addpl.Click += new System.EventHandler(this.addpl_Click);
            // 
            // ldate
            // 
            this.ldate.AutoSize = true;
            this.ldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ldate.ForeColor = System.Drawing.Color.Firebrick;
            this.ldate.Location = new System.Drawing.Point(647, 70);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(48, 16);
            this.ldate.TabIndex = 54;
            this.ldate.Text = "DATE";
            // 
            // totallb
            // 
            this.totallb.AutoSize = true;
            this.totallb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totallb.ForeColor = System.Drawing.Color.Firebrick;
            this.totallb.Location = new System.Drawing.Point(486, 235);
            this.totallb.Name = "totallb";
            this.totallb.Size = new System.Drawing.Size(64, 20);
            this.totallb.TabIndex = 56;
            this.totallb.Text = "TOTAL";
            // 
            // ttl
            // 
            this.ttl.AutoSize = true;
            this.ttl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ttl.ForeColor = System.Drawing.Color.Firebrick;
            this.ttl.Location = new System.Drawing.Point(550, 235);
            this.ttl.Name = "ttl";
            this.ttl.Size = new System.Drawing.Size(19, 20);
            this.ttl.TabIndex = 57;
            this.ttl.Text = "$";
            // 
            // lattend
            // 
            this.lattend.AutoSize = true;
            this.lattend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lattend.ForeColor = System.Drawing.Color.Firebrick;
            this.lattend.Location = new System.Drawing.Point(12, 68);
            this.lattend.Name = "lattend";
            this.lattend.Size = new System.Drawing.Size(100, 16);
            this.lattend.TabIndex = 58;
            this.lattend.Text = "ATTENDANT";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(356, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "ATTENDANT LIST";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(653, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 60;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lattend);
            this.Controls.Add(this.ttl);
            this.Controls.Add(this.totallb);
            this.Controls.Add(this.ldate);
            this.Controls.Add(this.addpl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prodDGV1);
            this.Controls.Add(this.billsDGV);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.orderDGV);
            this.Controls.Add(this.printb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.catcb);
            this.Controls.Add(this.ppricet);
            this.Controls.Add(this.pqtyt);
            this.Controls.Add(this.pnamet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pidt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label1;
        private Button button5;
        private Button button4;
        private DataGridView orderDGV;
        private Button printb;
        private Button button2;
        private ComboBox catcb;
        private TextBox ppricet;
        private TextBox pqtyt;
        private TextBox pnamet;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox pidt;
        private DataGridView billsDGV;
        private DataGridView prodDGV1;
        private Label label7;
        private Button addpl;
        private DataGridViewTextBoxColumn pid;
        private DataGridViewTextBoxColumn pname;
        private DataGridViewTextBoxColumn pqty;
        private DataGridViewTextBoxColumn pprice;
        private DataGridViewTextBoxColumn total;
        private Label ldate;
        private Label totallb;
        private Label ttl;
        private Label lattend;
        private Button addpl_click;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label2;
        private Button button1;
    }
}