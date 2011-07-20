//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.layout.container
namespace Ext.layout.container
{
    #region Card
    /// <summary>
    /// This layout manages multiple child Components, each fitted to the Container, where only a single child Component can be
    /// visible at any given time.  This layout style is most commonly used for wizards, tab implementations, etc.
    /// This class is intended to be extended or created via the layout:&#39;card&#39; Ext.container.Container.layout config,
    /// and should generally not need to be created directly via the new keyword. The CardLayout&#39;s focal method is setActiveItem.  Since only one panel is displayed at a time,
    /// the only way to move from one Component to the next is by calling setActiveItem, passing the id or index of
    /// the next panel to display.  The layout itself does not provide a user interface for handling this navigation,
    /// so that functionality must be provided by the developer. In the following example, a simplistic wizard setup is demonstrated.  A button bar is added
    /// to the footer of the containing panel to provide navigation buttons.  The buttons will be handled by a
    /// common navigation routine.  Note that other uses of a CardLayout (like a tab control) would require a
    /// completely different implementation.  For serious implementations, a better approach would be to extend
    /// CardLayout to provide the custom functionality needed.  Example usage: var navigate = function(panel, direction){
    /// // This routine could contain business logic required to manage the navigation steps.
    /// // It would call setActiveItem as needed, manage navigation button state, handle any
    /// // branching logic that might be required, handle alternate actions like cancellation
    /// // or finalization, etc.  A complete wizard implementation could get pretty
    /// // sophisticated depending on the complexity required, and should probably be
    /// // done as a subclass of CardLayout in a real-world implementation.
    /// var layout = panel.getLayout();
    /// layout[direction]();
    /// Ext.getCmp(&#39;move-prev&#39;).setDisabled(!layout.getPrev());
    /// Ext.getCmp(&#39;move-next&#39;).setDisabled(!layout.getNext());
    /// };
    /// Ext.create(&#39;Ext.panel.Panel&#39;, {
    /// title: &#39;Example Wizard&#39;,
    /// width: 300,
    /// height: 200,
    /// layout: &#39;card&#39;,
    /// activeItem: 0, // make sure the active item is set on the container config!
    /// bodyStyle: &#39;padding:15px&#39;,
    /// defaults: {
    /// // applied to each contained panel
    /// border: false
    /// },
    /// // just an example of one possible navigation scheme, using buttons
    /// bbar: [
    /// {
    /// id: &#39;move-prev&#39;,
    /// text: &#39;Back&#39;,
    /// handler: function(btn) {
    /// navigate(btn.up(&quot;panel&quot;), &quot;prev&quot;);
    /// },
    /// disabled: true
    /// },
    /// &#39;-&amp;gt;&#39;, // greedy spacer so that the buttons are aligned to each side
    /// {
    /// id: &#39;move-next&#39;,
    /// text: &#39;Next&#39;,
    /// handler: function(btn) {
    /// navigate(btn.up(&quot;panel&quot;), &quot;next&quot;);
    /// }
    /// }
    /// ],
    /// // the panels (or &quot;cards&quot;) within the layout
    /// items: [{
    /// id: &#39;card-0&#39;,
    /// html: &#39;&amp;lt;h1&amp;gt;Welcome to the Wizard!&amp;lt;/h1&amp;gt;&amp;lt;p&amp;gt;Step 1 of 3&amp;lt;/p&amp;gt;&#39;
    /// },{
    /// id: &#39;card-1&#39;,
    /// html: &#39;&amp;lt;p&amp;gt;Step 2 of 3&amp;lt;/p&amp;gt;&#39;
    /// },{
    /// id: &#39;card-2&#39;,
    /// html: &#39;&amp;lt;h1&amp;gt;Congratulations!&amp;lt;/h1&amp;gt;&amp;lt;p&amp;gt;Step 3 of 3 - Complete&amp;lt;/p&amp;gt;&#39;
    /// }],
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Card : AbstractCard
    {
        /// <summary>
        /// Makes the given card active. ...
        /// </summary>
        public Ext.Component setActiveItem(object newCard){return null;}
        public Card(CardConfig config){}
        public Card(){}
    }
    #endregion
    #region CardConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class CardConfig : AbstractCardConfig
    {
    }
    #endregion
    #region CardEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class CardEvents : AbstractCardEvents
    {
    }
    #endregion
}
#endregion
