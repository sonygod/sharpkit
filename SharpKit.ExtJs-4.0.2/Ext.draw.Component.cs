//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.draw
namespace Ext.draw
{
    #region Component
    /// <summary>
    /// The Draw Component is a surface in which sprites can be rendered. The Draw Component
    /// manages and holds a Surface instance: an interface that has
    /// an SVG or VML implementation depending on the browser capabilities and where
    /// Sprites can be appended.
    /// One way to create a draw component is: var drawComponent = Ext.create(&#39;Ext.draw.Component&#39;, {
    /// viewBox: false,
    /// items: [{
    /// type: &#39;circle&#39;,
    /// fill: &#39;#79BB3F&#39;,
    /// radius: 100,
    /// x: 100,
    /// y: 100
    /// }]
    /// });
    /// Ext.create(&#39;Ext.Window&#39;, {
    /// width: 215,
    /// height: 235,
    /// layout: &#39;fit&#39;,
    /// items: [drawComponent]
    /// }).show();
    /// In this case we created a draw component and added a sprite to it.
    /// The type of the sprite is circle so if you run this code you&#39;ll see a yellow-ish
    /// circle in a Window. When setting viewBox to false we are responsible for setting the object&#39;s position and
    /// dimensions accordingly. You can also add sprites by using the surface&#39;s add method: drawComponent.surface.add({
    /// type: &#39;circle&#39;,
    /// fill: &#39;#79BB3F&#39;,
    /// radius: 100,
    /// x: 100,
    /// y: 100
    /// });
    /// For more information on Sprites, the core elements added to a draw component&#39;s surface,
    /// refer to the Ext.draw.Sprite documentation.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Component : Ext.Component, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Create the Surface instance. ...
        /// </summary>
        public object createSurface(){return null;}
        public Component(Ext.draw.ComponentConfig config){}
        public Component(){}
    }
    #endregion
    #region ComponentConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ComponentConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// Turn on autoSize support which will set the bounding div's size to the natural size of the contents. ...
        /// </summary>
        public bool autoSize{get;set;}
        /// <summary>
        /// Defines the priority order for which Surface implementation to use. ...
        /// </summary>
        public JsArray enginePriority{get;set;}
        /// <summary>
        /// (optional) Define a set of gradients that can be used as fill property in sprites. ...
        /// </summary>
        public JsArray gradients{get;set;}
        /// <summary>
        /// Turn on view box support which will scale and position items in the draw component to fit to the component while
        /// main...
        /// </summary>
        public bool viewBox{get;set;}
    }
    #endregion
    #region ComponentEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ComponentEvents : Ext.ComponentEvents
    {
    }
    #endregion
}
#endregion
