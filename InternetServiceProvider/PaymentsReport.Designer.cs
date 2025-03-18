namespace InternetServiceProvider
{
    partial class PaymentsReport
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
            this.internetServiceProviderDBDataSet9 = new InternetServiceProvider.InternetServiceProviderDBDataSet9();
            this.paymenthistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payment_historyTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSet9TableAdapters.payment_historyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenthistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.paymenthistoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InternetServiceProvider.Payments.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // internetServiceProviderDBDataSet9
            // 
            this.internetServiceProviderDBDataSet9.DataSetName = "InternetServiceProviderDBDataSet9";
            this.internetServiceProviderDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymenthistoryBindingSource
            // 
            this.paymenthistoryBindingSource.DataMember = "payment_history";
            this.paymenthistoryBindingSource.DataSource = this.internetServiceProviderDBDataSet9;
            // 
            // payment_historyTableAdapter
            // 
            this.payment_historyTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PaymentsReport";
            this.Text = "PaymentsReport";
            this.Load += new System.EventHandler(this.PaymentsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenthistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private InternetServiceProviderDBDataSet9 internetServiceProviderDBDataSet9;
        private System.Windows.Forms.BindingSource paymenthistoryBindingSource;
        private InternetServiceProviderDBDataSet9TableAdapters.payment_historyTableAdapter payment_historyTableAdapter;
    }
}