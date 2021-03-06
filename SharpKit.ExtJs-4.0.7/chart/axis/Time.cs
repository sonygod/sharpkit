//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart.axis
namespace Ext.chart.axis
{
    #region Time
    /// <summary>
    /// A type of axis whose units are measured in time values. Use this axis
    /// for listing dates that you will want to group or dynamically change.
    /// If you just want to display dates as categories then use the
    /// Category class for axis instead. For example: axes: [{
    /// type: &#39;Time&#39;,
    /// position: &#39;bottom&#39;,
    /// fields: &#39;date&#39;,
    /// title: &#39;Day&#39;,
    /// dateFormat: &#39;M d&#39;,
    /// groupBy: &#39;year,month,day&#39;,
    /// aggregateOp: &#39;sum&#39;,
    /// constrain: true,
    /// fromDate: new Date(&#39;1/1/11&#39;),
    /// toDate: new Date(&#39;1/7/11&#39;)
    /// }]
    /// In this example we&#39;re creating a time axis that has as title Day.
    /// The field the axis is bound to is date.
    /// The date format to use to display the text for the axis labels is M d
    /// which is a three letter month abbreviation followed by the day number.
    /// The time axis will show values for dates between fromDate and toDate.
    /// Since constrain is set to true all other values for other dates not between
    /// the fromDate and toDate will not be displayed.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Time : Axis
    {
        /// <summary>
        /// Aggregation operation when grouping. ...
        /// </summary>
        public JsString aggregateOp{get;set;}
        /// <summary>
        /// The minimum value drawn by the axis. ...
        /// </summary>
        public bool calculateByLabelSize{get;set;}
        /// <summary>
        /// If true, the values of the chart will be rendered only if they belong between the fromDate and toDate. ...
        /// </summary>
        public bool constrain{get;set;}
        /// <summary>
        /// Indicates the format the date will be rendered on. ...
        /// </summary>
        public object dateFormat{get;set;}
        public JsDate fromDate{get;set;}
        /// <summary>
        /// An array with two components: The first is the unit of the step (day, month, year, etc). ...
        /// </summary>
        public JsArray step{get;set;}
        /// <summary>
        /// Indicates the time unit to use for each step. ...
        /// </summary>
        public JsString timeUnit{get;set;}
        public JsDate toDate{get;set;}
        public Time(Ext.chart.axis.TimeConfig config){}
        public Time(){}
    }
    #endregion
    #region TimeConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TimeConfig : AxisConfig
    {
    }
    #endregion
    #region TimeEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TimeEvents : AxisEvents
    {
    }
    #endregion
}
#endregion
