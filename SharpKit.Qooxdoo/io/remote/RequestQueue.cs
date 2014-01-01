// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.io.remote
{
    /// <summary>
	/// <para>Handles scheduling of requests to be sent to a server.</para>
	/// <para>This class is a singleton and is used by qx.io.remote.Request to schedule its
	/// requests. It should not be used directly.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.io.remote.RequestQueue", OmitOptionalParameters = true, Export = false)]
    public partial class RequestQueue : qx.core.Object
    {
		#region Properties

		/// <summary>
		/// <para>Default timeout for remote requests in milliseconds.</para>
		/// </summary>
		[JsProperty(Name = "defaultTimeout", NativeField = true)]
		public double DefaultTimeout { get; set; }

		/// <summary>
		/// <para>Indicates whether queue is enabled or not.</para>
		/// </summary>
		[JsProperty(Name = "enabled", NativeField = true)]
		public bool Enabled { get; set; }

		/// <summary>
		/// <para>Maximum number of parallel requests.</para>
		/// </summary>
		[JsProperty(Name = "maxConcurrentRequests", NativeField = true)]
		public double MaxConcurrentRequests { get; set; }

		/// <summary>
		/// <para>The maximum number of total requests.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "maxTotalRequests", NativeField = true)]
		public double MaxTotalRequests { get; set; }

		#endregion Properties

		#region Methods

		public RequestQueue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the request from the pending requests queue.</para>
		/// <para>The underlying transport of the request is forced into the aborted
		/// state (&#8220;aborted&#8221;) and listeners of the &#8220;aborted&#8221;
		/// signal are notified about the event. If the request isn&#8217;t in the
		/// pending requests queue, this method is a noop.</para>
		/// </summary>
		/// <param name="vRequest">The request</param>
		[JsMethod(Name = "abort")]
		public void Abort(object vRequest) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add the request to the pending requests queue.</para>
		/// </summary>
		/// <param name="vRequest">The request</param>
		[JsMethod(Name = "add")]
		public void Add(object vRequest) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a list of active queued requests, each one wrapped in an instance of
		/// <see cref="qx.io.remote.Exchange"/></para>
		/// </summary>
		/// <returns>The list of active queued requests, each one wrapped in an instance of qx.io.remote.Exchange</returns>
		[JsMethod(Name = "getActiveQueue")]
		public Exchange GetActiveQueue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property defaultTimeout.</para>
		/// </summary>
		[JsMethod(Name = "getDefaultTimeout")]
		public double GetDefaultTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property enabled.</para>
		/// </summary>
		[JsMethod(Name = "getEnabled")]
		public bool GetEnabled() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property maxConcurrentRequests.</para>
		/// </summary>
		[JsMethod(Name = "getMaxConcurrentRequests")]
		public double GetMaxConcurrentRequests() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property maxTotalRequests.</para>
		/// </summary>
		[JsMethod(Name = "getMaxTotalRequests")]
		public double GetMaxTotalRequests() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a list of queued requests</para>
		/// </summary>
		/// <returns>The list of queued requests</returns>
		[JsMethod(Name = "getRequestQueue")]
		public Request GetRequestQueue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property defaultTimeout
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property defaultTimeout.</param>
		[JsMethod(Name = "initDefaultTimeout")]
		public void InitDefaultTimeout(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property enabled
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property enabled.</param>
		[JsMethod(Name = "initEnabled")]
		public void InitEnabled(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property maxConcurrentRequests
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property maxConcurrentRequests.</param>
		[JsMethod(Name = "initMaxConcurrentRequests")]
		public void InitMaxConcurrentRequests(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property maxTotalRequests
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property maxTotalRequests.</param>
		[JsMethod(Name = "initMaxTotalRequests")]
		public void InitMaxTotalRequests(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property enabled equals true.</para>
		/// </summary>
		[JsMethod(Name = "isEnabled")]
		public void IsEnabled() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property defaultTimeout.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDefaultTimeout")]
		public void ResetDefaultTimeout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property enabled.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetEnabled")]
		public void ResetEnabled() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property maxConcurrentRequests.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMaxConcurrentRequests")]
		public void ResetMaxConcurrentRequests() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property maxTotalRequests.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMaxTotalRequests")]
		public void ResetMaxTotalRequests() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property defaultTimeout.</para>
		/// </summary>
		/// <param name="value">New value for property defaultTimeout.</param>
		[JsMethod(Name = "setDefaultTimeout")]
		public void SetDefaultTimeout(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property enabled.</para>
		/// </summary>
		/// <param name="value">New value for property enabled.</param>
		[JsMethod(Name = "setEnabled")]
		public void SetEnabled(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property maxConcurrentRequests.</para>
		/// </summary>
		/// <param name="value">New value for property maxConcurrentRequests.</param>
		[JsMethod(Name = "setMaxConcurrentRequests")]
		public void SetMaxConcurrentRequests(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property maxTotalRequests.</para>
		/// </summary>
		/// <param name="value">New value for property maxTotalRequests.</param>
		[JsMethod(Name = "setMaxTotalRequests")]
		public void SetMaxTotalRequests(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property enabled.</para>
		/// </summary>
		[JsMethod(Name = "toggleEnabled")]
		public void ToggleEnabled() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.io.remote.RequestQueue GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}