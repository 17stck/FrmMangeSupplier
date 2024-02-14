Imports MySql.Data.MySqlClient

Module Code
    Dim conn As New MySqlConnection
    Friend da As New MySqlDataAdapter
    Friend Dr As MySqlDataReader
    Friend sql As String
    Dim comm As New MySqlCommand
    Friend ds As New DataSet
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


    Friend Sub binddataToObject(obj As Object, prmsql As String)
        connectData()
        comm = New MySqlCommand(prmsql, conn)
        Dr = comm.ExecuteReader
        obj.items.clear()
        While Dr.Read
            obj.items.Add(Dr(0))
        End While
        Dr.Close()
    End Sub
    Friend Function getProvinceData(ByVal prmsql As String) As ClsProvince
        Dim obj As New ClsProvince()
        Dr = ExecuteReader(prmsql)
        Dr.Read()
        'ขั้นตอนการนำค่าที่อ่านจาก table มาแสดงที่ textBox
        obj._province_Id = Dr.Item("Province_id").ToString
        obj._province_Name = Dr.Item("Province_Name").ToString
        Return obj
    End Function

End Module
