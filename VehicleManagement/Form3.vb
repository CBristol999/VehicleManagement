Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class Form3
    Dim query As String
    Dim tableinfo As DataTable 'hold record from mysql
    Dim da As MySqlDataAdapter 'handle sql query

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        databaseConnect()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            query = "SELECT * FROM vehicleInfo where vID = '" + txtSearch.Text + "' "

            'send sql query to server
            da = New MySqlDataAdapter(query, datacon)
            tableinfo = New DataTable

            'fill the table
            da.Fill(tableinfo)

            Dim myDataReport As New CrystalReport1()
            myDataReport.SetDataSource(tableinfo)
            CrystalReportViewer1.ReportSource = myDataReport

            datacon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            datacon.Close()
        End Try
    End Sub

End Class