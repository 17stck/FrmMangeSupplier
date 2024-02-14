Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto

Public Class FrmMangeSupplier
    Dim conn As New MySqlConnection
    Friend da As New MySqlDataAdapter
    Friend Dr As MySqlDataReader
    Friend sql As String
    Dim comm As New MySqlCommand
    Friend ds As New DataSet
    Friend _Sup_id As String
    Friend _Sup_name As String
    Friend _Sup_address As String
    Friend _ProvincId As String
    Friend _Sup_tel As String
    Friend _Contract_name As String
    Sub connectData()
        Dim strconnect As String = ""
        strconnect = "server=localhost;userid=root;password='';database=datatest"
        'strconnect = "Data Source=DESKTOP-DOI5KEL\SQLEXPRESS;Initial Catalog=data;Integrated Security=True"
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.ConnectionString = strconnect
        conn.Open()
        MessageBox.Show("Connection OK ")
    End Sub

    Function ExecuteSQL(prmSQL As String) As Boolean
        connectData()
        Dim addCom As New MySqlCommand
        addCom.CommandType = CommandType.Text
        addCom.CommandText = prmSQL
        addCom.Connection = conn
        addCom.ExecuteNonQuery()

        ExecuteSQL = True
    End Function
    Public Function ExcuteDataTable()
        connectData()
        da = New MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds, "table")
        Return ds.Tables("table")
    End Function
    Public Function ExecuteReader(ByVal prmSQL As String) As MySqlDataReader
        Dim addcom As New MySqlCommand
        connectData()
        With addcom
            .CommandType = CommandType.Text
            .CommandText = prmSQL
            .Connection = conn
            Dr = .ExecuteReader()
            Return Dr
        End With
    End Function

    Public Function FindSupllier(prmsql As String) As Boolean
        Try
            Dr = ExecuteReader(prmsql)
            Dr.Read()
            _Sup_id = Dr.Item("Sup_id").ToString
            _Sup_name = Dr.Item("Sup_name").ToString
            _Sup_address = Dr.Item("Sup_Address").ToString
            _ProvincId = Dr.Item("ProvinceId").ToString
            _Sup_tel = Dr.Item("Sup_tel").ToString
            _Contract_name = Dr.Item("Contract_name").ToString
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub getDatagrid(datagrid As DataGridView, prmsql As String)
        sql = prmsql
        datagrid.DataSource = ExcuteDataTable()
    End Sub
    Private Sub RefreshDataGrid()
        ' สร้างคำสั่ง SQL เพื่อดึงข้อมูลทั้งหมด
        Dim sql As String = "SELECT * FROM supplier"

        ' เรียกให้แสดงข้อมูลใน DataGridView
        getDatagrid(dgrSupplier, sql)
    End Sub
    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "select Province_name from provincedata;"
        binddataToObject(cmbProvinceName, sql)
    End Sub

    Private Sub cmbProvinceName_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbProvinceName.SelectedIndexChanged
        Dim data As New ClsProvince
        sql = "select * from Provincedata where Province_name = '" & cmbProvinceName.Text & "';"
        data = getProvinceData(sql)
        txtprovinceId.Text = data._province_Id
    End Sub

    Private Sub btnSupplierAdd_Click(sender As Object, e As EventArgs) Handles btnSupplierAdd.Click
        ' ตรวจสอบความถูกต้องของข้อมูลที่กรอกใน TextBox
        If txtSup_id.Text <> "" AndAlso txtSup_name.Text <> "" AndAlso txtSup_address.Text <> "" AndAlso txtprovinceId.Text <> "" AndAlso txtSup_tel.Text <> "" AndAlso txtContractname.Text <> "" Then
            ' กำหนดค่าข้อมูลที่จะเพิ่มลงในฐานข้อมูล
            Dim idsup As String = txtSup_id.Text
            Dim namesup As String = txtSup_name.Text
            Dim addsup As String = txtSup_address.Text
            Dim provinceId As String = txtprovinceId.Text
            Dim telsup As String = txtSup_tel.Text
            Dim contractsup As String = txtContractname.Text

            ' สร้างคำสั่ง SQL สำหรับการเพิ่มข้อมูลซัพพลายเออร์ใหม่
            Dim sql As String = "INSERT INTO supplier (Sup_id, Sup_name, Sup_Address, ProvinceId, Sup_tel, Contract_name) VALUES ('" & idsup & "','" & namesup & "','" & addsup & "','" & provinceId & "','" & telsup & "','" & contractsup & "')"

            ' ทำการเพิ่มข้อมูลลงในฐานข้อมูล
            ExecuteSQL(sql)

            ' เรียกให้แสดงข้อมูลใน DataGridView อีกครั้ง
            RefreshDataGrid()
        Else
            ' แสดงข้อความแจ้งเตือนเมื่อข้อมูลไม่ครบถ้วน
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnSupplierEdit_Click(sender As Object, e As EventArgs) Handles btnSupplierEdit.Click
        ' ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
        If dgrSupplier.SelectedRows.Count > 0 Then
            ' ดึงค่ารหัสซัพพลายเออร์จากแถวที่เลือกใน DataGridView
            Dim supId As String = dgrSupplier.SelectedRows(0).Cells("Sup_id").Value.ToString()

            ' เรียกใช้เมทอด FindSupllier เพื่อค้นหาข้อมูลของซัพพลายเออร์
            Dim sql As String = "SELECT * FROM supplier WHERE Sup_id = '" & supId & "'"
            If FindSupllier(sql) Then
                ' สร้างฟอร์มแก้ไขซัพพลายเออร์โดยส่งค่ารหัสซัพพลายเออร์และข้อมูลไปยังฟอร์ม
                Dim editSupplierForm As New FrmEditSupplier()
                editSupplierForm.Sup_id = _Sup_id
                editSupplierForm.Sup_name = _Sup_name
                editSupplierForm.Sup_address = _Sup_address
                editSupplierForm.Sup_tel = _Sup_tel
                editSupplierForm.Contract_name = _Contract_name

                ' แสดงฟอร์มแก้ไขซัพพลายเออร์
                editSupplierForm.ShowDialog()

                ' เมื่อฟอร์มแก้ไขซัพพลายเออร์ถูกปิด ให้รีเฟรชข้อมูลใน DataGridView
                RefreshDataGrid()
            Else
                MessageBox.Show("ไม่พบข้อมูลซัพพลายเออร์", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("กรุณาเลือกซัพพลายเออร์ที่ต้องการแก้ไข", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




    Private Sub btnSupplierDel_Click(sender As Object, e As EventArgs) Handles btnSupplierDel.Click
        ' ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
        If dgrSupplier.SelectedRows.Count > 0 Then
            ' แสดงกล่องข้อความยืนยันการลบ
            Dim result As DialogResult = MessageBox.Show("คุณต้องการลบข้อมูลซัพพลายเออร์นี้ใช่หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' ดึงค่ารหัสซัพพลายเออร์จากแถวที่เลือกใน DataGridView
                Dim supId As String = dgrSupplier.SelectedRows(0).Cells("Sup_id").Value.ToString()

                ' สร้างคำสั่ง SQL สำหรับลบข้อมูลซัพพลายเออร์
                Dim sql As String = "DELETE FROM supplier WHERE Sup_id = '" & supId & "'"

                ' ทำการลบข้อมูลในฐานข้อมูล
                If ExecuteSQL(sql) Then
                    MessageBox.Show("ลบข้อมูลซัพพลายเออร์สำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' เมื่อลบข้อมูลสำเร็จ ให้รีเฟรชข้อมูลใน DataGridView
                    RefreshDataGrid()
                Else
                    MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูลซัพพลายเออร์", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("กรุณาเลือกซัพพลายเออร์ที่ต้องการลบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnSupplierFind_Click(sender As Object, e As EventArgs) Handles btnSupplierFind.Click
        If Len(txtSup_id.Text) = 0 Then
            sql = "select * from supplier where Sup_id = '1' "
        Else
            sql = "select * from supplier where Sup_id = '" & txtSup_id.Text & "';"
        End If
        getDatagrid(dgrSupplier, sql)
    End Sub
End Class