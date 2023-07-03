<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksipenjualan1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaksipenjualan1))
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.txtprint = New System.Windows.Forms.Button()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidbarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtpemesan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbelanja = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sub Harga"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(8, 58)
        Me.txtbayar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(207, 22)
        Me.txtbayar.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox3.Controls.Add(Me.btnkembali)
        Me.GroupBox3.Controls.Add(Me.txtkembali)
        Me.GroupBox3.Location = New System.Drawing.Point(745, 512)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(225, 123)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'btnkembali
        '
        Me.btnkembali.BackColor = System.Drawing.Color.DarkOrange
        Me.btnkembali.Location = New System.Drawing.Point(7, 84)
        Me.btnkembali.Margin = New System.Windows.Forms.Padding(4)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(209, 28)
        Me.btnkembali.TabIndex = 23
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = False
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(8, 38)
        Me.txtkembali.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(207, 22)
        Me.txtkembali.TabIndex = 0
        '
        'btnclear
        '
        Me.btnclear.BackgroundImage = CType(resources.GetObject("btnclear.BackgroundImage"), System.Drawing.Image)
        Me.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclear.Location = New System.Drawing.Point(825, 642)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(60, 55)
        Me.btnclear.TabIndex = 79
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'txtprint
        '
        Me.txtprint.BackgroundImage = CType(resources.GetObject("txtprint.BackgroundImage"), System.Drawing.Image)
        Me.txtprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtprint.Location = New System.Drawing.Point(911, 642)
        Me.txtprint.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprint.Name = "txtprint"
        Me.txtprint.Size = New System.Drawing.Size(60, 55)
        Me.txtprint.TabIndex = 78
        Me.txtprint.UseVisualStyleBackColor = True
        '
        'btnhitung
        '
        Me.btnhitung.BackColor = System.Drawing.Color.DarkOrange
        Me.btnhitung.Location = New System.Drawing.Point(368, 106)
        Me.btnhitung.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(75, 28)
        Me.btnhitung.TabIndex = 25
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = False
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.Color.PeachPuff
        Me.label11.Location = New System.Drawing.Point(244, 87)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(85, 16)
        Me.label11.TabIndex = 67
        Me.label11.Text = "Total Barang"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(227, 106)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(132, 22)
        Me.txttotal.TabIndex = 64
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.PeachPuff
        Me.label10.Location = New System.Drawing.Point(68, 87)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(90, 16)
        Me.label10.TabIndex = 66
        Me.label10.Text = "Harga Satuan"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.PeachPuff
        Me.Label.Location = New System.Drawing.Point(391, 31)
        Me.Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(27, 16)
        Me.Label.TabIndex = 65
        Me.Label.Text = "Qty"
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(51, 106)
        Me.txtharga.Margin = New System.Windows.Forms.Padding(4)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(132, 22)
        Me.txtharga.TabIndex = 63
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(344, 50)
        Me.txtqty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(132, 22)
        Me.txtqty.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(654, 70)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Penjualan Coffe Shop"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.btnhitung)
        Me.GroupBox4.Controls.Add(Me.label11)
        Me.GroupBox4.Controls.Add(Me.txtidbarang)
        Me.GroupBox4.Controls.Add(Me.txttotal)
        Me.GroupBox4.Controls.Add(Me.label10)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label)
        Me.GroupBox4.Controls.Add(Me.txtharga)
        Me.GroupBox4.Controls.Add(Me.txtnama)
        Me.GroupBox4.Controls.Add(Me.txtqty)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(517, 145)
        Me.GroupBox4.TabIndex = 81
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detail BARANG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Barang"
        '
        'txtidbarang
        '
        Me.txtidbarang.Location = New System.Drawing.Point(8, 50)
        Me.txtidbarang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtidbarang.Name = "txtidbarang"
        Me.txtidbarang.Size = New System.Drawing.Size(132, 22)
        Me.txtidbarang.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PeachPuff
        Me.Label2.Location = New System.Drawing.Point(189, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama Barang"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(169, 50)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(132, 22)
        Me.txtnama.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.PeachPuff
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(173, 86)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 69)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "="
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(12, 703)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 49)
        Me.Button1.TabIndex = 83
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox2.Controls.Add(Me.txtbayar)
        Me.GroupBox2.Location = New System.Drawing.Point(745, 382)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(225, 123)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Harga Satuan"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(73, 703)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 49)
        Me.Button2.TabIndex = 84
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.BackgroundImage = CType(resources.GetObject("btnsave.BackgroundImage"), System.Drawing.Image)
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Location = New System.Drawing.Point(745, 642)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(60, 55)
        Me.btnsave.TabIndex = 73
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 17)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nama Pelayan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 55)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ID Penjualan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tanggal/Bulan/Tahun"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(169, 17)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(244, 24)
        Me.ComboBox1.TabIndex = 16
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(169, 50)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(245, 22)
        Me.txtid.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(169, 82)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(244, 22)
        Me.DateTimePicker1.TabIndex = 19
        '
        'txtpemesan
        '
        Me.txtpemesan.Location = New System.Drawing.Point(169, 114)
        Me.txtpemesan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpemesan.Name = "txtpemesan"
        Me.txtpemesan.Size = New System.Drawing.Size(244, 22)
        Me.txtpemesan.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nama Pemesan"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox1.Controls.Add(Me.txtbelanja)
        Me.GroupBox1.Location = New System.Drawing.Point(745, 251)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(225, 123)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtbelanja
        '
        Me.txtbelanja.AutoSize = True
        Me.txtbelanja.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbelanja.Location = New System.Drawing.Point(0, 79)
        Me.txtbelanja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtbelanja.Name = "txtbelanja"
        Me.txtbelanja.Size = New System.Drawing.Size(0, 39)
        Me.txtbelanja.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 251)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(725, 447)
        Me.DataGridView1.TabIndex = 76
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Barang"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Qty"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.ComboBox1)
        Me.GroupBox5.Controls.Add(Me.txtid)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox5.Controls.Add(Me.txtpemesan)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(537, 98)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(433, 144)
        Me.GroupBox5.TabIndex = 82
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detail PENJUALAN"
        '
        'transaksipenjualan1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(988, 757)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.txtprint)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "transaksipenjualan1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "transaksipenjualan1"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnkembali As Button
    Friend WithEvents txtkembali As TextBox
    Friend WithEvents btnclear As Button
    Friend WithEvents txtprint As Button
    Friend WithEvents btnhitung As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents label11 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents label10 As Label
    Friend WithEvents Label As Label
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidbarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtpemesan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbelanja As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As GroupBox
End Class
