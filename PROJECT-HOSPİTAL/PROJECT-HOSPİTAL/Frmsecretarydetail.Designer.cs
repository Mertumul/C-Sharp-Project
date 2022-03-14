
namespace PROJECT_HOSPİTAL
{
    partial class Frmsecretarydetail
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
            this.lblnamesurname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.rchannouncement = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnappointmentsave = new System.Windows.Forms.Button();
            this.chkaaible = new System.Windows.Forms.CheckBox();
            this.mskpatientid = new System.Windows.Forms.MaskedTextBox();
            this.cmbdoctor = new System.Windows.Forms.ComboBox();
            this.cmbspecialty = new System.Windows.Forms.ComboBox();
            this.mskappointmenttime = new System.Windows.Forms.MaskedTextBox();
            this.mskappointmentdate = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnappointmentlist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btndocpanel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblnamesurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SecretaryInfo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblnamesurname
            // 
            this.lblnamesurname.AutoSize = true;
            this.lblnamesurname.Location = new System.Drawing.Point(210, 107);
            this.lblnamesurname.Name = "lblnamesurname";
            this.lblnamesurname.Size = new System.Drawing.Size(77, 23);
            this.lblnamesurname.TabIndex = 14;
            this.lblnamesurname.Text = "Null/Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name /Surname:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(220, 60);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(120, 23);
            this.lblTC.TabIndex = 12;
            this.lblTC.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "TC Identification No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncreate);
            this.groupBox2.Controls.Add(this.rchannouncement);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 346);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Make an Announcement";
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(116, 288);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(156, 35);
            this.btncreate.TabIndex = 3;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // rchannouncement
            // 
            this.rchannouncement.Location = new System.Drawing.Point(47, 41);
            this.rchannouncement.Name = "rchannouncement";
            this.rchannouncement.Size = new System.Drawing.Size(300, 231);
            this.rchannouncement.TabIndex = 2;
            this.rchannouncement.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnappointmentsave);
            this.groupBox3.Controls.Add(this.chkaaible);
            this.groupBox3.Controls.Add(this.mskpatientid);
            this.groupBox3.Controls.Add(this.cmbdoctor);
            this.groupBox3.Controls.Add(this.cmbspecialty);
            this.groupBox3.Controls.Add(this.mskappointmenttime);
            this.groupBox3.Controls.Add(this.mskappointmentdate);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(433, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 569);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create a Appointment";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnappointmentsave
            // 
            this.btnappointmentsave.Location = new System.Drawing.Point(97, 492);
            this.btnappointmentsave.Name = "btnappointmentsave";
            this.btnappointmentsave.Size = new System.Drawing.Size(303, 35);
            this.btnappointmentsave.TabIndex = 14;
            this.btnappointmentsave.Text = "Save";
            this.btnappointmentsave.UseVisualStyleBackColor = true;
            this.btnappointmentsave.Click += new System.EventHandler(this.btnappointmentsave_Click);
            // 
            // chkaaible
            // 
            this.chkaaible.AutoSize = true;
            this.chkaaible.Location = new System.Drawing.Point(240, 416);
            this.chkaaible.Name = "chkaaible";
            this.chkaaible.Size = new System.Drawing.Size(86, 27);
            this.chkaaible.TabIndex = 13;
            this.chkaaible.Text = "Avaible";
            this.chkaaible.UseVisualStyleBackColor = true;
            // 
            // mskpatientid
            // 
            this.mskpatientid.Location = new System.Drawing.Point(216, 363);
            this.mskpatientid.Mask = "00000000000";
            this.mskpatientid.Name = "mskpatientid";
            this.mskpatientid.Size = new System.Drawing.Size(204, 31);
            this.mskpatientid.TabIndex = 12;
            this.mskpatientid.ValidatingType = typeof(int);
            // 
            // cmbdoctor
            // 
            this.cmbdoctor.FormattingEnabled = true;
            this.cmbdoctor.Location = new System.Drawing.Point(216, 306);
            this.cmbdoctor.Name = "cmbdoctor";
            this.cmbdoctor.Size = new System.Drawing.Size(204, 31);
            this.cmbdoctor.TabIndex = 11;
            // 
            // cmbspecialty
            // 
            this.cmbspecialty.FormattingEnabled = true;
            this.cmbspecialty.Location = new System.Drawing.Point(216, 250);
            this.cmbspecialty.Name = "cmbspecialty";
            this.cmbspecialty.Size = new System.Drawing.Size(204, 31);
            this.cmbspecialty.TabIndex = 10;
            this.cmbspecialty.SelectedIndexChanged += new System.EventHandler(this.cmbspecialty_SelectedIndexChanged);
            // 
            // mskappointmenttime
            // 
            this.mskappointmenttime.Location = new System.Drawing.Point(216, 194);
            this.mskappointmenttime.Mask = "00:00";
            this.mskappointmenttime.Name = "mskappointmenttime";
            this.mskappointmenttime.Size = new System.Drawing.Size(204, 31);
            this.mskappointmenttime.TabIndex = 9;
            this.mskappointmenttime.ValidatingType = typeof(System.DateTime);
            // 
            // mskappointmentdate
            // 
            this.mskappointmentdate.Location = new System.Drawing.Point(216, 145);
            this.mskappointmentdate.Mask = "00/00/0000";
            this.mskappointmentdate.Name = "mskappointmentdate";
            this.mskappointmentdate.Size = new System.Drawing.Size(204, 31);
            this.mskappointmentdate.TabIndex = 8;
            this.mskappointmentdate.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(216, 95);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(204, 31);
            this.txtid.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Patient TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Appointment Status:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Appointment Doctor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "AppointmentSpecialty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Appointment Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "AppointmentDate:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(890, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(603, 330);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Specialty";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(890, 348);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(603, 375);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(597, 345);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.btnappointmentlist);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btndocpanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 587);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(872, 136);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Quick Access";
            // 
            // btnappointmentlist
            // 
            this.btnappointmentlist.Location = new System.Drawing.Point(477, 54);
            this.btnappointmentlist.Name = "btnappointmentlist";
            this.btnappointmentlist.Size = new System.Drawing.Size(199, 35);
            this.btnappointmentlist.TabIndex = 18;
            this.btnappointmentlist.Text = "Appointment List";
            this.btnappointmentlist.UseVisualStyleBackColor = true;
            this.btnappointmentlist.Click += new System.EventHandler(this.btnappointmentlist_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Specialty Panel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndocpanel
            // 
            this.btndocpanel.Location = new System.Drawing.Point(6, 54);
            this.btndocpanel.Name = "btndocpanel";
            this.btndocpanel.Size = new System.Drawing.Size(228, 35);
            this.btndocpanel.TabIndex = 16;
            this.btndocpanel.Text = "Doctor Panel";
            this.btndocpanel.UseVisualStyleBackColor = true;
            this.btndocpanel.Click += new System.EventHandler(this.btndocpanel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Announcement";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frmsecretarydetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1501, 728);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Frmsecretarydetail";
            this.Text = "Frmsecretarydetail";
            this.Load += new System.EventHandler(this.Frmsecretarydetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnamesurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.RichTextBox rchannouncement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskpatientid;
        private System.Windows.Forms.ComboBox cmbdoctor;
        private System.Windows.Forms.ComboBox cmbspecialty;
        private System.Windows.Forms.MaskedTextBox mskappointmenttime;
        private System.Windows.Forms.MaskedTextBox mskappointmentdate;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkaaible;
        private System.Windows.Forms.Button btnappointmentsave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnappointmentlist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndocpanel;
        private System.Windows.Forms.Button button2;
    }
}