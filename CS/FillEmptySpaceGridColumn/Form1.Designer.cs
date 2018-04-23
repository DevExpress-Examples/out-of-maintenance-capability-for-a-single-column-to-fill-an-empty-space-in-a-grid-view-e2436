namespace FillEmptySpaceGridColumn
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDBDataSet = new FillEmptySpaceGridColumn.CarsDBDataSet();
            this.carsTableAdapter = new FillEmptySpaceGridColumn.CarsDBDataSetTableAdapters.CarsTableAdapter();
            this.gridControlOverride1 = new FillEmptySpaceGridColumn.GridControlOverride();
            this.fillGridView1 = new FillEmptySpaceGridColumn.FillGridView();
            this.colID = new FillEmptySpaceGridColumn.FillGridColumn();
            this.colTrademark = new FillEmptySpaceGridColumn.FillGridColumn();
            this.colModel = new FillEmptySpaceGridColumn.FillGridColumn();
            this.colHP = new FillEmptySpaceGridColumn.FillGridColumn();
            this.colLiter = new FillEmptySpaceGridColumn.FillGridColumn();
            this.colCyl = new FillEmptySpaceGridColumn.FillGridColumn();
            this.colTransmissSpeedCount = new FillEmptySpaceGridColumn.FillGridColumn();
            this.colTransmissAutomatic = new FillEmptySpaceGridColumn.FillGridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOverride1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carsDBDataSet;
            // 
            // carsDBDataSet
            // 
            this.carsDBDataSet.DataSetName = "CarsDBDataSet";
            this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // gridControlOverride1
            // 
            this.gridControlOverride1.DataSource = this.carsBindingSource;
            this.gridControlOverride1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOverride1.Location = new System.Drawing.Point(0, 0);
            this.gridControlOverride1.MainView = this.fillGridView1;
            this.gridControlOverride1.Name = "gridControlOverride1";
            this.gridControlOverride1.Size = new System.Drawing.Size(670, 491);
            this.gridControlOverride1.TabIndex = 0;
            this.gridControlOverride1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fillGridView1});
            // 
            // fillGridView1
            // 
            this.fillGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTrademark,
            this.colModel,
            this.colHP,
            this.colLiter,
            this.colCyl,
            this.colTransmissSpeedCount,
            this.colTransmissAutomatic});
            this.fillGridView1.GridControl = this.gridControlOverride1;
            this.fillGridView1.Name = "fillGridView1";
            this.fillGridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.FillEmptySpace = false;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 33;
            // 
            // colTrademark
            // 
            this.colTrademark.FieldName = "Trademark";
            this.colTrademark.FillEmptySpace = false;
            this.colTrademark.Name = "colTrademark";
            this.colTrademark.Visible = true;
            this.colTrademark.VisibleIndex = 1;
            this.colTrademark.Width = 73;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.FillEmptySpace = false;
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 2;
            this.colModel.Width = 50;
            // 
            // colHP
            // 
            this.colHP.FieldName = "HP";
            this.colHP.FillEmptySpace = false;
            this.colHP.Name = "colHP";
            this.colHP.Visible = true;
            this.colHP.VisibleIndex = 3;
            this.colHP.Width = 35;
            // 
            // colLiter
            // 
            this.colLiter.FieldName = "Liter";
            this.colLiter.FillEmptySpace = false;
            this.colLiter.Name = "colLiter";
            this.colLiter.Visible = true;
            this.colLiter.VisibleIndex = 4;
            this.colLiter.Width = 43;
            // 
            // colCyl
            // 
            this.colCyl.FieldName = "Cyl";
            this.colCyl.FillEmptySpace = false;
            this.colCyl.Name = "colCyl";
            this.colCyl.Visible = true;
            this.colCyl.VisibleIndex = 5;
            this.colCyl.Width = 37;
            // 
            // colTransmissSpeedCount
            // 
            this.colTransmissSpeedCount.FieldName = "TransmissSpeedCount";
            this.colTransmissSpeedCount.FillEmptySpace = false;
            this.colTransmissSpeedCount.Name = "colTransmissSpeedCount";
            this.colTransmissSpeedCount.Visible = true;
            this.colTransmissSpeedCount.VisibleIndex = 6;
            this.colTransmissSpeedCount.Width = 134;
            // 
            // colTransmissAutomatic
            // 
            this.colTransmissAutomatic.FieldName = "TransmissAutomatic";
            this.colTransmissAutomatic.FillEmptySpace = true;
            this.colTransmissAutomatic.Name = "colTransmissAutomatic";
            this.colTransmissAutomatic.Visible = true;
            this.colTransmissAutomatic.VisibleIndex = 7;
            this.colTransmissAutomatic.Width = 244;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 456);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Hide HP column";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 491);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControlOverride1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOverride1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillGridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private CarsDBDataSet carsDBDataSet;
		private System.Windows.Forms.BindingSource carsBindingSource;
		private CarsDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
		private GridControlOverride gridControlOverride1;
		private FillGridView fillGridView1;
		private FillGridColumn colID;
		private FillGridColumn colTrademark;
		private FillGridColumn colModel;
		private FillGridColumn colHP;
		private FillGridColumn colLiter;
		private FillGridColumn colCyl;
		private FillGridColumn colTransmissSpeedCount;
		private FillGridColumn colTransmissAutomatic;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

	}
}

