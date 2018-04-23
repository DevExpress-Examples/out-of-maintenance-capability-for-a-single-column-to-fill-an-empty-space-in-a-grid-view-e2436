Namespace FillEmptySpaceGridColumn
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsDBDataSet_Renamed = New FillEmptySpaceGridColumn.CarsDBDataSet()
            Me.carsTableAdapter = New FillEmptySpaceGridColumn.CarsDBDataSetTableAdapters.CarsTableAdapter()
            Me.gridControlOverride1 = New FillEmptySpaceGridColumn.GridControlOverride()
            Me.fillGridView1 = New FillEmptySpaceGridColumn.FillGridView()
            Me.colID = New FillEmptySpaceGridColumn.FillGridColumn()
            Me.colTrademark = New FillEmptySpaceGridColumn.FillGridColumn()
            Me.colModel = New FillEmptySpaceGridColumn.FillGridColumn()
            Me.colHP = New FillEmptySpaceGridColumn.FillGridColumn()
            Me.colLiter = New FillEmptySpaceGridColumn.FillGridColumn()
            Me.colCyl = New FillEmptySpaceGridColumn.FillGridColumn()
            Me.colTransmissSpeedCount = New FillEmptySpaceGridColumn.FillGridColumn()
            Me.colTransmissAutomatic = New FillEmptySpaceGridColumn.FillGridColumn()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            DirectCast(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControlOverride1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.fillGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' carsBindingSource
            ' 
            Me.carsBindingSource.DataMember = "Cars"
            Me.carsBindingSource.DataSource = Me.carsDBDataSet_Renamed
            ' 
            ' carsDBDataSet
            ' 
            Me.carsDBDataSet_Renamed.DataSetName = "CarsDBDataSet"
            Me.carsDBDataSet_Renamed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' carsTableAdapter
            ' 
            Me.carsTableAdapter.ClearBeforeFill = True
            ' 
            ' gridControlOverride1
            ' 
            Me.gridControlOverride1.DataSource = Me.carsBindingSource
            Me.gridControlOverride1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControlOverride1.Location = New System.Drawing.Point(0, 0)
            Me.gridControlOverride1.MainView = Me.fillGridView1
            Me.gridControlOverride1.Name = "gridControlOverride1"
            Me.gridControlOverride1.Size = New System.Drawing.Size(670, 491)
            Me.gridControlOverride1.TabIndex = 0
            Me.gridControlOverride1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.fillGridView1})
            ' 
            ' fillGridView1
            ' 
            Me.fillGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colTrademark, Me.colModel, Me.colHP, Me.colLiter, Me.colCyl, Me.colTransmissSpeedCount, Me.colTransmissAutomatic})
            Me.fillGridView1.GridControl = Me.gridControlOverride1
            Me.fillGridView1.Name = "fillGridView1"
            Me.fillGridView1.OptionsView.ColumnAutoWidth = False
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.FillEmptySpace = False
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            Me.colID.Width = 33
            ' 
            ' colTrademark
            ' 
            Me.colTrademark.FieldName = "Trademark"
            Me.colTrademark.FillEmptySpace = False
            Me.colTrademark.Name = "colTrademark"
            Me.colTrademark.Visible = True
            Me.colTrademark.VisibleIndex = 1
            Me.colTrademark.Width = 73
            ' 
            ' colModel
            ' 
            Me.colModel.FieldName = "Model"
            Me.colModel.FillEmptySpace = False
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 2
            Me.colModel.Width = 50
            ' 
            ' colHP
            ' 
            Me.colHP.FieldName = "HP"
            Me.colHP.FillEmptySpace = False
            Me.colHP.Name = "colHP"
            Me.colHP.Visible = True
            Me.colHP.VisibleIndex = 3
            Me.colHP.Width = 35
            ' 
            ' colLiter
            ' 
            Me.colLiter.FieldName = "Liter"
            Me.colLiter.FillEmptySpace = False
            Me.colLiter.Name = "colLiter"
            Me.colLiter.Visible = True
            Me.colLiter.VisibleIndex = 4
            Me.colLiter.Width = 43
            ' 
            ' colCyl
            ' 
            Me.colCyl.FieldName = "Cyl"
            Me.colCyl.FillEmptySpace = False
            Me.colCyl.Name = "colCyl"
            Me.colCyl.Visible = True
            Me.colCyl.VisibleIndex = 5
            Me.colCyl.Width = 37
            ' 
            ' colTransmissSpeedCount
            ' 
            Me.colTransmissSpeedCount.FieldName = "TransmissSpeedCount"
            Me.colTransmissSpeedCount.FillEmptySpace = False
            Me.colTransmissSpeedCount.Name = "colTransmissSpeedCount"
            Me.colTransmissSpeedCount.Visible = True
            Me.colTransmissSpeedCount.VisibleIndex = 6
            Me.colTransmissSpeedCount.Width = 134
            ' 
            ' colTransmissAutomatic
            ' 
            Me.colTransmissAutomatic.FieldName = "TransmissAutomatic"
            Me.colTransmissAutomatic.FillEmptySpace = True
            Me.colTransmissAutomatic.Name = "colTransmissAutomatic"
            Me.colTransmissAutomatic.Visible = True
            Me.colTransmissAutomatic.VisibleIndex = 7
            Me.colTransmissAutomatic.Width = 244
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(12, 456)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(93, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Hide HP column"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(670, 491)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.gridControlOverride1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControlOverride1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.fillGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region


        Private carsDBDataSet_Renamed As CarsDBDataSet
        Private carsBindingSource As System.Windows.Forms.BindingSource
        Private carsTableAdapter As CarsDBDataSetTableAdapters.CarsTableAdapter
        Private gridControlOverride1 As GridControlOverride
        Private fillGridView1 As FillGridView
        Private colID As FillGridColumn
        Private colTrademark As FillGridColumn
        Private colModel As FillGridColumn
        Private colHP As FillGridColumn
        Private colLiter As FillGridColumn
        Private colCyl As FillGridColumn
        Private colTransmissSpeedCount As FillGridColumn
        Private colTransmissAutomatic As FillGridColumn
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton

    End Class
End Namespace

