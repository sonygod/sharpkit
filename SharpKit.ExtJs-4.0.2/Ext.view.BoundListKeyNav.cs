//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.view
namespace Ext.view
{
    #region BoundListKeyNav
    /// <summary>
    /// A specialized Ext.util.KeyNav implementation for navigating a Ext.view.BoundList using
    /// the keyboard. The up, down, pageup, pagedown, home, and end keys move the active highlight
    /// through the list. The enter key invokes the selection model&#39;s select action using the highlighted item.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class BoundListKeyNav : Ext.util.KeyNav
    {
        /// <summary>
        /// Highlights the item at the given index. ...
        /// </summary>
        public object highlightAt(JsNumber index){return null;}
        /// <summary>
        /// Triggers selection of the currently highlighted item according to the behavior of
        /// the configured SelectionModel. ...
        /// </summary>
        public object selectHighlighted(object e){return null;}
        public BoundListKeyNav(BoundListKeyNavConfig config){}
        public BoundListKeyNav(){}
    }
    #endregion
    #region BoundListKeyNavConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class BoundListKeyNavConfig : Ext.util.KeyNavConfig
    {
        /// <summary>
        /// @required
        /// The Ext.view.BoundList instance for which key navigation will be managed. ...
        /// </summary>
        public BoundList boundList{get;set;}
    }
    #endregion
    #region BoundListKeyNavEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class BoundListKeyNavEvents : Ext.util.KeyNavEvents
    {
    }
    #endregion
}
#endregion
