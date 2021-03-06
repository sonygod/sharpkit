// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.data.store
{
    /// <summary>
	/// <para>EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION</para>
	/// <para>Handles response associated to a resource&#8217;s action. The model property is
	/// populated with the marshaled response. Note the action is invoked on the
	/// resource, not the store.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.data.store.Rest", OmitOptionalParameters = true, Export = false)]
    public partial class Rest : qx.core.Object
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Model"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeModel;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The name of the resource&#8217;s action to retrieve the response from.</para>
		/// </summary>
		[JsProperty(Name = "actionName", NativeField = true)]
		public string ActionName { get; set; }

		/// <summary>
		/// <para>Populated with the marshaled response.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "model", NativeField = true)]
		public object Model { get; set; }

		/// <summary>
		/// <para>The resource.</para>
		/// </summary>
		[JsProperty(Name = "resource", NativeField = true)]
		public qx.io.rest.Resource Resource { get; set; }

		#endregion Properties

		#region Methods

		public Rest() { throw new NotImplementedException(); }

		/// <param name="resource">The resource.</param>
		/// <param name="actionName">The name of the resource&#8217;s action to retrieve the response from.</param>
		/// <param name="delegatex">The delegate containing one of the methods specified in qx.data.store.IStoreDelegate.</param>
		public Rest(qx.io.rest.Resource resource, string actionName, object delegatex = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property actionName.</para>
		/// </summary>
		[JsMethod(Name = "getActionName")]
		public string GetActionName() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property model.</para>
		/// </summary>
		[JsMethod(Name = "getModel")]
		public object GetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property resource.</para>
		/// </summary>
		[JsMethod(Name = "getResource")]
		public qx.io.rest.Resource GetResource() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property actionName
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property actionName.</param>
		[JsMethod(Name = "initActionName")]
		public void InitActionName(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property model
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property model.</param>
		[JsMethod(Name = "initModel")]
		public void InitModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property resource
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property resource.</param>
		[JsMethod(Name = "initResource")]
		public void InitResource(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property actionName.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetActionName")]
		public void ResetActionName() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property model.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetModel")]
		public void ResetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property resource.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetResource")]
		public void ResetResource() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property actionName.</para>
		/// </summary>
		/// <param name="value">New value for property actionName.</param>
		[JsMethod(Name = "setActionName")]
		public void SetActionName(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property model.</para>
		/// </summary>
		/// <param name="value">New value for property model.</param>
		[JsMethod(Name = "setModel")]
		public void SetModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property resource.</para>
		/// </summary>
		/// <param name="value">New value for property resource.</param>
		[JsMethod(Name = "setResource")]
		public void SetResource(qx.io.rest.Resource value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}