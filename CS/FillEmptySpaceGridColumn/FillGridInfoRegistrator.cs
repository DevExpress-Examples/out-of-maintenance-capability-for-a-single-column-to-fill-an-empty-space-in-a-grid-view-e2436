using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace FillEmptySpaceGridColumn
{
	public class FillGridInfoRegistrator : GridInfoRegistrator
	{
		public override BaseView CreateView(GridControl grid)
		{
			return new FillGridView(grid as GridControl);
		}

		public override string ViewName
		{
			get
			{
				return "FillGridView";
			}
		}
	}
}
