Imports System.Data
Imports System.Data.SqlClient

Public Class transaksipembelianperalatan
    Dim query As String
    Dim conn As New SqlConnection
    Public Sub connect()
        conn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True"
    End Sub
    Public Sub dgv()
        'Dim i As Integer
        Dim cmdOpen As New SqlCommand

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn

        query = "SELECT * FROM TransaksiPeralatan ORDER BY id_pembelian"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        DataGridView1.Rows.Clear()

        If drOpen.HasRows.ToString Then
            While drOpen.Read
                DataGridView1.Rows.Add(drOpen("id_pembelian").ToString, drOpen("nama").ToString, drOpen("jumlah").ToString, drOpen("total").ToString, drOpen("tanggal").ToString)
            End While
        End If
        drOpen.Close()
        conn.Close()

    End Sub
    Sub clear()
        txtid.Text = PeralatanAutocode("peralatan", Now.Date)
        txtnama.Text = ""
        txtharga.Text = ""
        txtperjumlah.Text = ""
        txttotal.Text = ""
        DateTimePicker1.Value = Now.Date
    End Sub
    Private Sub transaksipembelianperalatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        clear()
        dgv()
        txtnama.Select()
    End Sub
    Private Sub txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtharga.KeyPress
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtperjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtperjumlah.KeyPress
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtharga_LostFocus(sender As Object, e As EventArgs) Handles txtharga.LostFocus
        If Not IsNumeric(Trim(txtharga.Text)) Then
            txtharga.Text = 0
        End If
        txtharga.Text = Format(CDec(txtharga.Text), "###,##0.00")
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim cmdOpen As New SqlCommand

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn
        query = "SELECT * FROM TransaksiPeralatan WHERE id_pembelian = '" & Trim(txtid.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        If drOpen.HasRows Then
            query = "UPDATE TransaksiPeralatan SET " &
                    "nama = '" & Trim(txtnama.Text) & "'," &
                    "harga = " & CDbl(Trim(txtharga.Text)) & "," &
                    "jumlah = " & CInt(Trim(txtperjumlah.Text)) & "," &
                    "total = " & CDbl(Trim(txttotal.Text)) & "," &
                    "tanggal = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'," &
                    "gambar = '" & Trim(txtgambar.Text) & "'" &
                    "WHERE id_pembelian = '" & Trim(txtid.Text) & "'"
        Else
            query = "INSERT INTO TransaksiPeralatan VALUES('" & Trim(txtid.Text) & "', 
                    '" & Trim(txtnama.Text) & "',
                    " & CDbl(Trim(txtharga.Text)) & ",
                    " & CInt(Trim(txtperjumlah.Text)) & ",
                    " & CDbl(Trim(txttotal.Text)) & ",
                    '" & Trim(txtgambar.Text) & "',
                    '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
        End If
        drOpen.Close()
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Data berhasil disimpan ke database !!!")
        clear()
        dgv()
        txtnama.Select()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MessageBox.Show("Konfirmasi di Hapus dari Database ?", "Ok", MessageBoxButtons.OKCancel) = vbOK Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn
            query = "DELETE FROM TransaksiPeralatan WHERE id_pembelian = '" & Trim(txtid.Text) & "'"
            cmdOpen.CommandText = query
            cmdOpen.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data telah di hapus dari database !!!")
            clear()
            dgv()
            txtnama.Select()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
        txtnama.Select()
    End Sub

    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        Dim bil1, bil2 As Integer

        bil1 = txtharga.Text
        bil2 = txtperjumlah.Text

        txttotal.Text = bil1 * bil2
        txttotal.Text = Format(CDec(txttotal.Text), "###,##0.00")
    End Sub

    Private Sub transaksipembelianperalatan_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub txtbrowse_Click(sender As Object, e As EventArgs) Handles txtbrowse.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtbrowse.Text = OpenFileDialog1.FileName
        PictureBox1.Load(txtbrowse.Text)
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Me.Hide()
    '    login.Show()
    'End Sub
    '
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Me.Hide()
    '    Menu.Show()
    'End Sub
    Private Sub txtid_LostFocus(sender As Object, e As EventArgs) Handles txtid.LostFocus
        If Trim(txtid.Text) <> "" Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn

            query = "SELECT * FROM TransaksiPeralatan WHERE id_pembelian = '" & Trim(txtid.Text) & "'"
            cmdOpen.CommandText = query

            Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
            If drOpen.HasRows Then
                While drOpen.Read
                    txtid.Text = drOpen("id_pembelian").ToString
                    txtnama.Text = drOpen("nama").ToString
                    txtharga.Text = (drOpen("harga")).ToString
                    txtperjumlah.Text = (drOpen("jumlah")).ToString
                    txttotal.Text = (drOpen("total")).ToString
                End While
            Else
                'clear()
                txtnama.Select()
            End If
            drOpen.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        menuutama.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        login.Show()
    End Sub
End Class