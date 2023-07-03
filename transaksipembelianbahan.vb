Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class transaksipembelianbahan
    Dim query As String
    Dim conn As New SqlConnection
    Dim pilihan As String
    Public Sub connect()
        conn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True ; Encrypt=False"
    End Sub
    Public Sub dgv()
        Dim cmdOpen As New SqlCommand

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn

        query = "SELECT * FROM PembelianBahan ORDER BY id_pembeli"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        DataGridView1.Rows.Clear()

        If drOpen.HasRows.ToString Then
            While drOpen.Read
                DataGridView1.Rows.Add(drOpen("nama_barang").ToString, drOpen("qty").ToString, drOpen("harga").ToString, drOpen("total").ToString)
            End While
        End If
        drOpen.Close()
        conn.Close()
    End Sub
    Sub idsupplier()
        Dim cmdOpen As New SqlCommand

        cboid.Items.Clear()

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        cmdOpen.Connection = conn
        query = "SELECT * FROM Supplier"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        Do While drOpen.Read
            cboid.Items.Add(drOpen.Item(0))
        Loop
    End Sub
    Sub namasupplier()
        Dim cmdOpen As New SqlCommand

        cbonama.Items.Clear()

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        cmdOpen.Connection = conn
        query = "SELECT * FROM Supplier"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        Do While drOpen.Read
            cbonama.Items.Add(drOpen.Item(1))
        Loop
    End Sub
    Sub kontak()
        Dim cmdOpen As New SqlCommand

        cbokontak.Items.Clear()

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        cmdOpen.Connection = conn
        query = "SELECT * FROM Supplier"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        Do While drOpen.Read
            cbokontak.Items.Add(drOpen.Item(4))
        Loop
    End Sub
    Public Sub clear()
        'DATA SUPPLIER
        cbonama.Text = ""
        cboid.Text = ""
        cbokontak.Text = ""

        'DATA PEMBELIAN
        txtid.Text = BahanAutocode("bahan", Now.Date)
        txtnamabarang.Text = ""
        txtqty.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""

        'DATA HUTANG
        totalhutang.Text = ""
        dibayarhutang.Text = ""
        sisahutang.Text = ""
        bungahutang.Text = ""
        jumlahbunga.Text = ""
        jumlahhutang.Text = ""

        rd1.Checked = False
        rd2.Checked = False

    End Sub
    Private Sub transaksipembelianbahan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        clear()
        dgv()
        GroupBox1.Visible = False

        'DATA SUPPLIER
        idsupplier()
        namasupplier()
        kontak()
    End Sub

    Private Sub rd1_CheckedChanged(sender As Object, e As EventArgs) Handles rd1.CheckedChanged
        GroupBox1.Hide()
    End Sub

    Private Sub rd2_CheckedChanged(sender As Object, e As EventArgs) Handles rd2.CheckedChanged
        GroupBox1.Show()
        totalhutang.Text = txtjumlah.Text
        'totalhutang.Text = Format(CDec(totalhutang.Text), "##,##0.00")
    End Sub

    Private Sub tglbayar_ValueChanged(sender As Object, e As EventArgs) Handles tglbayar.ValueChanged
        If Format(tglbayar.Value, "yyyy-MM-dd") > Format(tgltempo.Value, "yyyy-MM-dd") Then
            MessageBox.Show("Anda telah membayar hutang melewati jatuh tempo !!!")
            jumlahhutang.Text = Val(jumlahbunga.Text) + Val(sisahutang.Text)
        Else
            MessageBox.Show("Anda telah membayar hutang tepat waktu !!!")
            jumlahhutang.Text = sisahutang.Text
        End If
    End Sub

    Private Sub btnhutang_Click(sender As Object, e As EventArgs) Handles btnhutang.Click
        jumlahbunga.Text = Val(sisahutang.Text) * Val(bungahutang.Text / 100)
    End Sub

    Private Sub transaksipembelianbahan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        jumlahbunga.Enabled = False
        jumlahhutang.Enabled = False
        totalhutang.Enabled = False
    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtharga.KeyPress
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub dibayarhutang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dibayarhutang.KeyPress
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub sisahutang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sisahutang.KeyPress
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub bungahutang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bungahutang.KeyPress
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub btnpembeli_Click(sender As Object, e As EventArgs) Handles btnpembeli.Click
        txtjumlah.Text = Val(txtqty.Text) * Val(txtharga.Text)
    End Sub

    Private Sub txtharga_LostFocus(sender As Object, e As EventArgs) Handles txtharga.LostFocus
        If Not IsNumeric(Trim(txtharga.Text)) Then txtharga.Text = 0
        txtjumlah.Text = Val(txtqty.Text) * Val(txtharga.Text)
    End Sub
    Private Sub dibayarhutang_LostFocus(sender As Object, e As EventArgs) Handles dibayarhutang.LostFocus
        If Not IsNumeric(Trim(dibayarhutang.Text)) Then dibayarhutang.Text = 0
    End Sub
    Private Sub sisahutang_LostFocus(sender As Object, e As EventArgs) Handles sisahutang.LostFocus
        If Not IsNumeric(Trim(sisahutang.Text)) Then sisahutang.Text = 0
    End Sub

    Private Sub btnpower_Click(sender As Object, e As EventArgs) Handles btnpower.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        Me.Hide()
        menuutama.Show()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
        cboid.Focus()
        GroupBox1.Visible = False
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim cmdOpen As New SqlCommand

        If rd1.Checked = True Then
            pilihan = rd1.Text
        ElseIf rd2.Checked = True Then
            pilihan = rd2.Text
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn

        query = "SELECT * FROM PembelianBahan WHERE id_supplier = '" & Trim(cboid.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        If drOpen.HasRows Then
            query = "UPDATE PembelianBahan SET " &
                    "nama_supplier= '" & Trim(cbonama.Text) & "'," &
                    "kontak= '" & Trim(cbokontak.Text) & "'," &
                    "id_pembeli = '" & Trim(txtid.Text) & "'," &
                    "nama_barang = '" & Trim(txtnamabarang.Text) & "'," &
                    "qty = '" & Trim(txtqty.Text) & "'," &
                    "harga = '" & Trim(txtharga.Text) & "'," &
                    "total = '" & Trim(txtjumlah.Text) & "'," &
                    "tgl_beli = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'," &
                    "status = '" & Trim(pilihan) & "'," &
                    "total_hutang = '" & Trim(totalhutang.Text) & "'," &
                    "bayar_hutang = '" & Trim(dibayarhutang.Text) & "'," &
                    "sisa_hutang = '" & Trim(sisahutang.Text) & "'," &
                    "bunga = '" & Trim(bungahutang.Text) & "'," &
                    "jumlah_bunga = '" & Trim(jumlahbunga.Text) & "'," &
                    "tgl_bayar = '" & Format(tglbayar.Value, "yyyy-MM-dd") & "'," &
                    "tgl_tempo = '" & Format(tgltempo.Value, "yyyy-MM-dd") & "'," &
                    "jumlah_hutang = '" & Trim(jumlahhutang.Text) & "'" &
                    "WHERE id_supplier = '" & Trim(cboid.Text) & "'"
        Else
            query = "INSERT INTO PembelianBahan VALUES ('" & Trim(cboid.Text) & "',
                    '" & Trim(cbonama.Text) & "', 
                    '" & Trim(cbokontak.Text) & "', 
                    '" & Trim(txtid.Text) & "', 
                    '" & Trim(txtnamabarang.Text) & "', 
                    '" & Trim(txtqty.Text) & "',  
                    '" & Trim(txtharga.Text) & "', 
                    '" & Trim(txtjumlah.Text) & "', 
                    '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "', 
                    '" & Trim(pilihan) & "', 
                    '" & Trim(totalhutang.Text) & "', 
                    '" & Trim(dibayarhutang.Text) & "', 
                    '" & Trim(sisahutang.Text) & "', 
                    '" & Trim(bungahutang.Text) & "', 
                    '" & Trim(jumlahbunga.Text) & "', 
                    '" & Format(tglbayar.Value, "yyyy-MM-dd") & "', 
                    '" & Format(tgltempo.Value, "yyyy-MM-dd") & "', 
                    '" & Trim(jumlahhutang.Text) & "')"
        End If
        drOpen.Close()
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        conn.Close()

        MessageBox.Show("Data berhasil disimpan kedalam database !!!")
        clear()
        dgv()
        cboid.Focus()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If MessageBox.Show("Konfirmasi di Hapus dari Database ?", "Ok", MessageBoxButtons.OKCancel) = vbOK Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn
            query = "DELETE FROM PembelianBahan WHERE id_pembeli = '" & Trim(txtid.Text) & "'"
            cmdOpen.CommandText = query
            cmdOpen.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data telah di hapus dari database !!!")
            clear()
            dgv()
            cbonama.Select()
        End If
    End Sub
    Private Sub txtid_LostFocus(sender As Object, e As EventArgs) Handles txtid.LostFocus
        If Trim(txtid.Text) <> "" Then
            Dim cmdOpen As New SqlCommand

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            cmdOpen.Connection = conn

            query = "SELECT * FROM PembelianBahan WHERE id_pembeli = '" & Trim(txtid.Text) & "'"
            cmdOpen.CommandText = query

            Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
            If drOpen.HasRows Then
                While drOpen.Read
                    'DATA SUPPLIER
                    cboid.Text = drOpen("id_supplier").ToString
                    cbonama.Text = drOpen("nama_supplier").ToString
                    cbokontak.Text = drOpen("kontak").ToString

                    'DATA PEMBELI
                    txtid.Text = drOpen("id_pembeli").ToString
                    txtnamabarang.Text = drOpen("nama_barang").ToString
                    txtqty.Text = drOpen("qty").ToString
                    txtharga.Text = drOpen("harga").ToString
                    txtjumlah.Text = drOpen("total").ToString
                    pilihan = drOpen("status").ToString
                    'DateTimePicker1.Text = (drOpen("tgl_beli")).ToString

                    'DATA HUTANG
                    totalhutang.Text = drOpen("total_hutang").ToString
                    dibayarhutang.Text = drOpen("bayar_hutang").ToString
                    sisahutang.Text = drOpen("sisa_hutang").ToString
                    bungahutang.Text = drOpen("bunga").ToString
                    jumlahbunga.Text = drOpen("jumlah_bunga").ToString
                    'tglbayar.Text = (drOpen("tgl_bayar")).ToString
                    'tgltempo.Text = (drOpen("tgl_tempo")).ToString
                    jumlahhutang.Text = drOpen("jumlah_hutang").ToString
                End While
            Else
                'clear()
                cbonama.Focus()
            End If
            drOpen.Close()
        End If
    End Sub

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged

    End Sub

    Private Sub txtqty_LostFocus(sender As Object, e As EventArgs) Handles txtqty.LostFocus
        txtjumlah.Text = Val(txtqty.Text) * Val(txtharga.Text)
    End Sub

End Class