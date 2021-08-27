<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128624143/10.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2436)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [FillGridColumn.cs](./CS/FillEmptySpaceGridColumn/FillGridColumn.cs)
* [FillGridColumnCollection.cs](./CS/FillEmptySpaceGridColumn/FillGridColumnCollection.cs)
* [FillGridInfoRegistrator.cs](./CS/FillEmptySpaceGridColumn/FillGridInfoRegistrator.cs)
* [FillGridView.cs](./CS/FillEmptySpaceGridColumn/FillGridView.cs)
* [Form1.cs](./CS/FillEmptySpaceGridColumn/Form1.cs)
* [GridControlOverride.cs](./CS/FillEmptySpaceGridColumn/GridControlOverride.cs)
* [Program.cs](./CS/FillEmptySpaceGridColumn/Program.cs)
<!-- default file list end -->
# Capability for a single column to fill an empty space in a grid view


<p>We implemented this feature in <strong>v17.1</strong>. Assign a column to the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.AutoFillColumn.property">GridView.AutoFillColumn Property</a>.<br><br><strong>[For older versions]</strong><br>In this example we added a FillEmptySpace option to the GridColumn descendant. Only one column in the grid view can have this option enabled, i.e. if you set the FillEmptySpace property to true for a single column other columns immediately set this option to false themselves. Column with this option enabled now recalculates its width after every layout change in order to fill an empty space in the grid view. This feature won't work if the grid view's option OptionsView.ColumnAutoWidth is enabled.</p>

<br/>


