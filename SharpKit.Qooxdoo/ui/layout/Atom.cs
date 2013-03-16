// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.layout
{
    /// <summary>
	/// <para>A atom layout. Used to place an image and label in relation
	/// to each other. Useful to create buttons, list items, etc.</para>
	/// <para>Features</para>
	/// <list type="bullet">
	/// <item>Gap between icon and text (using <see cref="Gap"/>)</item>
	/// <item>Vertical and horizontal mode (using <see cref="IconPosition"/>)</item>
	/// <item>Sorting options to place first child on top/left or bottom/right (using <see cref="IconPosition"/>)</item>
	/// <item>Automatically middles/centers content to the available space</item>
	/// <item>Auto-sizing</item>
	/// <item>Supports more than two children (will be processed the same way like the previous ones)</item>
	/// </list
	/// <para>Item Properties</para>
	/// <para>None</para>
	/// <para>Notes</para>
	/// <list type="bullet">
	/// <item>Does not support margins and alignment of <see cref="qx.ui.core.LayoutItem"/>.</item>
	/// </list
	/// <para>Alternative Names</para>
	/// <para>None</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.layout.Atom", OmitOptionalParameters = true, Export = false)]
    public partial class Atom : qx.ui.layout.Abstract
    {
		#region Properties

		/// <summary>
		/// <para>Whether the content should be rendered centrally when to much space
		/// is available. Affects both axis.</para>
		/// </summary>
		[JsProperty(Name = "center", NativeField = true)]
		public bool Center { get; set; }

		/// <summary>
		/// <para>The gap between the icon and the text</para>
		/// </summary>
		[JsProperty(Name = "gap", NativeField = true)]
		public double Gap { get; set; }

		/// <summary>
		/// <para>The position of the icon in relation to the text</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "left","top","right","bottom","top-left","bottom-left"
		/// </remarks>
		[JsProperty(Name = "iconPosition", NativeField = true)]
		public object IconPosition { get; set; }

		#endregion Properties

		#region Methods

		public Atom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property center.</para>
		/// </summary>
		[JsMethod(Name = "getCenter")]
		public bool GetCenter() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property gap.</para>
		/// </summary>
		[JsMethod(Name = "getGap")]
		public double GetGap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property iconPosition.</para>
		/// </summary>
		[JsMethod(Name = "getIconPosition")]
		public object GetIconPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property center
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property center.</param>
		[JsMethod(Name = "initCenter")]
		public void InitCenter(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property gap
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property gap.</param>
		[JsMethod(Name = "initGap")]
		public void InitGap(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property iconPosition
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property iconPosition.</param>
		[JsMethod(Name = "initIconPosition")]
		public void InitIconPosition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property center equals true.</para>
		/// </summary>
		[JsMethod(Name = "isCenter")]
		public void IsCenter() { throw new NotImplementedException(); }

		[JsMethod(Name = "renderLayout")]
		public void RenderLayout(object availWidth, object availHeight) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property center.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetCenter")]
		public void ResetCenter() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property gap.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetGap")]
		public void ResetGap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property iconPosition.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIconPosition")]
		public void ResetIconPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property center.</para>
		/// </summary>
		/// <param name="value">New value for property center.</param>
		[JsMethod(Name = "setCenter")]
		public void SetCenter(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property gap.</para>
		/// </summary>
		/// <param name="value">New value for property gap.</param>
		[JsMethod(Name = "setGap")]
		public void SetGap(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property iconPosition.</para>
		/// </summary>
		/// <param name="value">New value for property iconPosition.</param>
		[JsMethod(Name = "setIconPosition")]
		public void SetIconPosition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property center.</para>
		/// </summary>
		[JsMethod(Name = "toggleCenter")]
		public void ToggleCenter() { throw new NotImplementedException(); }

		#endregion Methods
    }
}