Attribute VB_Name = "moddatabase"
Public Sub Connect_To_DataBase()
    Set cn = New ADODB.connection
    cn.Provider = "Microsoft.Jet.OLEDB.4.0"
    cn.ConnectionString = App.Path + "\QLBH.mdb"
    cn.Open
End Sub

