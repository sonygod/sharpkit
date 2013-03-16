// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.layout
{
    /// <summary>
	/// <para>Docks children to one of the edges.</para>
	/// <para>Features</para>
	/// <list type="bullet">
	/// <item>Percent width for left/right/center attached children</item>
	/// <item>Percent height for top/bottom/center attached children</item>
	/// <item>Minimum and maximum dimensions</item>
	/// <item>Prioritized growing/shrinking (flex)</item>
	/// <item>Auto sizing</item>
	/// <item>Margins and Spacings</item>
	/// <item>Alignment in orthogonal axis (e.g. alignX of north attached)</item>
	/// <item>Different sort options for children</item>
	/// </list
	/// <para>Item Properties</para>
	/// <list type="bullet">
	/// <item>edge (String): The edge where the layout item
	/// should be docked. This may be one of north, east,
	/// south, west or center. (Required)</item>
	/// <item>width (String): Defines a percent
	/// width for the item. The percent width,
	/// when specified, is used instead of the width defined by the size hint.
	/// This is only supported for children added to the north or south edge or
	/// are centered in the middle of the layout.
	/// The minimum and maximum width still takes care of the elements limitations.
	/// It has no influence on the layout's size hint. Percents are mainly useful for
	/// widgets which are sized by the outer hierarchy.
	/// </item>
	/// <item>height (String): Defines a percent
	/// height for the item. The percent height,
	/// when specified, is used instead of the height defined by the size hint.
	/// This is only supported for children added to the west or east edge or
	/// are centered in the middle of the layout.
	/// The minimum and maximum height still takes care of the elements limitations.
	/// It has no influence on the layout's size hint. Percents are mainly useful for
	/// widgets which are sized by the outer hierarchy.
	/// </item>
	/// </list
	/// <para>Example</para>
	/// <code>
	/// var layout = new qx.ui.layout.Dock();
	/// var w1 = new qx.ui.core.Widget();
	/// var w2 = new qx.ui.core.Widget();
	/// var w3 = new qx.ui.core.Widget();
	/// w1.setHeight(200);
	/// w2.setWidth(150);
	/// var container = new qx.ui.container.Composite(layout);
	/// container.add(w1, {edge:"north"});
	/// container.add(w2, {edge:"west"});
	/// container.add(w3, {edge:"center"});
	/// </code>
	/// <para>Detailed Description</para>
	/// <para>Using this layout, items may be &#8220;docked&#8221; to a specific side
	/// of the available space. Each displayed item reduces the available space
	/// for the following children. Priorities depend on the position of
	/// the child in the internal children list.</para>
	/// <para>External Documentation</para>
	/// 
	/// Extended documentation and links to demos of this layout in the qooxdoo manual.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.layout.Dock", OmitOptionalParameters = true, Export = false)]
    public partial class Dock : qx.ui.layout.Abstract
    {
		#region Properties

		/// <summary>
		/// <para>Whether separators should be collapsed so when a spacing is
		/// configured the line go over into each other</para>
		/// </summary>
		[JsProperty(Name = "connectSeparators", NativeField = true)]
		public bool ConnectSeparators { get; set; }

		/// <summary>
		/// <para>Separator lines to use between the horizontal objects</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "separatorX", NativeField = true)]
		public qx.html.Decorator SeparatorX { get; set; }

		/// <summary>
		/// <para>Separator lines to use between the vertical objects</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "separatorY", NativeField = true)]
		public qx.html.Decorator SeparatorY { get; set; }

		/// <summary>
		/// <para>The way the widgets should be displayed (in conjunction with their
		/// position in the childrens array).</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "auto","y","x"
		/// </remarks>
		[JsProperty(Name = "sort", NativeField = true)]
		public object Sort { get; set; }

		/// <summary>
		/// <para>Horizontal spacing between two children</para>
		/// </summary>
		[JsProperty(Name = "spacingX", NativeField = true)]
		public double SpacingX { get; set; }

		/// <summary>
		/// <para>Vertical spacing between two children</para>
		/// </summary>
		[JsProperty(Name = "spacingY", NativeField = true)]
		public double SpacingY { get; set; }

		#endregion Properties

		#region Methods

		public Dock() { throw new NotImplementedException(); }

		/// <param name="spacingX">The horizontal spacing. Sets #spacingX.</param>
		/// <param name="spacingY">The vertical spacing. Sets #spacingY.</param>
		/// <param name="separatorX">Separator to render between columns</param>
		/// <param name="separatorY">Separator to render between rows</param>
		public Dock(double spacingX = 0, double spacingY = 0, qx.html.Decorator separatorX = null, qx.html.Decorator separatorY = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property connectSeparators.</para>
		/// </summary>
		[JsMethod(Name = "getConnectSeparators")]
		public bool GetConnectSeparators() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property separatorX.</para>
		/// </summary>
		[JsMethod(Name = "getSeparatorX")]
		public qx.html.Decorator GetSeparatorX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property separatorY.</para>
		/// </summary>
		[JsMethod(Name = "getSeparatorY")]
		public qx.html.Decorator GetSeparatorY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property sort.</para>
		/// </summary>
		[JsMethod(Name = "getSort")]
		public object GetSort() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property spacingX.</para>
		/// </summary>
		[JsMethod(Name = "getSpacingX")]
		public double GetSpacingX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property spacingY.</para>
		/// </summary>
		[JsMethod(Name = "getSpacingY")]
		public double GetSpacingY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property connectSeparators
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property connectSeparators.</param>
		[JsMethod(Name = "initConnectSeparators")]
		public void InitConnectSeparators(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property separatorX
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property separatorX.</param>
		[JsMethod(Name = "initSeparatorX")]
		public void InitSeparatorX(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property separatorY
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property separatorY.</param>
		[JsMethod(Name = "initSeparatorY")]
		public void InitSeparatorY(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property sort
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property sort.</param>
		[JsMethod(Name = "initSort")]
		public void InitSort(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property spacingX
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property spacingX.</param>
		[JsMethod(Name = "initSpacingX")]
		public void InitSpacingX(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property spacingY
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property spacingY.</param>
		[JsMethod(Name = "initSpacingY")]
		public void InitSpacingY(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property connectSeparators equals true.</para>
		/// </summary>
		[JsMethod(Name = "isConnectSeparators")]
		public void IsConnectSeparators() { throw new NotImplementedException(); }

		[JsMethod(Name = "renderLayout")]
		public void RenderLayout(object availWidth, object availHeight) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property connectSeparators.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetConnectSeparators")]
		public void ResetConnectSeparators() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property separatorX.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSeparatorX")]
		public void ResetSeparatorX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property separatorY.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSeparatorY")]
		public void ResetSeparatorY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property sort.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSort")]
		public void ResetSort() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property spacingX.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSpacingX")]
		public void ResetSpacingX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property spacingY.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSpacingY")]
		public void ResetSpacingY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property connectSeparators.</para>
		/// </summary>
		/// <param name="value">New value for property connectSeparators.</param>
		[JsMethod(Name = "setConnectSeparators")]
		public void SetConnectSeparators(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property separatorX.</para>
		/// </summary>
		/// <param name="value">New value for property separatorX.</param>
		[JsMethod(Name = "setSeparatorX")]
		public void SetSeparatorX(qx.html.Decorator value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property separatorY.</para>
		/// </summary>
		/// <param name="value">New value for property separatorY.</param>
		[JsMethod(Name = "setSeparatorY")]
		public void SetSeparatorY(qx.html.Decorator value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property sort.</para>
		/// </summary>
		/// <param name="value">New value for property sort.</param>
		[JsMethod(Name = "setSort")]
		public void SetSort(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property spacingX.</para>
		/// </summary>
		/// <param name="value">New value for property spacingX.</param>
		[JsMethod(Name = "setSpacingX")]
		public void SetSpacingX(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property spacingY.</para>
		/// </summary>
		/// <param name="value">New value for property spacingY.</param>
		[JsMethod(Name = "setSpacingY")]
		public void SetSpacingY(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property connectSeparators.</para>
		/// </summary>
		[JsMethod(Name = "toggleConnectSeparators")]
		public void ToggleConnectSeparators() { throw new NotImplementedException(); }

		#endregion Methods
    }
}