Public Class formHoaDon
    Private _DBAccess As New DataBaseAccess

    ' Hàm thêm dữ liệu
    Private Sub InsertHoaDon()
        Dim sqlQuery As String = String.Format("INSERT INTO dbo.HoaDon (MaHD, MaKH, NgayLap) VALUES ('{0}', '{1}', '{2}')", Me.txtMaHD.Text, Me.cmbMaKH.Text, Me.dateNgayLap.Text)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Thêm dữ liệu thành công rồi!")
        Else
            MessageBox.Show("Thêm dữ liệu lỗi cmnr!")
        End If
    End Sub

    ' Hàm cập nhật dữ liệu
    Private Sub UpdateHoaDon()
        Dim sqlQuery As String = String.Format("Update dbo.HoaDon Set [MaKH] = '{0}', [NgayLap] = '{1}' where [MaHD] = '{2}'", Me.cmbMaKH.Text, Me.dateNgayLap.Text, Me.txtMaHD.Text)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Chỉnh sửa dữ liệu thành công rồi!")
        Else
            MessageBox.Show("Chỉnh sửa dữ liệu lỗi cmnr!")
        End If
    End Sub

    ' Hàm xóa dữ liệu
    Private Sub DeleteHoaDon()
        Dim sqlQuery As String = String.Format("Delete From dbo.HoaDon where [MaHD] = '{0}'", Me.txtMaHD.Text)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Xóa dữ liệu thành công rồi!")
        Else
            MessageBox.Show("Xóa dữ liệu lỗi cmnr!")
        End If
    End Sub

    ' Khi ấn Button Thao Tác, lựa chọn các trường hợp để tiến hành thêm, sửa, xóa
    Private Sub btnOKHoaDon_Click(sender As Object, e As EventArgs) Handles btnOKHoaDon.Click
        If Me.rdoAddHD.Checked Then
            InsertHoaDon()
        ElseIf Me.rdoEditHD.Checked Then
            UpdateHoaDon()
        ElseIf Me.rdoDelHoaDon.Checked Then
            DeleteHoaDon()
        End If

    End Sub

    ' Format định dạng thời gian tránh bị lỗi khi update hoặc thêm dữ liệu với DateTimePicker
    Private Sub formHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dateNgayLap.Format = DateTimePickerFormat.Custom
        Me.dateNgayLap.CustomFormat = "yyyy-MM-dd"
    End Sub

    ' Khi thêm dữ liệu, các trường đều có thể chỉnh sửa
    Private Sub rdoAddHD_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAddHD.CheckedChanged
        Me.txtMaHD.ReadOnly = False
        Me.cmbMaKH.Enabled = True
        Me.dateNgayLap.Enabled = True
    End Sub
    ' Khi sửa dữ liệu, các trường đều có thể chỉnh sửa ngoại trừ Mã Hóa Đơn
    Private Sub rdoEditHD_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEditHD.CheckedChanged
        Me.txtMaHD.ReadOnly = True
        Me.cmbMaKH.Enabled = True
        Me.dateNgayLap.Enabled = True
    End Sub

    ' Khi xóa dữ liệu, các trường đều không thể chỉnh sửa
    Private Sub rdoDelHoaDon_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDelHoaDon.CheckedChanged
        Me.txtMaHD.ReadOnly = True
        Me.cmbMaKH.Enabled = False
        Me.dateNgayLap.Enabled = False
    End Sub

    ' Khi ấn vào Button Hủy thì Dialog sẽ đóng lại và load lại dữ liệu của bảng Hóa Đơn lên GridView
    Private Sub btnCancelHoaDon_Click(sender As Object, e As EventArgs) Handles btnCancelHoaDon.Click
        Me.Close()
        Dim sqlQuery As String = "Select * from dbo.HoaDon"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        formQLKH.dataGridView.DataSource = dTable

        With formQLKH.dataGridView
            .Columns(0).HeaderText = "Mã Hóa Đơn"
            .Columns(1).HeaderText = "Mã Khách Hàng"
            .Columns(2).HeaderText = "Ngày Lập"
        End With
    End Sub
End Class