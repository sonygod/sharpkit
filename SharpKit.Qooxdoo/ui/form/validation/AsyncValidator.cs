// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.form.validation
{
    /// <summary>
	/// <para>This class is responsible for validation in all asynchronous cases and
	/// should always be used with <see cref="qx.ui.form.validation.Manager"/>.</para>
	/// <para>It acts like a wrapper for asynchronous validation functions. These
	/// validation function must be set in the constructor. The form manager will
	/// invoke the validation and the validator function will be called with two
	/// arguments:
	/// <list type="bullet">
	/// <item>asyncValidator: A reference to the corresponding validator.</item>
	/// <item>value: The value of the assigned input field.</item>
	/// </list
	/// These two parameters are needed to set the validation status of the current
	/// validator. <see cref="SetValid"/> is responsible for doing that.</para>
	/// <para>Warning: Instances of this class can only be used with one input
	/// field at a time. Multi usage is not supported!</para>
	/// <para>Warning: Calling <see cref="SetValid"/> synchronously does not work. If you
	/// have an synchronous validator, please check
	/// <see cref="qx.ui.form.validation.Manager.Add"/>. If you have both cases, you have
	/// to wrap the synchronous call in a timeout to make it asychronous.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.form.validation.AsyncValidator", OmitOptionalParameters = true, Export = false)]
    public partial class AsyncValidator : qx.core.Object
    {
		#region Methods

		public AsyncValidator() { throw new NotImplementedException(); }

		/// <param name="validator">The validator function, which has to be asynchronous.</param>
		public AsyncValidator(Action<object> validator) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method should be called within the asynchronous callback to tell the
		/// validator the result of the validation.</para>
		/// </summary>
		/// <param name="valid">The boolean state of the validation.</param>
		/// <param name="message">The invalidMessage of the validation.</param>
		[JsMethod(Name = "setValid")]
		public void SetValid(bool valid, string message) { throw new NotImplementedException(); }

		#endregion Methods
    }
}