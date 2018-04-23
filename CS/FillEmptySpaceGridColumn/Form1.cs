using System;
using System.Windows.Forms;

namespace FillEmptySpaceGridColumn
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
		}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fillGridView1.Columns["HP"].Visible = !fillGridView1.Columns["HP"].Visible;
        }
	}

}