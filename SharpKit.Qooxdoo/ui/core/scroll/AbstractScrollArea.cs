// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core.scroll
{
    /// <summary>
	/// <para>The ScrollArea provides a container widget with on demand scroll bars
	/// if the content size exceeds the size of the container.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.scroll.AbstractScrollArea", OmitOptionalParameters = true, Export = false)]
    public abstract partial class AbstractScrollArea : qx.ui.core.Widget
    {
		#region Events

		/// <summary>
		/// <para>Fired as soon as the scroll animation in X direction ends.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnScrollAnimationXEnd;

		/// <summary>
		/// <para>Fired as soon as the scroll animation in X direction ends.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnScrollAnimationYEnd;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>The item&#8217;s preferred height.</para>
		/// <para>The computed height may differ from the given height due to
		/// stretching. Also take a look at the related properties
		/// <see cref="MinHeight"/> and <see cref="MaxHeight"/>.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "height", NativeField = true)]
		public double Height { get; set; }

		/// <summary>
		/// <para>Group property, to set the overflow of both scroll bars.</para>
		/// </summary>
		[JsProperty(Name = "scrollbar", NativeField = true)]
		public object Scrollbar { get; set; }

		/// <summary>
		/// <para>The policy, when the horizontal scrollbar should be shown.
		/// <list type="bullet">
		/// <item>auto: Show scrollbar on demand</item>
		/// <item>on: Always show the scrollbar</item>
		/// <item>off: Never show the scrollbar</item>
		/// </list</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "auto","on","off"
		/// </remarks>
		[JsProperty(Name = "scrollbarX", NativeField = true)]
		public object ScrollbarX { get; set; }

		/// <summary>
		/// <para>The policy, when the horizontal scrollbar should be shown.
		/// <list type="bullet">
		/// <item>auto: Show scrollbar on demand</item>
		/// <item>on: Always show the scrollbar</item>
		/// <item>off: Never show the scrollbar</item>
		/// </list</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "auto","on","off"
		/// </remarks>
		[JsProperty(Name = "scrollbarY", NativeField = true)]
		public object ScrollbarY { get; set; }

		/// <summary>
		/// <para>The LayoutItem&#8216;s preferred width.</para>
		/// <para>The computed width may differ from the given width due to
		/// stretching. Also take a look at the related properties
		/// <see cref="MinWidth"/> and <see cref="MaxWidth"/>.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "width", NativeField = true)]
		public double Width { get; set; }

		#endregion Properties

		#region Methods

		public AbstractScrollArea() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the top offset of the end of the given item in relation to the
		/// inner height of this widget.</para>
		/// </summary>
		/// <param name="item">Item to query</param>
		/// <returns>Top offset</returns>
		[JsMethod(Name = "getItemBottom")]
		public double GetItemBottom(qx.ui.core.Widget item) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the left offset of the given item in relation to the
		/// inner width of this widget.</para>
		/// </summary>
		/// <param name="item">Item to query</param>
		/// <returns>Top offset</returns>
		[JsMethod(Name = "getItemLeft")]
		public double GetItemLeft(qx.ui.core.Widget item) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the left offset of the end of the given item in relation to the
		/// inner width of this widget.</para>
		/// </summary>
		/// <param name="item">Item to query</param>
		/// <returns>Right offset</returns>
		[JsMethod(Name = "getItemRight")]
		public double GetItemRight(qx.ui.core.Widget item) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the top offset of the given item in relation to the
		/// inner height of this widget.</para>
		/// </summary>
		/// <param name="item">Item to query</param>
		/// <returns>Top offset</returns>
		[JsMethod(Name = "getItemTop")]
		public double GetItemTop(qx.ui.core.Widget item) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the boundaries of the pane.</para>
		/// </summary>
		/// <returns>The pane boundaries.</returns>
		[JsMethod(Name = "getPaneSize")]
		public object GetPaneSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property scrollbarX.</para>
		/// </summary>
		[JsMethod(Name = "getScrollbarX")]
		public object GetScrollbarX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property scrollbarY.</para>
		/// </summary>
		[JsMethod(Name = "getScrollbarY")]
		public object GetScrollbarY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the scroll left position of the content</para>
		/// </summary>
		/// <returns>Horizontal scroll position</returns>
		[JsMethod(Name = "getScrollX")]
		public double GetScrollX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the scroll top position of the content</para>
		/// </summary>
		/// <returns>Vertical scroll position</returns>
		[JsMethod(Name = "getScrollY")]
		public double GetScrollY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property scrollbarX
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property scrollbarX.</param>
		[JsMethod(Name = "initScrollbarX")]
		public void InitScrollbarX(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property scrollbarY
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property scrollbarY.</param>
		[JsMethod(Name = "initScrollbarY")]
		public void InitScrollbarY(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property scrollbar.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetScrollbar")]
		public void ResetScrollbar() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property scrollbarX.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetScrollbarX")]
		public void ResetScrollbarX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property scrollbarY.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetScrollbarY")]
		public void ResetScrollbarY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls the element&#8217;s content by the given left offset</para>
		/// </summary>
		/// <param name="value">The vertical position to scroll to.</param>
		/// <param name="duration">The time in milliseconds the scroll to should take.</param>
		[JsMethod(Name = "scrollByX")]
		public void ScrollByX(double value, double duration) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls the element&#8217;s content by the given top offset</para>
		/// </summary>
		/// <param name="value">The horizontal position to scroll to.</param>
		/// <param name="duration">The time in milliseconds the scroll to should take.</param>
		[JsMethod(Name = "scrollByY")]
		public void ScrollByY(double value, double duration) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls the element&#8217;s content to the given left coordinate</para>
		/// </summary>
		/// <param name="value">The vertical position to scroll to.</param>
		/// <param name="duration">The time in milliseconds the scroll to should take.</param>
		[JsMethod(Name = "scrollToX")]
		public void ScrollToX(double value, double duration) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls the element&#8217;s content to the given top coordinate</para>
		/// </summary>
		/// <param name="value">The horizontal position to scroll to.</param>
		/// <param name="duration">The time in milliseconds the scroll to should take.</param>
		[JsMethod(Name = "scrollToY")]
		public void ScrollToY(double value, double duration) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the values of the property group scrollbar.</para>
		/// </summary>
		/// <param name="scrollbarX">Sets the value of the property #scrollbarX.</param>
		/// <param name="scrollbarY">Sets the value of the property #scrollbarY.</param>
		[JsMethod(Name = "setScrollbar")]
		public void SetScrollbar(object scrollbarX, object scrollbarY) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property scrollbarX.</para>
		/// </summary>
		/// <param name="value">New value for property scrollbarX.</param>
		[JsMethod(Name = "setScrollbarX")]
		public void SetScrollbarX(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property scrollbarY.</para>
		/// </summary>
		/// <param name="value">New value for property scrollbarY.</param>
		[JsMethod(Name = "setScrollbarY")]
		public void SetScrollbarY(object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}