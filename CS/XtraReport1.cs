using System.Drawing;
using DevExpress.XtraReports.UI;
// ...

namespace BindWebReportToArrayList {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        public void AddBoundLabel(string bindingMember, Rectangle bounds) {
            // Create a label.
            XRLabel label = new XRLabel();

            // Add the label to the report's Detail band.
            Detail.Controls.Add(label);

            // Set its location and size.
            label.Location = bounds.Location;
            label.Size = bounds.Size;

            // Bind it to the bindingMember data field.
            label.DataBindings.Add("Text", DataSource, bindingMember);
        }
    }
}
