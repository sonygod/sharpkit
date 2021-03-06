//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.field
namespace Ext.form.field
{
    #region Text
    /// <summary>
    /// A basic text field.  Can be used as a direct replacement for traditional text inputs,
    /// or as the base class for more sophisticated input controls (like Ext.form.field.TextArea
    /// and Ext.form.field.ComboBox). Has support for empty-field placeholder values (see emptyText). Validation The Text field has a useful set of validations built in:  allowBlank for making the field required minLength for requiring a minimum value length maxLength for setting a maximum value length (with enforceMaxLength to add it
    /// as the maxlength attribute on the input element) regex to specify a custom regular expression for validation  In addition, custom validations may be added:  vtype specifies a virtual type implementation from Ext.form.field.VTypes which can contain
    /// custom validation logic validator allows a custom arbitrary function to be called during validation  The details around how and when each of these validation options get used are described in the
    /// documentation for getErrors. By default, the field value is checked for validity immediately while the user is typing in the
    /// field. This can be controlled with the validateOnChange, checkChangeEvents, and
    /// checkChangeBugger configurations. Also see the details on Form Validation in the
    /// Ext.form.Panel class documentation. Masking and Character Stripping Text fields can be configured with custom regular expressions to be applied to entered values before
    /// validation: see maskRe and stripCharsRe for details.
    /// Example usage: Ext.create(&#39;Ext.form.Panel&#39;, {
    /// title: &#39;Contact Info&#39;,
    /// width: 300,
    /// bodyPadding: 10,
    /// renderTo: Ext.getBody(),
    /// items: [{
    /// xtype: &#39;textfield&#39;,
    /// name: &#39;name&#39;,
    /// fieldLabel: &#39;Name&#39;,
    /// allowBlank: false  // requires a non-empty value
    /// }, {
    /// xtype: &#39;textfield&#39;,
    /// name: &#39;email&#39;,
    /// fieldLabel: &#39;Email Address&#39;,
    /// vtype: &#39;email&#39;  // requires value to be a valid email address format
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Text : Ext.form.field.Base, Labelable, Ext.form.field.Field, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Automatically grows the field to accomodate the width of the text up to the maximum field width allowed. ...
        /// </summary>
        public object autoSize(){return null;}
        /// <summary>
        /// override
        /// To get the natural width of the inputEl, we do a simple calculation based on the
        /// 'size' config. ...
        /// </summary>
        public new object getBodyNaturalWidth(){return null;}
        /// <summary>
        /// Validates a value according to the field's validation rules and returns an array of errors
        /// for any failing validations. ...
        /// </summary>
        public new JsArray getErrors(object value){return null;}
        /// <summary>
        /// Returns the raw String value of the field, without performing any normalization, conversion, or validation. ...
        /// </summary>
        public new JsString getRawValue(){return null;}
        /// <summary>
        /// Performs any necessary manipulation of a raw String value to prepare it for conversion
        /// and/or validation. ...
        /// </summary>
        public JsString processRawValue(JsString value){return null;}
        /// <summary>
        /// Resets the current field value to the originally-loaded value and clears any validation messages. ...
        /// </summary>
        public new object reset(){return null;}
        /// <summary>
        /// Selects text in this field ...
        /// </summary>
        public object selectText(JsNumber start=null, JsNumber end=null){return null;}
        /// <summary>
        /// Sets a data value into the field and runs the change detection and validation. ...
        /// </summary>
        public new Ext.form.field.Field setValue(object value){return null;}
        public Text(TextConfig config){}
        public Text(){}
    }
    #endregion
    #region TextConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TextConfig : Ext.form.field.BaseConfig
    {
        public bool allowBlank{get;set;}
        public JsString blankText{get;set;}
        public bool disableKeyFilter{get;set;}
        /// <summary>
        /// The CSS class to apply to an empty field to style the emptyText
        /// (defaults to 'x-form-empty-field'). ...
        /// </summary>
        public JsString emptyCls{get;set;}
        /// <summary>
        /// The default text to place into an empty field (defaults to undefined). ...
        /// </summary>
        public JsString emptyText{get;set;}
        public bool enableKeyEvents{get;set;}
        /// <summary>
        /// True to set the maxLength property on the underlying input field. ...
        /// </summary>
        public bool enforceMaxLength{get;set;}
        public bool grow{get;set;}
        /// <summary>
        /// A string that will be appended to the field's current value for the purposes of calculating the target
        /// field size. ...
        /// </summary>
        public JsString growAppend{get;set;}
        public JsNumber growMax{get;set;}
        public JsNumber growMin{get;set;}
        public JsRegExp maskRe{get;set;}
        /// <summary>
        /// Maximum input field length allowed by validation (defaults to Number.MAX_VALUE). ...
        /// </summary>
        public JsNumber maxLength{get;set;}
        /// <summary>
        /// Error text to display if the maximum length
        /// validation fails (defaults to 'The maximum length for this field is {maxL...
        /// </summary>
        public JsString maxLengthText{get;set;}
        public JsNumber minLength{get;set;}
        /// <summary>
        /// Error text to display if the minimum length
        /// validation fails (defaults to 'The minimum length for this field is {minL...
        /// </summary>
        public JsString minLengthText{get;set;}
        /// <summary>
        /// A JavaScript RegExp object to be tested against the field value during validation
        /// (defaults to undefined). ...
        /// </summary>
        public JsRegExp regex{get;set;}
        public JsString regexText{get;set;}
        public bool selectOnFocus{get;set;}
        /// <summary>
        /// An initial value for the 'size' attribute on the text input element. ...
        /// </summary>
        public JsNumber size{get;set;}
        public JsRegExp stripCharsRe{get;set;}
        /// <summary>
        /// A custom validation function to be called during field validation (getErrors)
        /// (defaults to undefined). ...
        /// </summary>
        public JsAction validator{get;set;}
        public JsString vtype{get;set;}
        /// <summary>
        /// A custom error message to display in place of the default message provided
        /// for the vtype currently set for this field...
        /// </summary>
        public JsString vtypeText{get;set;}
    }
    #endregion
    #region TextEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TextEvents : Ext.form.field.BaseEvents
    {
        /// <summary>
        /// Fires when the autoSize function is triggered and the field is
        /// resized according to the grow/growMin/growMax configs ...
        /// </summary>
        public static JsString autosize="autosize";
        /// <summary>
        /// Keydown input field event. ...
        /// </summary>
        public static JsString keydown="keydown";
        /// <summary>
        /// Keypress input field event. ...
        /// </summary>
        public static JsString keypress="keypress";
        /// <summary>
        /// Keyup input field event. ...
        /// </summary>
        public static JsString keyup="keyup";
    }
    #endregion
}
#endregion
