//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart.axis
namespace Ext.chart.axis
{
    #region Category
    /// <summary>
    /// A type of axis that displays items in categories. This axis is generally used to
    /// display categorical information like names of items, month names, quarters, etc.
    /// but no quantitative values. For that other type of information Number
    /// axis are more suitable. As with other axis you can set the position of the axis and its title. For example:  var store = Ext.create(&#39;Ext.data.JsonStore&#39;, {
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
    /// In this example with set the category axis to the bottom of the surface, bound the axis to
    /// the name property and set as title Month of the Year.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Category : Axis
    {
        /// <summary>
        /// Indicates whether or not to calculate the number of categories (ticks and
        /// labels) when there is not enough room to di...
        /// </summary>
        public bool calculateCategoryCount{get;set;}
        public JsArray categoryNames{get;set;}
        public Category(CategoryConfig config){}
        public Category(){}
    }
    #endregion
    #region CategoryConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class CategoryConfig : AxisConfig
    {
    }
    #endregion
    #region CategoryEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class CategoryEvents : AxisEvents
    {
    }
    #endregion
}
#endregion
