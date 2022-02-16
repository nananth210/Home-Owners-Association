Partial Class ProjectDataSet
    Partial Public Class GroupByStateDataTable
        Private Sub GroupByStateDataTable_GroupByStateRowChanging(sender As Object, e As GroupByStateRowChangeEvent) Handles Me.GroupByStateRowChanging

        End Sub

    End Class

    Partial Public Class SALESPERSONDataTable


    End Class

    Partial Public Class MODELDataTable
        Private Sub MODELDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.BASE_PRICEColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class SALESPERSON_RATINGSDataTable
        Private Sub SALESPERSON_RATINGSDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.RATING_COMMENTSColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace ProjectDataSetTableAdapters
    Partial Public Class MODELTableAdapter
        Overloads Sub ModelbyDoubleInput(mODEL As ProjectDataSet.MODELDataTable, v As Decimal)
            Throw New NotImplementedException()
        End Sub

        Overloads Function CountModelbyDoubleInput(mODEL As ProjectDataSet.MODELDataTable, v As Decimal) As String
            Throw New NotImplementedException()
        End Function
        'Friend Sub ModelbyDoubleInput(mODEL As ProjectDataSet.MODELDataTable, v As Decimal)
        'Throw New NotImplementedException()
        ' End Sub
    End Class
End Namespace