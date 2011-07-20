//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart.series
namespace Ext.chart.series
{
    #region Radar
    /// <summary>
    /// Creates a Radar Chart. A Radar Chart is a useful visualization technique for comparing different quantitative values for
    /// a constrained number of categories.
    /// As with all other series, the Radar series must be appended in the series Chart array configuration. See the Chart
    /// documentation for more information. A typical configuration object for the radar series could be:  var store = Ext.create(&#39;Ext.data.JsonStore&#39;, {
    /// fields: [&#39;name&#39;, &#39;data1&#39;, &#39;data2&#39;, &#39;data3&#39;, &#39;data4&#39;, &#39;data5&#39;],
    /// data: [
    /// {&#39;name&#39;:&#39;metric one&#39;, &#39;data1&#39;:10, &#39;data2&#39;:12, &#39;data3&#39;:14, &#39;data4&#39;:8, &#39;data5&#39;:13},
    /// {&#39;name&#39;:&#39;metric two&#39;, &#39;data1&#39;:7, &#39;data2&#39;:8, &#39;data3&#39;:16, &#39;data4&#39;:10, &#39;data5&#39;:3},
    /// {&#39;name&#39;:&#39;metric three&#39;, &#39;data1&#39;:5, &#39;data2&#39;:2, &#39;data3&#39;:14, &#39;data4&#39;:12, &#39;data5&#39;:7},
    /// {&#39;name&#39;:&#39;metric four&#39;, &#39;data1&#39;:2, &#39;data2&#39;:14, &#39;data3&#39;:6, &#39;data4&#39;:1, &#39;data5&#39;:23},
    /// {&#39;name&#39;:&#39;metric five&#39;, &#39;data1&#39;:27, &#39;data2&#39;:38, &#39;data3&#39;:36, &#39;data4&#39;:13, &#39;data5&#39;:33}
    /// ]
    /// });
    /// Ext.create(&#39;Ext.chart.Chart&#39;, {
    /// renderTo: Ext.getBody(),
    /// width: 500,
    /// height: 300,
    /// animate: true,
    /// theme:&#39;Category2&#39;,
    /// store: store,
    /// axes: [{
    /// type: &#39;Radial&#39;,
    /// position: &#39;radial&#39;,
    /// label: {
    /// display: true
    /// }
    /// }],
    /// series: [{
    /// type: &#39;radar&#39;,
    /// xField: &#39;name&#39;,
    /// yField: &#39;data3&#39;,
    /// showInLegend: true,
    /// showMarkers: true,
    /// markerConfig: {
    /// radius: 5,
    /// size: 5
    /// },
    /// style: {
    /// &#39;stroke-width&#39;: 2,
    /// fill: &#39;none&#39;
    /// }
    /// },{
    /// type: &#39;radar&#39;,
    /// xField: &#39;name&#39;,
    /// yField: &#39;data2&#39;,
    /// showMarkers: true,
    /// showInLegend: true,
    /// markerConfig: {
    /// radius: 5,
    /// size: 5
    /// },
    /// style: {
    /// &#39;stroke-width&#39;: 2,
    /// fill: &#39;none&#39;
    /// }
    /// },{
    /// type: &#39;radar&#39;,
    /// xField: &#39;name&#39;,
    /// yField: &#39;data5&#39;,
    /// showMarkers: true,
    /// showInLegend: true,
    /// markerConfig: {
    /// radius: 5,
    /// size: 5
    /// },
    /// style: {
    /// &#39;stroke-width&#39;: 2,
    /// fill: &#39;none&#39;
    /// }
    /// }]
    /// });
    /// In this configuration we add three series to the chart. Each of these series is bound to the same categories field, name but bound to different properties for each category,
    /// data1, data2 and data3 respectively. All series display markers by having showMarkers enabled. The configuration for the markers of each series can be set by adding properties onto
    /// the markerConfig object. Finally we override some theme styling properties by adding properties to the style object.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Radar : Series, Ext.util.Observable, Ext.chart.Label, Highlight, Ext.chart.Tip, Callout
    {
        /// <summary>
        /// Draws the series for the current chart. ...
        /// </summary>
        public object drawSeries(){return null;}
        public Radar(RadarConfig config){}
        public Radar(){}
    }
    #endregion
    #region RadarConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class RadarConfig : SeriesConfig
    {
        public object style{get;set;}
    }
    #endregion
    #region RadarEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class RadarEvents : SeriesEvents
    {
    }
    #endregion
}
#endregion
