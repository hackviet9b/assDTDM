<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKhachHang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdoAddKhachHang = New System.Windows.Forms.RadioButton()
        Me.rdoEditKhachHang = New System.Windows.Forms.RadioButton()
        Me.rdoDelKhachHang = New System.Windows.Forms.RadioButton()
        Me.btnOKKhachHang = New System.Windows.Forms.Button()
        Me.btncancelKhachHang = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(115, 52)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(250, 20)
        Me.txtMaKH.TabIndex = 1
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(115, 97)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(250, 20)
        Me.txtTenKH.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Khách Hàng"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(115, 145)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 20)
        Me.txtEmail.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(115, 236)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(250, 20)
        Me.txtSDT.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Địa Chỉ"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(115, 190)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(250, 20)
        Me.txtDiaChi.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SDT"
        '
        'rdoAddKhachHang
        '
        Me.rdoAddKhachHang.AutoSize = True
        Me.rdoAddKhachHang.Location = New System.Drawing.Point(47, 290)
        Me.rdoAddKhachHang.Name = "rdoAddKhachHang"
        Me.rdoAddKhachHang.Size = New System.Drawing.Size(52, 17)
        Me.rdoAddKhachHang.TabIndex = 10
        Me.rdoAddKhachHang.TabStop = True
        Me.rdoAddKhachHang.Text = "Thêm"
        Me.rdoAddKhachHang.UseVisualStyleBackColor = True
        '
        'rdoEditKhachHang
        '
        Me.rdoEditKhachHang.AutoSize = True
        Me.rdoEditKhachHang.Location = New System.Drawing.Point(149, 290)
        Me.rdoEditKhachHang.Name = "rdoEditKhachHang"
        Me.rdoEditKhachHang.Size = New System.Drawing.Size(44, 17)
        Me.rdoEditKhachHang.TabIndex = 11
        Me.rdoEditKhachHang.TabStop = True
        Me.rdoEditKhachHang.Text = "Sửa"
        Me.rdoEditKhachHang.UseVisualStyleBackColor = True
        '
        'rdoDelKhachHang
        '
        Me.rdoDelKhachHang.AutoSize = True
        Me.rdoDelKhachHang.Location = New System.Drawing.Point(264, 290)
        Me.rdoDelKhachHang.Name = "rdoDelKhachHang"
        Me.rdoDelKhachHang.Size = New System.Drawing.Size(44, 17)
        Me.rdoDelKhachHang.TabIndex = 12
        Me.rdoDelKhachHang.TabStop = True
        Me.rdoDelKhachHang.Text = "Xóa"
        Me.rdoDelKhachHang.UseVisualStyleBackColor = True
        '
        'btnOKKhachHang
        '
        Me.btnOKKhachHang.Location = New System.Drawing.Point(16, 352)
        Me.btnOKKhachHang.Name = "btnOKKhachHang"
        Me.btnOKKhachHang.Size = New System.Drawing.Size(75, 23)
        Me.btnOKKhachHang.TabIndex = 13
        Me.btnOKKhachHang.Text = "Thao Tác"
        Me.btnOKKhachHang.UseVisualStyleBackColor = True
        '
        'btncancelKhachHang
        '
        Me.btncancelKhachHang.Location = New System.Drawing.Point(290, 352)
        Me.btncancelKhachHang.Name = "btncancelKhachHang"
        Me.btncancelKhachHang.Size = New System.Drawing.Size(75, 23)
        Me.btncancelKhachHang.TabIndex = 14
        Me.btncancelKhachHang.Text = "Hủy"
        Me.btncancelKhachHang.UseVisualStyleBackColor = True
        '
        'formKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 414)
        Me.Controls.Add(Me.btncancelKhachHang)
        Me.Controls.Add(Me.btnOKKhachHang)
        Me.Controls.Add(Me.rdoDelKhachHang)
        Me.Controls.Add(Me.rdoEditKhachHang)
        Me.Controls.Add(Me.rdoAddKhachHang)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formKhachHang"
        Me.Text = "Khách Hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdoAddKhachHang As System.Windows.Forms.RadioButton
    Friend WithEvents rdoEditKhachHang As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDelKhachHang As System.Windows.Forms.RadioButton
    Friend WithEvents btnOKKhachHang As System.Windows.Forms.Button
    Friend WithEvents btncancelKhachHang As System.Windows.Forms.Button
End Class
