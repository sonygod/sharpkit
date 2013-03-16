// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.html
{
    /// <summary>
	/// <para>A Input wrap any valid HTML input element and make it accessible
	/// through the normalized qooxdoo element interface.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.html.Input", OmitOptionalParameters = true, Export = false)]
    public partial class Input : qx.html.Element
    {
		#region Methods

		public Input() { throw new NotImplementedException(); }

		/// <param name="type">The type of the input field. Valid values are text, textarea, select, checkbox, radio, password, hidden, submit, image, file, search, reset, select and textarea.</param>
		/// <param name="styles">optional map of CSS styles, where the key is the name of the style and the value is the value to use.</param>
		/// <param name="attributes">optional map of element attributes, where the key is the name of the attribute and the value is the value to use.</param>
		public Input(string type, object styles = null, object attributes = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the current value.</para>
		/// </summary>
		/// <returns>The element&#8217;s current value.</returns>
		[JsMethod(Name = "getValue")]
		public string GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Gets the text wrap behavior of a text area element.</para>
		/// <para>This property uses the style property &#8220;wrap&#8221; (IE) respectively &#8220;whiteSpace&#8221;</para>
		/// </summary>
		/// <returns>Whether wrapping is enabled or disabled.</returns>
		[JsMethod(Name = "getWrap")]
		public bool GetWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the value of the input element.</para>
		/// </summary>
		/// <param name="value">the new value</param>
		/// <returns>This instance for for chaining support.</returns>
		[JsMethod(Name = "setValue")]
		public qx.html.Input SetValue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the text wrap behavior of a text area element.</para>
		/// <para>This property uses the style property &#8220;wrap&#8221; (IE) respectively &#8220;whiteSpace&#8221;</para>
		/// </summary>
		/// <param name="wrap">Whether to turn text wrap on or off.</param>
		/// <param name="direct">Whether the execution should be made directly when possible</param>
		/// <returns>This instance for for chaining support.</returns>
		[JsMethod(Name = "setWrap")]
		public qx.html.Input SetWrap(bool wrap, bool direct = false) { throw new NotImplementedException(); }

		#endregion Methods
    }
}