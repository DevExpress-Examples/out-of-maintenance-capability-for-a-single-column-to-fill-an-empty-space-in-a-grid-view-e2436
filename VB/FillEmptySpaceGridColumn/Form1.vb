Imports System
Imports System.Windows.Forms

Namespace FillEmptySpaceGridColumn
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.carsTableAdapter.Fill(Me.carsDBDataSet_Renamed.Cars)
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            fillGridView1.Columns("HP").Visible = Not fillGridView1.Columns("HP").Visible
        End Sub
    End Class

End Namespace