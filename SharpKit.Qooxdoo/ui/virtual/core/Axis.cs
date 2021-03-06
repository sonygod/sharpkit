// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.core
{
    /// <summary>
	/// <para>EXPERIMENTAL!</para>
	/// <para>The axis maps virtual screen coordinates to item indexes. By default all
	/// items have the same size but it is also possible to give specific items
	/// a different size.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.core.Axis", OmitOptionalParameters = true, Export = false)]
    public partial class Axis : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Every change to the axis configuration triggers this event.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnChange;

		#endregion Events

		#region Methods

		public Axis() { throw new NotImplementedException(); }

		/// <param name="defaultItemSize">The default size of the items.</param>
		/// <param name="itemCount">The number of item on the axis.</param>
		public Axis(double defaultItemSize, double itemCount) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the default size of the items.</para>
		/// </summary>
		/// <returns>The default item size.</returns>
		[JsMethod(Name = "getDefaultItemSize")]
		public double GetDefaultItemSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the item and the offset into the item at the given position.</para>
		/// </summary>
		/// <param name="position">The position to get the item for.</param>
		/// <returns>A map with the keys index and offset. The index is the index of the item containing the position and offsets specifies offset into this item. If the position is outside of the range, null is returned.</returns>
		[JsMethod(Name = "getItemAtPosition")]
		public object GetItemAtPosition(double position) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the number of items in the axis.</para>
		/// </summary>
		/// <returns>The number of items.</returns>
		[JsMethod(Name = "getItemCount")]
		public double GetItemCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the start position of the item with the given index.</para>
		/// </summary>
		/// <param name="index">The item&#8217;s index.</param>
		/// <returns>The start position of the item. If the index is outside of the axis range null is returned.</returns>
		[JsMethod(Name = "getItemPosition")]
		public double GetItemPosition(double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the size of the item at the given index.</para>
		/// </summary>
		/// <param name="index">Index of the item to get the size for.</param>
		/// <returns>Size of the item.</returns>
		[JsMethod(Name = "getItemSize")]
		public double GetItemSize(double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get an array of item sizes starting with the item at &#8220;startIndex&#8221;. The
		/// sum of all sizes in the returned array is at least &#8220;minSizeSum&#8221;.</para>
		/// </summary>
		/// <param name="startIndex">The index of the first item.</param>
		/// <param name="minSizeSum">The minimum sum of the item sizes.</param>
		/// <returns>List of item sizes starting with the size of the item at index startIndex. The sum of the item sizes is at least minSizeSum.</returns>
		[JsMethod(Name = "getItemSizes")]
		public double GetItemSizes(double startIndex, double minSizeSum) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the sum of all cell sizes.</para>
		/// </summary>
		/// <returns>The sum of all item sizes.</returns>
		[JsMethod(Name = "getTotalSize")]
		public double GetTotalSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Reset all custom sizes set with <see cref="SetItemSize"/>.</para>
		/// </summary>
		[JsMethod(Name = "resetItemSizes")]
		public void ResetItemSizes() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the default size the items.</para>
		/// </summary>
		/// <param name="defaultItemSize">The default size of the items.</param>
		[JsMethod(Name = "setDefaultItemSize")]
		public void SetDefaultItemSize(double defaultItemSize) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the number of items in the axis.</para>
		/// </summary>
		/// <param name="itemCount">The new item count.</param>
		[JsMethod(Name = "setItemCount")]
		public void SetItemCount(double itemCount) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the size of a specific item. This allow item, which have a size
		/// different from the default size.</para>
		/// </summary>
		/// <param name="index">Index of the item to change.</param>
		/// <param name="size">New size of the item.</param>
		[JsMethod(Name = "setItemSize")]
		public void SetItemSize(double index, double size) { throw new NotImplementedException(); }

		#endregion Methods
    }
}