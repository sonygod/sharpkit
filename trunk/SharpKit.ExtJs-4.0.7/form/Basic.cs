//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form
namespace Ext.form
{
    #region Basic
    /// <summary>
    /// Provides input field management, validation, submission, and form loading services for the collection
    /// of Field instances within a Ext.container.Container. It is recommended
    /// that you use a Ext.form.Panel as the form container, as that has logic to automatically
    /// hook up an instance of Ext.form.Basic (plus other conveniences related to field configuration.) Form Actions The Basic class delegates the handling of form loads and submits to instances of Ext.form.action.Action.
    /// See the various Action implementations for specific details of each one&#39;s functionality, as well as the
    /// documentation for doAction which details the configuration options that can be specified in
    /// each action call. The default submit Action is Ext.form.action.Submit, which uses an Ajax request to submit the
    /// form&#39;s values to a configured URL. To enable normal browser submission of an Ext form, use the
    /// standardSubmit config option. Note: File uploads are not performed using normal &#39;Ajax&#39; techniques; see the description for
    /// hasUpload for details. Example usage: Ext.create(&#39;Ext.form.Panel&#39;, {
    /// title: &#39;Basic Form&#39;,
    /// renderTo: Ext.getBody(),
    /// bodyPadding: 5,
    /// width: 350,
    /// // Any configuration items here will be automatically passed along to
    /// // the Ext.form.Basic instance when it gets created.
    /// // The form will submit an AJAX request to this URL when submitted
    /// url: &#39;save-form.php&#39;,
    /// items: [{
    /// fieldLabel: &#39;Field&#39;,
    /// name: &#39;theField&#39;
    /// }],
    /// buttons: [{
    /// text: &#39;Submit&#39;,
    /// handler: function() {
    /// // The getForm() method returns the Ext.form.Basic instance:
    /// var form = this.up(&#39;form&#39;).getForm();
    /// if (form.isValid()) {
    /// // Submit the Ajax request and handle the response
    /// form.submit({
    /// success: function(form, action) {
    /// Ext.Msg.alert(&#39;Success&#39;, action.result.msg);
    /// },
    /// failure: function(form, action) {
    /// Ext.Msg.alert(&#39;Failed&#39;, action.result.msg);
    /// }
    /// });
    /// }
    /// }
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false,OmitOptionalParameters = true)]
    public partial class Basic : Ext.util.Observable
    {
        /// <summary>
        /// Creates new form. ...
        /// </summary>
        public Basic(Ext.container.Container owner=null, object config=null){}
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public object addEvents( object o, params object[] more ){return null;}
        /// <summary>
        /// Appends an event handler to this object. ...
        /// </summary>
        public object addListener(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Adds listeners to any Observable object (or Element) which are automatically removed when this Component is
        /// destroyed. ...
        /// </summary>
        public object addManagedListener(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Calls Ext.applyIf for all field in this form with the passed object. ...
        /// </summary>
        public Basic applyIfToFields(object obj){return null;}
        /// <summary>
        /// Calls Ext.apply for all fields in this form with the passed object. ...
        /// </summary>
        public Basic applyToFields(object obj){return null;}
        /// <summary>
        /// Check whether the dirty state of the entire form has changed since it was last checked, and
        /// if so fire the dirtychang...
        /// </summary>
        public object checkDirty(){return null;}
        /// <summary>
        /// Check whether the validity of the entire form has changed since it was last checked, and
        /// if so fire the validitychang...
        /// </summary>
        public object checkValidity(){return null;}
        /// <summary>
        /// Clears all invalid field messages in this form. ...
        /// </summary>
        public Basic clearInvalid(){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public object clearManagedListeners(){return null;}
        /// <summary>
        /// Destroys this object. ...
        /// </summary>
        public object destroy(){return null;}
        /// <summary>
        /// Performs a predefined action (an implementation of Ext.form.action.Action)
        /// to perform application-specific processing. ...
        /// </summary>
        public Basic doAction(object action, object options=null){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public object enableBubble(object events){return null;}
        /// <summary>
        /// Find a specific Ext.form.field.Field in this form by id or name. ...
        /// </summary>
        public object findField(JsString id){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addListener...
        /// </summary>
        public bool fireEvent( JsString eventName, params object[] args ){return false;}
        /// <summary>
        /// Retrieves the fields in the form as a set of key/value pairs, using their
        /// getModelData() method to collect the values. ...
        /// </summary>
        public object getFieldValues(bool dirtyOnly=false){return null;}
        /// <summary>
        /// Return all the Ext.form.field.Field components in the owner container. ...
        /// </summary>
        public Ext.util.MixedCollection getFields(){return null;}
        /// <summary>
        /// Returns the last Ext.data.Model instance that was loaded via loadRecord ...
        /// </summary>
        public Ext.data.Model getRecord(){return null;}
        /// <summary>
        /// Returns true if the form contains any invalid fields. ...
        /// </summary>
        public object hasInvalidField(){return null;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Returns true if the form contains a file upload field. ...
        /// </summary>
        public object hasUpload(){return null;}
        /// <summary>
        /// Returns true if any fields in this form have changed from their original values. ...
        /// </summary>
        public object isDirty(){return null;}
        /// <summary>
        /// Returns true if client-side validation on the form is successful. ...
        /// </summary>
        public object isValid(){return null;}
        /// <summary>
        /// Shortcut to do a load action. ...
        /// </summary>
        public Basic load(object options=null){return null;}
        /// <summary>
        /// Loads an Ext.data.Model into this form by calling setValues with the
        /// record data. ...
        /// </summary>
        public Basic loadRecord(Ext.data.Model record){return null;}
        /// <summary>
        /// Mark fields in this form invalid in bulk. ...
        /// </summary>
        public Basic markInvalid(object errors){return null;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public object relayEvents( object origin, object events, object prefix ){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Resets all fields in this form. ...
        /// </summary>
        public Basic reset(){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public object resumeEvents(){return null;}
        /// <summary>
        /// Set values for fields in this form in bulk. ...
        /// </summary>
        public Basic setValues(object values){return null;}
        /// <summary>
        /// Shortcut to do a submit action. ...
        /// </summary>
        public Basic submit(object options=null){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Persists the values in this form into the passed Ext.data.Model object in a beginEdit/endEdit block. ...
        /// </summary>
        public Basic updateRecord(Ext.data.Model record){return null;}
        public Ext.container.Container owner{get;set;}
        public Basic(BasicConfig config){}
        public Basic(){}
    }
    #endregion
    #region BasicConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class BasicConfig : Ext.util.ObservableConfig
    {
        /// <summary>
        /// (Optional) If specified, load and submit actions will be handled
        /// with Ext.form.action.DirectLoad and Ext.form.action....
        /// </summary>
        public object api{get;set;}
        /// <summary>
        /// Parameters to pass with all requests. ...
        /// </summary>
        public object baseParams{get;set;}
        /// <summary>
        /// An Ext.data.DataReader (e.g. ...
        /// </summary>
        public Ext.data.reader.Reader errorReader{get;set;}
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public new object listeners{get;set;}
        public JsString method{get;set;}
        /// <summary>
        /// A list of params to be executed server side. ...
        /// </summary>
        public object paramOrder{get;set;}
        /// <summary>
        /// Only used for the api
        /// load configuration. ...
        /// </summary>
        public bool paramsAsHash{get;set;}
        /// <summary>
        /// An Ext.data.DataReader (e.g. ...
        /// </summary>
        public Ext.data.reader.Reader reader{get;set;}
        /// <summary>
        /// If set to true, a standard HTML form submit is used instead
        /// of a XHR (Ajax) style form submission. ...
        /// </summary>
        public bool standardSubmit{get;set;}
        public JsNumber timeout{get;set;}
        /// <summary>
        /// If set to true, reset() resets to the last loaded
        /// or setValues() data instead of when the form was first created. ...
        /// </summary>
        public bool trackResetOnLoad{get;set;}
        public JsString url{get;set;}
        /// <summary>
        /// By default wait messages are displayed with Ext.MessageBox.wait. ...
        /// </summary>
        public object waitMsgTarget{get;set;}
        public JsString waitTitle{get;set;}
    }
    #endregion
    #region BasicEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class BasicEvents : Ext.util.ObservableEvents
    {
        /// <summary>
        /// Fires when an action is completed. ...
        /// </summary>
        public static JsString actioncomplete="actioncomplete";
        /// <summary>
        /// Fires when an action fails. ...
        /// </summary>
        public static JsString actionfailed="actionfailed";
        /// <summary>
        /// Fires before any action is performed. ...
        /// </summary>
        public static JsString beforeaction="beforeaction";
        /// <summary>
        /// Fires when the dirty state of the entire form changes. ...
        /// </summary>
        public static JsString dirtychange="dirtychange";
        /// <summary>
        /// Fires when the validity of the entire form changes. ...
        /// </summary>
        public static JsString validitychange="validitychange";
    }
    #endregion
}
#endregion