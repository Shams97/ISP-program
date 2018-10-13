Partial Class ISP_program1DataSet
    Partial Class cardsDataTable

        Private Sub cardsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me._partoke_dateColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class towersDataTable

        Private Sub towersDataTable_towersRowChanging(sender As Object, e As towersRowChangeEvent) Handles Me.towersRowChanging

        End Sub

    End Class

End Class
