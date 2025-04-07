namespace InternetServiceProvider
{
    partial class TechniciansReport
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
            this.techniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internetServiceProviderDBDataSet8 = new InternetServiceProvider.InternetServiceProviderDBDataSet8();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.techniciansTableAdapter = new InternetServiceProvider.InternetServiceProviderDBDataSet8TableAdapters.techniciansTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // techniciansBindingSource
            // 
            this.techniciansBindingSource.DataMember = "technicians";
            this.techniciansBindingSource.DataSource = this.internetServiceProviderDBDataSet8;
            // 
            // internetServiceProviderDBDataSet8
            // 
            this.internetServiceProviderDBDataSet8.DataSetName = "InternetServiceProviderDBDataSet8";
            this.internetServiceProviderDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.techniciansBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InternetServiceProvider.Technicians.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // techniciansTableAdapter
            // 
            this.techniciansTableAdapter.ClearBeforeFill = true;
            // 
            // TechniciansReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TechniciansReport";
            this.Text = "Звіт по тех-працівникам";
            this.Load += new System.EventHandler(this.TechniciansReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetServiceProviderDBDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private InternetServiceProviderDBDataSet8 internetServiceProviderDBDataSet8;
        private System.Windows.Forms.BindingSource techniciansBindingSource;
        private InternetServiceProviderDBDataSet8TableAdapters.techniciansTableAdapter techniciansTableAdapter;
    }
}