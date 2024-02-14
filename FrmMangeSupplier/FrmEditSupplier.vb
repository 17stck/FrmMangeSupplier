Imports Org.BouncyCastle.Crypto

Public Class FrmEditSupplier

    ' ประกาศตัวแปรสำหรับเก็บข้อมูลซัพพลายเออร์
    Private _Sup_id As String
    Private _Sup_name As String
    Private _Sup_address As String
    Private _Sup_tel As String
    Private _Contract_name As String

    ' สร้าง property สำหรับเข้าถึงและกำหนดค่าข้อมูลซัพพลายเออร์
    Public Property Sup_id() As String
        Get
            Return _Sup_id
        End Get
        Set(ByVal value As String)
            _Sup_id = value
            txtSup_id.Text = value
        End Set
    End Property

    Public Property Sup_name() As String
        Get
            Return _Sup_name
        End Get
        Set(ByVal value As String)
            _Sup_name = value
            txtSup_name.Text = value ' กำหนดค่าข้อมูลลงใน TextBox
        End Set
    End Property

    Public Property Sup_address() As String
        Get
            Return _Sup_address
        End Get
        Set(ByVal value As String)
            _Sup_address = value
            txtSup_address.Text = value ' กำหนดค่าข้อมูลลงใน TextBox
        End Set
    End Property

    Public Property Sup_tel() As String
        Get
            Return _Sup_tel
        End Get
        Set(ByVal value As String)
            _Sup_tel = value
            txtSup_tel.Text = value ' กำหนดค่าข้อมูลลงใน TextBox
        End Set
    End Property

    Public Property Contract_name() As String
        Get
            Return _Contract_name
        End Get
        Set(ByVal value As String)
            _Contract_name = value
            txtContractname.Text = value ' กำหนดค่าข้อมูลลงใน TextBox
        End Set
    End Property

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' รับค่าข้อมูลที่ต้องการอัปเดตจาก TextBox
        Dim idsup As String = txtSup_id.Text
        Dim namesup As String = txtSup_name.Text
        Dim addsup As String = txtSup_address.Text
        Dim telsup As String = txtSup_tel.Text
        Dim contractsup As String = txtContractname.Text

        ' สร้างคำสั่ง SQL UPDATE โดยระบุตาราง supplier และคอลัมน์ที่ต้องการอัปเดตพร้อมค่าใหม่
        Dim sql As String = "UPDATE supplier SET Sup_name = '" & namesup & "', Sup_Address = '" & addsup & "', Sup_tel = '" & telsup & "', Contract_name = '" & contractsup & "' WHERE Sup_id = '" & idsup & "'"

        ' เรียกใช้เมทอด ExecuteSQL เพื่อทำการอัปเดตข้อมูลในฐานข้อมูล
        If ExecuteSQL(sql) Then
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' ปิดฟอร์มแก้ไขซัพพลายเออร์เมื่อเสร็จสิ้น
            Me.Close()
        Else
            MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' ปิดฟอร์มแก้ไขซัพพลายเออร์โดยไม่บันทึกการเปลี่ยน
        Me.Close()
    End Sub
End Class
