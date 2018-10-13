Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.DataSet
Imports System.Random
Public Class cards
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ISP program1.mdb")
    Dim cmd As New OleDbCommand("", conn)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ISP_program1DataSet.towers' table. You can move, or remove it, as needed.
        Me.TowersTableAdapter.Fill(Me.ISP_program1DataSet.towers)
        'TODO: This line of code loads data into the 'ISP_program1DataSet.cards' table. You can move, or remove it, as needed.
        Me.CardsTableAdapter.Fill(Me.ISP_program1DataSet.cards)

    End Sub

    Private Sub slct_Click(sender As Object, e As EventArgs) Handles slct.Click
        Try

            conn.Open()
            Dim table As New DataTable("cards")
            Dim rs As New OleDb.OleDbDataAdapter("select * from cards ", conn)
            rs.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.Refresh()
            rs.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        conn.Open()
        Dim z As String
        z = InputBox("Enter no of the card:")
        Dim q As String = "INSERT INTO cards([cards-no],[partoke-date],[cards-ID])VALUES('" & z & "','" & InputBox("enter partoke date") & "','" & InputBox("enter ID Card less than 9") & "')"
        Dim cmd As New OleDb.OleDbCommand(q, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Done Adding new Card ")
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim r As New Random
        Dim c As Integer = r.Next(1, 9)
        DataGridView1.Rows().Add.Equals(c)
    End Sub

    Private Sub ext_Click(sender As Object, e As EventArgs) Handles ext.Click
        End
    End Sub

    Private Sub bck_Click(sender As Object, e As EventArgs) Handles bck.Click
        Me.Close()
        mainpage.Show()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

    End Sub
End Class
