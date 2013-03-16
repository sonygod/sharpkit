// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.cell
{
    /// <summary>
	/// <para>Date cell renderer.</para>
	/// <para>Renders a date according to the configured date formatter.</para>
	/// <para>EXPERIMENTAL!</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.cell.Date", OmitOptionalParameters = true, Export = false)]
    public partial class Date : qx.ui.virtualx.cell.Cell
    {
		#region Properties

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		/// <summary>
		/// <para>The date format used to render the cell</para>
		/// </summary>
		[JsProperty(Name = "dateFormat", NativeField = true)]
		public qx.util.format.DateFormat DateFormat { get; set; }

		#endregion Properties

		#region Methods

		public Date() { throw new NotImplementedException(); }

		/// <param name="dateFormat">optional date formatter to use</param>
		public Date(qx.util.format.DateFormat dateFormat) { throw new NotImplementedException(); }

		[JsMethod(Name = "getContent")]
		public void GetContent(object value, object states) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property dateFormat.</para>
		/// </summary>
		[JsMethod(Name = "getDateFormat")]
		public qx.util.format.DateFormat GetDateFormat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property dateFormat
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property dateFormat.</param>
		[JsMethod(Name = "initDateFormat")]
		public void InitDateFormat(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property dateFormat.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDateFormat")]
		public void ResetDateFormat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property dateFormat.</para>
		/// </summary>
		/// <param name="value">New value for property dateFormat.</param>
		[JsMethod(Name = "setDateFormat")]
		public void SetDateFormat(qx.util.format.DateFormat value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}