Imports MySql.Data.MySqlClient

Public Class Form2
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim model, plateno, type As String
    Dim query As String

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        model = txtModel.Text
        type = txtType.Text
        plateno = txtPlate.Text
        query = "INSERT INTO vehicleinfo(vType," & "plateNo, vModel) VALUES ('" & type & "','" & plateno & "','" &
            model & "')"

        If type <> "" And model <> "" And plateno <> "" Then
            Try
                With cmd
                    .Connection = datacon
                    .CommandText = query
                    result = .ExecuteNonQuery
                    If result > 0 Then
                        MsgBox("saved successfully")
                        txtModel.Clear()
                        txtPlate.Clear()
                        txtType.Clear()

                    Else
                        MsgBox("Failed to Insert Record")
                    End If
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        databaseConnect()

    End Sub
End Class