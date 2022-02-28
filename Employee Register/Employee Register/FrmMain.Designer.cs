
namespace Employee_Register
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskdtxtsalary = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.rdbtnsingle = new System.Windows.Forms.RadioButton();
            this.rdbtnmarried = new System.Windows.Forms.RadioButton();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemployeeid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btngraphics = new System.Windows.Forms.Button();
            this.btnstatistics = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeecityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeMarriageStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employeeJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataBaseDataSet = new Employee_Register.EmployeeDataBaseDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_EmployeeTableAdapter = new Employee_Register.EmployeeDataBaseDataSetTableAdapters.Tbl_EmployeeTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskdtxtsalary);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbcity);
            this.groupBox1.Controls.Add(this.rdbtnsingle);
            this.groupBox1.Controls.Add(this.rdbtnmarried);
            this.groupBox1.Controls.Add(this.txtjob);
            this.groupBox1.Controls.Add(this.txtsurname);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtemployeeid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 346);
            this.groupBox1.TabIndex = 200;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Registration";
            // 
            // mskdtxtsalary
            // 
            this.mskdtxtsalary.Location = new System.Drawing.Point(152, 201);
            this.mskdtxtsalary.Mask = "0000";
            this.mskdtxtsalary.Name = "mskdtxtsalary";
            this.mskdtxtsalary.Size = new System.Drawing.Size(173, 27);
            this.mskdtxtsalary.TabIndex = 5;
            this.mskdtxtsalary.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Salary:";
            // 
            // cmbcity
            // 
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Location = new System.Drawing.Point(152, 168);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(173, 27);
            this.cmbcity.TabIndex = 4;
            // 
            // rdbtnsingle
            // 
            this.rdbtnsingle.AutoSize = true;
            this.rdbtnsingle.Location = new System.Drawing.Point(237, 234);
            this.rdbtnsingle.Name = "rdbtnsingle";
            this.rdbtnsingle.Size = new System.Drawing.Size(69, 23);
            this.rdbtnsingle.TabIndex = 13;
            this.rdbtnsingle.TabStop = true;
            this.rdbtnsingle.Text = "Single";
            this.rdbtnsingle.UseVisualStyleBackColor = true;
            this.rdbtnsingle.CheckedChanged += new System.EventHandler(this.rdbtnsingle_CheckedChanged);
            // 
            // rdbtnmarried
            // 
            this.rdbtnmarried.AutoSize = true;
            this.rdbtnmarried.Location = new System.Drawing.Point(152, 234);
            this.rdbtnmarried.Name = "rdbtnmarried";
            this.rdbtnmarried.Size = new System.Drawing.Size(79, 23);
            this.rdbtnmarried.TabIndex = 12;
            this.rdbtnmarried.TabStop = true;
            this.rdbtnmarried.Text = "Married";
            this.rdbtnmarried.UseVisualStyleBackColor = true;
            this.rdbtnmarried.CheckedChanged += new System.EventHandler(this.rdbtnmarried_CheckedChanged);
            // 
            // txtjob
            // 
            this.txtjob.Location = new System.Drawing.Point(152, 266);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(173, 27);
            this.txtjob.TabIndex = 6;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(152, 126);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(173, 27);
            this.txtsurname.TabIndex = 83;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(152, 88);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(173, 27);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.Location = new System.Drawing.Point(152, 46);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.Size = new System.Drawing.Size(173, 27);
            this.txtemployeeid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Job:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marriage Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btngraphics);
            this.groupBox2.Controls.Add(this.btnstatistics);
            this.groupBox2.Controls.Add(this.btnclear);
            this.groupBox2.Controls.Add(this.btnupdate);
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Controls.Add(this.btnlist);
            this.groupBox2.Location = new System.Drawing.Point(421, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 346);
            this.groupBox2.TabIndex = 200;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions";
            // 
            // btngraphics
            // 
            this.btngraphics.Location = new System.Drawing.Point(17, 257);
            this.btngraphics.Name = "btngraphics";
            this.btngraphics.Size = new System.Drawing.Size(182, 36);
            this.btngraphics.TabIndex = 6;
            this.btngraphics.Text = "Graphics";
            this.btngraphics.UseVisualStyleBackColor = true;
            this.btngraphics.Click += new System.EventHandler(this.btngraphics_Click);
            // 
            // btnstatistics
            // 
            this.btnstatistics.Location = new System.Drawing.Point(17, 222);
            this.btnstatistics.Name = "btnstatistics";
            this.btnstatistics.Size = new System.Drawing.Size(182, 36);
            this.btnstatistics.TabIndex = 5;
            this.btnstatistics.Text = "Statistics";
            this.btnstatistics.UseVisualStyleBackColor = true;
            this.btnstatistics.Click += new System.EventHandler(this.btnstatistics_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(17, 187);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(182, 36);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(17, 152);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(182, 36);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(17, 117);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(182, 36);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(17, 82);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(182, 36);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(17, 47);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(182, 36);
            this.btnlist.TabIndex = 0;
            this.btnlist.Text = "List";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(824, 202);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeidDataGridViewTextBoxColumn,
            this.employeenameDataGridViewTextBoxColumn,
            this.employeesurnameDataGridViewTextBoxColumn,
            this.employeecityDataGridViewTextBoxColumn,
            this.employeesalaryDataGridViewTextBoxColumn,
            this.employeeMarriageStatusDataGridViewCheckBoxColumn,
            this.employeeJobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmployeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 176);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "Employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "Employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeenameDataGridViewTextBoxColumn
            // 
            this.employeenameDataGridViewTextBoxColumn.DataPropertyName = "Employee_name";
            this.employeenameDataGridViewTextBoxColumn.HeaderText = "Employee_name";
            this.employeenameDataGridViewTextBoxColumn.Name = "employeenameDataGridViewTextBoxColumn";
            // 
            // employeesurnameDataGridViewTextBoxColumn
            // 
            this.employeesurnameDataGridViewTextBoxColumn.DataPropertyName = "Employee_surname";
            this.employeesurnameDataGridViewTextBoxColumn.HeaderText = "Employee_surname";
            this.employeesurnameDataGridViewTextBoxColumn.Name = "employeesurnameDataGridViewTextBoxColumn";
            // 
            // employeecityDataGridViewTextBoxColumn
            // 
            this.employeecityDataGridViewTextBoxColumn.DataPropertyName = "Employee_city";
            this.employeecityDataGridViewTextBoxColumn.HeaderText = "Employee_city";
            this.employeecityDataGridViewTextBoxColumn.Name = "employeecityDataGridViewTextBoxColumn";
            // 
            // employeesalaryDataGridViewTextBoxColumn
            // 
            this.employeesalaryDataGridViewTextBoxColumn.DataPropertyName = "Employee_salary";
            this.employeesalaryDataGridViewTextBoxColumn.HeaderText = "Employee_salary";
            this.employeesalaryDataGridViewTextBoxColumn.Name = "employeesalaryDataGridViewTextBoxColumn";
            // 
            // employeeMarriageStatusDataGridViewCheckBoxColumn
            // 
            this.employeeMarriageStatusDataGridViewCheckBoxColumn.DataPropertyName = "Employee_MarriageStatus";
            this.employeeMarriageStatusDataGridViewCheckBoxColumn.HeaderText = "Employee_MarriageStatus";
            this.employeeMarriageStatusDataGridViewCheckBoxColumn.Name = "employeeMarriageStatusDataGridViewCheckBoxColumn";
            // 
            // employeeJobDataGridViewTextBoxColumn
            // 
            this.employeeJobDataGridViewTextBoxColumn.DataPropertyName = "Employee_Job";
            this.employeeJobDataGridViewTextBoxColumn.HeaderText = "Employee_Job";
            this.employeeJobDataGridViewTextBoxColumn.Name = "employeeJobDataGridViewTextBoxColumn";
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "Tbl_Employee";
            this.tblEmployeeBindingSource.DataSource = this.employeeDataBaseDataSet;
            // 
            // employeeDataBaseDataSet
            // 
            this.employeeDataBaseDataSet.DataSetName = "EmployeeDataBaseDataSet";
            this.employeeDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(658, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_EmployeeTableAdapter
            // 
            this.tbl_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(704, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 201;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(842, 577);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemployeeid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskdtxtsalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcity;
        private System.Windows.Forms.RadioButton rdbtnsingle;
        private System.Windows.Forms.RadioButton rdbtnmarried;
        private System.Windows.Forms.TextBox txtjob;
        private System.Windows.Forms.Button btngraphics;
        private System.Windows.Forms.Button btnstatistics;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EmployeeDataBaseDataSet employeeDataBaseDataSet;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private EmployeeDataBaseDataSetTableAdapters.Tbl_EmployeeTableAdapter tbl_EmployeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeecityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn employeeMarriageStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

