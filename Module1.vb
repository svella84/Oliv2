Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Module Module1
    Public stringaconn As String
    Public stringasql As String
    Public stringasql2 As String

    Public connection As SqlConnection
    Public cmd As SqlCommand

    'Public ds As DataSet
    'Public da As SqlDataAdapter
    'Public bs As BindingSource

    Public Sub ApriConnessione()

        stringaconn = "Data Source=(LocalDB)\v11.0;"
        stringaconn = stringaconn & "AttachDbFilename=|DataDirectory|\Database\OLIVER.mdf;;Integrated Security=True;Connect Timeout=30"
        connection = New SqlConnection(stringaconn)
        connection.Open()

    End Sub

    Public Sub ChiudiConnessione()

        connection.Close()

    End Sub


End Module
