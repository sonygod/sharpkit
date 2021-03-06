//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region History
    /// <summary>
    /// History management component that allows you to register arbitrary tokens that signify application
    /// history state on navigation actions.  You can then handle the history change event in order
    /// to reset your application UI to the appropriate state when the user navigates forward or backward through
    /// the browser history stack. Initializing
    /// The init method of the History object must be called before using History. This sets up the internal
    /// state and must be the first thing called before using History. Setup
    /// The History objects requires elements on the page to keep track of the browser history. For older versions of IE,
    /// an IFrame is required to do the tracking. For other browsers, a hidden field can be used. The history objects expects
    /// these to be on the page before the init method is called. The following markup is suggested in order
    /// to support all browsers: &amp;lt;form id=&quot;history-form&quot; class=&quot;x-hide-display&quot;&amp;gt;
    /// &amp;lt;input type=&quot;hidden&quot; id=&quot;x-history-field&quot; /&amp;gt;
    /// &amp;lt;iframe id=&quot;x-history-frame&quot;&amp;gt;&amp;lt;/iframe&amp;gt;
    /// &amp;lt;/form&amp;gt;
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class History : Ext.Base//, Observable
    {
        /// <summary>
        /// Add a new token to the history stack. ...
        /// </summary>
        public static object add(JsString token, bool preventDuplicates){return null;}
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public static object addEvents(object o, JsString more){return null;}
        /// <summary>
        /// Appends an event handler to this object. ...
        /// </summary>
        public static object addListener(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Adds listeners to any Observable object (or Element) which are automatically removed when this Component is
        /// destroyed. ...
        /// </summary>
        public static object addManagedListener(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Programmatically steps back one step in browser history (equivalent to the user pressing the Back button). ...
        /// </summary>
        public static object back(){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public static object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public static object clearManagedListeners(){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public static object enableBubble(object events){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public static bool fireEvent(JsString eventName, object args){return false;}
        /// <summary>
        /// Programmatically steps forward one step in browser history (equivalent to the user pressing the Forward button). ...
        /// </summary>
        public static object forward(){return null;}
        /// <summary>
        /// Retrieves the currently-active history token. ...
        /// </summary>
        public static JsString getToken(){return null;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public static bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Initialize the global History instance. ...
        /// </summary>
        public static object init(bool onReady=false, object scope=null){return null;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public static object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public static object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public static object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public static object relayEvents(object origin, JsString events, object prefix){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public static object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public static object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public static object resumeEvents(){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public static object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public static object un(JsString eventName, JsAction handler, object scope=null){return null;}
        public static JsString fieldId{get;set;}
        public static JsString iframeId{get;set;}
        public History(HistoryConfig config){}
        public History(){}
    }
    #endregion
    #region HistoryConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class HistoryConfig : Ext.BaseConfig
    {
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
    }
    #endregion
    #region HistoryEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class HistoryEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires when navigation back or forwards within the local page's history occurs. ...
        /// </summary>
        public static JsString change="change";
        /// <summary>
        /// Fires when the Ext.util.History singleton has been initialized and is ready for use. ...
        /// </summary>
        public static JsString ready="ready";
    }
    #endregion
}
#endregion
