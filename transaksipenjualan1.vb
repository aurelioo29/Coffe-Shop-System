Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class transaksipenjualan1
    Dim query As String
    Dim conn As New SqlConnection

    'Struk Print
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim tharga As Long
    Dim tqty As Long
    Dim panjang As Integer

    Dim kode As String
    Dim stok, jumlah, harga, total As Long
    Dim grandtotal, subtotal, kembali, bayar, diskon As Long

    Public Sub connect()
        conn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True"
    End Sub
    Sub input()
        DataGridView1.Rows.Add(txtidbarang.Text, txtnama.Text, txtqty.Text, txtharga.Text, txttotal.Text)
    End Sub
    Sub clearall()
        txtid.Text = PenjualanAutocode("penjualan", Now.Date)
        ComboBox1.Text = ""
        DateTimePicker1.Value = Now.Date
        txtpemesan.Text = ""

        txtidbarang.Text = ""
        txtnama.Text = ""
        txtqty.Text = ""
        txtharga.Text = ""
        txttotal.Text = ""

        txtbelanja.Text = ""
        txtbayar.Text = ""
        txtkembali.Text = ""

        DataGridView1.Rows.Clear()
    End Sub
    Sub cleardetailbarang()
        txtid.Text = PenjualanAutocode("penjualan", Now.Date)
        txtidbarang.Text = ""
        txtnama.Text = ""
        txtqty.Text = ""
        txtharga.Text = ""
        txttotal.Text = ""
    End Sub
    Sub namapengguna()
        Dim cmdOpen As New SqlCommand

        ComboBox1.Items.Clear()

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        cmdOpen.Connection = conn
        query = "SELECT * FROM Pengguna"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

        Do While drOpen.Read
            ComboBox1.Items.Add(drOpen.Item(1))
        Loop
    End Sub

    Private Sub transaksipenjualan1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        clearall()
        namapengguna()
        txtidbarang.Select()
    End Sub
    Private Sub transaksipenjualan1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtnama.Enabled = False
        txtharga.Enabled = False
        txtid.Enabled = False
        txtkembali.Enabled = False
    End Sub


    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If

        Dim cmdOpen As New SqlCommand
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn

        query = "SELECT * FROM Menu WHERE id_menu = '" & Trim(txtidbarang.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        If drOpen.HasRows Then
            While drOpen.Read
                If (e.KeyChar = Chr(13)) Then
                    If txtqty.Text = "" Then
                        MessageBox.Show("Isi terlebih dahulu qty yang di inginkan!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf txtqty.Text = 0 Then
                        MessageBox.Show("Qty yang di inginkan tidak boleh kosong!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf CInt(Trim(txtqty.Text)) > CInt(drOpen("stok")) Then
                        MessageBox.Show("Qty tidak mencukupi stok yang ada!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        txtidbarang.Text = ""
                        txtnama.Text = ""
                        txtqty.Text = ""
                        txtharga.Text = ""
                        txttotal.Text = ""
                        txtidbarang.Focus()
                    End If
                End If
            End While
        End If
    End Sub
    Private Sub hitung()
        Dim xtotal As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            xtotal = xtotal + DataGridView1.Rows(i).Cells(4).Value
        Next
        txtbelanja.Text = Format(xtotal)
    End Sub

    Private Sub txtbayar_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> Asc(vbBack) Then
            If Asc(e.KeyChar) < Asc(0) Or Asc(e.KeyChar) > Asc(9) Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtbayar_LostFocus(sender As Object, e As EventArgs)
        If Not IsNumeric(Trim(txtharga.Text)) Then
            txtharga.Text = 0
        End If
        'txtharga.Text = Format(CDec(txtharga.Text), "##,##0.00")
    End Sub
    '================================[ PRINT AREA ]================================
    Sub ubahpanjang()
        Dim rowcount As Integer
        panjang = 0
        rowcount = DataGridView1.Rows.Count
        panjang = rowcount * 15
        panjang = panjang + 200
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        menu1.Show()
    End Sub

    Private Sub txtprint_Click(sender As Object, e As EventArgs) Handles txtprint.Click
        ubahpanjang()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clearall()
        txtidbarang.Select()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        txtkembali.Text = Val(txtbayar.Text) - Val(txtbelanja.Text)

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtpemesan.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Harap cek nama 'PELAYAN' dan nama 'PEMESAN' tidak boleh kosong !!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim cmdOpen As New SqlCommand

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn
        query = "SELECT * FROM Penjualan WHERE id_penjualan = '" & Trim(txtid.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        If drOpen.HasRows Then
            query = "UPDATE Penjualan SET " &
                    "pengguna = '" & Trim(ComboBox1.Text) & "'," &
                    "tanggal = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'," &
                    "pemesan = '" & Trim(txtpemesan.Text) & "'," &
                    "id_menu = '" & Trim(txtidbarang.Text) & "'," &
                    "qty = " & CInt(Trim(txtqty.Text)) & "," &
                    "harga = " & CDbl(Trim(txtharga.Text)) & "," &
                    "total = " & CDbl(Trim(txttotal.Text)) & "," &
                    "bayar = " & CDbl(Trim(txtbayar.Text)) & "," &
                    "kembali = " & CDbl(Trim(txtkembali.Text)) &
                    "WHERE id_penjualan = '" & Trim(txtid.Text) & "'"
        Else
            query = "INSERT INTO Penjualan VALUES('" & Trim(txtid.Text) & "', 
                    '" & Trim(ComboBox1.Text) & "',
                    '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "',
                    '" & Trim(txtpemesan.Text) & "',
                    '" & Trim(txtidbarang.Text) & "', 
                    " & CInt(Trim(txtqty.Text)) & ", 
                    " & CDbl(Trim(txtharga.Text)) & ",
                    " & CDbl(Trim(txttotal.Text)) & ",
                    " & CDbl(Trim(txtbayar.Text)) & ",
                    " & CDbl(Trim(txtkembali.Text)) & ")"
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
                query = "SELECT * FROM Penjualan WHERE id_penjualan = '" & Trim(txtid.Text) & "'"
                cmdX.CommandText = query
                cmdX.ExecuteNonQuery()

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read
                            cmdOpen.CommandText = "UPDATE Menu SET stok = stok - " & drX("qty") &
                                                  "WHERE id_menu = '" & drX("id_menu") & "'"
                            cmdOpen.ExecuteNonQuery()
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using

        conn.Close()
        MessageBox.Show("Data berhasil disimpan ke database !!!")
        cleardetailbarang()
        txtidbarang.Select()
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        txttotal.Text = Val(txtqty.Text) * Val(txtharga.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        login.Show()
    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, panjang)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "--------------------------------------------------------------------------------------"

        e.Graphics.DrawString("Nama Toko", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl. Gatot Subroto No.34", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("HP: (061) 390777", f14, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)

        e.Graphics.DrawString(Format(Today, "dd-MM-yyyy"), f10, Brushes.Black, 0, 90)
        e.Graphics.DrawString(Format(TimeOfDay), f10, Brushes.Black, rightmargin, 90, kanan)

        e.Graphics.DrawString("Order Name", f10, Brushes.Black, 0, 60)
        'e.Graphics.DrawString(":", f10, Brushes.Black, 65, 60)
        e.Graphics.DrawString(txtpemesan.Text, f10, Brushes.Black, rightmargin, 60, kanan)

        e.Graphics.DrawString("Cashier Name", f10, Brushes.Black, 0, 75)
        'e.Graphics.DrawString(":", f10, Brushes.Black, 65, 75)
        e.Graphics.DrawString(ComboBox1.Text, f10, Brushes.Black, rightmargin, 75, kanan)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)

        DataGridView1.AllowUserToAddRows = False

        Dim tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To DataGridView1.Rows.Count - 1
            tinggi += 15
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 0, 100 + tinggi)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 25, 100 + tinggi)
            i = DataGridView1.Rows(baris).Cells(4).Value
            DataGridView1.Rows(baris).Cells(4).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, rightmargin, 100 + tinggi, kanan)
        Next

        tinggi = 110 + tinggi
        hitungprint()

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, tinggi)

        e.Graphics.DrawString("Total : " & Format(tharga, "##,##0"), f10, Brushes.Black, rightmargin, 10 + tinggi, kanan)
        e.Graphics.DrawString(tqty, f10, Brushes.Black, 0, 10 + tinggi)

        e.Graphics.DrawString("Notes", f10, Brushes.Black, centermargin, 45 + tinggi, tengah)
        e.Graphics.DrawString("Thank You and Always Coffe", f10, Brushes.Black, centermargin, 60 + tinggi, tengah)
    End Sub
    Sub hitungprint()
        Dim hitung As Long = 0
        For baris As Long = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(baris).Cells(4).Value
        Next
        tharga = hitung

        Dim hitungqty As Long = 0
        For baris As Long = 0 To DataGridView1.Rows.Count - 1
            hitungqty = hitungqty + DataGridView1.Rows(baris).Cells(2).Value
        Next
        tqty = hitungqty
    End Sub

    Private Sub txtidbarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidbarang.KeyPress
        If (e.KeyChar = Chr(13)) Then
            If txtidbarang.Text = "" Then
                MessageBox.Show("Isi terlebih dahulu Id Barang!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim cmdOpen As New SqlCommand

                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                cmdOpen.Connection = conn

                query = "SELECT * FROM Menu WHERE id_menu = '" & txtidbarang.Text & "'"
                cmdOpen.CommandText = query
                cmdOpen.ExecuteNonQuery()

                Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader

                If drOpen.Read Then
                    kode = drOpen.Item("id_menu")
                    txtnama.Text = drOpen.Item("nama")
                    txtqty.Text = drOpen.Item("stok")
                    jumlah = 1
                    'txtharga.Text = drOpen.Item("harga")
                    harga = drOpen.Item("harga")
                    'txttotal.Text = jumlah * harga
                    total = jumlah * harga

                    txtqty.Text = jumlah
                    txtharga.Text = harga
                    txttotal.Text = total

                    txtqty.Focus()
                Else
                    MessageBox.Show("Id Barang tersebut tidak ada di dalam database!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtidbarang.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub GroupBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles GroupBox4.MouseClick
        input()
        hitung()
    End Sub

    'Private Sub btnpower_Click(sender As Object, e As EventArgs) Handles btnpower.Click
    '    login.Show()
    '    Me.Close()
    'End Sub
    '
    'Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
    '    Menu.Show()
    '    Me.Close()
    'End Sub
End Class