using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetServiceProvider
{
    public partial class PaymentsHistoryReport: Form
    {
        public PaymentsHistoryReport()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void PaymentsHistoryReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paymentHistoryDataSet.payment_history' table. You can move, or remove it, as needed.
            this.payment_historyTableAdapter.Fill(this.paymentHistoryDataSet.payment_history);
            // TODO: This line of code loads data into the 'paymentHistoryDataSet.payment_history' table. You can move, or remove it, as needed.
            this.payment_historyTableAdapter.Fill(this.paymentHistoryDataSet.payment_history);

            this.reportViewer1.RefreshReport();
        }
    }
}
