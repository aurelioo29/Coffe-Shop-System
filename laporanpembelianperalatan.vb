Imports Microsoft.Reporting.WinForms
Imports projek_uas.PeralatanDataSet
Imports projek_uas.PeralatanDataSetTableAdapters

Public Class laporanpembelianperalatan
    Private Sub laporanpembelianperalatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As New PeralatanDataSet
        Dim adapter As New TransaksiPeralatanTableAdapter
        adapter.Fill(dataset.TransaksiPeralatan)

        ReportViewer1.LocalReport.ReportEmbeddedResource = "projek_uas.reportpembelianperalatan.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dataset.Tables(0)))

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        menuutama.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        login.Show()
    End Sub
End Class