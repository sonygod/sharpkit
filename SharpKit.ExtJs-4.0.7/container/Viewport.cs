//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.container
namespace Ext.container
{
    #region Viewport
    /// <summary>
    /// A specialized container representing the viewable application area (the browser viewport). The Viewport renders itself to the document body, and automatically sizes itself to the size of
    /// the browser viewport and manages window resizing. There may only be one Viewport created
    /// in a page. Like any Container, a Viewport will only perform sizing and positioning
    /// on its child Components if you configure it with a layout. A Common layout used with Viewports is border layout, but if the
    /// required layout is simpler, a different layout should be chosen. For example, to simply make a single child item occupy all available space, use fit layout. To display one &quot;active&quot; item at full size from a choice of several child items, use card layout. Inner layouts are available by virtue of the fact that all Panels
    /// added to the Viewport, either through its items, or through the items, or the add
    /// method of any of its child Panels may themselves have a layout. The Viewport does not provide scrolling, so child Panels within the Viewport should provide
    /// for scrolling if needed using the autoScroll config.
    /// An example showing a classic application border layout: Ext.create(&#39;Ext.container.Viewport&#39;, {
    /// layout: &#39;border&#39;,
    /// renderTo: Ext.getBody(),
    /// items: [{
    /// region: &#39;north&#39;,
    /// html: &#39;&amp;lt;h1 class=&quot;x-panel-header&quot;&amp;gt;Page Title&amp;lt;/h1&amp;gt;&#39;,
    /// autoHeight: true,
    /// border: false,
    /// margins: &#39;0 0 5 0&#39;
    /// }, {
    /// region: &#39;west&#39;,
    /// collapsible: true,
    /// title: &#39;Navigation&#39;,
    /// width: 150
    /// // could use a TreePanel or AccordionLayout for navigational items
    /// }, {
    /// region: &#39;south&#39;,
    /// title: &#39;South Panel&#39;,
    /// collapsible: true,
    /// html: &#39;Information goes here&#39;,
    /// split: true,
    /// height: 100,
    /// minHeight: 100
    /// }, {
    /// region: &#39;east&#39;,
    /// title: &#39;East Panel&#39;,
    /// collapsible: true,
    /// split: true,
    /// width: 150
    /// }, {
    /// region: &#39;center&#39;,
    /// xtype: &#39;tabpanel&#39;, // TabPanel itself has no title
    /// activeTab: 0,      // First tab active by default
    /// items: {
    /// title: &#39;Default Tab&#39;,
    /// html: &#39;The first tab\&#39;s content. Others may be added dynamically&#39;
    /// }
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Viewport : Ext.container.Container, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        public Viewport(ViewportConfig config){}
        public Viewport(){}
    }
    #endregion
    #region ViewportConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ViewportConfig : Ext.container.ContainerConfig
    {
    }
    #endregion
    #region ViewportEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ViewportEvents : Ext.container.ContainerEvents
    {
    }
    #endregion
}
#endregion
