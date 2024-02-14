<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditSupplier
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
        dgrSupplier = New DataGridView()
        txtContractname = New TextBox()
        txtSup_tel = New TextBox()
        txtSup_address = New TextBox()
        txtSup_name = New TextBox()
        txtSup_id = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        cmbProvinceName = New ComboBox()
        txtprovinceId = New TextBox()
        btnSupplierFind = New Button()
        Label6 = New Label()
        Label5 = New Label()
        btnCancel = New Button()
        btnSave = New Button()
        CType(dgrSupplier, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgrSupplier
        ' 
        dgrSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgrSupplier.Location = New Point(470, 20)
        dgrSupplier.Name = "dgrSupplier"
        dgrSupplier.Size = New Size(318, 418)
        dgrSupplier.TabIndex = 8
        ' 
        ' txtContractname
        ' 
        txtContractname.Location = New Point(117, 347)
        txtContractname.Name = "txtContractname"
        txtContractname.Size = New Size(302, 23)
        txtContractname.TabIndex = 18
        ' 
        ' txtSup_tel
        ' 
        txtSup_tel.Location = New Point(136, 304)
        txtSup_tel.Name = "txtSup_tel"
        txtSup_tel.Size = New Size(283, 23)
        txtSup_tel.TabIndex = 17
        ' 
        ' txtSup_address
        ' 
        txtSup_address.Location = New Point(117, 105)
        txtSup_address.Multiline = True
        txtSup_address.Name = "txtSup_address"
        txtSup_address.Size = New Size(302, 115)
        txtSup_address.TabIndex = 14
        ' 
        ' txtSup_name
        ' 
        txtSup_name.Location = New Point(117, 62)
        txtSup_name.Name = "txtSup_name"
        txtSup_name.Size = New Size(302, 23)
        txtSup_name.TabIndex = 13
        ' 
        ' txtSup_id
        ' 
        txtSup_id.Location = New Point(117, 26)
        txtSup_id.Name = "txtSup_id"
        txtSup_id.Size = New Size(185, 23)
        txtSup_id.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(18, 350)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 15)
        Label8.TabIndex = 11
        Label8.Text = "ชื่อผู้ติดต่อ"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 312)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 15)
        Label7.TabIndex = 10
        Label7.Text = "หมายเลขโทรศัพท์ติดต่อ"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 6
        Label3.Text = "ที่อยู่ผู้จัดจำหน่าย"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 5
        Label2.Text = "ชื่อผู้จัดจำหน่าย"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 15)
        Label1.TabIndex = 4
        Label1.Text = "เลขที่ผู้จัดจำหน่าย"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cmbProvinceName)
        GroupBox1.Controls.Add(txtContractname)
        GroupBox1.Controls.Add(txtSup_tel)
        GroupBox1.Controls.Add(txtprovinceId)
        GroupBox1.Controls.Add(txtSup_address)
        GroupBox1.Controls.Add(txtSup_name)
        GroupBox1.Controls.Add(txtSup_id)
        GroupBox1.Controls.Add(btnSupplierFind)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 50)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(438, 388)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' cmbProvinceName
        ' 
        cmbProvinceName.FormattingEnabled = True
        cmbProvinceName.Location = New Point(117, 234)
        cmbProvinceName.Name = "cmbProvinceName"
        cmbProvinceName.Size = New Size(302, 23)
        cmbProvinceName.TabIndex = 19
        ' 
        ' txtprovinceId
        ' 
        txtprovinceId.Location = New Point(117, 265)
        txtprovinceId.Name = "txtprovinceId"
        txtprovinceId.Size = New Size(302, 23)
        txtprovinceId.TabIndex = 16
        ' 
        ' btnSupplierFind
        ' 
        btnSupplierFind.Location = New Point(344, 29)
        btnSupplierFind.Name = "btnSupplierFind"
        btnSupplierFind.Size = New Size(75, 23)
        btnSupplierFind.TabIndex = 4
        btnSupplierFind.Text = "ค้นหา"
        btnSupplierFind.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 273)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 9
        Label6.Text = "รหัสจังหวัด"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 8
        Label5.Text = "ชื่อจังหวัด"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(239, 12)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 6
        btnCancel.Text = "ยกเลิก"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(122, 12)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 5
        btnSave.Text = "ตกลง"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' FrmEditSupplier
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgrSupplier)
        Controls.Add(GroupBox1)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Name = "FrmEditSupplier"
        Text = "FrmEditSupplier"
        CType(dgrSupplier, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgrSupplier As DataGridView
    Friend WithEvents txtContractname As TextBox
    Friend WithEvents txtSup_tel As TextBox
    Friend WithEvents txtSup_address As TextBox
    Friend WithEvents txtSup_name As TextBox
    Friend WithEvents txtSup_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbProvinceName As ComboBox
    Friend WithEvents txtprovinceId As TextBox
    Friend WithEvents btnSupplierFind As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
