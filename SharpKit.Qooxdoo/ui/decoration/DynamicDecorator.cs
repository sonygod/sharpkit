// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.decoration
{
    /// <summary>
	/// <para>This class is an abstract base calls and used by
	/// <see cref="qx.theme.manager.Decoration"/>. It&#8217;s main purpose is to combine the
	/// included mixins into one working decorator.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.decoration.DynamicDecorator", OmitOptionalParameters = true, Export = false)]
    public partial class DynamicDecorator : qx.ui.decoration.Abstract
    {
		#region Methods

		public DynamicDecorator() { throw new NotImplementedException(); }

		[JsMethod(Name = "getMarkup")]
		public void GetMarkup() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the styles of the decorator as a map with property names written
		/// in javascript style (e.g. fontWeight instead of font-weight).</para>
		/// </summary>
		/// <returns>style information</returns>
		[JsMethod(Name = "getStyles")]
		public object GetStyles() { throw new NotImplementedException(); }

		[JsMethod(Name = "resize")]
		public void Resize(object element, object width, object height) { throw new NotImplementedException(); }

		[JsMethod(Name = "tint")]
		public void Tint(object element, object bgcolor) { throw new NotImplementedException(); }

		#endregion Methods
    }
}