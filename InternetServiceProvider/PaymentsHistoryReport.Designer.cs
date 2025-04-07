﻿namespace InternetServiceProvider
{
    partial class PaymentsHistoryReport
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
            this.paymenthistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentHistoryDataSet = new InternetServiceProvider.PaymentHistoryDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.payment_historyTableAdapter = new InternetServiceProvider.PaymentHistoryDataSetTableAdapters.payment_historyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.paymenthistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentHistoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // paymenthistoryBindingSource
            // 
            this.paymenthistoryBindingSource.DataMember = "payment_history";
            this.paymenthistoryBindingSource.DataSource = this.paymentHistoryDataSet;
            // 
            // paymentHistoryDataSet
            // 
            this.paymentHistoryDataSet.DataSetName = "PaymentHistoryDataSet";
            this.paymentHistoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PaymentHistory";
            reportDataSource1.Value = this.paymenthistoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InternetServiceProvider.PaymentsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(898, 476);
            this.reportViewer1.TabIndex = 0;
            // 
            // payment_historyTableAdapter
            // 
            this.payment_historyTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentsHistoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 476);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PaymentsHistoryReport";
            this.Text = "Звіт по платежам";
            this.Load += new System.EventHandler(this.PaymentsHistoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymenthistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentHistoryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PaymentHistoryDataSet paymentHistoryDataSet;
        private System.Windows.Forms.BindingSource paymenthistoryBindingSource;
        private PaymentHistoryDataSetTableAdapters.payment_historyTableAdapter payment_historyTableAdapter;
    }
}