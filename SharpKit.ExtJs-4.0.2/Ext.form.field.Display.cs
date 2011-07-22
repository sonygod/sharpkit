//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.field
namespace Ext.form.field
{
    #region Display
    /// <summary>
    /// A display-only text field which is not validated and not submitted. This is useful for when you want
    /// to display a value from a form&#39;s loaded data but do not want to allow the
    /// user to edit or submit that value. The value can be optionally HTML encoded if it contains
    /// HTML markup that you do not want to be rendered. If you have more complex content, or need to include components within the displayed content, also
    /// consider using a Ext.form.FieldContainer instead.  Example:     Ext.create(&#39;Ext.form.Panel&#39;, {
    /// width: 175,
    /// height: 120,
    /// bodyPadding: 10,
    /// title: &#39;Final Score&#39;,
    /// items: [{
    /// xtype: &#39;displayfield&#39;,
    /// fieldLabel: &#39;Home&#39;,
    /// name: &#39;home_score&#39;,
    /// value: &#39;10&#39;
    /// }, {
    /// xtype: &#39;displayfield&#39;,
    /// fieldLabel: &#39;Visitor&#39;,
    /// name: &#39;visitor_score&#39;,
    /// value: &#39;11&#39;
    /// }],
    /// buttons: [{
    /// text: &#39;Update&#39;,
    /// }],
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Display : Ext.form.field.Base, Labelable, Ext.form.field.Field, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        public Display(DisplayConfig config){}
        public Display(){}
    }
    #endregion
    #region DisplayConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DisplayConfig : Ext.form.field.BaseConfig
    {
        public new JsString fieldCls{get;set;}
        /// <summary>
        /// false to skip HTML-encoding the text when rendering it (defaults to
        /// false). ...
        /// </summary>
        public bool htmlEncode{get;set;}
    }
    #endregion
    #region DisplayEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DisplayEvents : Ext.form.field.BaseEvents
    {
    }
    #endregion
}
#endregion
