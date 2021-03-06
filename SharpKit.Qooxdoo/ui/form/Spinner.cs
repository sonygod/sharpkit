// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.form
{
    /// <summary>
	/// <para>A spinner is a control that allows you to adjust a numerical value,
	/// typically within an allowed range. An obvious example would be to specify the
	/// month of a year as a number in the range 1 &#8211; 12.</para>
	/// <para>To do so, a spinner encompasses a field to display the current value (a
	/// textfield) and controls such as up and down buttons to change that value. The
	/// current value can also be changed by editing the display field directly, or
	/// using mouse wheel and cursor keys.</para>
	/// <para>An optional <see cref="NumberFormat"/> property allows you to control the format of
	/// how a value can be entered and will be displayed.</para>
	/// <para>A brief, but non-trivial example:</para>
	/// <code>
	/// var s = new qx.ui.form.Spinner();
	/// s.set({
	/// maximum: 3000,
	/// minimum: -3000
	/// });
	/// var nf = new qx.util.format.NumberFormat();
	/// nf.setMaximumFractionDigits(2);
	/// s.setNumberFormat(nf);
	/// </code>
	/// <para>A spinner instance without any further properties specified in the
	/// constructor or a subsequent set command will appear with default
	/// values and behaviour.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.form.Spinner", OmitOptionalParameters = true, Export = false)]
    public partial class Spinner : qx.ui.core.Widget, qx.ui.form.INumberForm, qx.ui.form.IRange, qx.ui.form.IForm
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Maximum"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeMaximum;

		/// <summary>
		/// Fired on change of the property <see cref="Minimum"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeMinimum;

		/// <summary>
		/// <para>Fired when the value was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValue;

		/// <summary>
		/// <para>Fired when the invalidMessage was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeInvalidMessage;

		/// <summary>
		/// <para>Fired when the required was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeRequired;

		/// <summary>
		/// <para>Fired when the valid state was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValid;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Whether the item can shrink vertically.</para>
		/// </summary>
		[JsProperty(Name = "allowShrinkY", NativeField = true)]
		public bool AllowShrinkY { get; set; }

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>Controls whether the textfield of the spinner is editable or not</para>
		/// </summary>
		[JsProperty(Name = "editable", NativeField = true)]
		public bool Editable { get; set; }

		/// <summary>
		/// <para>Whether the widget is focusable e.g. rendering a focus border and visualize
		/// as active element.</para>
		/// <para>See also <see cref="IsTabable"/> which allows runtime checks for
		/// isChecked or other stuff to test whether the widget is
		/// reachable via the TAB key.</para>
		/// </summary>
		[JsProperty(Name = "focusable", NativeField = true)]
		public bool Focusable { get; set; }

		/// <summary>
		/// <para>maximal value of the Range object</para>
		/// </summary>
		[JsProperty(Name = "maximum", NativeField = true)]
		public double Maximum { get; set; }

		/// <summary>
		/// <para>minimal value of the Range object</para>
		/// </summary>
		[JsProperty(Name = "minimum", NativeField = true)]
		public double Minimum { get; set; }

		/// <summary>
		/// <para>Controls the display of the number in the textfield</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "numberFormat", NativeField = true)]
		public qx.util.format.NumberFormat NumberFormat { get; set; }

		/// <summary>
		/// <para>The amount to increment on each pageup/pagedown keypress</para>
		/// </summary>
		[JsProperty(Name = "pageStep", NativeField = true)]
		public double PageStep { get; set; }

		/// <summary>
		/// <para>The amount to increment on each event (keypress or mousedown)</para>
		/// </summary>
		[JsProperty(Name = "singleStep", NativeField = true)]
		public double SingleStep { get; set; }

		/// <summary>
		/// <para>The value of the spinner.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "value", NativeField = true)]
		public object Value { get; set; }

		/// <summary>
		/// <para>whether the value should wrap around</para>
		/// </summary>
		[JsProperty(Name = "wrap", NativeField = true)]
		public bool Wrap { get; set; }

		/// <summary>
		/// <para>The &#8216;contentPadding&#8217; property is a shorthand property for setting &#8216;contentPaddingTop&#8217;,
		/// &#8216;contentPaddingRight&#8217;, &#8216;contentPaddingBottom&#8217; and &#8216;contentPaddingLeft&#8217;
		/// at the same time.</para>
		/// <para>If four values are specified they apply to top, right, bottom and left respectively.
		/// If there is only one value, it applies to all sides, if there are two or three,
		/// the missing values are taken from the opposite side.</para>
		/// </summary>
		[JsProperty(Name = "contentPadding", NativeField = true)]
		public object ContentPadding { get; set; }

		/// <summary>
		/// <para>Bottom padding of the content pane</para>
		/// </summary>
		[JsProperty(Name = "contentPaddingBottom", NativeField = true)]
		public double ContentPaddingBottom { get; set; }

		/// <summary>
		/// <para>Left padding of the content pane</para>
		/// </summary>
		[JsProperty(Name = "contentPaddingLeft", NativeField = true)]
		public double ContentPaddingLeft { get; set; }

		/// <summary>
		/// <para>Right padding of the content pane</para>
		/// </summary>
		[JsProperty(Name = "contentPaddingRight", NativeField = true)]
		public double ContentPaddingRight { get; set; }

		/// <summary>
		/// <para>Top padding of the content pane</para>
		/// </summary>
		[JsProperty(Name = "contentPaddingTop", NativeField = true)]
		public double ContentPaddingTop { get; set; }

		/// <summary>
		/// <para>Message which is shown in an invalid tooltip.</para>
		/// </summary>
		[JsProperty(Name = "invalidMessage", NativeField = true)]
		public string InvalidMessage { get; set; }

		/// <summary>
		/// <para>Flag signaling if a widget is required.</para>
		/// </summary>
		[JsProperty(Name = "required", NativeField = true)]
		public bool Required { get; set; }

		/// <summary>
		/// <para>Message which is shown in an invalid tooltip if the <see cref="Required"/> is
		/// set to true.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "requiredInvalidMessage", NativeField = true)]
		public string RequiredInvalidMessage { get; set; }

		/// <summary>
		/// <para>Flag signaling if a widget is valid. If a widget is invalid, an invalid
		/// state will be set.</para>
		/// </summary>
		[JsProperty(Name = "valid", NativeField = true)]
		public bool Valid { get; set; }

		#endregion Properties

		#region Methods

		public Spinner() { throw new NotImplementedException(); }

		/// <param name="min">Minimum value</param>
		/// <param name="value">Current value</param>
		/// <param name="max">Maximum value</param>
		public Spinner(double min, double value, double max) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property editable.</para>
		/// </summary>
		[JsMethod(Name = "getEditable")]
		public bool GetEditable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the current set maximum of the range.</para>
		/// </summary>
		/// <returns>The current set maximum.</returns>
		[JsMethod(Name = "getMaximum")]
		public double GetMaximum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the current set minimum of the range.</para>
		/// </summary>
		/// <returns>The current set minimum.</returns>
		[JsMethod(Name = "getMinimum")]
		public double GetMinimum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property numberFormat.</para>
		/// </summary>
		[JsMethod(Name = "getNumberFormat")]
		public qx.util.format.NumberFormat GetNumberFormat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the value which will be stepped in a page step in the range.</para>
		/// </summary>
		/// <returns>The current value for page steps.</returns>
		[JsMethod(Name = "getPageStep")]
		public double GetPageStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the value which will be stepped in a single step in the range.</para>
		/// </summary>
		/// <returns>The current value for single steps.</returns>
		[JsMethod(Name = "getSingleStep")]
		public double GetSingleStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The element&#8217;s user set value.</para>
		/// </summary>
		/// <returns>The value.</returns>
		[JsMethod(Name = "getValue")]
		public double GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property wrap.</para>
		/// </summary>
		[JsMethod(Name = "getWrap")]
		public bool GetWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Normalizes the incoming value to be in the valid range and
		/// applies it to the <see cref="Value"/> afterwards.</para>
		/// </summary>
		/// <param name="value">Any number</param>
		/// <returns>The normalized number</returns>
		[JsMethod(Name = "gotoValue")]
		public double GotoValue(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property editable
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property editable.</param>
		[JsMethod(Name = "initEditable")]
		public void InitEditable(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property maximum
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property maximum.</param>
		[JsMethod(Name = "initMaximum")]
		public void InitMaximum(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property minimum
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property minimum.</param>
		[JsMethod(Name = "initMinimum")]
		public void InitMinimum(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property numberFormat
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property numberFormat.</param>
		[JsMethod(Name = "initNumberFormat")]
		public void InitNumberFormat(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property pageStep
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property pageStep.</param>
		[JsMethod(Name = "initPageStep")]
		public void InitPageStep(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property singleStep
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property singleStep.</param>
		[JsMethod(Name = "initSingleStep")]
		public void InitSingleStep(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property value
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property value.</param>
		[JsMethod(Name = "initValue")]
		public void InitValue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property wrap
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property wrap.</param>
		[JsMethod(Name = "initWrap")]
		public void InitWrap(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property editable equals true.</para>
		/// </summary>
		[JsMethod(Name = "isEditable")]
		public void IsEditable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property wrap equals true.</para>
		/// </summary>
		[JsMethod(Name = "isWrap")]
		public void IsWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property editable.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetEditable")]
		public void ResetEditable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property maximum.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMaximum")]
		public void ResetMaximum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property minimum.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMinimum")]
		public void ResetMinimum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property numberFormat.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetNumberFormat")]
		public void ResetNumberFormat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property pageStep.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetPageStep")]
		public void ResetPageStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property singleStep.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSingleStep")]
		public void ResetSingleStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the element&#8217;s value to its initial value.</para>
		/// </summary>
		[JsMethod(Name = "resetValue")]
		public void ResetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property wrap.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetWrap")]
		public void ResetWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property editable.</para>
		/// </summary>
		/// <param name="value">New value for property editable.</param>
		[JsMethod(Name = "setEditable")]
		public void SetEditable(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the maximum value of the range.</para>
		/// </summary>
		/// <param name="max">The maximum.</param>
		[JsMethod(Name = "setMaximum")]
		public void SetMaximum(double max) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the minimum value of the range.</para>
		/// </summary>
		/// <param name="min">The minimum.</param>
		[JsMethod(Name = "setMinimum")]
		public void SetMinimum(double min) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property numberFormat.</para>
		/// </summary>
		/// <param name="value">New value for property numberFormat.</param>
		[JsMethod(Name = "setNumberFormat")]
		public void SetNumberFormat(qx.util.format.NumberFormat value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the value for page steps in the range.</para>
		/// </summary>
		/// <param name="step">The value of the step.</param>
		[JsMethod(Name = "setPageStep")]
		public void SetPageStep(double step) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the value for single steps in the range.</para>
		/// </summary>
		/// <param name="step">The value of the step.</param>
		[JsMethod(Name = "setSingleStep")]
		public void SetSingleStep(double step) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the element&#8217;s value.</para>
		/// </summary>
		/// <param name="value">The new value of the element.</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property wrap.</para>
		/// </summary>
		/// <param name="value">New value for property wrap.</param>
		[JsMethod(Name = "setWrap")]
		public void SetWrap(bool value) { throw new NotImplementedException(); }

		[JsMethod(Name = "tabFocus")]
		public void TabFocus() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property editable.</para>
		/// </summary>
		[JsMethod(Name = "toggleEditable")]
		public void ToggleEditable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property wrap.</para>
		/// </summary>
		[JsMethod(Name = "toggleWrap")]
		public void ToggleWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property contentPaddingBottom.</para>
		/// </summary>
		[JsMethod(Name = "getContentPaddingBottom")]
		public double GetContentPaddingBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property contentPaddingLeft.</para>
		/// </summary>
		[JsMethod(Name = "getContentPaddingLeft")]
		public double GetContentPaddingLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property contentPaddingRight.</para>
		/// </summary>
		[JsMethod(Name = "getContentPaddingRight")]
		public double GetContentPaddingRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property contentPaddingTop.</para>
		/// </summary>
		[JsMethod(Name = "getContentPaddingTop")]
		public double GetContentPaddingTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property contentPaddingBottom
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property contentPaddingBottom.</param>
		[JsMethod(Name = "initContentPaddingBottom")]
		public void InitContentPaddingBottom(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property contentPaddingLeft
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property contentPaddingLeft.</param>
		[JsMethod(Name = "initContentPaddingLeft")]
		public void InitContentPaddingLeft(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property contentPaddingRight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property contentPaddingRight.</param>
		[JsMethod(Name = "initContentPaddingRight")]
		public void InitContentPaddingRight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property contentPaddingTop
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property contentPaddingTop.</param>
		[JsMethod(Name = "initContentPaddingTop")]
		public void InitContentPaddingTop(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property contentPadding.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContentPadding")]
		public void ResetContentPadding() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property contentPaddingBottom.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContentPaddingBottom")]
		public void ResetContentPaddingBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property contentPaddingLeft.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContentPaddingLeft")]
		public void ResetContentPaddingLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property contentPaddingRight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContentPaddingRight")]
		public void ResetContentPaddingRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property contentPaddingTop.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContentPaddingTop")]
		public void ResetContentPaddingTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the values of the property group contentPadding.</para>
		/// <para>This setter supports a shorthand mode compatible with the way margins and paddins are set in CSS.</para>
		/// </summary>
		/// <param name="contentPaddingTop">Sets the value of the property #contentPaddingTop.</param>
		/// <param name="contentPaddingRight">Sets the value of the property #contentPaddingRight.</param>
		/// <param name="contentPaddingBottom">Sets the value of the property #contentPaddingBottom.</param>
		/// <param name="contentPaddingLeft">Sets the value of the property #contentPaddingLeft.</param>
		[JsMethod(Name = "setContentPadding")]
		public void SetContentPadding(object contentPaddingTop, object contentPaddingRight, object contentPaddingBottom, object contentPaddingLeft) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property contentPaddingBottom.</para>
		/// </summary>
		/// <param name="value">New value for property contentPaddingBottom.</param>
		[JsMethod(Name = "setContentPaddingBottom")]
		public void SetContentPaddingBottom(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property contentPaddingLeft.</para>
		/// </summary>
		/// <param name="value">New value for property contentPaddingLeft.</param>
		[JsMethod(Name = "setContentPaddingLeft")]
		public void SetContentPaddingLeft(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property contentPaddingRight.</para>
		/// </summary>
		/// <param name="value">New value for property contentPaddingRight.</param>
		[JsMethod(Name = "setContentPaddingRight")]
		public void SetContentPaddingRight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property contentPaddingTop.</para>
		/// </summary>
		/// <param name="value">New value for property contentPaddingTop.</param>
		[JsMethod(Name = "setContentPaddingTop")]
		public void SetContentPaddingTop(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the invalid message of the widget.</para>
		/// </summary>
		/// <returns>The current set message.</returns>
		[JsMethod(Name = "getInvalidMessage")]
		public string GetInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the current required state of the widget.</para>
		/// </summary>
		/// <returns>True, if the widget is required.</returns>
		[JsMethod(Name = "getRequired")]
		public bool GetRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the invalid message if required of the widget.</para>
		/// </summary>
		/// <returns>The current set message.</returns>
		[JsMethod(Name = "getRequiredInvalidMessage")]
		public string GetRequiredInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the valid state of the widget.</para>
		/// </summary>
		/// <returns>If the state of the widget is valid.</returns>
		[JsMethod(Name = "getValid")]
		public bool GetValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property invalidMessage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property invalidMessage.</param>
		[JsMethod(Name = "initInvalidMessage")]
		public void InitInvalidMessage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property required
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property required.</param>
		[JsMethod(Name = "initRequired")]
		public void InitRequired(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property requiredInvalidMessage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property requiredInvalidMessage.</param>
		[JsMethod(Name = "initRequiredInvalidMessage")]
		public void InitRequiredInvalidMessage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property valid
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property valid.</param>
		[JsMethod(Name = "initValid")]
		public void InitValid(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property required equals true.</para>
		/// </summary>
		[JsMethod(Name = "isRequired")]
		public void IsRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property valid equals true.</para>
		/// </summary>
		[JsMethod(Name = "isValid")]
		public void IsValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property invalidMessage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInvalidMessage")]
		public void ResetInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property required.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRequired")]
		public void ResetRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property requiredInvalidMessage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRequiredInvalidMessage")]
		public void ResetRequiredInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property valid.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetValid")]
		public void ResetValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the invalid message of the widget.</para>
		/// </summary>
		/// <param name="message">The invalid message.</param>
		[JsMethod(Name = "setInvalidMessage")]
		public void SetInvalidMessage(string message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the required state of a widget.</para>
		/// </summary>
		/// <param name="required">A flag signaling if the widget is required.</param>
		[JsMethod(Name = "setRequired")]
		public void SetRequired(bool required) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the invalid message if required of the widget.</para>
		/// </summary>
		/// <param name="message">The invalid message.</param>
		[JsMethod(Name = "setRequiredInvalidMessage")]
		public void SetRequiredInvalidMessage(string message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the valid state of the widget.</para>
		/// </summary>
		/// <param name="valid">The valid state of the widget.</param>
		[JsMethod(Name = "setValid")]
		public void SetValid(bool valid) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property required.</para>
		/// </summary>
		[JsMethod(Name = "toggleRequired")]
		public void ToggleRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property valid.</para>
		/// </summary>
		[JsMethod(Name = "toggleValid")]
		public void ToggleValid() { throw new NotImplementedException(); }

		#endregion Methods
    }
}