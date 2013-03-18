// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core.selection
{
    /// <summary>
	/// <para>A selection manager, which handles the selection in widgets.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.selection.Widget", OmitOptionalParameters = true, Export = false)]
    public partial class Widget : qx.ui.core.selection.Abstract
    {
		#region Methods

		public Widget() { throw new NotImplementedException(); }

		/// <param name="widget">The widget to connect to</param>
		public Widget(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns all selectable items of the container.</para>
		/// </summary>
		/// <param name="all">true for all selectables, false for the selectables the user can interactively select</param>
		/// <returns>A list of items</returns>
		[JsMethod(Name = "getSelectables")]
		public JsArray GetSelectables(bool all) { throw new NotImplementedException(); }

		#endregion Methods
    }
}