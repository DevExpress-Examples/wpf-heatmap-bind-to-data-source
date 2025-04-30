<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/417465220/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1036997)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Chart for WPF - Create a Heatmap Chart Based on a Data Source

This example shows how to create a heatmap and bind it to a data source. In this example, the heatmap obtains data from an XML file.

![Resulting heatmap](Images/heatmap.png)

To bind a heatmap to a data source, follow the steps below:

- Create a [HeatmapDataSourceAdapter](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapDataSourceAdapter?v=21.2&p=netframework) object. 

- Specify adapter properties listed below:

    - [DataSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapDataSourceAdapter.DataSource)
    - [ColorDataMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapDataSourceAdapter.ColorDataMember)
    - [XArgumentDataMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapDataSourceAdapter.XArgumentDataMember)
    - [YArgumentDataMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapDataSourceAdapter.YArgumentDataMember)

- Assign the adapter object to the [HeatmapControl.DataAdapter](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapControl.DataAdapter) property.

<!-- default file list -->
## Files to Review

- [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
- [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))

<!-- default file list end -->

## Documentation

- [HeatmapControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Heatmap.HeatmapControl)

## More Examples

- [How to Create a Heatmap Based on Arrays of String and Numeric Values](https://github.com/DevExpress-Examples/wpf-heatmap-matrix-data)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-heatmap-bind-to-data-source&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-heatmap-bind-to-data-source&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
