namespace EmployeeDB
{
    partial class EmployeeSalaryForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnbilling = new System.Windows.Forms.Button();
            this.txtNetSala = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtGrossSala = new System.Windows.Forms.TextBox();
            this.txtBaseSala = new System.Windows.Forms.TextBox();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PayCOmbo = new System.Windows.Forms.ComboBox();
            this.paymentMethodBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payment = new EmployeeDB.Payment();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paymentMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.AccCombo = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountantDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountantDataSet = new EmployeeDB.AccountantDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statusCombo = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statuscomboDataSet = new EmployeeDB.StatuscomboDataSet();
            this.remitdate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDeductedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalaryViewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allEmployeeSalaryDataSet = new EmployeeDB.AllEmployeeSalaryDataSet();
            this.allowanceCombo = new System.Windows.Forms.ComboBox();
            this.allowanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSalaryDataSet1 = new EmployeeDB.EmployeeSalaryDataSet1();
            this.payment_MethodTableAdapter = new EmployeeDB.PaymentTableAdapters.Payment_MethodTableAdapter();
            this.accountantTableAdapter = new EmployeeDB.AccountantDataSetTableAdapters.AccountantTableAdapter();
            this.statusTableAdapter = new EmployeeDB.StatuscomboDataSetTableAdapters.StatusTableAdapter();
            this.allowanceTableAdapter = new EmployeeDB.EmployeeSalaryDataSet1TableAdapters.AllowanceTableAdapter();
            this.employeeSalaryViewsTableAdapter = new EmployeeDB.AllEmployeeSalaryDataSetTableAdapters.EmployeeSalaryViewsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statuscomboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryViewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmployeeSalaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(771, 655);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 38);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnEmp_Click_1);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Snow;
            this.btnEmployee.Location = new System.Drawing.Point(571, 655);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(194, 38);
            this.btnEmployee.TabIndex = 54;
            this.btnEmployee.Text = "&Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnbilling
            // 
            this.btnbilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.btnbilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnbilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbilling.ForeColor = System.Drawing.Color.Snow;
            this.btnbilling.Location = new System.Drawing.Point(171, 655);
            this.btnbilling.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbilling.Name = "btnbilling";
            this.btnbilling.Size = new System.Drawing.Size(194, 38);
            this.btnbilling.TabIndex = 53;
            this.btnbilling.Text = "&Billing";
            this.btnbilling.UseVisualStyleBackColor = false;
            this.btnbilling.Click += new System.EventHandler(this.btnbilling_Click);
            // 
            // txtNetSala
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtNetSala, 3);
            this.txtNetSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNetSala.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetSala.Location = new System.Drawing.Point(371, 425);
            this.txtNetSala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNetSala.Name = "txtNetSala";
            this.txtNetSala.Size = new System.Drawing.Size(594, 27);
            this.txtNetSala.TabIndex = 52;
            // 
            // txtTax
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTax, 3);
            this.txtTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTax.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(371, 379);
            this.txtTax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(594, 27);
            this.txtTax.TabIndex = 51;
            // 
            // txtGrossSala
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtGrossSala, 3);
            this.txtGrossSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGrossSala.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossSala.Location = new System.Drawing.Point(371, 333);
            this.txtGrossSala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGrossSala.Name = "txtGrossSala";
            this.txtGrossSala.Size = new System.Drawing.Size(594, 27);
            this.txtGrossSala.TabIndex = 50;
            this.txtGrossSala.Click += new System.EventHandler(this.txtGrossSala_Click);
            // 
            // txtBaseSala
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtBaseSala, 3);
            this.txtBaseSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBaseSala.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseSala.Location = new System.Drawing.Point(371, 241);
            this.txtBaseSala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBaseSala.Name = "txtBaseSala";
            this.txtBaseSala.Size = new System.Drawing.Size(594, 27);
            this.txtBaseSala.TabIndex = 47;
            this.txtBaseSala.Click += new System.EventHandler(this.txtBaseSala_Click);
            // 
            // txtEmpNum
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtEmpNum, 3);
            this.txtEmpNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmpNum.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNum.Location = new System.Drawing.Point(371, 195);
            this.txtEmpNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.Size = new System.Drawing.Size(594, 27);
            this.txtEmpNum.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(171, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 46);
            this.label7.TabIndex = 45;
            this.label7.Text = "Net Salary : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 46);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tax Deducted :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 46);
            this.label5.TabIndex = 43;
            this.label5.Text = "Gross Salary :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 46);
            this.label3.TabIndex = 41;
            this.label3.Text = "Allowance : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 46);
            this.label2.TabIndex = 40;
            this.label2.Text = "Base Salary : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 46);
            this.label1.TabIndex = 39;
            this.label1.Text = "Employee Number :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 46);
            this.label4.TabIndex = 57;
            this.label4.Text = "Payment Method :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PayCOmbo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PayCOmbo, 3);
            this.PayCOmbo.DataSource = this.paymentMethodBindingSource3;
            this.PayCOmbo.DisplayMember = "Method";
            this.PayCOmbo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayCOmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PayCOmbo.FormattingEnabled = true;
            this.PayCOmbo.Location = new System.Drawing.Point(371, 471);
            this.PayCOmbo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PayCOmbo.Name = "PayCOmbo";
            this.PayCOmbo.Size = new System.Drawing.Size(594, 24);
            this.PayCOmbo.TabIndex = 59;
            this.PayCOmbo.ValueMember = "PaymentNo";
            // 
            // paymentMethodBindingSource3
            // 
            this.paymentMethodBindingSource3.DataMember = "Payment_Method";
            this.paymentMethodBindingSource3.DataSource = this.paymentBindingSource;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataSource = this.payment;
            this.paymentBindingSource.Position = 0;
            // 
            // payment
            // 
            this.payment.DataSetName = "Payment";
            this.payment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 4);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::EmployeeDB.Properties.Resources.photo_2023_09_26_21_27_22;
            this.pictureBox1.Location = new System.Drawing.Point(171, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 3);
            this.pictureBox1.Size = new System.Drawing.Size(794, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 46);
            this.label8.TabIndex = 60;
            this.label8.Text = "Accountant :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccCombo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.AccCombo, 3);
            this.AccCombo.DataSource = this.bindingSource1;
            this.AccCombo.DisplayMember = "AccountantName";
            this.AccCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccCombo.FormattingEnabled = true;
            this.AccCombo.Location = new System.Drawing.Point(371, 517);
            this.AccCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AccCombo.Name = "AccCombo";
            this.AccCombo.Size = new System.Drawing.Size(594, 24);
            this.AccCombo.TabIndex = 61;
            this.AccCombo.ValueMember = "AccountantNo";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Accountant";
            this.bindingSource1.DataSource = this.accountantDataSetBindingSource;
            // 
            // accountantDataSetBindingSource
            // 
            this.accountantDataSetBindingSource.DataSource = this.accountantDataSet;
            this.accountantDataSetBindingSource.Position = 0;
            // 
            // accountantDataSet
            // 
            this.accountantDataSet.DataSetName = "AccountantDataSet";
            this.accountantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 4, 14);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnEmployee, 3, 14);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnbilling, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtEmpNum, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBaseSala, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtGrossSala, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtTax, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtNetSala, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.PayCOmbo, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.AccCombo, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.statusCombo, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.remitdate, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.allowanceCombo, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 18;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1136, 843);
            this.tableLayoutPanel1.TabIndex = 62;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Snow;
            this.btnClear.Location = new System.Drawing.Point(371, 653);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(194, 42);
            this.btnClear.TabIndex = 62;
            this.btnClear.Text = "Report";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(171, 559);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 46);
            this.label9.TabIndex = 63;
            this.label9.Text = "Remit Date :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.064F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(171, 605);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 46);
            this.label10.TabIndex = 64;
            this.label10.Text = "Status :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusCombo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusCombo, 3);
            this.statusCombo.DataSource = this.statusBindingSource;
            this.statusCombo.DisplayMember = "Status";
            this.statusCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCombo.FormattingEnabled = true;
            this.statusCombo.Location = new System.Drawing.Point(371, 608);
            this.statusCombo.Name = "statusCombo";
            this.statusCombo.Size = new System.Drawing.Size(594, 24);
            this.statusCombo.TabIndex = 65;
            this.statusCombo.ValueMember = "StatusNo";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.statuscomboDataSet;
            // 
            // statuscomboDataSet
            // 
            this.statuscomboDataSet.DataSetName = "StatuscomboDataSet";
            this.statuscomboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remitdate
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.remitdate, 2);
            this.remitdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remitdate.Location = new System.Drawing.Point(371, 562);
            this.remitdate.Name = "remitdate";
            this.remitdate.Size = new System.Drawing.Size(394, 22);
            this.remitdate.TabIndex = 66;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.remitDateDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.timeWorkDataGridViewTextBoxColumn,
            this.grossSalaryDataGridViewTextBoxColumn,
            this.taxDeductedDataGridViewTextBoxColumn,
            this.netSalaryDataGridViewTextBoxColumn,
            this.accountantNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.methodDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.DataSource = this.employeeSalaryViewsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(171, 700);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 53;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 3);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 140);
            this.dataGridView1.TabIndex = 67;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // remitDateDataGridViewTextBoxColumn
            // 
            this.remitDateDataGridViewTextBoxColumn.DataPropertyName = "RemitDate";
            this.remitDateDataGridViewTextBoxColumn.HeaderText = "RemitDate";
            this.remitDateDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.remitDateDataGridViewTextBoxColumn.Name = "remitDateDataGridViewTextBoxColumn";
            this.remitDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 130;
            // 
            // timeWorkDataGridViewTextBoxColumn
            // 
            this.timeWorkDataGridViewTextBoxColumn.DataPropertyName = "TimeWork";
            this.timeWorkDataGridViewTextBoxColumn.HeaderText = "TimeWork";
            this.timeWorkDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.timeWorkDataGridViewTextBoxColumn.Name = "timeWorkDataGridViewTextBoxColumn";
            this.timeWorkDataGridViewTextBoxColumn.Width = 130;
            // 
            // grossSalaryDataGridViewTextBoxColumn
            // 
            this.grossSalaryDataGridViewTextBoxColumn.DataPropertyName = "GrossSalary";
            this.grossSalaryDataGridViewTextBoxColumn.HeaderText = "GrossSalary";
            this.grossSalaryDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.grossSalaryDataGridViewTextBoxColumn.Name = "grossSalaryDataGridViewTextBoxColumn";
            this.grossSalaryDataGridViewTextBoxColumn.Width = 130;
            // 
            // taxDeductedDataGridViewTextBoxColumn
            // 
            this.taxDeductedDataGridViewTextBoxColumn.DataPropertyName = "TaxDeducted";
            this.taxDeductedDataGridViewTextBoxColumn.HeaderText = "TaxDeducted";
            this.taxDeductedDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.taxDeductedDataGridViewTextBoxColumn.Name = "taxDeductedDataGridViewTextBoxColumn";
            this.taxDeductedDataGridViewTextBoxColumn.Width = 130;
            // 
            // netSalaryDataGridViewTextBoxColumn
            // 
            this.netSalaryDataGridViewTextBoxColumn.DataPropertyName = "NetSalary";
            this.netSalaryDataGridViewTextBoxColumn.HeaderText = "NetSalary";
            this.netSalaryDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.netSalaryDataGridViewTextBoxColumn.Name = "netSalaryDataGridViewTextBoxColumn";
            this.netSalaryDataGridViewTextBoxColumn.Width = 130;
            // 
            // accountantNameDataGridViewTextBoxColumn
            // 
            this.accountantNameDataGridViewTextBoxColumn.DataPropertyName = "AccountantName";
            this.accountantNameDataGridViewTextBoxColumn.HeaderText = "AccountantName";
            this.accountantNameDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.accountantNameDataGridViewTextBoxColumn.Name = "accountantNameDataGridViewTextBoxColumn";
            this.accountantNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 130;
            // 
            // methodDataGridViewTextBoxColumn
            // 
            this.methodDataGridViewTextBoxColumn.DataPropertyName = "Method";
            this.methodDataGridViewTextBoxColumn.HeaderText = "Method";
            this.methodDataGridViewTextBoxColumn.MinimumWidth = 7;
            this.methodDataGridViewTextBoxColumn.Name = "methodDataGridViewTextBoxColumn";
            this.methodDataGridViewTextBoxColumn.Width = 130;
            // 
            // employeeSalaryViewsBindingSource
            // 
            this.employeeSalaryViewsBindingSource.DataMember = "EmployeeSalaryViews";
            this.employeeSalaryViewsBindingSource.DataSource = this.allEmployeeSalaryDataSet;
            // 
            // allEmployeeSalaryDataSet
            // 
            this.allEmployeeSalaryDataSet.DataSetName = "AllEmployeeSalaryDataSet";
            this.allEmployeeSalaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allowanceCombo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.allowanceCombo, 3);
            this.allowanceCombo.DataSource = this.allowanceBindingSource;
            this.allowanceCombo.DisplayMember = "TimeWork";
            this.allowanceCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allowanceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allowanceCombo.FormattingEnabled = true;
            this.allowanceCombo.Location = new System.Drawing.Point(371, 286);
            this.allowanceCombo.Name = "allowanceCombo";
            this.allowanceCombo.Size = new System.Drawing.Size(594, 24);
            this.allowanceCombo.TabIndex = 68;
            this.allowanceCombo.ValueMember = "TimeWorkNo";
            this.allowanceCombo.SelectedIndexChanged += new System.EventHandler(this.allowanceCombo_SelectedIndexChanged);
            // 
            // allowanceBindingSource
            // 
            this.allowanceBindingSource.DataMember = "Allowance";
            this.allowanceBindingSource.DataSource = this.employeeSalaryDataSet1;
            // 
            // employeeSalaryDataSet1
            // 
            this.employeeSalaryDataSet1.DataSetName = "EmployeeSalaryDataSet1";
            this.employeeSalaryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payment_MethodTableAdapter
            // 
            this.payment_MethodTableAdapter.ClearBeforeFill = true;
            // 
            // accountantTableAdapter
            // 
            this.accountantTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // allowanceTableAdapter
            // 
            this.allowanceTableAdapter.ClearBeforeFill = true;
            // 
            // employeeSalaryViewsTableAdapter
            // 
            this.employeeSalaryViewsTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 843);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeSalaryForm";
            this.Text = "EmployeeSalary";
            this.Load += new System.EventHandler(this.EmployeeSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statuscomboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryViewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmployeeSalaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnbilling;
        private System.Windows.Forms.TextBox txtNetSala;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtGrossSala;
        private System.Windows.Forms.TextBox txtBaseSala;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PayCOmbo;
        private System.Windows.Forms.BindingSource paymentMethodBindingSource;

        private System.Windows.Forms.BindingSource paymentMethodBindingSource1;

        private System.Windows.Forms.BindingSource paymentMethodBindingSource2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AccCombo;
   

        private System.Windows.Forms.BindingSource accountantBindingSource;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private Payment payment;
        private System.Windows.Forms.BindingSource paymentMethodBindingSource3;
        private PaymentTableAdapters.Payment_MethodTableAdapter payment_MethodTableAdapter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource accountantDataSetBindingSource;
        private AccountantDataSet accountantDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AccountantDataSetTableAdapters.AccountantTableAdapter accountantTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox statusCombo;
        private System.Windows.Forms.DateTimePicker remitdate;
        private StatuscomboDataSet statuscomboDataSet;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private StatuscomboDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox allowanceCombo;
        private EmployeeSalaryDataSet1 employeeSalaryDataSet1;
        private System.Windows.Forms.BindingSource allowanceBindingSource;
        private EmployeeSalaryDataSet1TableAdapters.AllowanceTableAdapter allowanceTableAdapter;
        private AllEmployeeSalaryDataSet allEmployeeSalaryDataSet;
        private System.Windows.Forms.BindingSource employeeSalaryViewsBindingSource;
        private AllEmployeeSalaryDataSetTableAdapters.EmployeeSalaryViewsTableAdapter employeeSalaryViewsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDeductedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodDataGridViewTextBoxColumn;
    }
}