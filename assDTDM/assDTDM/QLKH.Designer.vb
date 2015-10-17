<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formQLKH
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
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.lbSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.lbShow = New System.Windows.Forms.Label()
        Me.lbShowTable = New System.Windows.Forms.Label()
        Me.lbControlTable = New System.Windows.Forms.Label()
        Me.rdoKhachHang = New System.Windows.Forms.RadioButton()
        Me.rdoHoaDon = New System.Windows.Forms.RadioButton()
        Me.rdoCTHD = New System.Windows.Forms.RadioButton()
        Me.rdoLoaiSP = New System.Windows.Forms.RadioButton()
        Me.rdoSanPham = New System.Windows.Forms.RadioButton()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.grbLoaiSP = New System.Windows.Forms.GroupBox()
        Me.cmbLoaiSP = New System.Windows.Forms.ComboBox()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLoaiSP.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGridView
        '
        Me.dataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.EnableHeadersVisualStyles = False
        Me.dataGridView.Location = New System.Drawing.Point(13, 117)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.ReadOnly = True
        Me.dataGridView.Size = New System.Drawing.Size(419, 416)
        Me.dataGridView.TabIndex = 0
        '
        'lbSearch
        '
        Me.lbSearch.AutoSize = True
        Me.lbSearch.Location = New System.Drawing.Point(13, 13)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(50, 13)
        Me.lbSearch.TabIndex = 1
        Me.lbSearch.Text = "Tìm Kiếm"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(197, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(235, 20)
        Me.txtSearch.TabIndex = 2
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"Khách Hàng", "Hóa Đơn", "Chi Tiết Hóa Đơn", "Loại Sản Phẩm", "Sản Phẩm"})
        Me.cmbSearch.Location = New System.Drawing.Point(70, 13)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearch.TabIndex = 3
        '
        'lbShow
        '
        Me.lbShow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbShow.AutoSize = True
        Me.lbShow.BackColor = System.Drawing.SystemColors.Control
        Me.lbShow.ForeColor = System.Drawing.Color.Red
        Me.lbShow.Location = New System.Drawing.Point(122, 53)
        Me.lbShow.Margin = New System.Windows.Forms.Padding(0)
        Me.lbShow.MaximumSize = New System.Drawing.Size(200, 50)
        Me.lbShow.MinimumSize = New System.Drawing.Size(200, 50)
        Me.lbShow.Name = "lbShow"
        Me.lbShow.Size = New System.Drawing.Size(200, 50)
        Me.lbShow.TabIndex = 6
        Me.lbShow.Text = "Hiển Thị Dữ Liệu"
        Me.lbShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbShowTable
        '
        Me.lbShowTable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbShowTable.AutoSize = True
        Me.lbShowTable.BackColor = System.Drawing.SystemColors.Control
        Me.lbShowTable.ForeColor = System.Drawing.Color.Red
        Me.lbShowTable.Location = New System.Drawing.Point(437, 53)
        Me.lbShowTable.Margin = New System.Windows.Forms.Padding(0)
        Me.lbShowTable.MaximumSize = New System.Drawing.Size(200, 50)
        Me.lbShowTable.MinimumSize = New System.Drawing.Size(150, 50)
        Me.lbShowTable.Name = "lbShowTable"
        Me.lbShowTable.Size = New System.Drawing.Size(150, 50)
        Me.lbShowTable.TabIndex = 8
        Me.lbShowTable.Text = "Xem Bảng"
        Me.lbShowTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbControlTable
        '
        Me.lbControlTable.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbControlTable.AutoSize = True
        Me.lbControlTable.BackColor = System.Drawing.SystemColors.Control
        Me.lbControlTable.ForeColor = System.Drawing.Color.Red
        Me.lbControlTable.Location = New System.Drawing.Point(610, 53)
        Me.lbControlTable.Margin = New System.Windows.Forms.Padding(0)
        Me.lbControlTable.MaximumSize = New System.Drawing.Size(200, 50)
        Me.lbControlTable.MinimumSize = New System.Drawing.Size(150, 50)
        Me.lbControlTable.Name = "lbControlTable"
        Me.lbControlTable.Size = New System.Drawing.Size(150, 50)
        Me.lbControlTable.TabIndex = 9
        Me.lbControlTable.Text = "Thao Tác Dữ Liệu"
        Me.lbControlTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdoKhachHang
        '
        Me.rdoKhachHang.AutoSize = True
        Me.rdoKhachHang.Location = New System.Drawing.Point(458, 117)
        Me.rdoKhachHang.Name = "rdoKhachHang"
        Me.rdoKhachHang.Size = New System.Drawing.Size(85, 17)
        Me.rdoKhachHang.TabIndex = 10
        Me.rdoKhachHang.TabStop = True
        Me.rdoKhachHang.Text = "Khách Hàng"
        Me.rdoKhachHang.UseVisualStyleBackColor = True
        '
        'rdoHoaDon
        '
        Me.rdoHoaDon.AutoSize = True
        Me.rdoHoaDon.Location = New System.Drawing.Point(458, 178)
        Me.rdoHoaDon.Name = "rdoHoaDon"
        Me.rdoHoaDon.Size = New System.Drawing.Size(68, 17)
        Me.rdoHoaDon.TabIndex = 11
        Me.rdoHoaDon.TabStop = True
        Me.rdoHoaDon.Text = "Hóa Đơn"
        Me.rdoHoaDon.UseVisualStyleBackColor = True
        '
        'rdoCTHD
        '
        Me.rdoCTHD.AutoSize = True
        Me.rdoCTHD.Location = New System.Drawing.Point(458, 249)
        Me.rdoCTHD.Name = "rdoCTHD"
        Me.rdoCTHD.Size = New System.Drawing.Size(107, 17)
        Me.rdoCTHD.TabIndex = 12
        Me.rdoCTHD.TabStop = True
        Me.rdoCTHD.Text = "Chi Tiết Hóa Đơn"
        Me.rdoCTHD.UseVisualStyleBackColor = True
        '
        'rdoLoaiSP
        '
        Me.rdoLoaiSP.AutoSize = True
        Me.rdoLoaiSP.Location = New System.Drawing.Point(458, 322)
        Me.rdoLoaiSP.Name = "rdoLoaiSP"
        Me.rdoLoaiSP.Size = New System.Drawing.Size(97, 17)
        Me.rdoLoaiSP.TabIndex = 13
        Me.rdoLoaiSP.TabStop = True
        Me.rdoLoaiSP.Text = "Loại Sản Phẩm"
        Me.rdoLoaiSP.UseVisualStyleBackColor = True
        '
        'rdoSanPham
        '
        Me.rdoSanPham.AutoSize = True
        Me.rdoSanPham.Location = New System.Drawing.Point(458, 403)
        Me.rdoSanPham.Name = "rdoSanPham"
        Me.rdoSanPham.Size = New System.Drawing.Size(74, 17)
        Me.rdoSanPham.TabIndex = 14
        Me.rdoSanPham.TabStop = True
        Me.rdoSanPham.Text = "Sản Phẩm"
        Me.rdoSanPham.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdd.ForeColor = System.Drawing.Color.Blue
        Me.btnAdd.Location = New System.Drawing.Point(613, 144)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 30)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEdit.ForeColor = System.Drawing.Color.Blue
        Me.btnEdit.Location = New System.Drawing.Point(613, 213)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 30)
        Me.btnEdit.TabIndex = 16
        Me.btnEdit.Text = "Sửa"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDel.ForeColor = System.Drawing.Color.Blue
        Me.btnDel.Location = New System.Drawing.Point(613, 289)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(100, 30)
        Me.btnDel.TabIndex = 17
        Me.btnDel.Text = "Xóa"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'grbLoaiSP
        '
        Me.grbLoaiSP.Controls.Add(Me.cmbLoaiSP)
        Me.grbLoaiSP.ForeColor = System.Drawing.SystemColors.Desktop
        Me.grbLoaiSP.Location = New System.Drawing.Point(583, 368)
        Me.grbLoaiSP.Name = "grbLoaiSP"
        Me.grbLoaiSP.Size = New System.Drawing.Size(144, 100)
        Me.grbLoaiSP.TabIndex = 18
        Me.grbLoaiSP.TabStop = False
        Me.grbLoaiSP.Text = "Các Loại Sản Phẩm"
        '
        'cmbLoaiSP
        '
        Me.cmbLoaiSP.FormattingEnabled = True
        Me.cmbLoaiSP.Location = New System.Drawing.Point(7, 34)
        Me.cmbLoaiSP.Name = "cmbLoaiSP"
        Me.cmbLoaiSP.Size = New System.Drawing.Size(131, 21)
        Me.cmbLoaiSP.TabIndex = 0
        '
        'formQLKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 545)
        Me.Controls.Add(Me.grbLoaiSP)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.rdoSanPham)
        Me.Controls.Add(Me.rdoLoaiSP)
        Me.Controls.Add(Me.rdoCTHD)
        Me.Controls.Add(Me.rdoHoaDon)
        Me.Controls.Add(Me.rdoKhachHang)
        Me.Controls.Add(Me.lbControlTable)
        Me.Controls.Add(Me.lbShowTable)
        Me.Controls.Add(Me.lbShow)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lbSearch)
        Me.Controls.Add(Me.dataGridView)
        Me.Name = "formQLKH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Khách Hàng"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Red
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLoaiSP.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents lbSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Public WithEvents lbShow As System.Windows.Forms.Label
    Public WithEvents lbShowTable As System.Windows.Forms.Label
    Public WithEvents lbControlTable As System.Windows.Forms.Label
    Friend WithEvents rdoKhachHang As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHoaDon As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCTHD As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLoaiSP As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSanPham As System.Windows.Forms.RadioButton
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents grbLoaiSP As System.Windows.Forms.GroupBox
    Friend WithEvents cmbLoaiSP As System.Windows.Forms.ComboBox

End Class
