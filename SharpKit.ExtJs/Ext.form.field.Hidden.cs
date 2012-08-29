//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.form.field
{
    #region Hidden
    /// <inheritdocs />
    /// <summary>
    /// <p>A basic hidden field for storing hidden values in forms that need to be passed in the form submit.</p>
    /// <p>This creates an actual input element with type="submit" in the DOM. While its label is
    /// <see cref="Ext.form.field.HiddenConfig.hideLabel">not rendered</see> by default, it is still a real component and may be sized according
    /// to its owner container's layout.</p>
    /// <p>Because of this, in most cases it is more convenient and less problematic to simply
    /// <see cref="Ext.form.action.ActionConfig.params">pass hidden parameters</see> directly when
    /// <see cref="Ext.form.Basic.submit">submitting the form</see>.</p>
    /// <p>Example:</p>
    /// <pre><code>new <see cref="Ext.form.Panel">Ext.form.Panel</see>({
    /// title: 'My Form',
    /// items: [{
    /// xtype: 'textfield',
    /// fieldLabel: 'Text Field',
    /// name: 'text_field',
    /// value: 'value from text field'
    /// }, {
    /// xtype: 'hiddenfield',
    /// name: 'hidden_field_1',
    /// value: 'value from hidden field'
    /// }],
    /// buttons: [{
    /// text: 'Submit',
    /// handler: function() {
    /// this.up('form').getForm().submit({
    /// params: {
    /// hidden_field_2: 'value from submit call'
    /// }
    /// });
    /// }
    /// }]
    /// });
    /// </code></pre>
    /// <p>Submitting the above form will result in three values sent to the server:</p>
    /// <pre><code>text_field=value+from+text+field&amp;hidden;_field_1=value+from+hidden+field&amp;hidden_field_2=value+from+submit+call
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Hidden : Ext.form.field.Base
    {
        public Hidden(HiddenConfig config){}
        public Hidden(){}
        public Hidden(params object[] args){}
    }
    #endregion
    #region HiddenConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class HiddenConfig : Ext.form.field.BaseConfig
    {
        public HiddenConfig(params object[] args){}
    }
    #endregion
    #region HiddenEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class HiddenEvents : Ext.form.field.BaseEvents
    {
        public HiddenEvents(params object[] args){}
    }
    #endregion
}
