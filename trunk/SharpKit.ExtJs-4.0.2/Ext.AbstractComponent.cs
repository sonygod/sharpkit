//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region AbstractComponent
    /// <summary>
    /// An abstract base class which provides shared methods for Components across the Sencha product line. Please refer to sub class&#39;s documentation
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class AbstractComponent : Ext.Base, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Creates new Component. ...
        /// </summary>
        public AbstractComponent(object config=null){}
        /// <summary>
        /// Adds a CSS class to the top level element representing this component. ...
        /// </summary>
        public Ext.Component addClass(JsString cls){return null;}
        /// <summary>
        /// Adds a CSS class to the top level element representing this component. ...
        /// </summary>
        public Ext.Component addCls(JsString cls){return null;}
        /// <summary>
        /// Adds a cls to the uiCls array, which will also call addUIClsToElement and adds
        /// to all elements of this component. ...
        /// </summary>
        public object addClsWithUI(object cls, object skip){return null;}
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
        /// Add events that will trigger the state to be saved. ...
        /// </summary>
        public object addStateEvents(object events){return null;}
        /// <summary>
        /// Method which adds a specified UI + uiCls to the components element. ...
        /// </summary>
        public object addUIClsToElement(JsString ui, object force){return null;}
        /// <summary>
        /// ...
        /// </summary>
        public object afterComponentLayout(JsNumber adjWidth, JsNumber adjHeight, bool isSetSize, Ext.Component callingContainer){return null;}
        /// <summary>
        /// Perform custom animation on this object. ...
        /// </summary>
        public object animate(object config){return null;}
        /// <summary>
        /// Applies the state to the object. ...
        /// </summary>
        public object applyState(object state){return null;}
        /// <summary>
        /// Occurs before componentLayout is run. ...
        /// </summary>
        public object beforeComponentLayout(JsNumber adjWidth, JsNumber adjHeight, bool isSetSize, Ext.Component callingContainer){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public object clearManagedListeners(){return null;}
        /// <summary>
        /// Destroys the Component. ...
        /// </summary>
        public object destroy(){return null;}
        /// <summary>
        /// Disable the component. ...
        /// </summary>
        public object disable(bool silent){return null;}
        /// <summary>
        /// Handles autoRender. ...
        /// </summary>
        public object doAutoRender(){return null;}
        /// <summary>
        /// This method needs to be called whenever you change something on this component that requires the Component's
        /// layout t...
        /// </summary>
        public Ext.container.Container doComponentLayout(object width, object height, object isSetSize, object callingContainer){return null;}
        /// <summary>
        /// Enable the component ...
        /// </summary>
        public object enable(bool silent){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public object enableBubble(object events){return null;}
        /// <summary>
        /// This method finds the topmost active layout who's processing will eventually determine the size and position of this
        /// ...
        /// </summary>
        public object findLayoutController(){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public bool fireEvent(JsString eventName, object args){return false;}
        /// <summary>
        /// Forces this component to redo its componentLayout. ...
        /// </summary>
        public object forceComponentLayout(){return null;}
        /// <summary>
        /// Returns thq current animation if this object has any effects actively running or queued, else returns false. ...
        /// </summary>
        public object getActiveAnimation(){return null;}
        /// <summary>
        /// Provides the link for Observable's fireEvent method to bubble up the ownership hierarchy. ...
        /// </summary>
        public Ext.container.Container getBubbleTarget(){return null;}
        /// <summary>
        /// Retrieves the top level element representing this component. ...
        /// </summary>
        public object getEl(){return null;}
        /// <summary>
        /// Gets the current height of the component's underlying element. ...
        /// </summary>
        public JsNumber getHeight(){return null;}
        /// <summary>
        /// Retrieves the id of this component. ...
        /// </summary>
        public object getId(){return null;}
        /// <summary>
        /// This function takes the position argument passed to onRender and returns a
        /// DOM element that you can use in the insert...
        /// </summary>
        public HTMLElement getInsertPosition(object position){return null;}
        /// <summary>
        /// Gets the Ext.ComponentLoader for this Component. ...
        /// </summary>
        public ComponentLoader getLoader(){return null;}
        /// <summary>
        /// Retrieves a plugin by its pluginId which has been bound to this
        /// component. ...
        /// </summary>
        public AbstractPlugin getPlugin(object pluginId){return null;}
        /// <summary>
        /// Gets the current size of the component's underlying element. ...
        /// </summary>
        public object getSize(){return null;}
        /// <summary>
        /// The supplied default state gathering method for the AbstractComponent class. ...
        /// </summary>
        public object getState(){return null;}
        /// <summary>
        /// Gets the state id for this object. ...
        /// </summary>
        public JsString getStateId(){return null;}
        /// <summary>
        /// Gets the current width of the component's underlying element. ...
        /// </summary>
        public JsNumber getWidth(){return null;}
        /// <summary>
        /// Returns this Component's xtype hierarchy as a slash-delimited string. ...
        /// </summary>
        public JsString getXTypes(){return null;}
        /// <summary>
        /// Returns thq current animation if this object has any effects actively running or queued, else returns false. ...
        /// </summary>
        public object hasActiveFx(){return null;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Checks if there is currently a specified uiCls ...
        /// </summary>
        public object hasUICls(JsString cls){return null;}
        /// <summary>
        /// Tests whether this Component matches the selector string. ...
        /// </summary>
        public bool @is(JsString selector){return false;}
        /// <summary>
        /// Determines whether this component is the descendant of a particular container. ...
        /// </summary>
        public bool isDescendantOf(Ext.container.Container container){return false;}
        /// <summary>
        /// Method to determine whether this Component is currently disabled. ...
        /// </summary>
        public bool isDisabled(){return false;}
        /// <summary>
        /// Method to determine whether this Component is draggable. ...
        /// </summary>
        public bool isDraggable(){return false;}
        /// <summary>
        /// Method to determine whether this Component is droppable. ...
        /// </summary>
        public bool isDroppable(){return false;}
        /// <summary>
        /// Method to determine whether this Component is floating. ...
        /// </summary>
        public bool isFloating(){return false;}
        /// <summary>
        /// Method to determine whether this Component is currently set to hidden. ...
        /// </summary>
        public bool isHidden(){return false;}
        /// <summary>
        /// Returns true if this component is visible. ...
        /// </summary>
        public bool isVisible(bool deep){return false;}
        /// <summary>
        /// Tests whether or not this Component is of a specific xtype. ...
        /// </summary>
        public bool isXType(JsString xtype, bool shallow=false){return false;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Returns the next node in the Component tree in tree traversal order. ...
        /// </summary>
        public object nextNode(JsString selector, object includeSelf){return null;}
        /// <summary>
        /// Returns the next sibling of this Component. ...
        /// </summary>
        public object nextSibling(JsString selector){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Returns the previous node in the Component tree in tree traversal order. ...
        /// </summary>
        public object previousNode(JsString selector, object includeSelf){return null;}
        /// <summary>
        /// Returns the previous sibling of this Component. ...
        /// </summary>
        public object previousSibling(JsString selector){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public object relayEvents(object origin, JsString events, object prefix){return null;}
        /// <summary>
        /// Removes a CSS class from the top level element representing this component. ...
        /// </summary>
        public Ext.Component removeCls(object className){return null;}
        /// <summary>
        /// Removes a cls to the uiCls array, which will also call removeUIClsFromElement and removes
        /// it from all elements of thi...
        /// </summary>
        public object removeClsWithUI(object cls, object skip){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Method which removes a specified UI + uiCls from the components element. ...
        /// </summary>
        public object removeUIClsFromElement(JsString ui, object force){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public object resumeEvents(){return null;}
        /// <summary>
        /// Ensures that all effects queued after sequenceFx is called on this object are
        /// run in sequence. ...
        /// </summary>
        public object sequenceFx(){return null;}
        /// <summary>
        /// Enable or disable the component. ...
        /// </summary>
        public object setDisabled(bool disabled){return null;}
        /// <summary>
        /// Sets the dock position of this component in its parent panel. ...
        /// </summary>
        public Ext.Component setDocked(object dock, object layoutParent){return null;}
        /// <summary>
        /// Sets the height of the component. ...
        /// </summary>
        public Ext.Component setHeight(JsNumber height){return null;}
        /// <summary>
        /// This method allows you to show or hide a LoadMask on top of this component. ...
        /// </summary>
        public LoadMask setLoading(object load, bool targetEl){return null;}
        /// <summary>
        /// Sets the left and top of the component. ...
        /// </summary>
        public Ext.Component setPosition(JsNumber left, JsNumber top){return null;}
        /// <summary>
        /// Sets the width and height of this Component. ...
        /// </summary>
        public Ext.Component setSize(object width, object height){return null;}
        /// <summary>
        /// Sets the UI for the component. ...
        /// </summary>
        public object setUI(JsString ui){return null;}
        /// <summary>
        /// Convenience function to hide or show this component by boolean. ...
        /// </summary>
        public Ext.Component setVisible(bool visible){return null;}
        /// <summary>
        /// Sets the width of the component. ...
        /// </summary>
        public Ext.Component setWidth(JsNumber width){return null;}
        /// <summary>
        /// Stops any running effects and clears this object's internal effects queue if it contains
        /// any additional effects that ...
        /// </summary>
        public Ext.core.Element stopAnimation(){return null;}
        /// <summary>
        /// Stops any running effects and clears this object's internal effects queue if it contains
        /// any additional effects that ...
        /// </summary>
        public Ext.core.Element stopFx(){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Ensures that all effects queued after syncFx is called on this object are
        /// run concurrently. ...
        /// </summary>
        public object syncFx(){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Walks up the ownerCt axis looking for an ancestor Container which matches
        /// the passed simple selector. ...
        /// </summary>
        public Ext.container.Container up(JsString selector){return null;}
        /// <summary>
        /// Update the content area of a component. ...
        /// </summary>
        public object update(object htmlOrData, bool loadScripts=false, JsAction callback=null){return null;}
        public bool draggable{get;set;}
        /// <summary>
        /// Read-only property indicating the width of any framing elements which were added within the encapsulating element
        /// to ...
        /// </summary>
        public object frameSize{get;set;}
        /// <summary>
        /// This is an internal flag that you use when creating custom components. ...
        /// </summary>
        public bool maskOnDisable{get;set;}
        /// <summary>
        /// This Component's owner Container (defaults to undefined, and is set automatically when
        /// this Component is added to a C...
        /// </summary>
        public Ext.container.Container ownerCt{get;set;}
        public bool rendered{get;set;}
        public AbstractComponent(AbstractComponentConfig config){}
    }
    #endregion
    #region AbstractComponentConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class AbstractComponentConfig : Ext.BaseConfig
    {
        /// <summary>
        /// A tag name or DomHelper spec used to create the Element which will
        /// encapsulate this Component. ...
        /// </summary>
        public object autoEl{get;set;}
        /// <summary>
        /// This config is intended mainly for floating Components which may or may not be shown. ...
        /// </summary>
        public object autoRender{get;set;}
        /// <summary>
        /// True to automatically show the component upon creation. ...
        /// </summary>
        public bool autoShow{get;set;}
        /// <summary>
        /// The base CSS class to apply to this components's element. ...
        /// </summary>
        public JsString baseCls{get;set;}
        /// <summary>
        /// Specifies the border for this component. ...
        /// </summary>
        public object border{get;set;}
        /// <summary>
        /// An optional extra CSS class that will be added to this component's Element (defaults to ''). ...
        /// </summary>
        public JsString cls{get;set;}
        public JsString componentCls{get;set;}
        /// <summary>
        /// The sizing and positioning of a Component's internal Elements is the responsibility of
        /// the Component's layout manager...
        /// </summary>
        public object componentLayout{get;set;}
        /// <summary>
        /// Optional. ...
        /// </summary>
        public JsString contentEl{get;set;}
        public object data{get;set;}
        public bool disabled{get;set;}
        /// <summary>
        /// CSS class to add when the Component is disabled. ...
        /// </summary>
        public JsString disabledCls{get;set;}
        public bool draggable{get;set;}
        /// <summary>
        /// Create the Component as a floating and use absolute positioning. ...
        /// </summary>
        public bool floating{get;set;}
        /// <summary>
        /// Specify as true to have the Component inject framing elements within the Component at render time to
        /// provide a graphi...
        /// </summary>
        public bool frame{get;set;}
        public JsNumber height{get;set;}
        public bool hidden{get;set;}
        /// <summary>
        /// A String which specifies how this Component's encapsulating DOM element will be hidden. ...
        /// </summary>
        public JsString hideMode{get;set;}
        /// <summary>
        /// An HTML fragment, or a DomHelper specification to use as the layout element
        /// content (defaults to ''). ...
        /// </summary>
        public object html{get;set;}
        /// <summary>
        /// The unique id of this component instance (defaults to an auto-assigned id). ...
        /// </summary>
        public JsString id{get;set;}
        /// <summary>
        /// An itemId can be used as an alternative way to get a reference to a component
        /// when no object reference is available. ...
        /// </summary>
        public JsString itemId{get;set;}
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
        public object loader{get;set;}
        /// <summary>
        /// Specifies the margin for this component. ...
        /// </summary>
        public object margin{get;set;}
        /// <summary>
        /// The maximum value in pixels which this Component will set its height to. ...
        /// </summary>
        public JsNumber maxHeight{get;set;}
        /// <summary>
        /// The maximum value in pixels which this Component will set its width to. ...
        /// </summary>
        public JsNumber maxWidth{get;set;}
        /// <summary>
        /// The minimum value in pixels which this Component will set its height to. ...
        /// </summary>
        public JsNumber minHeight{get;set;}
        /// <summary>
        /// The minimum value in pixels which this Component will set its width to. ...
        /// </summary>
        public JsNumber minWidth{get;set;}
        /// <summary>
        /// An optional extra CSS class that will be added to this component's Element when the mouse moves
        /// over the Element, and...
        /// </summary>
        public JsString overCls{get;set;}
        /// <summary>
        /// Specifies the padding for this component. ...
        /// </summary>
        public object padding{get;set;}
        /// <summary>
        /// An object or array of objects that will provide custom functionality for this component. ...
        /// </summary>
        public object plugins{get;set;}
        /// <summary>
        /// An object containing properties specifying DomQuery selectors which identify child elements
        /// created by the render pro...
        /// </summary>
        public object renderSelectors{get;set;}
        /// <summary>
        /// Specify the id of the element, a DOM element or an existing Element that this component
        /// will be rendered into. ...
        /// </summary>
        public object renderTo{get;set;}
        /// <summary>
        /// An XTemplate used to create the internal structure inside this Component's
        /// encapsulating Element. ...
        /// </summary>
        public object renderTpl{get;set;}
        /// <summary>
        /// A buffer to be applied if many state events are fired within
        /// a short period. ...
        /// </summary>
        public JsNumber saveBuffer{get;set;}
        /// <summary>
        /// An array of events that, when fired, should trigger this object to
        /// save its state (defaults to none). ...
        /// </summary>
        public JsArray stateEvents{get;set;}
        /// <summary>
        /// The unique id for this object to use for state management purposes. ...
        /// </summary>
        public JsString stateId{get;set;}
        /// <summary>
        /// A flag which causes the object to attempt to restore the state of
        /// internal properties from a saved state on startup. ...
        /// </summary>
        public bool stateful{get;set;}
        /// <summary>
        /// A custom style specification to be applied to this component's Element. ...
        /// </summary>
        public JsString style{get;set;}
        /// <summary>
        /// The class that is added to the content target when you set styleHtmlContent to true. ...
        /// </summary>
        public JsString styleHtmlCls{get;set;}
        /// <summary>
        /// True to automatically style the html inside the content target of this component (body for panels). ...
        /// </summary>
        public bool styleHtmlContent{get;set;}
        /// <summary>
        /// An Ext.Template, Ext.XTemplate
        /// or an array of strings to form an Ext.XTemplate. ...
        /// </summary>
        public object tpl{get;set;}
        /// <summary>
        /// The Ext.(X)Template method to use when
        /// updating the content area of the Component. ...
        /// </summary>
        public JsString tplWriteMode{get;set;}
        /// <summary>
        /// A set style for a component. ...
        /// </summary>
        public object ui{get;set;}
        public JsNumber width{get;set;}
    }
    #endregion
    #region AbstractComponentEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class AbstractComponentEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires after a Component has been visually activated. ...
        /// </summary>
        public static JsString activate="activate";
        /// <summary>
        /// Fires after a Component had been added to a Container. ...
        /// </summary>
        public static JsString added="added";
        /// <summary>
        /// Fires after the component rendering is finished. ...
        /// </summary>
        public static JsString afterrender="afterrender";
        /// <summary>
        /// Fires before a Component has been visually activated. ...
        /// </summary>
        public static JsString beforeactivate="beforeactivate";
        /// <summary>
        /// Fires before a Component has been visually deactivated. ...
        /// </summary>
        public static JsString beforedeactivate="beforedeactivate";
        /// <summary>
        /// Fires before the component is destroyed. ...
        /// </summary>
        public static JsString beforedestroy="beforedestroy";
        /// <summary>
        /// Fires before the component is hidden when calling the hide method. ...
        /// </summary>
        public static JsString beforehide="beforehide";
        /// <summary>
        /// Fires before the component is rendered. ...
        /// </summary>
        public static JsString beforerender="beforerender";
        /// <summary>
        /// Fires before the component is shown when calling the show method. ...
        /// </summary>
        public static JsString beforeshow="beforeshow";
        /// <summary>
        /// Fires before the state of the object is restored. ...
        /// </summary>
        public static JsString beforestaterestore="beforestaterestore";
        /// <summary>
        /// Fires before the state of the object is saved to the configured state provider. ...
        /// </summary>
        public static JsString beforestatesave="beforestatesave";
        /// <summary>
        /// Fires after a Component has been visually deactivated. ...
        /// </summary>
        public static JsString deactivate="deactivate";
        /// <summary>
        /// Fires after the component is destroyed. ...
        /// </summary>
        public static JsString destroy="destroy";
        /// <summary>
        /// Fires after the component is disabled. ...
        /// </summary>
        public static JsString disable="disable";
        /// <summary>
        /// Fires after the component is enabled. ...
        /// </summary>
        public static JsString enable="enable";
        /// <summary>
        /// Fires after the component is hidden. ...
        /// </summary>
        public static JsString hide="hide";
        /// <summary>
        /// Fires after the component is moved. ...
        /// </summary>
        public static JsString move="move";
        /// <summary>
        /// Fires when a component is removed from an Ext.container.Container ...
        /// </summary>
        public static JsString removed="removed";
        /// <summary>
        /// Fires after the component markup is rendered. ...
        /// </summary>
        public static JsString render="render";
        /// <summary>
        /// Fires after the component is resized. ...
        /// </summary>
        public static JsString resize="resize";
        /// <summary>
        /// Fires after the component is shown when calling the show method. ...
        /// </summary>
        public static JsString show="show";
        /// <summary>
        /// Fires after the state of the object is restored. ...
        /// </summary>
        public static JsString staterestore="staterestore";
        /// <summary>
        /// Fires after the state of the object is saved to the configured state provider. ...
        /// </summary>
        public static JsString statesave="statesave";
    }
    #endregion
}
#endregion