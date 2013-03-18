// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.form
{
    /// <summary>
	/// <para>Basic class for a selectbox like lists. Basically supports a popup
	/// with a list and the whole children management.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.form.AbstractSelectBox", OmitOptionalParameters = true, Export = false)]
    public abstract partial class AbstractSelectBox : qx.ui.core.Widget, qx.ui.form.IForm
    {
		#region Events

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

		[JsProperty(Name = "focusable", NativeField = true)]
		public object Focusable { get; set; }

		/// <summary>
		/// <para>Formatter which format the value from the selected ListItem.
		/// Uses the default formatter <see cref="#_defaultFormat"/>.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "format", NativeField = true)]
		public Action<object> Format { get; set; }

		/// <summary>
		/// <para>The maximum height of the list popup. Setting this value to
		/// null will set cause the list to be auto-sized.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "maxListHeight", NativeField = true)]
		public double MaxListHeight { get; set; }

		[JsProperty(Name = "width", NativeField = true)]
		public object Width { get; set; }

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

		public AbstractSelectBox() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Hides the list popup.</para>
		/// </summary>
		[JsMethod(Name = "close")]
		public void Close() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the list widget.</para>
		/// </summary>
		/// <returns>the list</returns>
		[JsMethod(Name = "getChildrenContainer")]
		public qx.ui.form.List GetChildrenContainer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property format.</para>
		/// </summary>
		[JsMethod(Name = "getFormat")]
		public Action<object> GetFormat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property maxListHeight.</para>
		/// </summary>
		[JsMethod(Name = "getMaxListHeight")]
		public double GetMaxListHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property format
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property format.</param>
		[JsMethod(Name = "initFormat")]
		public void InitFormat(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property maxListHeight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property maxListHeight.</param>
		[JsMethod(Name = "initMaxListHeight")]
		public void InitMaxListHeight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Shows the list popup.</para>
		/// </summary>
		[JsMethod(Name = "open")]
		public void Open() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property format.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetFormat")]
		public void ResetFormat() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property maxListHeight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMaxListHeight")]
		public void ResetMaxListHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property format.</para>
		/// </summary>
		/// <param name="value">New value for property format.</param>
		[JsMethod(Name = "setFormat")]
		public void SetFormat(Action<object> value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property maxListHeight.</para>
		/// </summary>
		/// <param name="value">New value for property maxListHeight.</param>
		[JsMethod(Name = "setMaxListHeight")]
		public void SetMaxListHeight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the popup&#8217;s visibility.</para>
		/// </summary>
		[JsMethod(Name = "toggle")]
		public void Toggle() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a new child widget.</para>
		/// <para>The supported keys of the layout options map depend on the layout manager
		/// used to position the widget. The options are documented in the class
		/// documentation of each layout manager <see cref="qx.ui.layout"/>.</para>
		/// </summary>
		/// <param name="child">the item to add.</param>
		/// <param name="options">Optional layout data for item.</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "add")]
		public Widget Add(LayoutItem child, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add an item after another already inserted item</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">item to add</param>
		/// <param name="after">item, after which the new item will be inserted</param>
		/// <param name="options">Optional layout data for item.</param>
		[JsMethod(Name = "addAfter")]
		public void AddAfter(LayoutItem child, LayoutItem after, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a child at the specified index</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">item to add</param>
		/// <param name="index">Index, at which the item will be inserted</param>
		/// <param name="options">Optional layout data for item.</param>
		[JsMethod(Name = "addAt")]
		public void AddAt(LayoutItem child, double index, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add an item before another already inserted item</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">item to add</param>
		/// <param name="before">item before the new item will be inserted.</param>
		/// <param name="options">Optional layout data for item.</param>
		[JsMethod(Name = "addBefore")]
		public void AddBefore(LayoutItem child, LayoutItem before, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the children list</para>
		/// </summary>
		/// <returns>The children array (Arrays are reference types, please to not modify them in-place)</returns>
		[JsMethod(Name = "getChildren")]
		public LayoutItem GetChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the widget contains children.</para>
		/// </summary>
		/// <returns>Returns true when the widget has children.</returns>
		[JsMethod(Name = "hasChildren")]
		public bool HasChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the index position of the given item if it is
		/// a child item. Otherwise it returns -1.</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">the item to query for</param>
		/// <returns>The index position or -1 when the given item is no child of this layout.</returns>
		[JsMethod(Name = "indexOf")]
		public double IndexOf(LayoutItem child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the given child item.</para>
		/// </summary>
		/// <param name="child">the item to remove</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "remove")]
		public Widget Remove(LayoutItem child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all children.</para>
		/// </summary>
		/// <returns>An array containing the removed children.</returns>
		[JsMethod(Name = "removeAll")]
		public JsArray RemoveAll() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the item at the specified index.</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="index">Index of the item to remove.</param>
		/// <returns>The removed item</returns>
		[JsMethod(Name = "removeAt")]
		public qx.ui.core.LayoutItem RemoveAt(double index) { throw new NotImplementedException(); }

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