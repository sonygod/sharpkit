//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.menu
namespace Ext.menu
{
    #region ColorPicker
    /// <summary>
    /// A menu containing a Ext.picker.Color Component. Notes:  Although not listed here, the constructor for this class
    /// accepts all of the configuration options of Ext.picker.Color. If subclassing ColorMenu, any configuration options for the ColorPicker must be
    /// applied to the initialConfig property of the ColorMenu.
    /// Applying ColorPicker configuration settings to
    /// this will not affect the ColorPicker&#39;s configuration.   Example Usage var colorPicker = Ext.create(&#39;Ext.menu.ColorPicker&#39;, {
    /// value: &#39;000000&#39;
    /// });
    /// Ext.create(&#39;Ext.menu.Menu&#39;, {
    /// width: 100,
    /// height: 90,
    /// floating: false,  // usually you want this set to True (default)
    /// renderTo: Ext.getBody(),  // usually rendered by it&#39;s containing component
    /// items: [{
    /// text: &#39;choose a color&#39;,
    /// menu: colorPicker
    /// },{
    /// iconCls: &#39;add16&#39;,
    /// text: &#39;icon item&#39;
    /// },{
    /// text: &#39;regular item&#39;
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ColorPicker : Menu, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        public ColorPicker picker{get;set;}
        public ColorPicker(ColorPickerConfig config){}
        public ColorPicker(){}
    }
    #endregion
    #region ColorPickerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ColorPickerConfig : MenuConfig
    {
        public bool hideOnClick{get;set;}
        /// <summary>
        /// An id to assign to the underlying color picker. ...
        /// </summary>
        public JsString pickerId{get;set;}
    }
    #endregion
    #region ColorPickerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ColorPickerEvents : MenuEvents
    {
        /// <summary>
        /// Fires when a date is selected from the Ext.picker.Color ...
        /// </summary>
        public static JsString select="select";
    }
    #endregion
}
#endregion
