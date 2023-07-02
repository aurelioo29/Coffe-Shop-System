Imports System.Data
Imports System.Data.SqlClient

Public Class mastermenu1
    Dim query As String
    Dim conn As New SqlConnection
    Public Sub connect()
        conn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True"
    End Sub
    Public Sub dgv()
        Dim cmdOpen As New SqlCommand

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn

        query = "SELECT * FROM Menu ORDER BY id_menu"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        DataGridView1.Rows.Clear()

        If drOpen.HasRows.ToString Then
            While drOpen.Read
                DataGridView1.Rows.Add(drOpen("id_menu").ToString, drOpen("nama"), drOpen("kategori"), drOpen("stok"), drOpen("harga"))
            End While
        End If
        drOpen.Close()
        conn.Close()
    End Sub

    Sub clear()
        txtid.Text = MenuAutocode("menu", Now.Date)
        txtnama.Text = ""
        txtkategori.Text = ""
        txtstok.Text = ""
        txtharga.Text = ""
        txtgambar.Text = ""
        PictureBox1.Image = Nothing
    End Sub
    Private Sub mastermenu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        clear()
        dgv()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Me.Hide()
    '    login.Show()
    'End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
        txtnama.Select()
    End Sub
    Private Sub mastermenu1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        txtnama.Select()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn = Nothing
    End Sub
    Private Sub mastermenu1_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        txtnama.Select()
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MessageBox.Show("Yakin datanya ingin dihapus dari database ?", "Konfirmasi", MessageBoxButtons.OKCancel) = vbOK Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn

            query = "DELETE FROM Menu WHERE id_menu = '" & Trim(txtid.Text) & "'"
            cmdOpen.CommandText = query
            cmdOpen.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data tersebut telah dihapus dari database !!!")
            clear()
            dgv()
            txtnama.Select()
        End If
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim cmdOpen As New SqlCommand

        If txtnama.Text = "" Then
            MessageBox.Show("Harap isi Nama Barang dengan Valid !!!")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn

        query = "SELECT * FROM Menu WHERE id_menu = '" & Trim(txtid.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        If drOpen.HasRows Then
            query = "UPDATE Menu SET " &
                    "nama= '" & Trim(txtnama.Text) & "'," &
                    "kategori= '" & Trim(txtkategori.Text) & "'," &
                    "stok= " & CInt(Trim(txtstok.Text)) & "," &
                    "harga = " & CDbl(Trim(txtharga.Text)) & "," &
                    "gambar= '" & Trim(txtgambar.Text) & "'" &
                    "WHERE id_menu = '" & Trim(txtid.Text) & "'"
        Else
            query = "INSERT INTO Menu VALUES ('" & Trim(txtid.Text) & "',
                    '" & Trim(txtnama.Text) & "', 
                    '" & Trim(txtkategori.Text) & "', 
                    " & CInt(Trim(txtstok.Text)) & ",
                    " & CDbl(Trim(txtharga.Text)) & ",
                    '" & Trim(txtgambar.Text) & "')"
        End If
        drOpen.Close()
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        conn.Close()

        MessageBox.Show("Data berhasil disimpan kedalam database !!!")
        clear()
        dgv()
        txtnama.Select()
    End Sub
    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtgambar.Text = OpenFileDialog1.FileName
        PictureBox1.Load(txtgambar.Text)
    End Sub
    Private Sub txtharga_LostFocus(sender As Object, e As EventArgs) Handles txtharga.LostFocus
        If Not IsNumeric(Trim(txtharga.Text)) Then
            txtharga.Text = 0
        End If
        txtharga.Text = Format(CDec(txtharga.Text), "##,##0.00")
    End Sub
    Private Sub txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtharga.KeyPress
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Me.Hide()
    '    Menu.Show()
    'End Sub

    Private Sub txtstok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstok.KeyPress
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub mastermenu1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
    End Sub
    Private Sub txtid_LostFocus(sender As Object, e As EventArgs) Handles txtid.LostFocus
        If Trim(txtid.Text) <> "" Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn

            query = "SELECT * FROM Menu WHERE id_menu = '" & Trim(txtid.Text) & "'"
            cmdOpen.CommandText = query

            Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
            If drOpen.HasRows Then
                While drOpen.Read
                    txtid.Text = drOpen("id_menu").ToString
                    txtnama.Text = drOpen("nama").ToString
                    txtkategori.Text = drOpen("kategori").ToString
                    txtstok.Text = (drOpen("stok")).ToString
                    txtharga.Text = drOpen("harga").ToString
                    txtgambar.Text = drOpen("gambar").ToString
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
        menu1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        login.Show()
    End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    Me.Hide()
    '    menu1.Show()
    'End Sub

End Class