//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.panel
namespace Ext.panel
{
    #region Tool
    /// <summary>
    /// This class is used to display small visual icons in the header of a panel. There are a set of
    /// 25 icons that can be specified by using the type config. The handler config
    /// can be used to provide a function that will respond to any click events. In general, this class
    /// will not be instantiated directly, rather it will be created by specifying the Ext.panel.Panel.tools
    /// configuration on the Panel itself. Example Usage Ext.create(&#39;Ext.panel.Panel&#39;, {
    /// width: 200,
    /// height: 200,
    /// renderTo: document.body,
    /// title: &#39;A Panel&#39;,
    /// tools: [{
    /// type: &#39;help&#39;,
    /// handler: function(){
    /// // show help here
    /// }
    /// }, {
    /// itemId: &#39;refresh&#39;,
    /// type: &#39;refresh&#39;,
    /// hidden: true,
    /// handler: function(){
    /// // do refresh
    /// }
    /// }, {
    /// type: &#39;search&#39;,
    /// handler: function(event, target, owner, tool){
    /// // do search
    /// owner.child(&#39;#refresh&#39;).show();
    /// }
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Tool : Ext.Component, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Set the type of the tool. ...
        /// </summary>
        public Tool setType(JsString type){return null;}
        public Tool(ToolConfig config){}
        public Tool(){}
    }
    #endregion
    #region ToolConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ToolConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// A function to execute when the tool is clicked. ...
        /// </summary>
        public JsAction handler{get;set;}
        /// <summary>
        /// The scope to execute the handler function. ...
        /// </summary>
        public object scope{get;set;}
        /// <summary>
        /// Defaults to true. ...
        /// </summary>
        public bool stopEvent{get;set;}
        public object tooltip{get;set;}
        /// <summary>
        /// The type of tool to render. ...
        /// </summary>
        public JsString type{get;set;}
    }
    #endregion
    #region ToolEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ToolEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Fires when the tool is clicked ...
        /// </summary>
        public static JsString click="click";
    }
    #endregion
}
#endregion
