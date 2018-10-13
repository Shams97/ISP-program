Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.DataSet
Public Class towers_info
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ISP program1.mdb")
    Dim cmd As New OleDbCommand("", conn)

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub towers_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ISP_program1DataSet.towers' table. You can move, or remove it, as needed.
        Me.TowersTableAdapter.Fill(Me.ISP_program1DataSet.towers)

    End Sub


    Private Sub slct_Click(sender As Object, e As EventArgs) Handles slct.Click
        Try

            conn.Open()
            Dim table As New DataTable("towers")
            Dim rs As New OleDb.OleDbDataAdapter("select * from towers ", conn)
            rs.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.Refresh()
            rs.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
    End Sub



   
    Private Sub ext_Click(sender As Object, e As EventArgs) Handles ext.Click
        End
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        conn.Open()
        Dim z As String
        z = InputBox("Enter id :")
        Dim q As String = "INSERT INTO cards([towers-no],[towers-name],[noOfUsers])VALUES('" & z & "','" & InputBox("enter the name") & "','" & InputBox("enter no of users") & "')"
        Dim cmd As New OleDb.OleDbCommand(q, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Done Adding new Tower")

    End Sub

    'Private Sub TowersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TowersBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.TowersBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ISP_program1DataSet)

    'End Sub

    'Private Sub BindingNavigator1_SaveItems_1(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems
    '    Me.Validate()
    '    Me.TowersBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ISP_program1DataSet)
    'End Sub
End Class