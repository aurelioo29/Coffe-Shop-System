Imports System.Data
Imports System.Data.SqlClient
Public Class mastersupplier
    Dim query As String
    Dim conn As New SqlConnection
    Public Sub connect()
        conn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True"
    End Sub
    Public Sub data()
        Dim cmdOpen As New SqlCommand

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn

        query = "SELECT * FROM Supplier ORDER BY id_supplier"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        DataGridView1.Rows.Clear()

        If drOpen.HasRows.ToString Then
            While drOpen.Read
                DataGridView1.Rows.Add(drOpen("id_supplier").ToString, drOpen("nama").ToString, drOpen("kota").ToString, drOpen("alamat").ToString, drOpen("nomor_hp").ToString, drOpen("keterangan").ToString)
            End While
        End If
        drOpen.Close()
        conn.Close()
    End Sub
    Sub clear()
        txtid.Text = SupplierAutocode("supplier", Now.Date)
        txtnama.Text = ""
        txtkota.Text = ""
        txtalamat.Text = ""
        txthp.Text = ""
        txtketerangan.Text = ""
    End Sub

    Private Sub mastersupplier_load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        clear()
        data()
        txtnama.Select()
    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    Me.Hide()
    '    login.Show()
    'End Sub
    '
    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    Menu.Show()
    '    Me.Close()
    'End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
        txtnama.Select()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim cmdOpen As New SqlCommand

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn
        query = "SELECT * FROM Supplier WHERE id_supplier = '" & Trim(txtid.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        If drOpen.HasRows Then
            query = "UPDATE Supplier SET " &
                    "nama = '" & Trim(txtnama.Text) & "'," &
                    "kota = '" & Trim(txtkota.Text) & "'," &
                    "alamat = '" & Trim(txtalamat.Text) & "'," &
                    "nomor_hp = '" & Trim(txthp.Text) & "'," &
                    "keterangan = '" & Trim(txtketerangan.Text) & "'" &
                    "WHERE id_supplier = '" & Trim(txtid.Text) & "'"
        Else
            query = "INSERT INTO Supplier VALUES('" & Trim(txtid.Text) & "', 
                    '" & Trim(txtnama.Text) & "',
                    '" & Trim(txtkota.Text) & "', 
                    '" & Trim(txtalamat.Text) & "', 
                    '" & Trim(txthp.Text) & "',
                    '" & Trim(txtketerangan.Text) & "')"
        End If
        drOpen.Close()
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Data berhasil disimpan ke database !!!")
        clear()
        data()
        txtnama.Select()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MessageBox.Show("Konfirmasi di Hapus dari Database ?", "Ok", MessageBoxButtons.OKCancel) = vbOK Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn
            query = "DELETE FROM Supplier WHERE id_supplier = '" & Trim(txtid.Text) & "'"
            cmdOpen.CommandText = query
            cmdOpen.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data telah di hapus dari database !!!")
            clear()
            data()
            txtnama.Select()
        End If
    End Sub

    Private Sub mastersupplier_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        txtnama.Select()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn = Nothing
    End Sub

    Private Sub mastersupplier_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        txtnama.Select()
    End Sub

    Private Sub txthp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthp.KeyPress
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtid_LostFocus(sender As Object, e As EventArgs) Handles txtid.LostFocus
        If Trim(txtid.Text) <> "" Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn

            query = "SELECT * FROM Supplier WHERE id_supplier = '" & Trim(txtid.Text) & "'"
            cmdOpen.CommandText = query

            Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
            If drOpen.HasRows Then
                While drOpen.Read
                    txtid.Text = drOpen("id_supplier").ToString
                    txtnama.Text = drOpen("nama").ToString
                    txtkota.Text = drOpen("kota").ToString
                    txtalamat.Text = drOpen("alamat").ToString
                    txthp.Text = (drOpen("nomor_hp")).ToString
                    txtketerangan.Text = (drOpen("keterangan")).ToString
                End While
            Else
                'clear()
                txtnama.Select()
            End If
            drOpen.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        menuutama.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        login.Show()
    End Sub
End Class
