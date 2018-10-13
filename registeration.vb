Imports System.Data
Imports System.IO
Imports System.Data.OleDb
Public Class registeration
    Dim conn As New OleDbConnection
    

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            conn.Open()

            Dim tabel As New DataTable("signUp")
            ' Dim sqladd As String = " SELECT * FROM signUp(first name,last name,password,confirm password) values ('" & fname.Text & _
            ' "','" & secname.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            Dim sql As New OleDb.OleDbDataAdapter(" INSERT INTO * FROM signUp", conn)
            sql.Fill(tabel)
            MessageBox.Show("Done Add New Owner", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'c.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;" &
        ' "Data Source=C:\Users\Shams\Documents\IAP prgoram-DB.accdb")
        'Dim read As OleDbDataReader
        'c.Open()
        'Dim st As String
        'st = ("select * from signUp where first name='" & fname.Text & ";'")
        'Dim cmd As New OleDbCommand(st, c)
        'read = cmd.ExecuteReader()
        'Dim co = 0
        'While read.Read
        '    co += 1
        'End While
        'If co >= 1 Then
        '    MsgBox("This username has been taken !")
        '    read.Close()
        '    read.Close()
        '    If fname.Text = "" Or secname.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
        '        MsgBox("please, you have to fill all information")
        '    Else
        '        st = "Insert into signUp values('" & fname.Text & "','" & secname.Text & _
        '            "','" & TextBox3.Text & "','" & TextBox4.Text & "');"
        '        MsgBox("here is runing")
        '        ' "insert into signUp (first name,last name,password,confirmPassword) values ( '" & fname.Text & "','" & _
        '        ' secname.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        '        cmd = New OleDbCommand(st, c)
        '        read = cmd.ExecuteReader()
        '        MsgBox("Registeration is done !", MsgBoxStyle.Information, "Create")
        '        Me.Close()
        '    End If
        'End If
        'c.Close()

    End Sub
    Private Sub bck_Click(sender As Object, e As EventArgs) Handles bck.Click
        Me.Close()
        LogIn.Show()
    End Sub
End Class