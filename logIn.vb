Imports System.Data
Imports System.IO
Imports System.Data.OleDb

Public Class LogIn
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ISP program1.mdb")
    Dim cmd As New OleDbCommand("", conn)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            conn.Open()

            Dim tabel As New DataTable("signUp")
            Dim sql As New OleDb.OleDbDataAdapter(" SELECT * FROM signUp", conn)

            If sql.Fill(tabel) Then
                Me.Hide()
                mainpage.Show()
                conn.Close()
            ElseIf sql.Update(tabel) Then
                registeration.Show()
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()

    End Sub

    Private Function TestBindingSource() As Object
        Throw New NotImplementedException
    End Function

    Private Function TableAdapterManager() As Object
        Throw New NotImplementedException
    End Function

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
