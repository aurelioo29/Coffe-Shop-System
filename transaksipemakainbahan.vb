Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft

Public Class transaksipemakainbahan
    Dim query As String
    Dim conn As New SqlConnection

    Public Sub connect()
        conn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True"
    End Sub
    Public Sub clear()
        txtid.Text = PemakaianAutocode("pemakaian", Now.Date)
        cbonama.Text = ""
        txtjumlah.Text = ""
        txtketerangan.Text = ""
    End Sub
    Sub namabahan()
        Dim cmdOpen As New SqlCommand

        cbonama.Items.Clear()

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        cmdOpen.Connection = conn
        query = "SELECT * FROM PembelianBahan"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        Do While drOpen.Read
            cbonama.Items.Add(drOpen.Item(4))
        Loop
    End Sub
    Public Sub dgv()
        Dim cmdOpen As New SqlCommand

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn

        query = "SELECT * FROM PemakaianBahan ORDER BY id_pemakaian"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        DataGridView1.Rows.Clear()
        If drOpen.HasRows.ToString Then
            While drOpen.Read
                DataGridView1.Rows.Add(drOpen("id_pemakaian").ToString, drOpen("nama_bahan").ToString, drOpen("qty").ToString, drOpen("keterangan").ToString, drOpen("tanggal").ToString)
            End While
        End If
        drOpen.Close()
        conn.Close()
    End Sub
    Private Sub transaksipemakainbahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        clear()
        dgv()
        cbonama.Select()
        namabahan()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        Me.Hide()
        menuutama.Show()
    End Sub

    Private Sub btnpower_Click(sender As Object, e As EventArgs) Handles btnpower.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
        cbonama.Select()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim cmdOpen As New SqlCommand

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn
        query = "SELECT * FROM PemakaianBahan WHERE id_pemakaian = '" & Trim(txtid.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        If drOpen.HasRows Then
            query = "UPDATE PemakaianBahan SET " &
                    "nama_bahan = '" & Trim(cbonama.Text) & "'," &
                    "qty = '" & Trim(txtjumlah.Text) & "'," &
                    "keterangan = '" & Trim(txtketerangan.Text) & "'," &
                    "tanggal = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'" &
                    "WHERE id_pemakaian = '" & Trim(txtid.Text) & "'"
        Else
            query = "INSERT INTO PemakaianBahan VALUES('" & Trim(txtid.Text) & "', 
                    '" & Trim(cbonama.Text) & "',
                    '" & Trim(txtjumlah.Text) & "',
                    '" & Trim(txtketerangan.Text) & "',
                    '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
        End If
        drOpen.Close()
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        'UPDATE STOK DI FORM MENU
        Using cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True ; Encrypt=False"

            Using cmdX As New SqlCommand
                cnn.Open()
                cmdX.Connection = cnn
                query = "SELECT * FROM Pemakaianbahan WHERE id_pemakaian = '" & Trim(txtid.Text) & "'"
                cmdX.CommandText = query
                cmdX.ExecuteNonQuery()

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read
                            cmdOpen.CommandText = "UPDATE PembelianBahan SET qty = qty - " & drX("qty") &
                                                  "WHERE nama_barang = '" & drX("nama_bahan") & "'"
                            cmdOpen.ExecuteNonQuery()
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using

        conn.Close()
        MessageBox.Show("Data berhasil disimpan ke database !!!")
        clear()
        dgv()
        cbonama.Select()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MessageBox.Show("Konfirmasi di Hapus dari Database ?", "Ok", MessageBoxButtons.OKCancel) = vbOK Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn
            query = "DELETE FROM PemakaianBahan WHERE id_pemakaian = '" & Trim(txtid.Text) & "'"
            cmdOpen.CommandText = query
            cmdOpen.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data telah di hapus dari database !!!")
            clear()
            dgv()
            txtid.Select()
        End If
    End Sub

    Private Sub txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If

        Dim cmdOpen As New SqlCommand
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn

        query = "SELECT * FROM PembelianBahan WHERE nama_barang = '" & Trim(cbonama.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        If drOpen.HasRows Then
            While drOpen.Read
                If (e.KeyChar = Chr(13)) Then
                    If txtjumlah.Text = "" Then
                        MessageBox.Show("Isi terlebih dahulu qty yang di inginkan!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf txtjumlah.Text = 0 Then
                        MessageBox.Show("Qty yang di inginkan tidak boleh kosong!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf CInt(Trim(txtjumlah.Text)) > CInt(drOpen("qty")) Then
                        MessageBox.Show("Qty tidak mencukupi stok yang ada!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        txtid.Text = ""
                        cbonama.Text = ""
                        txtjumlah.Text = ""
                        txtketerangan.Text = ""
                        cbonama.Focus()
                    End If
                End If
            End While
        End If
    End Sub

    Private Sub txtid_LostFocus(sender As Object, e As EventArgs) Handles txtid.LostFocus
        If Trim(txtid.Text) <> "" Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn

            query = "SELECT * FROM PemakaianBahan WHERE id_pemakaian = '" & Trim(txtid.Text) & "'"
            cmdOpen.CommandText = query

            Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
            If drOpen.HasRows Then
                While drOpen.Read
                    txtid.Text = drOpen("id_pemakaian").ToString
                    cbonama.Text = drOpen("nama_bahan").ToString
                    txtjumlah.Text = drOpen("qty").ToString
                    txtketerangan.Text = (drOpen("keterangan")).ToString
                    DateTimePicker1.Text = (drOpen("tanggal")).ToString
                End While
            Else
                'clear()
                cbonama.Focus()
            End If
            drOpen.Close()
        End If
    End Sub
End Class