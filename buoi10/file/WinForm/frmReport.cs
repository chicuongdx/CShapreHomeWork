using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace bt1.Buoi09
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        public void LoadReport(DataTable dt, string TenNV, string TenKH)
        {
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "rptBill.rdlc";

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "dsReportBill";
            dts.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);

            ReportParameter para1 = new ReportParameter();
            para1.Name = "TenNV";
            para1.Values.Add(TenNV);
            ReportParameter para2 = new ReportParameter();
            para2.Name = "TenKH";
            para2.Values.Add(TenKH);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1, para2 }); 
        }
    }
}
