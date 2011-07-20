//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:25
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.layout.container
namespace Ext.layout.container
{
    #region Border
    /// <summary>
    /// This is a multi-pane, application-oriented UI layout style that supports multiple
    /// nested panels, automatic bars between regions and built-in
    /// expanding and collapsing of regions. This class is intended to be extended or created via the layout:&#39;border&#39; Ext.container.Container.layout config, and should generally not need to be created directly
    /// via the new keyword.  Example usage:      Ext.create(&#39;Ext.panel.Panel&#39;, {
    /// width: 500,
    /// height: 400,
    /// title: &#39;Border Layout&#39;,
    /// layout: &#39;border&#39;,
    /// items: [{
    /// title: &#39;South Region is resizable&#39;,
    /// region: &#39;south&#39;,     // position for region
    /// xtype: &#39;panel&#39;,
    /// height: 100,
    /// split: true,         // enable resizing
    /// margins: &#39;0 5 5 5&#39;
    /// },{
    /// // xtype: &#39;panel&#39; implied by default
    /// title: &#39;West Region is collapsible&#39;,
    /// region:&#39;west&#39;,
    /// xtype: &#39;panel&#39;,
    /// margins: &#39;5 0 0 5&#39;,
    /// width: 200,
    /// collapsible: true,   // make collapsible
    /// id: &#39;west-region-container&#39;,
    /// layout: &#39;fit&#39;
    /// },{
    /// title: &#39;Center Region&#39;,
    /// region: &#39;center&#39;,     // center region is required, no width/height specified
    /// xtype: &#39;panel&#39;,
    /// layout: &#39;fit&#39;,
    /// margins: &#39;5 5 0 0&#39;
    /// }],
    /// renderTo: Ext.getBody()
    /// });
    /// Notes:  Any Container using the Border layout must have a child item with region:&#39;center&#39;.
    /// The child item in the center region will always be resized to fill the remaining space not used by
    /// the other regions in the layout. Any child items with a region of west or east may be configured with either
    /// an initial width, or a Ext.layout.container.Box.flex value, or an initial percentage width string (Which is simply divided by 100 and used as a flex value). The &#39;center&#39; region has a flex value of 1. Any child items with a region of north or south may be configured with either
    /// an initial height, or a Ext.layout.container.Box.flex value, or an initial percentage height string (Which is simply divided by 100 and used as a flex value). The &#39;center&#39; region has a flex value of 1. The regions of a BorderLayout are fixed at render time and thereafter, its child Components may not be removed or added.To add/remove
    /// Components within a BorderLayout, have them wrapped by an additional Container which is directly
    /// managed by the BorderLayout.  If the region is to be collapsible, the Container used directly
    /// by the BorderLayout manager should be a Panel.  In the following example a Container (an Ext.panel.Panel)
    /// is added to the west region:
    /// wrc = Ext.getCmp(&#39;west-region-container&#39;);
    /// wrc.removeAll();
    /// wrc.add({
    /// title: &#39;Added Panel&#39;,
    /// html: &#39;Some content&#39;
    /// });
    /// There is no BorderLayout.Region class in ExtJS 4.0+
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Border : Ext.layout.container.Container
    {
        /// <summary>
        /// Return the placeholder Component to which the passed child Panel of the layout will collapse. ...
        /// </summary>
        public Ext.Component getPlaceholder(Panel panel){return null;}
    }
    #endregion
    #region BorderConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class BorderConfig : Ext.layout.container.ContainerConfig
    {
    }
    #endregion
    #region BorderEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class BorderEvents : Ext.layout.container.ContainerEvents
    {
    }
    #endregion
}
#endregion
