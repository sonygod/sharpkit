// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.form
{
    /// <summary>
	/// <para>The mixin contains all functionality to provide a value property for input
	/// widgets.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.form.MValue", OmitOptionalParameters = true, Export = false)]
    public partial class MValue 
    {
		#region Events

		/// <summary>
		/// <para>The event is fired each time the text field looses focus and the
		/// text field values has changed.</para>
		/// <para>If you change <see cref="LiveUpdate"/> to true, the changeValue event will
		/// be fired after every keystroke and not only after every focus loss. In
		/// that mode, the changeValue event is equal to the <see cref="Input"/> event.</para>
		/// <para>The method <see cref="qx.event.type.Data.GetData"/> returns the
		/// current text value of the field.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeValueEvent;

		/// <summary>
		/// <para>The event is fired on every keystroke modifying the value of the field.</para>
		/// <para>The method <see cref="qx.event.type.Data.GetData"/> returns the
		/// current value of the text field.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> InputEvent;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Whether the <see cref="ChangeValue"/> event should be fired on every key
		/// input. If set to true, the changeValue event is equal to the
		/// <see cref="Input"/> event.</para>
		/// </summary>
		[JsProperty(Name = "liveUpdate", NativeField = true)]
		public bool LiveUpdate { get; set; }

		#endregion Properties

		#region Methods

		public MValue() { throw new NotImplementedException(); }

		/// <param name="value">The value of the widget.</param>
		public MValue(object value = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property liveUpdate.</para>
		/// </summary>
		[JsMethod(Name = "getLiveUpdate")]
		public bool GetLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the set value.</para>
		/// </summary>
		/// <returns>The set value</returns>
		[JsMethod(Name = "getValue")]
		public object GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property liveUpdate
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property liveUpdate.</param>
		[JsMethod(Name = "initLiveUpdate")]
		public void InitLiveUpdate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property liveUpdate equals true.</para>
		/// </summary>
		[JsMethod(Name = "isLiveUpdate")]
		public void IsLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property liveUpdate.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLiveUpdate")]
		public void ResetLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the value.</para>
		/// </summary>
		[JsMethod(Name = "resetValue")]
		public void ResetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property liveUpdate.</para>
		/// </summary>
		/// <param name="value">New value for property liveUpdate.</param>
		[JsMethod(Name = "setLiveUpdate")]
		public void SetLiveUpdate(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the value.</para>
		/// </summary>
		/// <param name="value">The value to set</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property liveUpdate.</para>
		/// </summary>
		[JsMethod(Name = "toggleLiveUpdate")]
		public void ToggleLiveUpdate() { throw new NotImplementedException(); }

		#endregion Methods
    }
}