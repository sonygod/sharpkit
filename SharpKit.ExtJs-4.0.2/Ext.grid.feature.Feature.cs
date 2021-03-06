//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.feature
namespace Ext.grid.feature
{
    #region Feature
    /// <summary>
    /// A feature is a type of plugin that is specific to the Ext.grid.Panel. It provides several
    /// hooks that allows the developer to inject additional functionality at certain points throughout the
    /// grid creation cycle. This class provides the base template methods that are available to the developer,
    /// it should be extended. There are several built in features that extend this class, for example:  Ext.grid.feature.Grouping - Shows grid rows in groups as specified by the Ext.data.Store Ext.grid.feature.RowBody - Adds a body section for each grid row that can contain markup. Ext.grid.feature.Summary - Adds a summary row at the bottom of the grid with aggregate totals for a column.  Using Features A feature is added to the grid by specifying it an array of features in the configuration: var groupingFeature = Ext.create(&#39;Ext.grid.feature.Grouping&#39;);
    /// Ext.create(&#39;Ext.grid.Panel&#39;, {
    /// // other options
    /// features: [groupingFeature]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Feature : Ext.util.Observable
    {
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public object addEvents(object o, JsString more){return null;}
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
        /// Approriate place to attach events to the view, selectionmodel, headerCt, etc ...
        /// </summary>
        public object attachEvents(){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public object clearManagedListeners(){return null;}
        /// <summary>
        /// Disable a feature ...
        /// </summary>
        public object disable(){return null;}
        /// <summary>
        /// Enable a feature ...
        /// </summary>
        public object enable(){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public object enableBubble(object events){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public bool fireEvent(JsString eventName, object args){return false;}
        /// <summary>
        /// Provide additional data to the prepareData call within the grid view. ...
        /// </summary>
        public object getAdditionalData(object data, JsNumber idx, Ext.data.Model record, object orig){return null;}
        /// <summary>
        /// Abstract method to be overriden when a feature should add additional
        /// arguments to its event signature. ...
        /// </summary>
        public object getFireEventArgs(object eventName, object view, object featureTarget, object e){return null;}
        /// <summary>
        /// Allows a feature to inject member methods into the metaRowTpl. ...
        /// </summary>
        public object getMetaRowTplFragments(){return null;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Allows a feature to mutate the metaRowTpl. ...
        /// </summary>
        public object mutateMetaRowTpl(object metaRowTplArray){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public object relayEvents(object origin, JsString events, object prefix){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public object resumeEvents(){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Most features will not modify the data returned to the view. ...
        /// </summary>
        public bool collectData{get;set;}
        /// <summary>
        /// Prefix to use when firing events on the view. ...
        /// </summary>
        public JsString eventPrefix{get;set;}
        public JsString eventSelector{get;set;}
        public Ext.grid.Panel grid{get;set;}
        public bool hasFeatureEvent{get;set;}
        public Ext.view.Table view{get;set;}
        public JsString ftype { get; set; }
        public Feature(FeatureConfig config){}
        public Feature(){}
    }
    #endregion
    #region FeatureConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class FeatureConfig : Ext.util.ObservableConfig
    {
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public new object listeners{get;set;}
    }
    #endregion
    #region FeatureEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class FeatureEvents : Ext.util.ObservableEvents
    {
    }
    #endregion
}
#endregion
