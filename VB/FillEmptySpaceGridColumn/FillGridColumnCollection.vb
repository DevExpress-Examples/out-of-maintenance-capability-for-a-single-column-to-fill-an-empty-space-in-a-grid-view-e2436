Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Namespace FillEmptySpaceGridColumn
    Public Class FillGridColumnCollection
        Inherits GridColumnCollection

        Public Sub New(ByVal view As ColumnView)
            MyBase.New(view)
        End Sub

        Protected Overrides Function CreateColumn() As GridColumn
            Return New FillGridColumn()
        End Function
    End Class
End Namespace
