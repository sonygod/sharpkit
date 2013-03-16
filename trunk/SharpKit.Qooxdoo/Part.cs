// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx
{
    /// <summary>
	/// <para>The part loader knows about all generated packages and parts.</para>
	/// <para>It contains functionality to load parts.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.Part", OmitOptionalParameters = true, Export = false)]
    public partial class Part 
    {
		#region Methods

		public Part() { throw new NotImplementedException(); }

		/// <param name="loader">The data structure from the boot script about all known parts and packages. Usually qx.$loader.</param>
		public Part(object loader) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Loaded closure packages have to call this method to indicate
		/// successful loading and to get their closure stored.</para>
		/// </summary>
		/// <param name="id">The id of the package.</param>
		/// <param name="closure">The wrapped code of the package.</param>
		[JsMethod(Name = "$$notifyLoad")]
		public static void NotifyLoad(string id, Action<object> closure) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the default part loader instance</para>
		/// </summary>
		/// <returns>the default part loader</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.Part GetInstance() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Preloads one or more closure parts but does not execute them. This means
		/// the closure (the whole code of the part) is already loaded but not
		/// executed so you can&#8217;t use the classes in the the part after a preload.
		/// If you want to execute them, just use the regular <see cref="Require"/>
		/// function.</para>
		/// </summary>
		/// <param name="partNames">List of parts names to preload as defined in the config file at compile time.</param>
		[JsMethod(Name = "preload")]
		public static void PreloadS(string partNames) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Loads one or more parts asynchronously. The callback is called after all
		/// parts and their dependencies are fully loaded. If the parts are already
		/// loaded the callback is called immediately.</para>
		/// </summary>
		/// <param name="partNames">List of parts names to load as defined in the config file at compile time.</param>
		/// <param name="callback">Function to execute on completion</param>
		/// <param name="self">Context to execute the given function in</param>
		[JsMethod(Name = "require")]
		public static void RequireS(string partNames, Action<object> callback, object self = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Preloader for the given part.</para>
		/// </summary>
		/// <param name="partNames">The hash of the part to preload.</param>
		/// <param name="callback">Function to execute on completion. The function has one parameter which is an array of ready states of the parts specified in the partNames argument.</param>
		/// <param name="self">Context to execute the given function in</param>
		[JsMethod(Name = "preload")]
		public void Preload(string partNames, Action<object> callback, object self = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Loads one or more parts asynchronously. The callback is called after all
		/// parts and their dependencies are fully loaded. If the parts are already
		/// loaded the callback is called immediately.</para>
		/// </summary>
		/// <param name="partNames">List of parts names to load as defined in the config file at compile time. The method also accepts a single string as parameter to only load one part.</param>
		/// <param name="callback">Function to execute on completion. The function has one parameter which is an array of ready states of the parts specified in the partNames argument.</param>
		/// <param name="self">Context to execute the given function in</param>
		[JsMethod(Name = "require")]
		public void Require(object partNames, Action<object> callback, object self = null) { throw new NotImplementedException(); }

		#endregion Methods
    }
}