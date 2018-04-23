using System;
using System.Collections;
using System.Drawing;
using DevExpress.XtraReports.UI;
// ...

namespace BindWebReportToArrayList {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ReportViewer1.Report = CreateReport();
        }
        protected override void OnInit(EventArgs e) {
            base.OnInit(e);
            ReportViewer1.Report = CreateReport();
        }

        XtraReport CreateReport() {

            // Create a list.
            ArrayList listDataSource = new ArrayList();

            // Populate the list with records.
            listDataSource.Add(new Record(1, "Jane", 19));
            listDataSource.Add(new Record(2, "Joe", 30));
            listDataSource.Add(new Record(3, "Bill", 15));
            listDataSource.Add(new Record(4, "Michael", 42));

            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Bind the report to the list.
            report.DataSource = listDataSource;

            // Add bounded labels to the Detail band of the report.
            report.AddBoundLabel("ID", new Rectangle(100, 20, 100, 30));
            report.AddBoundLabel("Name", new Rectangle(200, 20, 100, 30));
            report.AddBoundLabel("Age", new Rectangle(300, 20, 100, 30));

            return report;
        }
    }
}
