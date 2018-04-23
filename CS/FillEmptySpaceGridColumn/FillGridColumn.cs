using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace FillEmptySpaceGridColumn
{
	public class FillGridColumn : GridColumn
	{
		private bool fillEmptySpace = false;

		public FillGridColumn()
			: base()
		{
		}

		protected virtual void SetFillEmptySpace(bool value)
		{
			fillEmptySpace = value;
			if ( IsLoading || View == null )
				return;

			if ( fillEmptySpace )
			{
				this.Width += 1;
				for ( int i = 0; i < View.Columns.Count; i++ )
					if ( View.Columns[i] != this && ((FillGridColumn)View.Columns[i]).FillEmptySpace )
					{
						((FillGridColumn)View.Columns[i]).FillEmptySpace = false;
						return;
					}
			}
			else
			{
				this.BestFit();
			}
		}

		public bool FillEmptySpace
		{
			get
			{
				return fillEmptySpace;
			}
			set
			{
				SetFillEmptySpace(value);
			}
		}

	}
}