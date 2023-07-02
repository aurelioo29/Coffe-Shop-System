Imports Microsoft.Reporting.WinForms
Imports projek_uas.PemakaianBahanDataSet
Imports projek_uas.PemakaianBahanDataSetTableAdapters


Public Class laporanpemakaianbahan
    Private Sub laporanpemakaianbahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As New PemakaianBahanDataSet
        Dim adapter As New PemakaianBahanTableAdapter()
        adapter.Fill(dataset.PemakaianBahan)

        ReportViewer1.LocalReport.ReportEmbeddedResource = "projek_uas.PemakaianBahan.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dataset.Tables(0)))

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class