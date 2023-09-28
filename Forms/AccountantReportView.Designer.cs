namespace EmployeeDB.Forms
{
    partial class AccountantReportView
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.accountantDataSet = new EmployeeDB.AccountantDataSet();
            this.accountantDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountantTableAdapter = new EmployeeDB.AccountantDataSetTableAdapters.AccountantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Accountant";
            reportDataSource1.Value = this.accountantBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmployeeDB.Reports.AccountantReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // accountantDataSet
            // 
            this.accountantDataSet.DataSetName = "AccountantDataSet";
            this.accountantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountantDataSetBindingSource
            // 
            this.accountantDataSetBindingSource.DataSource = this.accountantDataSet;
            this.accountantDataSetBindingSource.Position = 0;
            // 
            // accountantBindingSource
            // 
            this.accountantBindingSource.DataMember = "Accountant";
            this.accountantBindingSource.DataSource = this.accountantDataSetBindingSource;
            // 
            // accountantTableAdapter
            // 
            this.accountantTableAdapter.ClearBeforeFill = true;
            // 
            // AccountantReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AccountantReportView";
            this.Text = "AccountantReportView";
            this.Load += new System.EventHandler(this.AccountantReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AccountantDataSet accountantDataSet;
        private System.Windows.Forms.BindingSource accountantDataSetBindingSource;
        private System.Windows.Forms.BindingSource accountantBindingSource;
        private AccountantDataSetTableAdapters.AccountantTableAdapter accountantTableAdapter;
    }
}