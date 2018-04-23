using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace FillEmptySpaceGridColumn
{
	public class FillGridColumnCollection : GridColumnCollection
	{
		public FillGridColumnCollection(ColumnView view)
			: base(view)
		{
		}

		protected override GridColumn CreateColumn()
		{
			return new FillGridColumn();
		}
	}
}
