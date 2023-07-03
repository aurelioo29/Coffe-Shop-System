<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuutama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuutama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianPeralatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianBahanBakuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemakaianBahanBakuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianPeralatanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianBahanBakuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemakaianBahanBakuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Tan
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggunaToolStripMenuItem, Me.MenuToolStripMenuItem, Me.SupplierToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.PenggunaToolStripMenuItem.Text = "Pengguna"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.PembelianPeralatanToolStripMenuItem, Me.PembelianBahanBakuToolStripMenuItem, Me.PemakaianBahanBakuToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'PembelianPeralatanToolStripMenuItem
        '
        Me.PembelianPeralatanToolStripMenuItem.Name = "PembelianPeralatanToolStripMenuItem"
        Me.PembelianPeralatanToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.PembelianPeralatanToolStripMenuItem.Text = "Pembelian Peralatan"
        '
        'PembelianBahanBakuToolStripMenuItem
        '
        Me.PembelianBahanBakuToolStripMenuItem.Name = "PembelianBahanBakuToolStripMenuItem"
        Me.PembelianBahanBakuToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.PembelianBahanBakuToolStripMenuItem.Text = "Pembelian Bahan Baku"
        '
        'PemakaianBahanBakuToolStripMenuItem
        '
        Me.PemakaianBahanBakuToolStripMenuItem.Name = "PemakaianBahanBakuToolStripMenuItem"
        Me.PemakaianBahanBakuToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.PemakaianBahanBakuToolStripMenuItem.Text = "Pemakaian Bahan Baku"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem1, Me.PembelianPeralatanToolStripMenuItem1, Me.PembelianBahanBakuToolStripMenuItem1, Me.PemakaianBahanBakuToolStripMenuItem1})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'PenjualanToolStripMenuItem1
        '
        Me.PenjualanToolStripMenuItem1.Name = "PenjualanToolStripMenuItem1"
        Me.PenjualanToolStripMenuItem1.Size = New System.Drawing.Size(244, 26)
        Me.PenjualanToolStripMenuItem1.Text = "Penjualan"
        '
        'PembelianPeralatanToolStripMenuItem1
        '
        Me.PembelianPeralatanToolStripMenuItem1.Name = "PembelianPeralatanToolStripMenuItem1"
        Me.PembelianPeralatanToolStripMenuItem1.Size = New System.Drawing.Size(244, 26)
        Me.PembelianPeralatanToolStripMenuItem1.Text = "Pembelian Peralatan"
        '
        'PembelianBahanBakuToolStripMenuItem1
        '
        Me.PembelianBahanBakuToolStripMenuItem1.Name = "PembelianBahanBakuToolStripMenuItem1"
        Me.PembelianBahanBakuToolStripMenuItem1.Size = New System.Drawing.Size(244, 26)
        Me.PembelianBahanBakuToolStripMenuItem1.Text = "Pembelian Bahan Baku"
        '
        'PemakaianBahanBakuToolStripMenuItem1
        '
        Me.PemakaianBahanBakuToolStripMenuItem1.Name = "PemakaianBahanBakuToolStripMenuItem1"
        Me.PemakaianBahanBakuToolStripMenuItem1.Size = New System.Drawing.Size(244, 26)
        Me.PemakaianBahanBakuToolStripMenuItem1.Text = "Pemakaian Bahan Baku"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(29, 57)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(287, 249)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(480, 172)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(287, 249)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'menuutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "menuutama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianPeralatanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianBahanBakuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemakaianBahanBakuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PembelianPeralatanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PembelianBahanBakuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PemakaianBahanBakuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
