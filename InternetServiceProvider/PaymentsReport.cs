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
    public partial class PaymentsReport: Form
    {
        public PaymentsReport()
        {
            InitializeComponent();
        }

        private void PaymentsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetServiceProviderDBDataSet9.payment_history' table. You can move, or remove it, as needed.
            this.payment_historyTableAdapter.Fill(this.internetServiceProviderDBDataSet9.payment_history);

            this.reportViewer1.RefreshReport();
        }
    }
}
