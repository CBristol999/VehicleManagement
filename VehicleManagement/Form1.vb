Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form1
    Dim query As String
    Dim tableinfo As DataTable 'hold record from mysql
    Dim da As MySqlDataAdapter 'handle sql query


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'call databaseConnect procudure to open connection
        databaseConnect()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click

        Try
            query = "SELECT * FROM vehicleInfo"

            'send sql query to server
            da = New MySqlDataAdapter(query, datacon)
            tableinfo = New DataTable

            'fill the table
            da.Fill(tableinfo)

            'display record in data grid view
            dataRecord.DataSource = tableinfo

            'autoresize column width
            dataRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            datacon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            datacon.Close()
        End Try
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            query = "SELECT * FROM vehicleInfo"

            'send sql query to server
            da = New MySqlDataAdapter(query, datacon)
            tableinfo = New DataTable

            'fill the table
            da.Fill(tableinfo)

            datacon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            datacon.Close()
        End Try

        Form3.Show()
        Dim report As New ReportDocument
        report.Load("C:\Users\Admin\source\repos\VehicleManagement\CrystalReport1.rpt")
        Form3.CrystalReportViewer1.ReportSource = report
        Form3.CrystalReportViewer1.Refresh()

    End Sub
End Class
