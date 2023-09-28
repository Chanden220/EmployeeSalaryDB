namespace EmployeeDB.Forms
{
    partial class EmployeeReportView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.employeeSalaryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSalaryDataSet = new EmployeeDB.EmployeeSalaryDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet = new EmployeeDB.EmployeeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.employeeTableAdapter = new EmployeeDB.EmployeeDataSetTableAdapters.EmployeeTableAdapter();
            this.employeeSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSalaryTableAdapter = new EmployeeDB.EmployeeSalaryDataSetTableAdapters.EmployeeSalaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeSalaryDataSetBindingSource
            // 
            this.employeeSalaryDataSetBindingSource.DataSource = this.employeeSalaryDataSet;
            this.employeeSalaryDataSetBindingSource.Position = 0;
            // 
            // employeeSalaryDataSet
            // 
            this.employeeSalaryDataSet.DataSetName = "EmployeeSalaryDataSet";
            this.employeeSalaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.employeeSalaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmployeeDB.Reports.EmployeeSalary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeSalaryBindingSource
            // 
            this.employeeSalaryBindingSource.DataMember = "EmployeeSalary";
            this.employeeSalaryBindingSource.DataSource = this.employeeSalaryDataSetBindingSource;
            // 
            // employeeSalaryTableAdapter
            // 
            this.employeeSalaryTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmployeeReportView";
            this.Text = "EmployeeReportView";
            this.Load += new System.EventHandler(this.EmployeeReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeSalaryDataSetBindingSource;
        private EmployeeSalaryDataSet employeeSalaryDataSet;
        private System.Windows.Forms.BindingSource employeeSalaryBindingSource;
        private EmployeeSalaryDataSetTableAdapters.EmployeeSalaryTableAdapter employeeSalaryTableAdapter;
    }
}