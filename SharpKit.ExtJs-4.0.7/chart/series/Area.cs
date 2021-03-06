//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart.series
namespace Ext.chart.series
{
    #region Area
    /// <summary>
    /// Creates a Stacked Area Chart. The stacked area chart is useful when displaying multiple aggregated layers of information.
    /// As with all other series, the Area Series must be appended in the *series* Chart array configuration. See the Chart
    /// documentation for more information. A typical configuration object for the area series could be:
    /// var store = Ext.create(&#39;Ext.data.JsonStore&#39;, {
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
    /// store: store,
    /// axes: [{
    /// type: &#39;Numeric&#39;,
    /// grid: true,
    /// position: &#39;left&#39;,
    /// fields: [&#39;data1&#39;, &#39;data2&#39;, &#39;data3&#39;, &#39;data4&#39;, &#39;data5&#39;],
    /// title: &#39;Sample Values&#39;,
    /// grid: {
    /// odd: {
    /// opacity: 1,
    /// fill: &#39;#ddd&#39;,
    /// stroke: &#39;#bbb&#39;,
    /// &#39;stroke-width&#39;: 1
    /// }
    /// },
    /// minimum: 0,
    /// adjustMinimumByMajorUnit: 0
    /// }, {
    /// type: &#39;Category&#39;,
    /// position: &#39;bottom&#39;,
    /// fields: [&#39;name&#39;],
    /// title: &#39;Sample Metrics&#39;,
    /// grid: true,
    /// label: {
    /// rotate: {
    /// degrees: 315
    /// }
    /// }
    /// }],
    /// series: [{
    /// type: &#39;area&#39;,
    /// highlight: false,
    /// axis: &#39;left&#39;,
    /// xField: &#39;name&#39;,
    /// yField: [&#39;data1&#39;, &#39;data2&#39;, &#39;data3&#39;, &#39;data4&#39;, &#39;data5&#39;],
    /// style: {
    /// opacity: 0.93
    /// }
    /// }]
    /// });
    /// In this configuration we set area as the type for the series, set highlighting options to true for highlighting elements on hover,
    /// take the left axis to measure the data in the area series, set as xField (x values) the name field of each element in the store,
    /// and as yFields (aggregated layers) seven data fields from the same store. Then we override some theming styles by adding some opacity
    /// to the style object.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Area : Cartesian, Ext.util.Observable, Ext.chart.Label, Highlight, Ext.chart.Tip, Callout
    {
        /// <summary>
        /// Draws the series for the current chart. ...
        /// </summary>
        public object drawSeries(){return null;}
        /// <summary>
        /// Returns the color of the series (to be displayed as color for the series legend item). ...
        /// </summary>
        public new object getLegendColor(object item){return null;}
        /// <summary>
        /// Highlight the specified item. ...
        /// </summary>
        public new object highlightItem(object item){return null;}
        /// <summary>
        /// Highlight this entire series. ...
        /// </summary>
        public object highlightSeries(object item){return null;}
        /// <summary>
        /// un-highlights the specified item. ...
        /// </summary>
        public object unHighlightItem(object item){return null;}
        /// <summary>
        /// UnHighlight this entire series. ...
        /// </summary>
        public object unHighlightSeries(object item){return null;}
        public Area(AreaConfig config){}
        public Area(){}
    }
    #endregion
    #region AreaConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class AreaConfig : CartesianConfig
    {
        public object style{get;set;}
    }
    #endregion
    #region AreaEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class AreaEvents : CartesianEvents
    {
    }
    #endregion
}
#endregion
