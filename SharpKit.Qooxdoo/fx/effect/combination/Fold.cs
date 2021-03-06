// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.fx.effect.combination
{
    /// <summary>
	/// <para>Combination effect &#8220;Fold&#8221;</para>
	/// <para>Shrinks the element in width and height until it gets invisible.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.fx.effect.combination.Fold", OmitOptionalParameters = true, Export = false)]
    public partial class Fold : qx.fx.Base
    {
		#region Properties

		/// <summary>
		/// <para>String indicating if element should fold in or out</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "in","out"
		/// </remarks>
		[JsProperty(Name = "mode", NativeField = true)]
		public object Mode { get; set; }

		/// <summary>
		/// <para>Flag indicating if the CSS attribute &#8220;display&#8221;
		/// should be modified by effect</para>
		/// </summary>
		[JsProperty(Name = "modifyDisplay", NativeField = true)]
		public bool ModifyDisplay { get; set; }

		#endregion Properties

		#region Methods

		public Fold() { throw new NotImplementedException(); }

		/// <param name="element">The DOM element</param>
		public Fold(object element) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This internal function is called after
		/// the effect actually has ended.</para>
		/// </summary>
		[JsMethod(Name = "afterFinish")]
		public void AfterFinish() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property mode.</para>
		/// </summary>
		[JsMethod(Name = "getMode")]
		public object GetMode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property modifyDisplay.</para>
		/// </summary>
		[JsMethod(Name = "getModifyDisplay")]
		public bool GetModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property mode
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property mode.</param>
		[JsMethod(Name = "initMode")]
		public void InitMode(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property modifyDisplay
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property modifyDisplay.</param>
		[JsMethod(Name = "initModifyDisplay")]
		public void InitModifyDisplay(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property modifyDisplay equals true.</para>
		/// </summary>
		[JsMethod(Name = "isModifyDisplay")]
		public void IsModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property mode.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMode")]
		public void ResetMode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property modifyDisplay.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetModifyDisplay")]
		public void ResetModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property mode.</para>
		/// </summary>
		/// <param name="value">New value for property mode.</param>
		[JsMethod(Name = "setMode")]
		public void SetMode(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property modifyDisplay.</para>
		/// </summary>
		/// <param name="value">New value for property modifyDisplay.</param>
		[JsMethod(Name = "setModifyDisplay")]
		public void SetModifyDisplay(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Starts the effect</para>
		/// </summary>
		/// <returns>true if the effect was successfully started</returns>
		[JsMethod(Name = "start")]
		public bool Start() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property modifyDisplay.</para>
		/// </summary>
		[JsMethod(Name = "toggleModifyDisplay")]
		public void ToggleModifyDisplay() { throw new NotImplementedException(); }

		#endregion Methods
    }
}