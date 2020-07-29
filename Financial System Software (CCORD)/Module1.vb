Imports System.Data.SqlClient
Module Module1
    Public cn As New SqlConnection("Data Source=.;Initial Catalog=VB;Integrated Security=True")
    Public cmd As New SqlCommand
    Public Da As New SqlDataAdapter
    Public dr As SqlDataReader
    Public ds As DataSet
    Public cb As SqlCommandBuilder
    Public table As New DataTable

End Module
