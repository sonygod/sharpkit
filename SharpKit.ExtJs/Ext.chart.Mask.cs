//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.chart
{
    #region Mask
    /// <summary>
    /// <p>Defines a mask for a chart's series.
    /// The 'chart' member must be set prior to rendering.</p>
    /// <p>A Mask can be used to select a certain region in a chart.
    /// When enabled, the <c>select</c> event will be triggered when a
    /// region is selected by the mask, allowing the user to perform
    /// other tasks like zooming on that region, etc.</p>
    /// <p>In order to use the mask one has to set the Chart <c>mask</c> option to
    /// <c>true</c>, <c>vertical</c> or <c>horizontal</c>. Then a possible configuration for the
    /// listener could be:</p>
    /// <pre><code>items: {
    /// xtype: 'chart',
    /// animate: true,
    /// store: store1,
    /// mask: 'horizontal',
    /// listeners: {
    /// select: {
    /// fn: function(me, selection) {
    /// me.setZoom(selection);
    /// me.mask.hide();
    /// }
    /// }
    /// }
    /// }
    /// </code></pre>
    /// <p>In this example we zoom the chart to that particular region. You can also get
    /// a handle to a mask instance from the chart object. The <c>chart.mask</c> element is a
    /// <c><see cref="Ext.panel.Panel">Ext.Panel</see></c>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial interface Mask
    {
    }
    #endregion
    #region MaskConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class MaskConfig : Ext.BaseConfig
    {
        /// <summary>
        /// Enables selecting a region on chart. True to enable any selection,
        /// 'horizontal' or 'vertical' to restrict the selection to X or Y axis.
        /// The mask in itself will do nothing but fire 'select' event.
        /// See <see cref="Ext.chart.Mask">Ext.chart.Mask</see> for example.
        /// </summary>
        public object mask;
        public MaskConfig(params object[] args){}
    }
    #endregion
    #region MaskEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class MaskEvents : Ext.BaseEvents
    {
        public MaskEvents(params object[] args){}
    }
    #endregion
}
