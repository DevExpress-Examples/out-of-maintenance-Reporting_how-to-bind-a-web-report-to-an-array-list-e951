Imports System
Imports System.Collections
Imports System.Drawing
Imports DevExpress.XtraReports.UI

Namespace BindWebReportToArrayList
    Partial Public Class _Default
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport = CreateReport()
            documentViewer.OpenReport(report)
        End Sub

        Protected Overrides Sub OnInit(ByVal e As EventArgs)
            MyBase.OnInit(e)
            Dim report As XtraReport = CreateReport()
            documentViewer.OpenReport(report)
        End Sub

        Private Function CreateReport() As XtraReport
            ' Create a list.
            Dim listDataSource As New ArrayList()

            ' Populate the list with records.
            listDataSource.Add(New Record(1, "Jane", 19))
            listDataSource.Add(New Record(2, "Joe", 30))
            listDataSource.Add(New Record(3, "Bill", 15))
            listDataSource.Add(New Record(4, "Michael", 42))

            ' Create a report.
            Dim report As New XtraReport1()

            ' Bind the report to the list.
            report.DataSource = listDataSource

            ' Add bounded labels to the Detail band of the report.
            report.AddBoundLabel("ID", New Rectangle(100, 20, 100, 30))
            report.AddBoundLabel("Name", New Rectangle(200, 20, 100, 30))
            report.AddBoundLabel("Age", New Rectangle(300, 20, 100, 30))

            Return report
        End Function
    End Class
End Namespace
