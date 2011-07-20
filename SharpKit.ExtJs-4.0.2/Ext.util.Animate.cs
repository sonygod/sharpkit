//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:25
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region Animate
    /// <summary>
    /// This animation class is a mixin. Ext.util.Animate provides an API for the creation of animated transitions of properties and styles.
    /// This class is used as a mixin and currently applied to Ext.core.Element, Ext.CompositeElement,
    /// Ext.draw.Sprite, Ext.draw.CompositeSprite, and Ext.Component.  Note that Components
    /// have a limited subset of what attributes can be animated such as top, left, x, y, height, width, and
    /// opacity (color, paddings, and margins can not be animated). Animation Basics All animations require three things - easing, duration, and to (the final end value for each property)
    /// you wish to animate. Easing and duration are defaulted values specified below.
    /// Easing describes how the intermediate values used during a transition will be calculated.
    /// Easing allows for a transition to change speed over its duration.
    /// You may use the defaults for easing and duration, but you must always set a
    /// to property which is the end value for all animations. Popular element &#39;to&#39; configurations are:  opacity x y color height width  Popular sprite &#39;to&#39; configurations are:  translation path scale stroke rotation  The default duration for animations is 250 (which is a 1/4 of a second).  Duration is denoted in
    /// milliseconds.  Therefore 1 second is 1000, 1 minute would be 60000, and so on. The default easing curve
    /// used for all animations is &#39;ease&#39;.  Popular easing functions are included and can be found in Easing. For example, a simple animation to fade out an element with a default easing and duration: var p1 = Ext.get(&#39;myElementId&#39;);
    /// p1.animate({
    /// to: {
    /// opacity: 0
    /// }
    /// });
    /// To make this animation fade out in a tenth of a second: var p1 = Ext.get(&#39;myElementId&#39;);
    /// p1.animate({
    /// duration: 100,
    /// to: {
    /// opacity: 0
    /// }
    /// });
    /// Animation Queues By default all animations are added to a queue which allows for animation via a chain-style API.
    /// For example, the following code will queue 4 animations which occur sequentially (one right after the other): p1.animate({
    /// to: {
    /// x: 500
    /// }
    /// }).animate({
    /// to: {
    /// y: 150
    /// }
    /// }).animate({
    /// to: {
    /// backgroundColor: &#39;#f00&#39;  //red
    /// }
    /// }).animate({
    /// to: {
    /// opacity: 0
    /// }
    /// });
    /// You can change this behavior by calling the syncFx method and all
    /// subsequent animations for the specified target will be run concurrently (at the same time). p1.syncFx();  //this will make all animations run at the same time
    /// p1.animate({
    /// to: {
    /// x: 500
    /// }
    /// }).animate({
    /// to: {
    /// y: 150
    /// }
    /// }).animate({
    /// to: {
    /// backgroundColor: &#39;#f00&#39;  //red
    /// }
    /// }).animate({
    /// to: {
    /// opacity: 0
    /// }
    /// });
    /// This works the same as: p1.animate({
    /// to: {
    /// x: 500,
    /// y: 150,
    /// backgroundColor: &#39;#f00&#39;  //red
    /// opacity: 0
    /// }
    /// });
    /// The stopAnimation method can be used to stop any
    /// currently running animations and clear any queued animations. Animation Keyframes You can also set up complex animations with keyframe which follows the
    /// CSS3 Animation configuration pattern. Note rotation, translation, and scaling can only be done for sprites.
    /// The previous example can be written with the following syntax: p1.animate({
    /// duration: 1000,  //one second total
    /// keyframes: {
    /// 25: {     //from 0 to 250ms (25%)
    /// x: 0
    /// },
    /// 50: {   //from 250ms to 500ms (50%)
    /// y: 0
    /// },
    /// 75: {  //from 500ms to 750ms (75%)
    /// backgroundColor: &#39;#f00&#39;  //red
    /// },
    /// 100: {  //from 750ms to 1sec
    /// opacity: 0
    /// }
    /// }
    /// });
    /// Animation Events Each animation you create has events for beforeanimation,
    /// afteranimate, and lastframe.
    /// Keyframed animations adds an additional keyframe event which
    /// fires for each keyframe in your animation. All animations support the listeners configuration to attact functions to these events. startAnimate: function() {
    /// var p1 = Ext.get(&#39;myElementId&#39;);
    /// p1.animate({
    /// duration: 100,
    /// to: {
    /// opacity: 0
    /// },
    /// listeners: {
    /// beforeanimate:  function() {
    /// // Execute my custom method before the animation
    /// this.myBeforeAnimateFn();
    /// },
    /// afteranimate: function() {
    /// // Execute my custom method after the animation
    /// this.myAfterAnimateFn();
    /// },
    /// scope: this
    /// });
    /// },
    /// myBeforeAnimateFn: function() {
    /// // My custom logic
    /// },
    /// myAfterAnimateFn: function() {
    /// // My custom logic
    /// }
    /// Due to the fact that animations run asynchronously, you can determine if an animation is currently
    /// running on any target by using the getActiveAnimation
    /// method.  This method will return false if there are no active animations or return the currently
    /// running Ext.fx.Anim instance. In this example, we&#39;re going to wait for the current animation to finish, then stop any other
    /// queued animations before we fade our element&#39;s opacity to 0: var curAnim = p1.getActiveAnimation();
    /// if (curAnim) {
    /// curAnim.on(&#39;afteranimate&#39;, function() {
    /// p1.stopAnimation();
    /// p1.animate({
    /// to: {
    /// opacity: 0
    /// }
    /// });
    /// });
    /// }
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial interface Animate
    {
        /// <summary>
        /// Perform custom animation on this object. ...
        /// </summary>
        object animate(object config);
        /// <summary>
        /// Returns thq current animation if this object has any effects actively running or queued, else returns false. ...
        /// </summary>
        object getActiveAnimation();
        /// <summary>
        /// Returns thq current animation if this object has any effects actively running or queued, else returns false. ...
        /// </summary>
        object hasActiveFx();
        /// <summary>
        /// Ensures that all effects queued after sequenceFx is called on this object are
        /// run in sequence. ...
        /// </summary>
        object sequenceFx();
        /// <summary>
        /// Stops any running effects and clears this object's internal effects queue if it contains
        /// any additional effects that ...
        /// </summary>
        Ext.core.Element stopAnimation();
        /// <summary>
        /// Stops any running effects and clears this object's internal effects queue if it contains
        /// any additional effects that ...
        /// </summary>
        Ext.core.Element stopFx();
        /// <summary>
        /// Ensures that all effects queued after syncFx is called on this object are
        /// run concurrently. ...
        /// </summary>
        object syncFx();
    }
    #endregion
    #region AnimateConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class AnimateConfig : Ext.BaseConfig
    {
    }
    #endregion
    #region AnimateEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class AnimateEvents : Ext.BaseEvents
    {
    }
    #endregion
}
#endregion
