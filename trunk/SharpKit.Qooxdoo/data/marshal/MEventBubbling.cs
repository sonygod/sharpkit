// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.data.marshal
{
    /// <summary>
	/// <para>Mixin used for the bubbling events. If you want to use this in your own model
	/// classes, be sure that every property will call the
	/// <see cref="#_applyEventPropagation"/> function on every change.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.data.marshal.MEventBubbling", OmitOptionalParameters = true, Export = false)]
    public partial class MEventBubbling 
    {
		#region Events

		/// <summary>
		/// <para>The change event which will be fired on every change in the model no
		/// matter what property changes. This event bubbles so the root model will
		/// fire a change event on every change of its children properties too.</para>
		/// <para>Note that properties are required to call
		/// <see cref="#_applyEventPropagation"/> on apply for changes to be tracked as
		/// desired. It is already taken care of that properties created with the
		/// <see cref="qx.data.marshal.Json"/> marshaler call this method.</para>
		/// <para>The data will contain a map with the following three keys
		/// <item>value: The new value of the property</item>
		/// <item>old: The old value of the property.</item>
		/// <item>name: The name of the property changed including its parent
		/// properties separated by dots.</item>
		/// <item>item: The item which has the changed property.</item>
		/// Due to that, the getOldData method will always return null
		/// because the old data is contained in the map.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> ChangeBubbleEvent;

		#endregion Events

		#region Methods

		public MEventBubbling() { throw new NotImplementedException(); }

		#endregion Methods
    }
}