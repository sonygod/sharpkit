//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.window
{
    #region Window
    /// <inheritdocs />
    /// <summary>
    /// <p>A specialized panel intended for use as an application window. Windows are floated, <see cref="Ext.window.WindowConfig.resizable">resizable</see>, and
    /// <see cref="Ext.window.WindowConfig.draggable">draggable</see> by default. Windows can be <see cref="Ext.window.WindowConfig.maximizable">maximized</see> to fill the viewport, restored to
    /// their prior size, and can be <see cref="Ext.window.Window.minimize">minimize</see>d.</p>
    /// <p>Windows can also be linked to a <see cref="Ext.ZIndexManager">Ext.ZIndexManager</see> or managed by the <see cref="Ext.WindowManager">Ext.WindowManager</see> to provide
    /// grouping, activation, to front, to back and other application-specific behavior.</p>
    /// <p>By default, Windows will be rendered to document.body. To <see cref="Ext.window.WindowConfig.constrain">constrain</see> a Window to another element specify
    /// <see cref="Ext.ComponentConfig.renderTo">renderTo</see>.</p>
    /// <p><strong>As with all <see cref="Ext.container.Container">Container</see>s, it is important to consider how you want the Window to size
    /// and arrange any child Components. Choose an appropriate <see cref="Ext.window.WindowConfig.layout">layout</see> configuration which lays out child Components
    /// in the required manner.</strong></p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.window.Window">Ext.window.Window</see>', {
    /// title: 'Hello',
    /// height: 200,
    /// width: 400,
    /// layout: 'fit',
    /// items: {  // Let's put an empty grid in just to illustrate fit layout
    /// xtype: 'grid',
    /// border: false,
    /// columns: [{header: 'World'}],                 // One header just for show. There's no data,
    /// store: <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.ArrayStore">Ext.data.ArrayStore</see>', {}) // A dummy empty data store
    /// }
    /// }).show();
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Window : Ext.panel.Panel
    {
        /// <summary>
        /// Id or element from which the window should animate while opening.
        /// Defaults to: <c>null</c>
        /// </summary>
        public object animateTarget;
        /// <summary>
        /// True to constrain the window within its containing element, false to allow it to fall outside of its containing
        /// element. By default the window will be rendered to document.body. To render and constrain the window within
        /// another element specify renderTo. Optionally the header only can be constrained
        /// using constrainHeader.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool constrain;
        /// <summary>
        /// True to constrain the window header within its containing element (allowing the window body to fall outside of
        /// its containing element) or false to allow the header to fall outside its containing element.
        /// Optionally the entire window can be constrained using constrain.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool constrainHeader;
        /// <summary>
        /// A Region (or an element from which a Region measurement will be read) which is used
        /// to constrain the window.
        /// </summary>
        public object constrainTo;
        /// <summary>
        /// Specifies a Component to receive focus when this Window is focused.
        /// This may be one of:
        /// <li>The index of a footer Button.</li>
        /// <li>The id or <see cref="Ext.AbstractComponentConfig.itemId">Ext.AbstractComponent.itemId</see> of a descendant Component.</li>
        /// <li>A Component.</li>
        /// </summary>
        public object defaultFocus;
        /// <summary>
        /// True to always expand the window when it is displayed, false to keep it in its current state (which may be
        /// collapsed) when displayed.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool expandOnShow;
        /// <summary>
        /// True to display the 'maximize' tool button and allow the user to maximize the window, false to hide the button
        /// and disallow maximizing the window. Note that when a window is maximized, the tool button
        /// will automatically change to a 'restore' button with the appropriate behavior already built-in that will restore
        /// the window to its previous size.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool maximizable;
        /// <summary>
        /// True to initially display the window in a maximized state.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool maximized;
        /// <summary>
        /// True to display the 'minimize' tool button and allow the user to minimize the window, false to hide the button
        /// and disallow minimizing the window. Note that this button provides no implementation -- the
        /// behavior of minimizing a window is implementation-specific, so the minimize event must be handled and a custom
        /// minimize behavior implemented for this option to be useful.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool minimizable;
        /// <summary>
        /// True to make the window modal and mask everything behind it when displayed, false to display it without
        /// restricting access to other UI elements.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool modal;
        /// <summary>
        /// Allows override of the built-in processing for the escape key. Default action is to close the Window (performing
        /// whatever action is specified in closeAction. To prevent the Window closing when the escape key is
        /// pressed, specify this as Ext.emptyFn.
        /// </summary>
        public System.Delegate onEsc;
        /// <summary>
        /// True to render the window body with a transparent background so that it will blend into the framing elements,
        /// false to add a lighter background color to visually highlight the body element and separate it more distinctly
        /// from the surrounding frame.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool plain;
        /// <summary>
        /// The X position of the left edge of the window on initial showing. Defaults to centering the Window within the
        /// width of the Window's container Element (The Element that the Window is rendered to).
        /// </summary>
        public JsNumber x;
        /// <summary>
        /// The Y position of the top edge of the window on initial showing. Defaults to centering the Window within the
        /// height of the Window's container Element (The Element that the Window is rendered to).
        /// </summary>
        public JsNumber y;
        /// <summary>
        /// true in this class to identify an object as an instantiated Window, or subclass thereof.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isWindow{get;set;}
        /// <summary>
        /// Gets the configured default focus item.  If a defaultFocus is set, it will
        /// receive focus when the Window's focus method is called, otherwise the
        /// Window itself will receive focus.
        /// </summary>
        public void getDefaultFocus(){}
        /// <summary>
        /// Override Component.initDraggable.
        /// Window uses the header element as the delegate.
        /// </summary>
        private void initDraggable(){}
        /// <summary>
        /// Fits the window within its current container and automatically replaces the 'maximize' tool
        /// button with the 'restore' tool button. Also see toggleMaximize.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.window.Window">Ext.window.Window</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Window maximize(){return null;}
        /// <summary>
        /// Placeholder method for minimizing the window. By default, this method simply fires the minimize event
        /// since the behavior of minimizing a window is application-specific. To implement custom minimize behavior, either
        /// the minimize event can be handled or this method can be overridden.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.window.Window">Ext.window.Window</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Window minimize(){return null;}
        /// <summary>
        /// Called when a Component's focusEl receives focus.
        /// If there is a valid default focus Component to jump to, focus that,
        /// otherwise continue as usual, focus this Component.
        /// </summary>
        private void onFocus(){}
        /// <summary>
        /// Restores a maximized window back to its original size and position prior to being maximized
        /// and also replaces the 'restore' tool button with the 'maximize' tool button. Also see toggleMaximize.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.window.Window">Ext.window.Window</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Window restore(){return null;}
        /// <summary>
        /// Synchronizes the presence of our listener for window resize events. This method
        /// should be called whenever this status might change.
        /// </summary>
        private void syncMonitorWindowResize(){}
        /// <summary>
        /// A shortcut method for toggling between maximize and restore based on the current maximized
        /// state of the window.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.window.Window">Ext.window.Window</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Window toggleMaximize(){return null;}
        public Window(WindowConfig config){}
        public Window(){}
        public Window(params object[] args){}
    }
    #endregion
    #region WindowConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class WindowConfig : Ext.panel.PanelConfig
    {
        /// <summary>
        /// Id or element from which the window should animate while opening.
        /// Defaults to: <c>null</c>
        /// </summary>
        public object animateTarget;
        /// <summary>
        /// True to constrain the window within its containing element, false to allow it to fall outside of its containing
        /// element. By default the window will be rendered to document.body. To render and constrain the window within
        /// another element specify renderTo. Optionally the header only can be constrained
        /// using constrainHeader.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool constrain;
        /// <summary>
        /// True to constrain the window header within its containing element (allowing the window body to fall outside of
        /// its containing element) or false to allow the header to fall outside its containing element.
        /// Optionally the entire window can be constrained using constrain.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool constrainHeader;
        /// <summary>
        /// A Region (or an element from which a Region measurement will be read) which is used
        /// to constrain the window.
        /// </summary>
        public object constrainTo;
        /// <summary>
        /// Specifies a Component to receive focus when this Window is focused.
        /// This may be one of:
        /// <li>The index of a footer Button.</li>
        /// <li>The id or <see cref="Ext.AbstractComponentConfig.itemId">Ext.AbstractComponent.itemId</see> of a descendant Component.</li>
        /// <li>A Component.</li>
        /// </summary>
        public object defaultFocus;
        /// <summary>
        /// True to always expand the window when it is displayed, false to keep it in its current state (which may be
        /// collapsed) when displayed.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool expandOnShow;
        /// <summary>
        /// True to display the 'maximize' tool button and allow the user to maximize the window, false to hide the button
        /// and disallow maximizing the window. Note that when a window is maximized, the tool button
        /// will automatically change to a 'restore' button with the appropriate behavior already built-in that will restore
        /// the window to its previous size.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool maximizable;
        /// <summary>
        /// True to initially display the window in a maximized state.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool maximized;
        /// <summary>
        /// True to display the 'minimize' tool button and allow the user to minimize the window, false to hide the button
        /// and disallow minimizing the window. Note that this button provides no implementation -- the
        /// behavior of minimizing a window is implementation-specific, so the minimize event must be handled and a custom
        /// minimize behavior implemented for this option to be useful.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool minimizable;
        /// <summary>
        /// True to make the window modal and mask everything behind it when displayed, false to display it without
        /// restricting access to other UI elements.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool modal;
        /// <summary>
        /// Allows override of the built-in processing for the escape key. Default action is to close the Window (performing
        /// whatever action is specified in closeAction. To prevent the Window closing when the escape key is
        /// pressed, specify this as Ext.emptyFn.
        /// </summary>
        public System.Delegate onEsc;
        /// <summary>
        /// True to render the window body with a transparent background so that it will blend into the framing elements,
        /// false to add a lighter background color to visually highlight the body element and separate it more distinctly
        /// from the surrounding frame.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool plain;
        /// <summary>
        /// The X position of the left edge of the window on initial showing. Defaults to centering the Window within the
        /// width of the Window's container Element (The Element that the Window is rendered to).
        /// </summary>
        public JsNumber x;
        /// <summary>
        /// The Y position of the top edge of the window on initial showing. Defaults to centering the Window within the
        /// height of the Window's container Element (The Element that the Window is rendered to).
        /// </summary>
        public JsNumber y;
        public WindowConfig(params object[] args){}
    }
    #endregion
    #region WindowEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class WindowEvents : Ext.panel.PanelEvents
    {
        /// <summary>
        /// Fires after the window has been maximized.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void maximize(Window @this, object eOpts){}
        /// <summary>
        /// Fires after the window has been minimized.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void minimize(Window @this, object eOpts){}
        /// <summary>
        /// Fires after the window has been resized.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="width"><p>The window's new width</p>
        /// </param>
        /// <param name="height"><p>The window's new height</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void resize(Window @this, JsNumber width, JsNumber height, object eOpts){}
        /// <summary>
        /// Fires after the window has been restored to its original size after being maximized.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void restore(Window @this, object eOpts){}
        public WindowEvents(params object[] args){}
    }
    #endregion
}
