//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart
namespace Ext.chart
{
    #region Chart
    /// <summary>
    /// The Ext.chart package provides the capability to visualize data.
    /// Each chart binds directly to an Ext.data.Store enabling automatic updates of the chart.
    /// A chart configuration object has some overall styling options as well as an array of axes
    /// and series. A chart instance example could look like:     Ext.create(&#39;Ext.chart.Chart&#39;, {
    /// renderTo: Ext.getBody(),
    /// width: 800,
    /// height: 600,
    /// animate: true,
    /// store: store1,
    /// shadow: true,
    /// theme: &#39;Category1&#39;,
    /// legend: {
    /// position: &#39;right&#39;
    /// },
    /// axes: [ ...some axes options... ],
    /// series: [ ...some series options... ]
    /// });
    /// In this example we set the width and height of the chart, we decide whether our series are
    /// animated or not and we select a store to be bound to the chart. We also turn on shadows for all series,
    /// select a color theme Category1 for coloring the series, set the legend to the right part of the chart and
    /// then tell the chart to render itself in the body element of the document. For more information about the axes and
    /// series configurations please check the documentation of each series (Line, Bar, Pie, etc).
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Chart : Ext.draw.Component, Ext.chart.theme.Theme, Mask, Navigation, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Creates new Mask. ...
        /// </summary>
        public Chart(object config=null){}
        /// <summary>
        /// Changes the data store bound to this chart and refreshes it. ...
        /// </summary>
        public object bindStore(Ext.data.Store store, object initial){return null;}
        public Chart(ChartConfig config){}
    }
    #endregion
    #region ChartConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ChartConfig : Ext.draw.ComponentConfig
    {
        /// <summary>
        /// (optional) true for the default animation (easing: 'ease' and duration: 500)
        /// or a standard animation config object to...
        /// </summary>
        public object animate{get;set;}
        /// <summary>
        /// (optional) Set the chart background. ...
        /// </summary>
        public object background{get;set;}
        /// <summary>
        /// Defines the priority order for which Surface implementation to use. ...
        /// </summary>
        public new JsArray enginePriority{get;set;}
        /// <summary>
        /// (optional) Define a set of gradients that can be used as fill property in sprites. ...
        /// </summary>
        public new JsArray gradients{get;set;}
        /// <summary>
        /// (optional) Set the amount of inset padding in pixels for the chart. ...
        /// </summary>
        public JsNumber insetPadding{get;set;}
        /// <summary>
        /// (optional) true for the default legend display or a legend config object. ...
        /// </summary>
        public object legend{get;set;}
        /// <summary>
        /// Redraw the chart. ...
        /// </summary>
        public bool resize{get;set;}
        /// <summary>
        /// (optional) The name of the theme to be used. ...
        /// </summary>
        public JsString theme{get;set;}
    }
    #endregion
    #region ChartEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ChartEvents : Ext.draw.ComponentEvents
    {
        /// <summary>
        /// Fires before a refresh to the chart data is called. ...
        /// </summary>
        public static JsString beforerefresh="beforerefresh";
        /// <summary>
        /// Fires after the chart data has been refreshed. ...
        /// </summary>
        public static JsString refresh="refresh";
    }
    #endregion
}
#endregion
