Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.DataSet

Public Class mainpage
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ISP program1.mdb")
    Dim cmd As New OleDbCommand("", conn)
    Private Sub slct_Click(sender As Object, e As EventArgs) Handles slct.Click
        Try

            conn.Open()
            Dim table As New DataTable("users")
            Dim rs As New OleDb.OleDbDataAdapter("select * from users ", conn)
            rs.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.Refresh()
            rs.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles towersInfo.Click
        towers_info.Show()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Try

            conn.Open()

            Dim tabel As New DataTable("users")
            Dim sqladd As String = "INSERT INTO users([owners-no],[owners-name])VALUES('" & InputBox("Enter id to add ") & "','" & InputBox("Enter name to add ") & "')"
            Dim sql As New OleDb.OleDbDataAdapter(sqladd, conn)
            sql.Fill(tabel)
            MessageBox.Show("Done Add New Owner", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cards.Show()
    End Sub
    Function GetTable(SQLselect As String) As DataTable
        Try
            Dim dataTable As New DataTable()
            If conn.State = ConnectionState.Closed Then conn.Open()
            cmd.CommandText = SQLselect
            dataTable.Load(cmd.ExecuteReader())
            Return dataTable
        Catch ex As Exception
            MsgBox(ex.Message)
            Return New DataTable()
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Try
            conn.Open()
            Dim table As New DataTable("users")
            Dim rs As New OleDb.OleDbDataAdapter("DELETE FROM users WHERE ([owners-no])VALUES('" & InputBox("enter  Id number ") & "')", conn)
            rs.Fill(table)
            'rs.Dispose()
            DataGridView1.DataSource = table
            DataGridView1.Refresh()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub


    Private Sub mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ISP_program1DataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.ISP_program1DataSet.users)

    End Sub

    Private Sub upate_Click(sender As Object, e As EventArgs) Handles upate.Click
        conn.Open()
        Dim x As Integer
        x = InputBox("Enter ID")
        Dim q As String = "SELECT * FROM users WHERE owners-no=" & x
        Dim cmd As New OleDb.OleDbCommand(q, conn)
        Dim z As String
        Dim n As Integer
        z = InputBox("Enter name of the owner")
        ' n = InputBox("Enter Age")
        q = ("UPDATE users SET owners-name='" & z & "'WHERE owners-no='" & x & "')")

        cmd = New OleDb.OleDbCommand(q, conn)
        cmd.ExecuteNonQuery()
        conn.Close()

        'Try

        '    conn.Open()
        '    Dim table As New DataTable("users")
        '    Dim rs As New OleDb.OleDbDataAdapter("UPDATE users SET owners-no='" & InputBox("enter id :") & "',owners-name='" & InputBox("enter name :") & "' Where owners-no=" & InputBox("") & ";  ", conn)
        '    rs.Fill(table)
        '    rs.Dispose()

        '    conn.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub
End Class