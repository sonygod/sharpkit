//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:51:06
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.draw
namespace Ext.draw
{
    #region Surface
    /// <summary>
    /// A Surface is an interface to render methods inside a draw Ext.draw.Component.
    /// A Surface contains methods to render sprites, get bounding boxes of sprites, add
    /// sprites to the canvas, initialize other graphic components, etc. One of the most used
    /// methods for this class is the add method, to add Sprites to the surface. Most of the Surface methods are abstract and they have a concrete implementation
    /// in VML or SVG engines. A Surface instance can be accessed as a property of a draw component. For example: drawComponent.surface.add({
    /// type: &#39;circle&#39;,
    /// fill: &#39;#ffc&#39;,
    /// radius: 100,
    /// x: 100,
    /// y: 100
    /// });
    /// The configuration object passed in the add method is the same as described in the Ext.draw.Sprite
    /// class documentation. Listeners You can also add event listeners to the surface using the Observable listener syntax. Supported events are:  mousedown mouseup mouseover mouseout mousemove mouseenter mouseleave click  For example: drawComponent.surface.on({
    /// &#39;mousemove&#39;: function() {
    /// console.log(&#39;moving the mouse over the surface&#39;);
    /// }
    /// });
    /// Example var drawComponent = Ext.create(&#39;Ext.draw.Component&#39;, {
    /// width: 800,
    /// height: 600,
    /// renderTo: document.body
    /// }), surface = drawComponent.surface;
    /// surface.add([{
    /// type: &#39;circle&#39;,
    /// radius: 10,
    /// fill: &#39;#f00&#39;,
    /// x: 10,
    /// y: 10,
    /// group: &#39;circles&#39;
    /// }, {
    /// type: &#39;circle&#39;,
    /// radius: 10,
    /// fill: &#39;#0f0&#39;,
    /// x: 50,
    /// y: 50,
    /// group: &#39;circles&#39;
    /// }, {
    /// type: &#39;circle&#39;,
    /// radius: 10,
    /// fill: &#39;#00f&#39;,
    /// x: 100,
    /// y: 100,
    /// group: &#39;circles&#39;
    /// }, {
    /// type: &#39;rect&#39;,
    /// width: 20,
    /// height: 20,
    /// fill: &#39;#f00&#39;,
    /// x: 10,
    /// y: 10,
    /// group: &#39;rectangles&#39;
    /// }, {
    /// type: &#39;rect&#39;,
    /// width: 20,
    /// height: 20,
    /// fill: &#39;#0f0&#39;,
    /// x: 50,
    /// y: 50,
    /// group: &#39;rectangles&#39;
    /// }, {
    /// type: &#39;rect&#39;,
    /// width: 20,
    /// height: 20,
    /// fill: &#39;#00f&#39;,
    /// x: 100,
    /// y: 100,
    /// group: &#39;rectangles&#39;
    /// }]);
    /// // Get references to my groups
    /// circles = surface.getGroup(&#39;circles&#39;);
    /// rectangles = surface.getGroup(&#39;rectangles&#39;);
    /// // Animate the circles down
    /// circles.animate({
    /// duration: 1000,
    /// to: {
    /// translate: {
    /// y: 200
    /// }
    /// }
    /// });
    /// // Animate the rectangles across
    /// rectangles.animate({
    /// duration: 1000,
    /// to: {
    /// translate: {
    /// x: 200
    /// }
    /// }
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Surface : Ext.Base, Ext.util.Observable
    {
        /// <summary>
        /// Creates new Surface. ...
        /// </summary>
        public object constructor(object config=null){return null;}
        /// <summary>
        /// Adds a Sprite to the surface. ...
        /// </summary>
        public object add(){return null;}
        /// <summary>
        /// Adds one or more CSS classes to the element. ...
        /// </summary>
        public object addCls(object sprite, object className){return null;}
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public object addEvents(object o, JsString more){return null;}
        /// <summary>
        /// Adds a gradient definition to the Surface. ...
        /// </summary>
        public object addGradient(){return null;}
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
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public object clearManagedListeners(){return null;}
        /// <summary>
        /// Destroys the surface. ...
        /// </summary>
        public object destroy(){return null;}
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
        /// Returns a new group or an existent group associated with the current surface. ...
        /// </summary>
        public object getGroup(JsString id){return null;}
        /// <summary>
        /// Retrieves the id of this component. ...
        /// </summary>
        public object getId(){return null;}
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
        /// Shorthand for addListener. ...
        /// </summary>
        public object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public object relayEvents(object origin, JsString events, object prefix){return null;}
        /// <summary>
        /// Removes a given sprite from the surface, optionally destroying the sprite in the process. ...
        /// </summary>
        public JsNumber remove(Ext.draw.Sprite sprite, bool destroySprite){return null;}
        /// <summary>
        /// Removes all sprites from the surface, optionally destroying the sprites in the process. ...
        /// </summary>
        public JsNumber removeAll(bool destroySprites){return null;}
        /// <summary>
        /// Removes one or more CSS classes from the element. ...
        /// </summary>
        public object removeCls(object sprite, object className){return null;}
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
        /// Sets the size of the surface. ...
        /// </summary>
        public object setSize(JsNumber w, JsNumber h){return null;}
        /// <summary>
        /// Sets CSS style attributes to an element. ...
        /// </summary>
        public object setStyle(object sprite, object styles){return null;}
        /// <summary>
        /// Changes the text in the sprite element. ...
        /// </summary>
        public object setText(object sprite, JsString text){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
    }
    #endregion
    #region SurfaceConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class SurfaceConfig
    {
        /// <summary>
        /// The height of this component in pixels (defaults to auto). ...
        /// </summary>
        public JsNumber height{get;set;}
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
        /// <summary>
        /// The width of this component in pixels (defaults to auto). ...
        /// </summary>
        public JsNumber width{get;set;}
    }
    #endregion
    #region SurfaceEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class SurfaceEvents
    {
    }
    #endregion
}
#endregion
