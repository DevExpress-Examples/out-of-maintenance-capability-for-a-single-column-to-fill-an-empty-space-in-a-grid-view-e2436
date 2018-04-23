Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base

Namespace FillEmptySpaceGridColumn
    Public Class FillGridInfoRegistrator
        Inherits GridInfoRegistrator

        Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
            Return New FillGridView(TryCast(grid, GridControl))
        End Function

        Public Overrides ReadOnly Property ViewName() As String
            Get
                Return "FillGridView"
            End Get
        End Property
    End Class
End Namespace
