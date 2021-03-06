// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>Wrapper around native event management capabilities of the browser.
	/// This class should not be used directly normally. It&#8217;s better
	/// to use <see cref="qx.event.Registration"/> instead.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.Event", OmitOptionalParameters = true, Export = false)]
    public partial class Event 
    {
		#region Methods

		public Event() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Use the low level browser functionality to attach event listeners
		/// to DOM nodes.</para>
		/// <para>Use this with caution. This is only thought for event handlers and
		/// qualified developers. These are not mem-leak protected!</para>
		/// </summary>
		/// <param name="target">Any valid native event target</param>
		/// <param name="type">Name of the event</param>
		/// <param name="listener">The pointer to the function to assign</param>
		/// <param name="useCapture">A Boolean value that specifies the event phase to add the event handler for the capturing phase or the bubbling phase.</param>
		[JsMethod(Name = "addNativeListener")]
		public static void AddNativeListener(object target, string type, Action<qx.eventx.type.Data> listener, bool useCapture = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Fires a synthetic native event on the given element.</para>
		/// </summary>
		/// <param name="target">DOM element to fire event on</param>
		/// <param name="type">Name of the event to fire</param>
		/// <returns>A value that indicates whether any of the event handlers called #preventDefault. true The default action is permitted, false the caller should prevent the default action.</returns>
		[JsMethod(Name = "fire")]
		public static bool Fire(qx.html.Element target, string type) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the related target from the native DOM event</para>
		/// </summary>
		/// <param name="e">Native DOM event object</param>
		/// <returns>The related target</returns>
		[JsMethod(Name = "getRelatedTarget")]
		public static qx.html.Element GetRelatedTarget(Event e) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the target of the event.</para>
		/// </summary>
		/// <param name="e">Native event object</param>
		/// <returns>Any valid native event target</returns>
		[JsMethod(Name = "getTarget")]
		public static object GetTarget(Event e) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prevent the native default of the event to be processed.</para>
		/// <para>This is useful to stop native keybindings, native selection
		/// and other native functionality behind events.</para>
		/// </summary>
		/// <param name="e">Native event object</param>
		[JsMethod(Name = "preventDefault")]
		public static void PreventDefault(Event e) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Use the low level browser functionality to remove event listeners
		/// from DOM nodes.</para>
		/// </summary>
		/// <param name="target">Any valid native event target</param>
		/// <param name="type">Name of the event</param>
		/// <param name="listener">The pointer to the function to assign</param>
		/// <param name="useCapture">A Boolean value that specifies the event phase to remove the event handler for the capturing phase or the bubbling phase.</param>
		[JsMethod(Name = "removeNativeListener")]
		public static void RemoveNativeListener(object target, string type, Action<qx.eventx.type.Data> listener, bool useCapture = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Stops the propagation of the given event to the parent element.</para>
		/// <para>Only useful for events which bubble e.g. mousedown.</para>
		/// </summary>
		/// <param name="e">Native event object</param>
		[JsMethod(Name = "stopPropagation")]
		public static void StopPropagation(Event e) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the given target supports the given event type.</para>
		/// <para>Useful for testing for support of new features like
		/// touch events, gesture events, orientation change, on/offline, etc.</para>
		/// </summary>
		/// <param name="target">Any valid target e.g. window, dom node, etc.</param>
		/// <param name="type">Type of the event e.g. click, mousedown</param>
		/// <returns>Whether the given event is supported</returns>
		[JsMethod(Name = "supportsEvent")]
		public static bool SupportsEvent(object target, string type) { throw new NotImplementedException(); }

		#endregion Methods
    }
}