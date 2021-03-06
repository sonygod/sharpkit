//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.picker
namespace Ext.picker
{
    #region Color
    /// <summary>
    /// ColorPicker provides a simple color palette for choosing colors. The picker can be rendered to any container.
    /// The available default to a standard 40-color palette; this can be customized with the colors config. Typically you will need to implement a handler function to be notified when the user chooses a color from the
    /// picker; you can register the handler using the select event, or by implementing the handler
    /// method. Here&#39;s an example of typical usage: var cp = new Ext.picker.Color({
    /// value: &#39;993300&#39;,  // initial selected color
    /// renderTo: &#39;my-div&#39;
    /// });
    /// cp.on(&#39;select&#39;, function(picker, selColor){
    /// // do something with selColor
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Color : Ext.Component, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Get the currently selected color value. ...
        /// </summary>
        public JsString getValue(){return null;}
        /// <summary>
        /// Selects the specified color in the picker (fires the select event) ...
        /// </summary>
        public object select(JsString color, bool suppressEvent=false){return null;}
        /// <summary>
        /// An array of 6-digit color hex code strings (without the # symbol). ...
        /// </summary>
        public JsArray colors{get;set;}
        public Color(Ext.picker.ColorConfig config){}
        public Color(){}
    }
    #endregion
    #region ColorConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ColorConfig : Ext.ComponentConfig
    {
        public bool allowReselect{get;set;}
        /// <summary>
        /// The DOM event that will cause a color to be selected. ...
        /// </summary>
        public JsString clickEvent{get;set;}
        public new JsString componentCls{get;set;}
        /// <summary>
        /// Optional. ...
        /// </summary>
        public JsAction handler{get;set;}
        /// <summary>
        /// The scope (this reference) in which the handler
        /// function will be called. ...
        /// </summary>
        public object scope{get;set;}
        public JsString selectedCls{get;set;}
        /// <summary>
        /// The initial color to highlight (should be a valid 6-digit color hex code without the # symbol). ...
        /// </summary>
        public JsString value{get;set;}
    }
    #endregion
    #region ColorEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ColorEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Fires when a color is selected ...
        /// </summary>
        public static JsString select="select";
    }
    #endregion
}
#endregion
