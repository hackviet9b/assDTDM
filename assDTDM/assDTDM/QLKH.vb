Public Class formQLKH
    Private _DBAccess As New DataBaseAccess
    Private isloading As Boolean = False

    ' Load dữ liệu từ bảng Khách Hàng ra GridView
    Public Sub LoadDataFromKhachHang()
        Dim sqlQuery As String = "Select * from dbo.KhachHang"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Khách Hàng"
            .Columns(1).HeaderText = "Tên Khách Hàng"
            .Columns(2).HeaderText = "Email"
            .Columns(3).HeaderText = "Địa Chỉ"
            .Columns(4).HeaderText = "SDT"
        End With
    End Sub

    'Load dữ liệu từ bảng Loại Sản Phẩm ra ComboBox
    Private Sub LoadDataOnComBoBox()
        Dim sqlQuery As String = "Select * from dbo.LoaiSP"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbLoaiSP.DataSource = dTable
        Me.cmbLoaiSP.ValueMember = "MaLoaiSP"
        Me.cmbLoaiSP.DisplayMember = "TenLoaiSP"
    End Sub

    ' Hiển thị dữ liệu Sản Phẩm có cùng MaLoaiSP
    Private Sub LoadDataOnGridView(MaLoaiSP As String)
        Dim sqlQuery As String = String.Format("SELECT * FROM dbo.SanPham Where [MaLoaiSP] = '{0}'", MaLoaiSP)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Sản Phẩm"
            .Columns(1).HeaderText = "Tên Sản Phẩm"
            .Columns(2).HeaderText = "Mô Tả"
            .Columns(3).HeaderText = "Mã Loại Sản Phẩm"
            .Columns(4).HeaderText = "Mệnh Giá"
        End With
    End Sub

    ' Khi Radio Button Khách Hàng được chọn thì sẽ load dữ liệu ra GridView
    Private Sub rdoKhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKhachHang.CheckedChanged
        Dim sqlQuery As String = "Select * from dbo.KhachHang"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Khách Hàng"
            .Columns(1).HeaderText = "Tên Khách Hàng"
            .Columns(2).HeaderText = "Email"
            .Columns(3).HeaderText = "Địa Chỉ"
            .Columns(4).HeaderText = "SDT"
        End With
    End Sub

    ' Khi Radio Button Hóa Đơn được chọn
    Public Sub rdoHoaDon_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHoaDon.CheckedChanged
        Dim sqlQuery As String = "Select * from dbo.HoaDon"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Hóa Đơn"
            .Columns(1).HeaderText = "Mã Khách Hàng"
            .Columns(2).HeaderText = "Ngày Lập"
        End With
    End Sub
    ' Khi Radio Button Chi Tiết Hóa Đơn được chọn
    Private Sub rdoCTHD_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCTHD.CheckedChanged
        Dim sqlQuery As String = "Select * from dbo.ChiTietHoaDon"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Sản Phẩm"
            .Columns(1).HeaderText = "Mã Hóa Đơn"
            .Columns(2).HeaderText = "Số Lượng"
            .Columns(3).HeaderText = "Đơn Giá"
        End With
    End Sub

    ' Khi Radio Button Loại Sản Phẩm được chọn
    Private Sub rdoLoaiSP_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLoaiSP.CheckedChanged
        Dim sqlQuery As String = "Select * from dbo.LoaiSP"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Loại Sản Phẩm"
            .Columns(1).HeaderText = "Tên Loại Sản Phẩm"
        End With
    End Sub

    ' Khi Radio Button Sản Phẩm được chọn
    Private Sub rdoSanPham_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSanPham.CheckedChanged
        isloading = True
        Dim sqlQuery As String = "Select * from dbo.SanPham"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Sản Phẩm"
            .Columns(1).HeaderText = "Tên Sản Phẩm"
            .Columns(2).HeaderText = "Mô Tả"
            .Columns(3).HeaderText = "Mã Loại Sản Phẩm"
            .Columns(4).HeaderText = "Mệnh Giá"
        End With
        LoadDataOnComBoBox()
        isloading = False
    End Sub

    ' Khi ComboBox LoaiSP thay đổi 
    Private Sub cmbLoaiSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLoaiSP.SelectedIndexChanged
        If Not isloading Then
            LoadDataOnGridView(Me.cmbLoaiSP.SelectedValue)
        End If
    End Sub

    ' Khi nhấn vào Button Thêm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.rdoKhachHang.Checked Then
            Dim form As New formKhachHang
            form.rdoAddKhachHang.Checked = True
            form.ShowDialog()
        ElseIf Me.rdoHoaDon.Checked Then
            Dim form As New formHoaDon
            form.rdoAddHD.Checked = True
            Dim sqlQuery As String = "Select * from dbo.HoaDon"
            Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
            form.cmbMaKH.DataSource = dTable
            form.cmbMaKH.ValueMember = "MaKH"
            form.cmbMaKH.DisplayMember = "MaKH"
            form.ShowDialog()
        End If
    End Sub

    ' Khi nhấn vào Button Sửa
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Me.rdoKhachHang.Checked Then
            Dim form As New formKhachHang
            form.rdoEditKhachHang.Checked = True
            form.txtMaKH.ReadOnly = True
            With Me.dataGridView
                form.txtMaKH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
                form.txtTenKH.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
                form.txtEmail.Text = .Rows(.CurrentCell.RowIndex).Cells("Email").Value
                form.txtDiaChi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
                form.txtSDT.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
            End With
            form.ShowDialog()
        ElseIf Me.rdoHoaDon.Checked Then
            Dim form As New formHoaDon
            form.rdoEditHD.Checked = True
            form.txtMaHD.ReadOnly = True
            With Me.dataGridView
                form.txtMaHD.Text = .Rows(.CurrentCell.RowIndex).Cells("MaHD").Value
                Dim sqlQuery As String = "Select * from dbo.HoaDon"
                Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
                form.cmbMaKH.DataSource = dTable
                form.cmbMaKH.ValueMember = "MaKH"
                form.cmbMaKH.DisplayMember = "MaKH"
                form.dateNgayLap.Text = .Rows(.CurrentCell.RowIndex).Cells("NgayLap").Value
            End With
            form.ShowDialog()
        End If
    End Sub

    ' Khi nhấn vào Button Xóa
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Me.rdoKhachHang.Checked Then
            Dim form As New formKhachHang
            form.rdoDelKhachHang.Checked = True
            form.txtMaKH.ReadOnly = True
            form.txtTenKH.ReadOnly = True
            form.txtEmail.ReadOnly = True
            form.txtDiaChi.ReadOnly = True
            form.txtSDT.ReadOnly = True

            With Me.dataGridView
                form.txtMaKH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
                form.txtTenKH.Text = .Rows(.CurrentCell.RowIndex).Cells("TenKH").Value
                form.txtEmail.Text = .Rows(.CurrentCell.RowIndex).Cells("Email").Value
                form.txtDiaChi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
                form.txtSDT.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
            End With
            form.ShowDialog()
        ElseIf Me.rdoHoaDon.Checked Then
            Dim form As New formHoaDon
            form.rdoDelHoaDon.Checked = True
            form.txtMaHD.ReadOnly = True
            With Me.dataGridView
                form.txtMaHD.Text = .Rows(.CurrentCell.RowIndex).Cells("MaHD").Value
                form.cmbMaKH.Text = .Rows(.CurrentCell.RowIndex).Cells("MaKH").Value
                form.dateNgayLap.Text = .Rows(.CurrentCell.RowIndex).Cells("NgayLap").Value
            End With
            form.ShowDialog()
        End If
    End Sub

    ' Tìm kiếm trên bảng Hóa Đơn
    Private Sub SearchingHoaDon(txtSearch As String)
        Dim txt As String = "%" + txtSearch + "%"
        Dim sqlQuery As String = String.Format("Select * from dbo.HoaDon where [MaHD] Like '{0}' or [MaKH] Like '{0}' or [NgayLap] Like '{0}'", txt)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Hóa Đơn"
            .Columns(1).HeaderText = "Mã Khách Hàng"
            .Columns(2).HeaderText = "Ngày Lập"
        End With
    End Sub

    ' Tìm kiếm trên bảng Khách Hàng
    Private Sub SearchingKhachHang(txtSearch As String)
        Dim txt As String = "%" + txtSearch + "%"
        Dim sqlQuery As String = String.Format("Select * from dbo.KhachHang where [MaKH] Like '{0}' or [TenKH] Like '{0}' or [Email] Like '{0}' or [DiaChi] Like '{0}' or [SDT] Like '{0}'", txt)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Khách Hàng"
            .Columns(1).HeaderText = "Tên Khách Hàng"
            .Columns(2).HeaderText = "Email"
            .Columns(3).HeaderText = "Địa Chỉ"
            .Columns(4).HeaderText = "SDT"
        End With
    End Sub

    ' Tìm kiếm trên bảng Chi Tiết Hóa Đơn
    Private Sub SearchingChiTietHoaDon(txtSearch As String)
        Dim txt As String = "%" + txtSearch + "%"
        Dim sqlQuery As String = String.Format("Select * from dbo.ChitietHoaDon where [MaSP] Like '{0}' or [MaHD] Like '{0}'", txt)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Sản Phẩm"
            .Columns(1).HeaderText = "Mã Hóa Đơn"
            .Columns(2).HeaderText = "Số Lượng"
            .Columns(3).HeaderText = "Đơn Giá"
        End With
    End Sub

    ' Tìm kiếm trên bảng Loại Sản Phẩm
    Private Sub SearchingLoaiSanPham(txtSearch As String)
        Dim txt As String = "%" + txtSearch + "%"
        Dim sqlQuery As String = String.Format("Select * from dbo.LoaiSP where [MaLoaiSP] Like '{0}' or [TenLoaiSP] Like '{0}'", txt)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Loại Sản Phẩm"
            .Columns(1).HeaderText = "Tên Loại Sản Phẩm"
        End With
    End Sub

    ' Tìm kiếm trên bảng Sản Phẩm
    Private Sub SearchingSanPham(txtSearch As String)
        Dim txt As String = "%" + txtSearch + "%"
        Dim sqlQuery As String = String.Format("Select * from dbo.SanPham where [MaSP] Like '{0}' or [TenSP] Like '{0}' or [Mota] Like '{0}' or [MaLoaiSP] Like '{0}' or [MenhGia] Like '{0}'", txt)
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dataGridView.DataSource = dTable

        With Me.dataGridView
            .Columns(0).HeaderText = "Mã Sản Phẩm"
            .Columns(1).HeaderText = "Tên Sản Phẩm"
            .Columns(2).HeaderText = "Mô Tả"
            .Columns(3).HeaderText = "Mã Loại Sản Phẩm"
            .Columns(4).HeaderText = "Mệnh Giá"
        End With
    End Sub

    'Hàm tìm kiếm mỗi khi textbox được nhập giá trị
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Me.cmbSearch.SelectedIndex = 0 Then
            SearchingKhachHang(Me.txtSearch.Text)
        ElseIf Me.cmbSearch.SelectedIndex = 1 Then
            SearchingHoaDon(Me.txtSearch.Text)
        ElseIf Me.cmbSearch.SelectedIndex = 2 Then
            SearchingChiTietHoaDon(Me.txtSearch.Text)
        ElseIf Me.cmbSearch.SelectedIndex = 3 Then
            SearchingLoaiSanPham(Me.txtSearch.Text)
        ElseIf Me.cmbSearch.SelectedIndex = 4 Then
            SearchingSanPham(Me.txtSearch.Text)
        End If
    End Sub
End Class
