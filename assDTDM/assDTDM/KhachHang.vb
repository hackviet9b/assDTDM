Public Class formKhachHang
    Private _DBAccess As New DataBaseAccess

    Private Sub btncancelKhachHang_Click(sender As Object, e As EventArgs) Handles btncancelKhachHang.Click
        Me.Close()
        formQLKH.LoadDataFromKhachHang()
    End Sub

    Private Sub InsertKhachHang()
        Dim sqlQuery As String = String.Format("INSERT INTO dbo.KhachHang ([MaKH], [TenKH], [Email], [DiaChi], [SDT]) VALUES ('{0}','{1}','{2}','{3}', '{4}')", Me.txtMaKH.Text, Me.txtTenKH.Text, Me.txtEmail.Text, Me.txtDiaChi.Text, Me.txtSDT.Text)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Thêm dữ liệu thành công rồi!")
        Else
            MessageBox.Show("Thêm dữ liệu lỗi cmnr!")
        End If
    End Sub

    Private Sub UpdateKhachHang()
        Dim sqlQuery As String = String.Format("Update dbo.KhachHang Set [TenKH] = '{0}', [Email] = '{1}', [DiaChi] = '{2}', [SDT] = '{3}' where [MaKH] = '{4}'", Me.txtTenKH.Text, Me.txtEmail.Text, Me.txtDiaChi.Text, Me.txtSDT.Text, Me.txtMaKH.Text)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Chỉnh sửa dữ liệu thành công rồi!")
        Else
            MessageBox.Show("Chỉnh sửa dữ liệu lỗi cmnr!")
        End If
    End Sub

    Private Sub DeleteKhachHang()
        Dim sqlQuery As String = String.Format("Delete From dbo.KhachHang where [MaKH] = '{0}'", Me.txtMaKH.Text)
        If _DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Xóa dữ liệu thành công rồi!")
        Else
            MessageBox.Show("Xóa dữ liệu lỗi cmnr!")
        End If
    End Sub

    Private Sub btnOKKhachHang_Click(sender As Object, e As EventArgs) Handles btnOKKhachHang.Click
        If Me.rdoAddKhachHang.Checked Then
            InsertKhachHang()
        ElseIf Me.rdoEditKhachHang.Checked Then
            UpdateKhachHang()
        ElseIf Me.rdoDelKhachHang.Checked Then
            DeleteKhachHang()
        End If
    End Sub

    Private Sub rdoEditKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEditKhachHang.CheckedChanged
        Me.txtMaKH.ReadOnly = True
        Me.txtTenKH.ReadOnly = False
        Me.txtEmail.ReadOnly = False
        Me.txtDiaChi.ReadOnly = False
        Me.txtSDT.ReadOnly = False
    End Sub

    Private Sub rdoAddKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAddKhachHang.CheckedChanged
        Me.txtMaKH.ReadOnly = False
        Me.txtTenKH.ReadOnly = False
        Me.txtEmail.ReadOnly = False
        Me.txtDiaChi.ReadOnly = False
        Me.txtSDT.ReadOnly = False
    End Sub

    Private Sub rdoDelKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDelKhachHang.CheckedChanged
        Me.txtMaKH.ReadOnly = True
        Me.txtTenKH.ReadOnly = True
        Me.txtEmail.ReadOnly = True
        Me.txtDiaChi.ReadOnly = True
        Me.txtSDT.ReadOnly = True
    End Sub
End Class