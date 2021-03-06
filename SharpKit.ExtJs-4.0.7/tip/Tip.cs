//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.tip
namespace Ext.tip
{
    #region Tip
    /// <summary>
    /// This is the base class for Ext.tip.QuickTip and Ext.tip.ToolTip that provides the basic layout and
    /// positioning that all tip-based classes require. This class can be used directly for simple, statically-positioned
    /// tips that are displayed programmatically, or it can be extended to provide custom tip implementations.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Tip : Ext.panel.Panel, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Shows this tip at the specified XY position. ...
        /// </summary>
        public object showAt(JsArray xy){return null;}
        /// <summary>
        /// Experimental. ...
        /// </summary>
        public object showBy(object el, JsString position=null){return null;}
        public bool frame{get;set;}
        public Tip(Ext.tip.TipConfig config){}
        public Tip(){}
    }
    #endregion
    #region TipConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TipConfig : Ext.panel.PanelConfig
    {
        public new bool closable{get;set;}
        /// <summary>
        /// The action to take when the close header tool is clicked:
        /// 'destroy' :
        /// remove the window from the DOM and destroy
        /// it...
        /// </summary>
        public new JsString closeAction{get;set;}
        /// <summary>
        /// If true, then the tooltip will be automatically constrained to stay within
        /// the browser viewport. ...
        /// </summary>
        public bool constrainPosition{get;set;}
        /// <summary>
        /// Experimental. ...
        /// </summary>
        public JsString defaultAlign{get;set;}
        /// <summary>
        /// The maximum width of the tip in pixels (defaults to 300). ...
        /// </summary>
        public new JsNumber maxWidth{get;set;}
        public new JsNumber minWidth{get;set;}
        /// <summary>
        /// True or "sides" for the default effect, "frame" for 4-way shadow, and "drop"
        /// for bottom-right shadow (defaults to "si...
        /// </summary>
        public new object shadow{get;set;}
        /// <summary>
        /// Width in pixels of the tip (defaults to auto). ...
        /// </summary>
        public new JsNumber width{get;set;}
    }
    #endregion
    #region TipEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TipEvents : Ext.panel.PanelEvents
    {
    }
    #endregion
}
#endregion
