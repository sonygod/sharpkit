// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;
using qx.ui.window;

namespace qx.ui.root
{
    /// <summary>
	/// <para>Shared implementation for all root widgets.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.root.Abstract", OmitOptionalParameters = true, Export = false)]
    public abstract partial class Abstract : qx.ui.core.Widget
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="GlobalCursor"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeGlobalCursor;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>Whether the widget is enabled. Disabled widgets are usually grayed out
		/// and do not process user created events. While in the disabled state most
		/// user input events are blocked. Only the <see cref="Mouseover"/> and
		/// <see cref="Mouseout"/> events will be dispatched.</para>
		/// </summary>
		[JsProperty(Name = "enabled", NativeField = true)]
		public bool Enabled { get; set; }

		/// <summary>
		/// <para>Whether the widget is focusable e.g. rendering a focus border and visualize
		/// as active element.</para>
		/// <para>See also <see cref="IsTabable"/> which allows runtime checks for
		/// isChecked or other stuff to test whether the widget is
		/// reachable via the TAB key.</para>
		/// </summary>
		[JsProperty(Name = "focusable", NativeField = true)]
		public bool Focusable { get; set; }

		/// <summary>
		/// <para>Sets the global cursor style</para>
		/// <para>The name of the cursor to show when the mouse pointer is over the widget.
		/// This is any valid CSS2 cursor name defined by W3C.</para>
		/// <para>The following values are possible:
		/// <list type="bullet"><item>default</item>
		/// <item>crosshair</item>
		/// <item>pointer (hand is the ie name and will mapped to pointer in non-ie).</item>
		/// <item>move</item>
		/// <item>n-resize</item>
		/// <item>ne-resize</item>
		/// <item>e-resize</item>
		/// <item>se-resize</item>
		/// <item>s-resize</item>
		/// <item>sw-resize</item>
		/// <item>w-resize</item>
		/// <item>nw-resize</item>
		/// <item>text</item>
		/// <item>wait</item>
		/// <item>help </item>
		/// <item>url([file]) = self defined cursor, file should be an ANI- or CUR-type</item>
		/// </list</para>
		/// <para>Please note that in the current implementation this has no effect in IE.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "globalCursor", NativeField = true)]
		public string GlobalCursor { get; set; }

		/// <summary>
		/// <para>Whether the native context menu should be globally enabled. Setting this
		/// property to true will allow native context menus in all
		/// child widgets of this root.</para>
		/// </summary>
		[JsProperty(Name = "nativeContextMenu", NativeField = true)]
		public object NativeContextMenu { get; set; }

		/// <summary>
		/// <para>If the user presses F1 in IE by default the onhelp event is fired and
		/// IE&#8217;s help window is opened. Setting this property to false
		/// prevents this behavior.</para>
		/// </summary>
		[JsProperty(Name = "nativeHelp", NativeField = true)]
		public bool NativeHelp { get; set; }

		/// <summary>
		/// <para>Color of the blocker</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "blockerColor", NativeField = true)]
		public string BlockerColor { get; set; }

		/// <summary>
		/// <para>Opacity of the blocker</para>
		/// </summary>
		[JsProperty(Name = "blockerOpacity", NativeField = true)]
		public double BlockerOpacity { get; set; }

		/// <summary>
		/// <para>The currently active window</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "activeWindow", NativeField = true)]
		public qx.ui.window.Window ActiveWindow { get; set; }

		#endregion Properties

		#region Methods

		public Abstract() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property globalCursor.</para>
		/// </summary>
		[JsMethod(Name = "getGlobalCursor")]
		public string GetGlobalCursor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the widget&#8217;s layout manager.</para>
		/// </summary>
		/// <returns>The widget&#8217;s layout manager</returns>
		[JsMethod(Name = "getLayout")]
		public qx.ui.layout.Abstract GetLayout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property nativeHelp.</para>
		/// </summary>
		[JsMethod(Name = "getNativeHelp")]
		public bool GetNativeHelp() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property globalCursor
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property globalCursor.</param>
		[JsMethod(Name = "initGlobalCursor")]
		public void InitGlobalCursor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property nativeHelp
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property nativeHelp.</param>
		[JsMethod(Name = "initNativeHelp")]
		public void InitNativeHelp(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property nativeHelp equals true.</para>
		/// </summary>
		[JsMethod(Name = "isNativeHelp")]
		public void IsNativeHelp() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the item is a root item and directly connected to
		/// the DOM.</para>
		/// </summary>
		/// <returns>Whether the item a root item</returns>
		[JsMethod(Name = "isRootWidget")]
		public bool IsRootWidget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property globalCursor.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetGlobalCursor")]
		public void ResetGlobalCursor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property nativeHelp.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetNativeHelp")]
		public void ResetNativeHelp() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property globalCursor.</para>
		/// </summary>
		/// <param name="value">New value for property globalCursor.</param>
		[JsMethod(Name = "setGlobalCursor")]
		public void SetGlobalCursor(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property nativeHelp.</para>
		/// </summary>
		/// <param name="value">New value for property nativeHelp.</param>
		[JsMethod(Name = "setNativeHelp")]
		public void SetNativeHelp(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property nativeHelp.</para>
		/// </summary>
		[JsMethod(Name = "toggleNativeHelp")]
		public void ToggleNativeHelp() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a new child widget.</para>
		/// <para>The supported keys of the layout options map depend on the layout manager
		/// used to position the widget. The options are documented in the class
		/// documentation of each layout manager <see cref="qx.ui.layout"/>.</para>
		/// </summary>
		/// <param name="child">the widget to add.</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "add")]
		public void Add(LayoutItem child, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a widget after another already inserted widget</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="after">Widget, after which the new widget will be inserted</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "addAfter")]
		public void AddAfter(LayoutItem child, LayoutItem after, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a child widget at the specified index</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="index">Index, at which the widget will be inserted</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "addAt")]
		public void AddAt(LayoutItem child, double index, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a widget before another already inserted widget</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="before">Widget before the new widget will be inserted.</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "addBefore")]
		public void AddBefore(LayoutItem child, LayoutItem before, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the children list</para>
		/// </summary>
		/// <returns>The children array (Arrays are reference types, please to not modify them in-place)</returns>
		[JsMethod(Name = "getChildren")]
		public LayoutItem GetChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the widget contains children.</para>
		/// </summary>
		/// <returns>Returns true when the widget has children.</returns>
		[JsMethod(Name = "hasChildren")]
		public bool HasChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the index position of the given widget if it is
		/// a child widget. Otherwise it returns -1.</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">the widget to query for</param>
		/// <returns>The index position or -1 when the given widget is no child of this layout.</returns>
		[JsMethod(Name = "indexOf")]
		public double IndexOf(Widget child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the given child widget.</para>
		/// </summary>
		/// <param name="child">the widget to remove</param>
		[JsMethod(Name = "remove")]
		public void Remove(LayoutItem child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all children.</para>
		/// </summary>
		/// <returns>An array of the removed children.</returns>
		[JsMethod(Name = "removeAll")]
		public JsArray RemoveAll() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the widget at the specified index.</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="index">Index of the widget to remove.</param>
		/// <returns>The child removed.</returns>
		[JsMethod(Name = "removeAt")]
		public LayoutItem RemoveAt(double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Mapping of protected methods to public.
		/// This omits an additional function call when using these methods. Call
		/// this methods in the defer block of the including class.</para>
		/// </summary>
		/// <param name="members">The including classes members map</param>
		[JsMethod(Name = "remap")]
		public static void Remap(object members) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Block all events from this widget by placing a transparent overlay widget,
		/// which receives all events, exactly over the widget.</para>
		/// </summary>
		[JsMethod(Name = "block")]
		public void Block() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Block direct child widgets with a zIndex below zIndex</para>
		/// </summary>
		/// <param name="zIndex">All child widgets with a zIndex below this value will be blocked</param>
		[JsMethod(Name = "blockContent")]
		public void BlockContent(double zIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the widget blocked by <see cref="Block"/>, but it doesn&#8217;t take care of
		/// the amount of <see cref="Block"/> calls. The blocker is directly removed.</para>
		/// </summary>
		[JsMethod(Name = "forceUnblock")]
		public void ForceUnblock() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the content blocked by <see cref="BlockContent"/>, but it doesn&#8217;t take
		/// care of the amount of <see cref="BlockContent"/> calls. The blocker is
		/// directly removed.</para>
		/// </summary>
		[JsMethod(Name = "forceUnblockContent")]
		public void ForceUnblockContent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the blocker</para>
		/// </summary>
		/// <returns>The blocker</returns>
		[JsMethod(Name = "getBlocker")]
		public qx.ui.core.Blocker GetBlocker() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property blockerColor.</para>
		/// </summary>
		[JsMethod(Name = "getBlockerColor")]
		public string GetBlockerColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property blockerOpacity.</para>
		/// </summary>
		[JsMethod(Name = "getBlockerOpacity")]
		public double GetBlockerOpacity() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property blockerColor
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property blockerColor.</param>
		[JsMethod(Name = "initBlockerColor")]
		public void InitBlockerColor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property blockerOpacity
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property blockerOpacity.</param>
		[JsMethod(Name = "initBlockerOpacity")]
		public void InitBlockerOpacity(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the widget is blocked.</para>
		/// </summary>
		/// <returns>Whether the widget is blocked.</returns>
		[JsMethod(Name = "isBlocked")]
		public bool IsBlocked() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the content is blocked</para>
		/// </summary>
		/// <returns>Whether the content is blocked</returns>
		[JsMethod(Name = "isContentBlocked")]
		public bool IsContentBlocked() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property blockerColor.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBlockerColor")]
		public void ResetBlockerColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property blockerOpacity.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBlockerOpacity")]
		public void ResetBlockerOpacity() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property blockerColor.</para>
		/// </summary>
		/// <param name="value">New value for property blockerColor.</param>
		[JsMethod(Name = "setBlockerColor")]
		public void SetBlockerColor(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property blockerOpacity.</para>
		/// </summary>
		/// <param name="value">New value for property blockerOpacity.</param>
		[JsMethod(Name = "setBlockerOpacity")]
		public void SetBlockerOpacity(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the widget blocked by <see cref="Block"/>, but it takes care of
		/// the amount of <see cref="Block"/> calls. The blocker is only removed if
		/// the numer of <see cref="Unblock"/> calls is identical to <see cref="Block"/> calls.</para>
		/// </summary>
		[JsMethod(Name = "unblock")]
		public void Unblock() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the content blocked by <see cref="BlockContent"/>, but it takes care of
		/// the amount of <see cref="BlockContent"/> calls. The blocker is only removed if
		/// the numer of <see cref="UnblockContent"/> calls is identical to
		/// <see cref="BlockContent"/> calls.</para>
		/// </summary>
		[JsMethod(Name = "unblockContent")]
		public void UnblockContent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property activeWindow.</para>
		/// </summary>
		[JsMethod(Name = "getActiveWindow")]
		public qx.ui.window.Window GetActiveWindow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the desktop&#8217;s window manager. Each desktop must have a window manager.
		/// If none is configured the default window manager <see cref="qx.ui.window.Window#DEFAULT_MANAGER_CLASS"/>
		/// is used.</para>
		/// </summary>
		/// <returns>The desktop&#8217;s window manager</returns>
		[JsMethod(Name = "getWindowManager")]
		public qx.ui.window.IWindowManager GetWindowManager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a list of all windows added to the desktop (including hidden windows)</para>
		/// </summary>
		/// <returns>Array of managed windows</returns>
		[JsMethod(Name = "getWindows")]
		public qx.ui.window.Window GetWindows() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property activeWindow
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property activeWindow.</param>
		[JsMethod(Name = "initActiveWindow")]
		public void InitActiveWindow(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property activeWindow.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetActiveWindow")]
		public void ResetActiveWindow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property activeWindow.</para>
		/// </summary>
		/// <param name="value">New value for property activeWindow.</param>
		[JsMethod(Name = "setActiveWindow")]
		public void SetActiveWindow(qx.ui.window.Window value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the desktop&#8217;s window manager</para>
		/// </summary>
		/// <param name="manager">The window manager</param>
		[JsMethod(Name = "setWindowManager")]
		public void SetWindowManager(qx.ui.window.IWindowManager manager) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the configured layout supports a maximized window
		/// e.g. is a Canvas.</para>
		/// </summary>
		/// <returns>Whether the layout supports maximized windows</returns>
		[JsMethod(Name = "supportsMaximize")]
		public bool SupportsMaximize() { throw new NotImplementedException(); }

		#endregion Methods
    }
}