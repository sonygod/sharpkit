// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.container
{
    /// <summary>
	/// <para>The master/detail container divides an area into two panes, master and detail. The master
	/// can be detached when the orientation of the device changes to portrait.
	/// This container provides an optimized view for tablet and mobile devices.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the master/detail container.</para>
	/// <code>
	/// var container = new qx.ui.mobile.container.MasterDetail();
	/// container.getMaster().add(new qx.ui.mobile.container.Navigation());
	/// container.getDetail().add(new qx.ui.mobile.container.Navigation());
	/// </code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.container.MasterDetail", OmitOptionalParameters = true, Export = false)]
    public partial class MasterDetail : qx.ui.mobile.container.Composite
    {
		#region Events

		/// <summary>
		/// <para>Fired when the layout of the master detail is changed. This happens
		/// when the orientation of the device is changed.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> LayoutChangeEvent;

		#endregion Events

		#region Properties

		[JsProperty(Name = "defaultCssClass", NativeField = true)]
		public object DefaultCssClass { get; set; }

		#endregion Properties

		#region Methods

		public MasterDetail() { throw new NotImplementedException(); }

		/// <param name="layout">The layout that should be used for this container</param>
		public MasterDetail(qx.ui.mobile.layout.Abstract layout = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the detail container.</para>
		/// </summary>
		/// <returns>The detail container</returns>
		[JsMethod(Name = "getDetail")]
		public qx.ui.mobile.container.Composite GetDetail() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the master container.</para>
		/// </summary>
		/// <returns>The master container</returns>
		[JsMethod(Name = "getMaster")]
		public qx.ui.mobile.container.Composite GetMaster() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the set container for the portrait mode. The master container will be added and removed
		/// automatically to this container when the orientation is changed.</para>
		/// </summary>
		/// <returns>The set master container for the portrait mode.</returns>
		[JsMethod(Name = "getPortraitMasterContainer")]
		public qx.ui.mobile.core.Widget GetPortraitMasterContainer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the container for the portrait mode. The master container will be added and removed
		/// automatically to this container when the orientation is changed.</para>
		/// </summary>
		/// <param name="container">The set master container for the portrait mode.</param>
		[JsMethod(Name = "setPortraitMasterContainer")]
		public void SetPortraitMasterContainer(qx.ui.mobile.core.Widget container) { throw new NotImplementedException(); }

		#endregion Methods
    }
}