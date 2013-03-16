// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.util
{
    /// <summary>
	/// <para>Contains information about images (size, format, clipping, ...) and
	/// other resources like CSS files, local data, ...</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.util.ResourceManager", OmitOptionalParameters = true, Export = false)]
    public partial class ResourceManager : qx.core.Object
    {
		#region Methods

		public ResourceManager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the format of the combined image (png, gif, ...), if the given
		/// resource identifier is an image contained in one, or the empty string
		/// otherwise.</para>
		/// </summary>
		/// <param name="id">Resource identifier</param>
		/// <returns>The type of the combined image containing id</returns>
		[JsMethod(Name = "getCombinedFormat")]
		public string GetCombinedFormat(string id) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get information about an resource.</para>
		/// </summary>
		/// <param name="id">The resource to get the information for</param>
		/// <returns>Registered data or null</returns>
		[JsMethod(Name = "getData")]
		public JsArray GetData(string id) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the format of the given resource ID,
		/// when it is not a known image null
		/// is returned.</para>
		/// </summary>
		/// <param name="id">Resource identifier</param>
		/// <returns>File format of the image</returns>
		[JsMethod(Name = "getImageFormat")]
		public string GetImageFormat(string id) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the height of the given resource ID,
		/// when it is not a known image 0 is
		/// returned.</para>
		/// </summary>
		/// <param name="id">Resource identifier</param>
		/// <returns>The image height, maybe null when the height is unknown</returns>
		[JsMethod(Name = "getImageHeight")]
		public double GetImageHeight(string id) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the width of the given resource ID,
		/// when it is not a known image 0 is
		/// returned.</para>
		/// </summary>
		/// <param name="id">Resource identifier</param>
		/// <returns>The image width, maybe null when the width is unknown</returns>
		[JsMethod(Name = "getImageWidth")]
		public double GetImageWidth(string id) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the registry has information about the given resource.</para>
		/// </summary>
		/// <param name="id">The resource to get the information for</param>
		/// <returns>true when the resource is known.</returns>
		[JsMethod(Name = "has")]
		public bool Has(string id) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Construct a data: URI for an image resource.</para>
		/// <para>Constructs a data: URI for a given resource id, if this resource is
		/// contained in a base64 combined image. If this is not the case (e.g.
		/// because the combined image has not been loaded yet), returns the direct
		/// URI to the image file itself.</para>
		/// </summary>
		/// <param name="resid">resource id of the image</param>
		/// <returns>&#8220;data:&#8221; or &#8220;http:&#8221; URI</returns>
		[JsMethod(Name = "toDataUri")]
		public string ToDataUri(string resid) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts the given resource ID to a full qualified URI</para>
		/// </summary>
		/// <param name="id">Resource ID</param>
		/// <returns>Resulting URI</returns>
		[JsMethod(Name = "toUri")]
		public string ToUri(string id) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.util.ResourceManager GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}