// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.toolbar
{
    /// <summary>
	/// <para>A button which is toggle-able for toolbars.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.toolbar.CheckBox", OmitOptionalParameters = true, Export = false)]
    public partial class CheckBox : qx.ui.form.ToggleButton
    {
		#region Properties

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		[JsProperty(Name = "focusable", NativeField = true)]
		public object Focusable { get; set; }

		[JsProperty(Name = "show", NativeField = true)]
		public object Show { get; set; }

		#endregion Properties

		#region Methods

		public CheckBox() { throw new NotImplementedException(); }

		public CheckBox(object label, object icon) { throw new NotImplementedException(); }

		#endregion Methods
    }
}