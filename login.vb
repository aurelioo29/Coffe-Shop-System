Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class login
    Dim conn As New SqlConnection
    Dim query As String
    Public Sub connect()
        conn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True"
    End Sub
    Sub clear()
        txtPw.Text = ""
        txtUser.Text = ""
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        txtPw.UseSystemPasswordChar = True
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Or txtPw.Text = "" Then
            MessageBox.Show("Masukan Username dan Password anda !!!")
        Else
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn
            query = "SELECT * FROM Pengguna WHERE username = '" & Trim(txtUser.Text) & "' and password = '" & Trim(txtPw.Text) & "'"
            cmdOpen.CommandText = query

            Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
            If drOpen.HasRows Then
                If txtPw.Text = "admin" Then
                    menu1.Show()
                    Me.Hide()
                Else txtPw.Text = "manager"
                    menuutama.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Username dan Password yang anda masukan salah !!!")
            End If
        End If
        MessageBox.Show("Login telah Berhasil !!!")
        clear()
        conn.Close()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPw.UseSystemPasswordChar = True Then
            txtPw.UseSystemPasswordChar = False
            'Button1.Text = "Hide"
        Else
            txtPw.UseSystemPasswordChar = True
            'Button1.Text = "Show"
        End If
    End Sub
End Class
