<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/416712979/21.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1036926)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to Create a Heatmap Chart Based on a Data Source

This example shows how to create a heatmap and bind it to a data source. In this example, the heatmap obtains data from an XML file.

![Resulting heatmap](Images/heatmap.png)

To bind a heatmap to a data source, follow the steps below:

- Create a [HeatmapDataSourceAdapter](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapDataSourceAdapter?v=21.2&p=netframework) object. 

- Specify adapter properties listed below:

    - [DataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapDataSourceAdapter.DataSource?v=21.2)
    - [ColorDataMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapDataSourceAdapter.ColorDataMember?v=21.2)
    - [XArgumentDataMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapDataSourceAdapter.XArgumentDataMember?v=21.2)
    - [YArgumentDataMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapDataSourceAdapter.YArgumentDataMember?v=21.2)

- Assign the adapter object to the [HeatmapControl.DataAdapter](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapControl.DataAdapter?v=21.2) property.

<!-- default file list -->
## Files to Look At

- [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
- [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))

<!-- default file list end -->

## Documentation

- [HeatmapControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapControl?v=21.2)

## More Examples

- [How to Create a Heatmap Based on Arrays of String and Numeric Values](https://github.com/DevExpress-Examples/wpf-heatmap-matrix-data)
