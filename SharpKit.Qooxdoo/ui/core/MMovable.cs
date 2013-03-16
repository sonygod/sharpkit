// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core
{
    /// <summary>
	/// <para>Provides move behavior to any widget.</para>
	/// <para>The widget using the mixin must register a widget as move handle so that
	/// the mouse events needed for moving it are attached to this widget).</para>
	/// <code>this._activateMoveHandle(widget);</code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.MMovable", OmitOptionalParameters = true, Export = false)]
    public partial class MMovable 
    {
		#region Properties

		/// <summary>
		/// <para>Whether the widget is movable</para>
		/// </summary>
		[JsProperty(Name = "movable", NativeField = true)]
		public bool Movable { get; set; }

		/// <summary>
		/// <para>Whether to use a frame instead of the original widget during move sequences</para>
		/// </summary>
		[JsProperty(Name = "useMoveFrame", NativeField = true)]
		public bool UseMoveFrame { get; set; }

		#endregion Properties

		#region Methods

		public MMovable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property movable.</para>
		/// </summary>
		[JsMethod(Name = "getMovable")]
		public bool GetMovable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property useMoveFrame.</para>
		/// </summary>
		[JsMethod(Name = "getUseMoveFrame")]
		public bool GetUseMoveFrame() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property movable
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property movable.</param>
		[JsMethod(Name = "initMovable")]
		public void InitMovable(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property useMoveFrame
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property useMoveFrame.</param>
		[JsMethod(Name = "initUseMoveFrame")]
		public void InitUseMoveFrame(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property movable equals true.</para>
		/// </summary>
		[JsMethod(Name = "isMovable")]
		public void IsMovable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property useMoveFrame equals true.</para>
		/// </summary>
		[JsMethod(Name = "isUseMoveFrame")]
		public void IsUseMoveFrame() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property movable.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMovable")]
		public void ResetMovable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property useMoveFrame.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetUseMoveFrame")]
		public void ResetUseMoveFrame() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property movable.</para>
		/// </summary>
		/// <param name="value">New value for property movable.</param>
		[JsMethod(Name = "setMovable")]
		public void SetMovable(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property useMoveFrame.</para>
		/// </summary>
		/// <param name="value">New value for property useMoveFrame.</param>
		[JsMethod(Name = "setUseMoveFrame")]
		public void SetUseMoveFrame(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property movable.</para>
		/// </summary>
		[JsMethod(Name = "toggleMovable")]
		public void ToggleMovable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property useMoveFrame.</para>
		/// </summary>
		[JsMethod(Name = "toggleUseMoveFrame")]
		public void ToggleUseMoveFrame() { throw new NotImplementedException(); }

		#endregion Methods
    }
}