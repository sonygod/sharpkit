//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.field
namespace Ext.form.field
{
    #region VTypes
    /// <summary>
    /// This is a singleton object which contains a set of commonly used field validation functions.
    /// The validations provided are basic and intended to be easily customizable and extended. To add custom VTypes specify the vtype validation
    /// test function, and optionally specify any corresponding error text to display and any keystroke
    /// filtering mask to apply. For example: // custom Vtype for vtype:&#39;time&#39;
    /// var timeTest = /^([1-9]|1[0-9]):([0-5][0-9])(\s[a|p]m)$/i;
    /// Ext.apply(Ext.form.field.VTypes, {
    /// //  vtype validation function
    /// time: function(val, field) {
    /// return timeTest.test(val);
    /// },
    /// // vtype Text property: The error text to display when the validation function returns false
    /// timeText: &#39;Not a valid time.  Must be in the format &quot;12:34 PM&quot;.&#39;,
    /// // vtype Mask property: The keystroke filter mask
    /// timeMask: /[\d\s:amp]/i
    /// });
    /// Another example: // custom Vtype for vtype:&#39;IPAddress&#39;
    /// Ext.apply(Ext.form.field.VTypes, {
    /// IPAddress:  function(v) {
    /// return /^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$/.test(v);
    /// },
    /// IPAddressText: &#39;Must be a numeric IP address&#39;,
    /// IPAddressMask: /[\d\.]/i
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class VTypes : Ext.Base
    {
        /// <summary>
        /// The function used to validate alpha values ...
        /// </summary>
        public bool alpha(JsString value){return false;}
        /// <summary>
        /// The function used to validate alphanumeric values ...
        /// </summary>
        public bool alphanum(JsString value){return false;}
        /// <summary>
        /// The function used to validate email addresses. ...
        /// </summary>
        public bool email(JsString value){return false;}
        /// <summary>
        /// The function used to validate URLs ...
        /// </summary>
        public bool url(JsString value){return false;}
        /// <summary>
        /// The keystroke filter mask to be applied on alpha input. ...
        /// </summary>
        public JsRegExp alphaMask{get;set;}
        /// <summary>
        /// The error text to display when the alpha validation function returns false. ...
        /// </summary>
        public JsString alphaText{get;set;}
        /// <summary>
        /// The keystroke filter mask to be applied on alphanumeric input. ...
        /// </summary>
        public JsRegExp alphanumMask{get;set;}
        /// <summary>
        /// The error text to display when the alphanumeric validation function returns false. ...
        /// </summary>
        public JsString alphanumText{get;set;}
        /// <summary>
        /// The keystroke filter mask to be applied on email input. ...
        /// </summary>
        public JsRegExp emailMask{get;set;}
        /// <summary>
        /// The error text to display when the email validation function returns false. ...
        /// </summary>
        public JsString emailText{get;set;}
        /// <summary>
        /// The error text to display when the url validation function returns false. ...
        /// </summary>
        public JsString urlText{get;set;}
        public VTypes(VTypesConfig config){}
        public VTypes(){}
    }
    #endregion
    #region VTypesConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class VTypesConfig : Ext.BaseConfig
    {
    }
    #endregion
    #region VTypesEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class VTypesEvents : Ext.BaseEvents
    {
    }
    #endregion
}
#endregion
