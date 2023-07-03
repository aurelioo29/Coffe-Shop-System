Imports System.Data
Imports System.Data.SqlClient

Public Class masterpengguna
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

        query = "SELECT * FROM Pengguna ORDER BY id_pengguna"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        DataGridView1.Rows.Clear()

        If drOpen.HasRows.ToString Then
            While drOpen.Read
                DataGridView1.Rows.Add(drOpen("id_pengguna").ToString, drOpen("username"), drOpen("password"), drOpen("jabatan"))
            End While
        End If
        drOpen.Close()
        conn.Close()
    End Sub
    Sub clear()
        txtId.Text = ""
        txtUsername.Text = ""
        txtPw.Text = ""
        txtJabatan.Text = ""
    End Sub
    Private Sub masterpengguna_load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        dgv()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
        txtId.Select()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Yakin datanya ingin dihapus dari database ?", "Konfirmasi", MessageBoxButtons.OKCancel) = vbOK Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn

            query = "DELETE FROM Pengguna WHERE id_pengguna = '" & Trim(txtId.Text) & "'"
            cmdOpen.CommandText = query
            cmdOpen.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data tersebut telah dihapus dari database !!!")
            clear()
            txtId.Select()
            dgv()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        login.Show()
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim cmdOpen As New SqlCommand

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn

        query = "SELECT * FROM Pengguna WHERE id_pengguna = '" & Trim(txtId.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        If drOpen.HasRows Then
            query = "UPDATE Pengguna SET " &
                    "username= '" & Trim(txtUsername.Text) & "'," &
                    "password= '" & Trim(txtPw.Text) & "'," &
                    "jabatan= '" & Trim(txtJabatan.Text) & "'" &
                    "WHERE id_pengguna = '" & Trim(txtId.Text) & "'"
        Else
            query = "INSERT INTO Pengguna VALUES ('" & Trim(txtId.Text) & "',
                    '" & Trim(txtUsername.Text) & "', 
                    '" & Trim(txtPw.Text) & "',
                    '" & Trim(txtJabatan.Text) & "')"
        End If
        drOpen.Close()
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        conn.Close()

        MessageBox.Show("Data berhasil disimpan kedalam database !!!")
        clear()
        dgv()
        txtId.Select()
    End Sub
    Private Sub masterpengguna_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        txtId.Select()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn = Nothing
    End Sub

    Private Sub masterpengguna_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        txtUsername.Select()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        menuutama.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        menuutama.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()
    End Sub
    Private Sub txtid_LostFocus(sender As Object, e As EventArgs) Handles txtId.LostFocus
        If Trim(txtId.Text) <> "" Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn

            query = "SELECT * FROM Pengguna WHERE id_pengguna = '" & Trim(txtId.Text) & "'"
            cmdOpen.CommandText = query

            Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
            If drOpen.HasRows Then
                While drOpen.Read
                    txtId.Text = drOpen("id_pengguna").ToString
                    txtUsername.Text = drOpen("username").ToString
                    txtPw.Text = drOpen("password").ToString
                    txtJabatan.Text = drOpen("jabatan").ToString
                End While
            Else
                'clear()
                txtUsername.Focus()
            End If
            drOpen.Close()
        End If
    End Sub
End Class