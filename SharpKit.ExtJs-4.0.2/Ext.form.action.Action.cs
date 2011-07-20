//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.form.action
namespace Ext.form.action
{
    #region Action
    /// <summary>
    /// The subclasses of this class provide actions to perform upon Forms. Instances of this class are only created by a Form when
    /// the Form needs to perform an action such as submit or load. The Configuration options
    /// listed for this class are set through the Form&#39;s action methods: submit,
    /// load and doAction The instance of Action which performed the action is passed to the success
    /// and failure callbacks of the Form&#39;s action methods (submit,
    /// load and doAction),
    /// and to the actioncomplete and
    /// actionfailed event handlers.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Action : Ext.Base
    {
        /// <summary>
        /// Creates new Action. ...
        /// </summary>
        public Action(object config=null){}
        /// <summary>
        /// The type of failure detected will be one of these: CLIENT_INVALID,
        /// SERVER_INVALID, CONNECT_FAILURE, or
        /// LOAD_FAILURE. ...
        /// </summary>
        public JsString failureType{get;set;}
        public object response{get;set;}
        public object result{get;set;}
        public object run{get;set;}
        /// <summary>
        /// The type of action this Action instance performs. ...
        /// </summary>
        public JsString type{get;set;}
        public Action(Ext.form.action.ActionConfig config){}
    }
    #endregion
    #region ActionConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ActionConfig : Ext.BaseConfig
    {
        /// <summary>
        /// The function to call when a failure packet was received, or when an
        /// error ocurred in the Ajax communication. ...
        /// </summary>
        public JsAction failure{get;set;}
        /// <summary>
        /// The BasicForm instance that
        /// is invoking this Action. ...
        /// </summary>
        public Basic form{get;set;}
        /// <summary>
        /// Extra headers to be sent in the AJAX request for submit and load actions. ...
        /// </summary>
        public object headers{get;set;}
        /// <summary>
        /// The HTTP method to use to access the requested URL. ...
        /// </summary>
        public JsString method{get;set;}
        /// <summary>
        /// Extra parameter values to pass. ...
        /// </summary>
        public object @params{get;set;}
        /// <summary>
        /// When set to true, causes the Form to be
        /// reset on Action success. ...
        /// </summary>
        public bool reset{get;set;}
        /// <summary>
        /// The scope in which to call the configured success and failure
        /// callback functions (the this reference for the callback...
        /// </summary>
        public object scope{get;set;}
        /// <summary>
        /// If set to true, the emptyText value will be sent with the form
        /// when it is submitted. ...
        /// </summary>
        public bool submitEmptyText{get;set;}
        /// <summary>
        /// The function to call when a valid success return packet is received. ...
        /// </summary>
        public JsAction success{get;set;}
        /// <summary>
        /// The number of seconds to wait for a server response before
        /// failing with the failureType as CONNECT_FAILURE. ...
        /// </summary>
        public JsNumber timeout{get;set;}
        /// <summary>
        /// The URL that the Action is to invoke. ...
        /// </summary>
        public JsString url{get;set;}
        public JsString waitMsg{get;set;}
        public JsString waitTitle{get;set;}
    }
    #endregion
    #region ActionEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ActionEvents : Ext.BaseEvents
    {
    }
    #endregion
}
#endregion
