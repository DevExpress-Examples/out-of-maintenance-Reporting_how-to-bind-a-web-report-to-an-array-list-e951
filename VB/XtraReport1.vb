Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraReports.UI
' ...

Namespace BindWebReportToArrayList
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub AddBoundLabel(ByVal bindingMember As String, ByVal bounds As Rectangle)
			' Create a label.
			Dim label As New XRLabel()

			' Add the label to the report's Detail band.
			Detail.Controls.Add(label)

			' Set its location and size.
			label.Location = bounds.Location
			label.Size = bounds.Size

			' Bind it to the bindingMember data field.
			label.DataBindings.Add("Text", DataSource, bindingMember)
		End Sub
	End Class
End Namespace
