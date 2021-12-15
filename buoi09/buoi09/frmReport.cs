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
            reportViewer1.LocalReport.ReportPath = "rpVin.rdlc";//Link report-mặc định đi tới bin/Debug

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "DataSet";
            dts.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);

            ReportParameter para1 = new ReportParameter();
            para1.Name = "TenNV";
            para1.Values.Add(TenNV);
            ReportParameter para2 = new ReportParameter();
            para2.Name = "TenKH";
            para2.Values.Add(TenKH);

            //ReportParameter para3 = new ReportParameter();
            //para3.Name = "Date";
            //para3.Values.Add(DateTime.Now.Date.ToString());

            //ReportParameter para4 = new ReportParameter();
            //para4.Name = "Time";
            //para4.Values.Add(DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString());

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1, para2 }); 
        }
    }
}
