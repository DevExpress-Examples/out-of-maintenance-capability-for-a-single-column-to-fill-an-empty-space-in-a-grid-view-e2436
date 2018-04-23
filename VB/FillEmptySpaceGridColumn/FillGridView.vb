Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Namespace FillEmptySpaceGridColumn
    Public Class FillGridView
        Inherits GridView

        Private needColumnRecalc As Boolean = False

        Public Sub New(ByVal ownerGrid As GridControl)
            MyBase.New(ownerGrid)
        End Sub
        Public Sub New()
        End Sub

        Protected Overridable Sub RecalculateColumnWidths()
            Dim colToResize As FillGridColumn = Nothing
            Dim totalWidth As Integer = 0
            For i As Integer = 0 To Columns.Count - 1
                If Not Columns(i).Visible Then
                    Continue For
                End If
                If CType(Columns(i), FillGridColumn).FillEmptySpace Then
                    colToResize = CType(Columns(i), FillGridColumn)
                Else
                    totalWidth += Columns(i).Width
                End If
            Next i

            If colToResize IsNot Nothing AndAlso ViewInfo.ViewRects.ColumnPanelWidth > 0 Then
                colToResize.Width = ViewInfo.ViewRects.ColumnPanelWidth - totalWidth
            End If
        End Sub

        Public Overrides Sub LayoutChanged()
            MyBase.LayoutChanged()
            If needColumnRecalc Then
                Return
            End If

            needColumnRecalc = True
            If Not OptionsView.ColumnAutoWidth Then
                RecalculateColumnWidths()
            End If
            needColumnRecalc = False
        End Sub

        Protected Overrides ReadOnly Property ViewName() As String
            Get
                Return "FillGridView"
            End Get
        End Property

        Protected Overrides Function CreateColumnCollection() As GridColumnCollection
            Return New FillGridColumnCollection(Me)
        End Function

    End Class
End Namespace