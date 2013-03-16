// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core
{
    /// <summary>
	/// <para>This mixin blocks events and can be included into all widgets.</para>
	/// <para>The <see cref="Block"/> and <see cref="Unblock"/> methods provided by this mixin can be used
	/// to block any event from the widget. When blocked,
	/// the blocker widget overlays the widget to block, including the padding area.</para>
	/// <para>The second set of methods (<see cref="BlockContent"/>, <see cref="UnblockContent"/>)
	/// can be used to block child widgets with a zIndex below a certain value.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.MBlocker", OmitOptionalParameters = true, Export = false)]
    public partial class MBlocker 
    {
		#region Properties

		/// <summary>
		/// <para>Color of the blocker</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "blockerColor", NativeField = true)]
		public string BlockerColor { get; set; }

		/// <summary>
		/// <para>Opacity of the blocker</para>
		/// </summary>
		[JsProperty(Name = "blockerOpacity", NativeField = true)]
		public double BlockerOpacity { get; set; }

		#endregion Properties

		#region Methods

		public MBlocker() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Block all events from this widget by placing a transparent overlay widget,
		/// which receives all events, exactly over the widget.</para>
		/// </summary>
		[JsMethod(Name = "block")]
		public void Block() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Block direct child widgets with a zIndex below zIndex</para>
		/// </summary>
		/// <param name="zIndex">All child widgets with a zIndex below this value will be blocked</param>
		[JsMethod(Name = "blockContent")]
		public void BlockContent(double zIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the widget blocked by <see cref="Block"/>, but it doesn&#8217;t take care of
		/// the amount of <see cref="Block"/> calls. The blocker is directly removed.</para>
		/// </summary>
		[JsMethod(Name = "forceUnblock")]
		public void ForceUnblock() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the content blocked by <see cref="BlockContent"/>, but it doesn&#8217;t take
		/// care of the amount of <see cref="BlockContent"/> calls. The blocker is
		/// directly removed.</para>
		/// </summary>
		[JsMethod(Name = "forceUnblockContent")]
		public void ForceUnblockContent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the blocker</para>
		/// </summary>
		/// <returns>The blocker</returns>
		[JsMethod(Name = "getBlocker")]
		public qx.ui.core.Blocker GetBlocker() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property blockerColor.</para>
		/// </summary>
		[JsMethod(Name = "getBlockerColor")]
		public string GetBlockerColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property blockerOpacity.</para>
		/// </summary>
		[JsMethod(Name = "getBlockerOpacity")]
		public double GetBlockerOpacity() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property blockerColor
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property blockerColor.</param>
		[JsMethod(Name = "initBlockerColor")]
		public void InitBlockerColor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property blockerOpacity
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property blockerOpacity.</param>
		[JsMethod(Name = "initBlockerOpacity")]
		public void InitBlockerOpacity(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the widget is blocked.</para>
		/// </summary>
		/// <returns>Whether the widget is blocked.</returns>
		[JsMethod(Name = "isBlocked")]
		public bool IsBlocked() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the content is blocked</para>
		/// </summary>
		/// <returns>Whether the content is blocked</returns>
		[JsMethod(Name = "isContentBlocked")]
		public bool IsContentBlocked() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property blockerColor.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBlockerColor")]
		public void ResetBlockerColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property blockerOpacity.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBlockerOpacity")]
		public void ResetBlockerOpacity() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property blockerColor.</para>
		/// </summary>
		/// <param name="value">New value for property blockerColor.</param>
		[JsMethod(Name = "setBlockerColor")]
		public void SetBlockerColor(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property blockerOpacity.</para>
		/// </summary>
		/// <param name="value">New value for property blockerOpacity.</param>
		[JsMethod(Name = "setBlockerOpacity")]
		public void SetBlockerOpacity(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the widget blocked by <see cref="Block"/>, but it takes care of
		/// the amount of <see cref="Block"/> calls. The blocker is only removed if
		/// the numer of <see cref="Unblock"/> calls is identical to <see cref="Block"/> calls.</para>
		/// </summary>
		[JsMethod(Name = "unblock")]
		public void Unblock() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the content blocked by <see cref="BlockContent"/>, but it takes care of
		/// the amount of <see cref="BlockContent"/> calls. The blocker is only removed if
		/// the numer of <see cref="UnblockContent"/> calls is identical to
		/// <see cref="BlockContent"/> calls.</para>
		/// </summary>
		[JsMethod(Name = "unblockContent")]
		public void UnblockContent() { throw new NotImplementedException(); }

		#endregion Methods
    }
}