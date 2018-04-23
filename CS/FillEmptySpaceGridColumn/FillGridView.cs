using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace FillEmptySpaceGridColumn
{
	public class FillGridView : GridView
	{
		private bool needColumnRecalc = false;

		public FillGridView(GridControl ownerGrid)
			: base(ownerGrid)
		{
		}
		public FillGridView()
		{
		}

		protected virtual void RecalculateColumnWidths()
		{
			FillGridColumn colToResize = null;
			int totalWidth = 0;
			for ( int i = 0; i < Columns.Count; i++ )
			{
                if (!Columns[i].Visible)
                    continue;
				if ( ((FillGridColumn)Columns[i]).FillEmptySpace )
					colToResize = (FillGridColumn)Columns[i];
				else
					totalWidth += Columns[i].Width;
			}

			if ( colToResize != null && ViewInfo.ViewRects.ColumnPanelWidth > 0 )
				colToResize.Width = ViewInfo.ViewRects.ColumnPanelWidth - totalWidth;
		}

		public override void LayoutChanged()
		{
			base.LayoutChanged();
			if ( needColumnRecalc )
				return;

			needColumnRecalc = true;
			if ( !OptionsView.ColumnAutoWidth )
				RecalculateColumnWidths();
			needColumnRecalc = false;
		}

		protected override string ViewName
		{
			get
			{
				return "FillGridView";
			}
		}

		protected override GridColumnCollection CreateColumnCollection()
		{
			return new FillGridColumnCollection(this);
		}

	}
}