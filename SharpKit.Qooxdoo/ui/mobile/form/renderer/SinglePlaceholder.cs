// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.form.renderer
{
    /// <summary>
	/// <para>SinglePlaceholder is a class used to render forms into a mobile page.
	/// It presents a label into the placeholder of the form elements</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.form.renderer.SinglePlaceholder", OmitOptionalParameters = true, Export = false)]
    public partial class SinglePlaceholder : qx.ui.mobile.form.renderer.Single
    {
		#region Methods

		public SinglePlaceholder() { throw new NotImplementedException(); }

		/// <param name="form">The target form of this renderer</param>
		public SinglePlaceholder(qx.ui.mobile.form.Form form) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a group of form items with the corresponding names. The names should
		/// be displayed as hint for the user what to do with the form item.
		/// The title is optional and can be used as grouping for the given form
		/// items.</para>
		/// </summary>
		/// <param name="items">An array of form items to render.</param>
		/// <param name="names">An array of names for the form items.</param>
		/// <param name="title">A title of the group you are adding.</param>
		/// <param name="itemsOptions">The added additional data.</param>
		/// <param name="headerOptions">The options map as defined by the form for the current group header.</param>
		[JsMethod(Name = "addItems")]
		public void AddItems(qx.ui.core.Widget items, string names, string title, JsArray itemsOptions = null, object headerOptions = null) { throw new NotImplementedException(); }

		#endregion Methods
    }
}