//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form
namespace Ext.form
{
    #region RadioGroup
    /// <summary>
    /// A field container which has a specialized layout for arranging
    /// Ext.form.field.Radio controls into columns, and provides convenience Ext.form.field.Field
    /// methods for getting, setting, and validating the
    /// group of radio buttons as a whole. Validation Individual radio buttons themselves have no default validation behavior, but
    /// sometimes you want to require a user to select one of a group of radios. RadioGroup
    /// allows this by setting the config allowBlank:false; when the user does not check at
    /// one of the radio buttons, the entire group will be highlighted as invalid and the
    /// error message will be displayed according to the msgTarget config. Layout The default layout for RadioGroup makes it easy to arrange the radio buttons into
    /// columns; see the columns and vertical config documentation for details. You may also
    /// use a completely different layout by setting the layout to one of the other supported layout
    /// types; for instance you may wish to use a custom arrangement of hbox and vbox containers. In that case
    /// the Radio components at any depth will still be managed by the RadioGroup&#39;s validation.  Example usage Ext.create(&#39;Ext.form.Panel&#39;, {
    /// title: &#39;RadioGroup Example&#39;,
    /// width: 300,
    /// height: 125,
    /// bodyPadding: 10,
    /// renderTo: Ext.getBody(),
    /// items:[{
    /// xtype: &#39;radiogroup&#39;,
    /// fieldLabel: &#39;Two Columns&#39;,
    /// // Arrange radio buttons into two columns, distributed vertically
    /// columns: 2,
    /// vertical: true,
    /// items: [
    /// {boxLabel: &#39;Item 1&#39;, name: &#39;rb&#39;, inputValue: &#39;1&#39;},
    /// {boxLabel: &#39;Item 2&#39;, name: &#39;rb&#39;, inputValue: &#39;2&#39;, checked: true},
    /// {boxLabel: &#39;Item 3&#39;, name: &#39;rb&#39;, inputValue: &#39;3&#39;},
    /// {boxLabel: &#39;Item 4&#39;, name: &#39;rb&#39;, inputValue: &#39;4&#39;},
    /// {boxLabel: &#39;Item 5&#39;, name: &#39;rb&#39;, inputValue: &#39;5&#39;},
    /// {boxLabel: &#39;Item 6&#39;, name: &#39;rb&#39;, inputValue: &#39;6&#39;}
    /// ]
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class RadioGroup : Ext.form.CheckboxGroup, Ext.form.field.Field, Labelable, FieldAncestor, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        public RadioGroup(RadioGroupConfig config){}
        public RadioGroup(){}
    }
    #endregion
    #region RadioGroupConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class RadioGroupConfig : Ext.form.CheckboxGroupConfig
    {
        /// <summary>
        /// True to allow every item in the group to be blank (defaults to true). ...
        /// </summary>
        public new bool allowBlank{get;set;}
        public new JsString blankText{get;set;}
        public new JsArray items{get;set;}
    }
    #endregion
    #region RadioGroupEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class RadioGroupEvents : Ext.form.CheckboxGroupEvents
    {
    }
    #endregion
}
#endregion
