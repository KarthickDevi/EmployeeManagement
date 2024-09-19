Imports System.Data.SqlClient
Public Class ApplicationMain
    Public Shared Conn As New SqlConnection
    Public Shared Sub Show_Form(oFrmName As Form)
        oFrmName.Show()
    End Sub

    Public Shared Sub GetConnection()
        Conn = New SqlConnection()
        Conn.ConnectionString = "data source = KARTHI\SQLEXPRESS;database = EmployeeDb;integrated security=true"
        ''Conn.ConnectionString = "data source = KARTHI\SQLEXPRESS;Initial Catalog=EmployeeDb;Integrated security =True"
        ''Conn.Open()

    End Sub
End Class
