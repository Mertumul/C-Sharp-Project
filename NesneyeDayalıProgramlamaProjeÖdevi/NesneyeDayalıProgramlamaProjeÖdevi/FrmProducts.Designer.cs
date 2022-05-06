
namespace NesneyeDayalıProgramlamaProjeÖdevi
{
    partial class FrmProducts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbproductgender = new System.Windows.Forms.ComboBox();
            this.cmbproductcatagory = new System.Windows.Forms.ComboBox();
            this.txtproductbrand = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtproductnumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtproductcolour = new System.Windows.Forms.TextBox();
            this.cmbproductsize = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblproductcode = new System.Windows.Forms.Label();
            this.txtproductcode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtproductprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProductWhere = new System.Windows.Forms.ComboBox();
            this.txtproductpurchase = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbproductgender);
            this.groupBox1.Controls.Add(this.cmbproductcatagory);
            this.groupBox1.Controls.Add(this.txtproductbrand);
            this.groupBox1.Controls.Add(this.txtproductname);
            this.groupBox1.Controls.Add(this.txtproductnumber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtproductcolour);
            this.groupBox1.Controls.Add(this.cmbproductsize);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lblproductcode);
            this.groupBox1.Controls.Add(this.txtproductcode);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtproductprice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbProductWhere);
            this.groupBox1.Controls.Add(this.txtproductpurchase);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(106, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 624);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ProductsEdit";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 28);
            this.button2.TabIndex = 79;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 28);
            this.button1.TabIndex = 78;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 23);
            this.label12.TabIndex = 76;
            this.label12.Text = "ProductNumber:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cmbproductgender
            // 
            this.cmbproductgender.FormattingEnabled = true;
            this.cmbproductgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbproductgender.Location = new System.Drawing.Point(239, 402);
            this.cmbproductgender.Name = "cmbproductgender";
            this.cmbproductgender.Size = new System.Drawing.Size(167, 31);
            this.cmbproductgender.TabIndex = 60;
            // 
            // cmbproductcatagory
            // 
            this.cmbproductcatagory.FormattingEnabled = true;
            this.cmbproductcatagory.Items.AddRange(new object[] {
            "T-Shirt",
            "Jean",
            "Sweatshirt",
            "Sweatpans",
            "Tights",
            "Shirt",
            "Skirt",
            "Trousers",
            "Sweater",
            "Jacket",
            "Raincoat",
            "Sock",
            "Trainers",
            "Coat",
            "Cap/Hat",
            "Belt",
            "Bag",
            "Slipper"});
            this.cmbproductcatagory.Location = new System.Drawing.Point(239, 358);
            this.cmbproductcatagory.Name = "cmbproductcatagory";
            this.cmbproductcatagory.Size = new System.Drawing.Size(163, 31);
            this.cmbproductcatagory.TabIndex = 73;
            // 
            // txtproductbrand
            // 
            this.txtproductbrand.Location = new System.Drawing.Point(239, 309);
            this.txtproductbrand.Name = "txtproductbrand";
            this.txtproductbrand.Size = new System.Drawing.Size(167, 31);
            this.txtproductbrand.TabIndex = 72;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(239, 80);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(167, 31);
            this.txtproductname.TabIndex = 75;
            // 
            // txtproductnumber
            // 
            this.txtproductnumber.Location = new System.Drawing.Point(239, 125);
            this.txtproductnumber.Name = "txtproductnumber";
            this.txtproductnumber.Size = new System.Drawing.Size(167, 31);
            this.txtproductnumber.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 498);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 23);
            this.label9.TabIndex = 70;
            this.label9.Text = "ProductColour:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 23);
            this.label11.TabIndex = 74;
            this.label11.Text = "ProductName:";
            // 
            // txtproductcolour
            // 
            this.txtproductcolour.Location = new System.Drawing.Point(239, 491);
            this.txtproductcolour.Name = "txtproductcolour";
            this.txtproductcolour.Size = new System.Drawing.Size(167, 31);
            this.txtproductcolour.TabIndex = 71;
            // 
            // cmbproductsize
            // 
            this.cmbproductsize.FormattingEnabled = true;
            this.cmbproductsize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "XL",
            "2XL",
            "3XL",
            "3-7Age",
            "7-11Age",
            "11-14Age",
            "Baby"});
            this.cmbproductsize.Location = new System.Drawing.Point(239, 446);
            this.cmbproductsize.Name = "cmbproductsize";
            this.cmbproductsize.Size = new System.Drawing.Size(167, 31);
            this.cmbproductsize.TabIndex = 69;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 448);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 23);
            this.label15.TabIndex = 68;
            this.label15.Text = "ProductSize:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(99, 409);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 23);
            this.label16.TabIndex = 67;
            this.label16.Text = "ProductGender:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(85, 364);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 23);
            this.label17.TabIndex = 65;
            this.label17.Text = "ProductCategory:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(110, 314);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 23);
            this.label18.TabIndex = 66;
            this.label18.Text = "ProductBrand:";
            // 
            // lblproductcode
            // 
            this.lblproductcode.AutoSize = true;
            this.lblproductcode.Location = new System.Drawing.Point(116, 265);
            this.lblproductcode.Name = "lblproductcode";
            this.lblproductcode.Size = new System.Drawing.Size(117, 23);
            this.lblproductcode.TabIndex = 63;
            this.lblproductcode.Text = "ProductCode:";
            // 
            // txtproductcode
            // 
            this.txtproductcode.Enabled = false;
            this.txtproductcode.Location = new System.Drawing.Point(239, 258);
            this.txtproductcode.Name = "txtproductcode";
            this.txtproductcode.Size = new System.Drawing.Size(167, 31);
            this.txtproductcode.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(118, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 23);
            this.label14.TabIndex = 61;
            this.label14.Text = "ProductPrice:";
            // 
            // txtproductprice
            // 
            this.txtproductprice.Location = new System.Drawing.Point(239, 217);
            this.txtproductprice.Name = "txtproductprice";
            this.txtproductprice.Size = new System.Drawing.Size(167, 31);
            this.txtproductprice.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 23);
            this.label8.TabIndex = 50;
            this.label8.Text = "ProductPurchasePrice:";
            // 
            // cmbProductWhere
            // 
            this.cmbProductWhere.FormattingEnabled = true;
            this.cmbProductWhere.Items.AddRange(new object[] {
            "Warehouse",
            "Shelf"});
            this.cmbProductWhere.Location = new System.Drawing.Point(239, 43);
            this.cmbProductWhere.Name = "cmbProductWhere";
            this.cmbProductWhere.Size = new System.Drawing.Size(167, 31);
            this.cmbProductWhere.TabIndex = 49;
            // 
            // txtproductpurchase
            // 
            this.txtproductpurchase.Location = new System.Drawing.Point(239, 171);
            this.txtproductpurchase.Name = "txtproductpurchase";
            this.txtproductpurchase.Size = new System.Drawing.Size(167, 31);
            this.txtproductpurchase.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 23);
            this.label13.TabIndex = 48;
            this.label13.Text = "ProductWhere:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 39);
            this.label4.TabIndex = 30;
            this.label4.Text = "Products Info Panel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(651, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 623);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ProductsList";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 593);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1501, 748);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmProducts";
            this.Text = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProductWhere;
        private System.Windows.Forms.TextBox txtproductpurchase;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbproductgender;
        private System.Windows.Forms.ComboBox cmbproductcatagory;
        private System.Windows.Forms.TextBox txtproductbrand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtproductcolour;
        private System.Windows.Forms.ComboBox cmbproductsize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblproductcode;
        private System.Windows.Forms.TextBox txtproductcode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtproductprice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.TextBox txtproductnumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}