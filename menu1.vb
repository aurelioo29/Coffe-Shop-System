Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class menu1
    Private Sub menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MASTER
        PenggunaToolStripMenuItem.Enabled = False
        MenuToolStripMenuItem.Enabled = True
        SupplierToolStripMenuItem.Enabled = False

        'TRANSAKI
        PenjualanToolStripMenuItem.Enabled = True
        PembelianPeralatanToolStripMenuItem.Enabled = False
        PembelianBahanBakuToolStripMenuItem.Enabled = False
        PemakaianBahanBakuToolStripMenuItem.Enabled = False

        'LAPORAN
        PenjualanToolStripMenuItem1.Enabled = False
        PembelianBahanBakuToolStripMenuItem1.Enabled = False
        PembelianPeralatanToolStripMenuItem1.Enabled = False
        PemakaianBahanBakuToolStripMenuItem1.Enabled = False
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Me.Hide()
        transaksipenjualan1.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Me.Hide()
        mastermenu1.Show()
    End Sub
End Class