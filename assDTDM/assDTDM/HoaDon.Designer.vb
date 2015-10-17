<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHoaDon
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.cmbMaKH = New System.Windows.Forms.ComboBox()
        Me.dateNgayLap = New System.Windows.Forms.DateTimePicker()
        Me.rdoAddHD = New System.Windows.Forms.RadioButton()
        Me.rdoEditHD = New System.Windows.Forms.RadioButton()
        Me.rdoDelHoaDon = New System.Windows.Forms.RadioButton()
        Me.btnOKHoaDon = New System.Windows.Forms.Button()
        Me.btnCancelHoaDon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày Lập"
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(105, 26)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(167, 20)
        Me.txtMaHD.TabIndex = 3
        '
        'cmbMaKH
        '
        Me.cmbMaKH.FormattingEnabled = True
        Me.cmbMaKH.Location = New System.Drawing.Point(105, 80)
        Me.cmbMaKH.Name = "cmbMaKH"
        Me.cmbMaKH.Size = New System.Drawing.Size(167, 21)
        Me.cmbMaKH.TabIndex = 4
        '
        'dateNgayLap
        '
        Me.dateNgayLap.Location = New System.Drawing.Point(105, 132)
        Me.dateNgayLap.Name = "dateNgayLap"
        Me.dateNgayLap.Size = New System.Drawing.Size(167, 20)
        Me.dateNgayLap.TabIndex = 5
        '
        'rdoAddHD
        '
        Me.rdoAddHD.AutoSize = True
        Me.rdoAddHD.Location = New System.Drawing.Point(37, 184)
        Me.rdoAddHD.Name = "rdoAddHD"
        Me.rdoAddHD.Size = New System.Drawing.Size(52, 17)
        Me.rdoAddHD.TabIndex = 6
        Me.rdoAddHD.TabStop = True
        Me.rdoAddHD.Text = "Thêm"
        Me.rdoAddHD.UseVisualStyleBackColor = True
        '
        'rdoEditHD
        '
        Me.rdoEditHD.AutoSize = True
        Me.rdoEditHD.Location = New System.Drawing.Point(122, 184)
        Me.rdoEditHD.Name = "rdoEditHD"
        Me.rdoEditHD.Size = New System.Drawing.Size(44, 17)
        Me.rdoEditHD.TabIndex = 7
        Me.rdoEditHD.TabStop = True
        Me.rdoEditHD.Text = "Sửa"
        Me.rdoEditHD.UseVisualStyleBackColor = True
        '
        'rdoDelHoaDon
        '
        Me.rdoDelHoaDon.AutoSize = True
        Me.rdoDelHoaDon.Location = New System.Drawing.Point(206, 184)
        Me.rdoDelHoaDon.Name = "rdoDelHoaDon"
        Me.rdoDelHoaDon.Size = New System.Drawing.Size(44, 17)
        Me.rdoDelHoaDon.TabIndex = 8
        Me.rdoDelHoaDon.TabStop = True
        Me.rdoDelHoaDon.Text = "Xóa"
        Me.rdoDelHoaDon.UseVisualStyleBackColor = True
        '
        'btnOKHoaDon
        '
        Me.btnOKHoaDon.Location = New System.Drawing.Point(15, 227)
        Me.btnOKHoaDon.Name = "btnOKHoaDon"
        Me.btnOKHoaDon.Size = New System.Drawing.Size(75, 23)
        Me.btnOKHoaDon.TabIndex = 9
        Me.btnOKHoaDon.Text = "Thao Tác"
        Me.btnOKHoaDon.UseVisualStyleBackColor = True
        '
        'btnCancelHoaDon
        '
        Me.btnCancelHoaDon.Location = New System.Drawing.Point(197, 227)
        Me.btnCancelHoaDon.Name = "btnCancelHoaDon"
        Me.btnCancelHoaDon.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelHoaDon.TabIndex = 10
        Me.btnCancelHoaDon.Text = "Hủy"
        Me.btnCancelHoaDon.UseVisualStyleBackColor = True
        '
        'formHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCancelHoaDon)
        Me.Controls.Add(Me.btnOKHoaDon)
        Me.Controls.Add(Me.rdoDelHoaDon)
        Me.Controls.Add(Me.rdoEditHD)
        Me.Controls.Add(Me.rdoAddHD)
        Me.Controls.Add(Me.dateNgayLap)
        Me.Controls.Add(Me.cmbMaKH)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formHoaDon"
        Me.Text = "Hóa Đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents cmbMaKH As System.Windows.Forms.ComboBox
    Friend WithEvents dateNgayLap As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdoAddHD As System.Windows.Forms.RadioButton
    Friend WithEvents rdoEditHD As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDelHoaDon As System.Windows.Forms.RadioButton
    Friend WithEvents btnOKHoaDon As System.Windows.Forms.Button
    Friend WithEvents btnCancelHoaDon As System.Windows.Forms.Button
End Class
