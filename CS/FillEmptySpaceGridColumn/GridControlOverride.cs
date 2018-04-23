using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace FillEmptySpaceGridColumn
{
	public class GridControlOverride : GridControl
	{
		public GridControlOverride()
			: base()
		{
		}
		protected override BaseView CreateDefaultView()
		{
			return CreateView("FillGridView");
		}
		protected override void RegisterAvailableViewsCore(InfoCollection collection)
		{
			base.RegisterAvailableViewsCore(collection);
			collection.Add(new FillGridInfoRegistrator());
		}
	}

}
