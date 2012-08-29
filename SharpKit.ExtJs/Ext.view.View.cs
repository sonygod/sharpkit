//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.view
namespace Ext.view
{
    #region View
    /// <inheritdocs />
    /// <summary>
    /// <p>A mechanism for displaying data using custom layout templates and formatting.</p>
    /// <p>The View uses an <see cref="Ext.XTemplate">Ext.XTemplate</see> as its internal templating mechanism, and is bound to an
    /// <see cref="Ext.data.Store">Ext.data.Store</see> so that as the data in the store changes the view is automatically updated
    /// to reflect the changes. The view also provides built-in behavior for many common events that can
    /// occur for its contained items including click, doubleclick, mouseover, mouseout, etc. as well as a
    /// built-in selection model. <strong>In order to use these features, an <see cref="Ext.view.ViewConfig.itemSelector">itemSelector</see> config must
    /// be provided for the View to determine what nodes it will be working with.</strong></p>
    /// <p>The example below binds a View to a <see cref="Ext.data.Store">Ext.data.Store</see> and renders it into an <see cref="Ext.panel.Panel">Ext.panel.Panel</see>.</p>
    /// <pre><code><see cref="Ext.ExtContext.define">Ext.define</see>('Image', {
    /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
    /// fields: [
    /// { name:'src', type:'string' },
    /// { name:'caption', type:'string' }
    /// ]
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.Store">Ext.data.Store</see>', {
    /// id:'imagesStore',
    /// model: 'Image',
    /// data: [
    /// { src:'http://www.sencha.com/img/20110215-feat-drawing.png', caption:'Drawing &amp; Charts' },
    /// { src:'http://www.sencha.com/img/20110215-feat-data.png', caption:'Advanced Data' },
    /// { src:'http://www.sencha.com/img/20110215-feat-html5.png', caption:'Overhauled Theme' },
    /// { src:'http://www.sencha.com/img/20110215-feat-perf.png', caption:'Performance Tuned' }
    /// ]
    /// });
    /// var imageTpl = new <see cref="Ext.XTemplate">Ext.XTemplate</see>(
    /// '&lt;tpl for="."&gt;',
    /// '&lt;div style="margin-bottom: 10px;" class="thumb-wrap"&gt;',
    /// '&lt;img src="{src}" /&gt;',
    /// '&lt;br/&gt;&lt;span&gt;{caption}&lt;/span&gt;',
    /// '&lt;/div&gt;',
    /// '&lt;/tpl&gt;'
    /// );
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.view.View">Ext.view.View</see>', {
    /// store: <see cref="Ext.data.StoreManager.lookup">Ext.data.StoreManager.lookup</see>('imagesStore'),
    /// tpl: imageTpl,
    /// itemSelector: 'div.thumb-wrap',
    /// emptyText: 'No images available',
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class View : AbstractView
    {
        /// <summary>
        /// Un-highlights the currently highlighted item, if any.
        /// </summary>
        public void clearHighlight(){}
        /// <summary>
        /// Highlights a given item in the View. This is called by the mouseover handler if overItemCls
        /// and trackOver are configured, but can also be called manually by other code, for instance to
        /// handle stepping through the list via keyboard navigation.
        /// </summary>
        /// <param name="item"><p>The item to highlight</p>
        /// </param>
        public void highlightItem(object item){}
        public View(Ext.view.ViewConfig config){}
        public View(){}
        public View(params object[] args){}
    }
    #endregion
    #region ViewConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ViewConfig : AbstractViewConfig
    {
        public ViewConfig(params object[] args){}
    }
    #endregion
    #region ViewEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ViewEvents : AbstractViewEvents
    {
        /// <summary>
        /// Fires before the click event on the container is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforecontainerclick(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the contextmenu event on the container is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforecontainercontextmenu(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the dblclick event on the container is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforecontainerdblclick(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the keydown event on the container is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object. Use <see cref="Ext.EventObject.getKey">getKey()</see> to retrieve the key that was pressed.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforecontainerkeydown(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the mousedown event on the container is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforecontainermousedown(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the mouseout event on the container is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforecontainermouseout(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the mouseover event on the container is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforecontainermouseover(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the mouseup event on the container is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforecontainermouseup(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fired before a record is deselected. If any listener returns false, the
        /// deselection is cancelled.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The deselected record</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforedeselect(Ext.selection.DataViewModel @this, Ext.data.Model record, object eOpts){}
        /// <summary>
        /// Fires before the click event on an item is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeitemclick(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the contextmenu event on an item is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeitemcontextmenu(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the dblclick event on an item is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeitemdblclick(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the keydown event on an item is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object. Use <see cref="Ext.EventObject.getKey">getKey()</see> to retrieve the key that was pressed.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeitemkeydown(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the mousedown event on an item is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeitemmousedown(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the mouseenter event on an item is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeitemmouseenter(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the mouseleave event on an item is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeitemmouseleave(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires before the mouseup event on an item is processed. Returns false to cancel the default action.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeitemmouseup(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fired before a record is selected. If any listener returns false, the
        /// selection is cancelled.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The selected record</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeselect(Ext.selection.DataViewModel @this, Ext.data.Model record, object eOpts){}
        /// <summary>
        /// Fires when the container is clicked.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void containerclick(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when the container is right clicked.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void containercontextmenu(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when the container is double clicked.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void containerdblclick(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when a key is pressed while the container is focused, and no item is currently selected.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object. Use <see cref="Ext.EventObject.getKey">getKey()</see> to retrieve the key that was pressed.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void containerkeydown(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when you move the mouse out of the container.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void containermouseout(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when you move the mouse over the container.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void containermouseover(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when there is a mouse up on the container
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void containermouseup(Ext.view.View @this, EventObject e, object eOpts){}
        /// <summary>
        /// Fired after a record is deselected
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The deselected record</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void deselect(Ext.selection.DataViewModel @this, Ext.data.Model record, object eOpts){}
        /// <summary>
        /// Fired when a row is focused
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="oldFocused"><p>The previously focused record</p>
        /// </param>
        /// <param name="newFocused"><p>The newly focused record</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void focuschange(Ext.selection.Model @this, Ext.data.Model oldFocused, Ext.data.Model newFocused, object eOpts){}
        /// <summary>
        /// Fires when a node is highlighted using keyboard navigation, or mouseover.
        /// </summary>
        /// <param name="view"><p>This View Component.</p>
        /// </param>
        /// <param name="node"><p>The highlighted node.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void highlightitem(Ext.view.View view, Ext.dom.Element node, object eOpts){}
        /// <summary>
        /// Fires when an item is clicked.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void itemclick(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when an item is right clicked.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void itemcontextmenu(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when an item is double clicked.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void itemdblclick(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when a key is pressed while an item is currently selected.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object. Use <see cref="Ext.EventObject.getKey">getKey()</see> to retrieve the key that was pressed.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void itemkeydown(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when there is a mouse down on an item
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void itemmousedown(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when the mouse enters an item.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void itemmouseenter(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when the mouse leaves an item.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void itemmouseleave(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fires when there is a mouse up on an item
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The record that belongs to the item</p>
        /// </param>
        /// <param name="item"><p>The item's element</p>
        /// </param>
        /// <param name="index"><p>The item's index</p>
        /// </param>
        /// <param name="e"><p>The raw event object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void itemmouseup(Ext.view.View @this, Ext.data.Model record, object item, JsNumber index, EventObject e, object eOpts){}
        /// <summary>
        /// Fired after a record is selected
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="record"><p>The selected record</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void select(Ext.selection.DataViewModel @this, Ext.data.Model record, object eOpts){}
        /// <summary>
        /// Fired after a selection change has occurred
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="selected"><p>The selected records</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void selectionchange(Ext.selection.Model @this, JsArray<Ext.data.Model> selected, object eOpts){}
        /// <summary>
        /// Fires when a node is unhighlighted using keyboard navigation, or mouseout.
        /// </summary>
        /// <param name="view"><p>This View Component.</p>
        /// </param>
        /// <param name="node"><p>The previously highlighted node.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void unhighlightitem(Ext.view.View view, Ext.dom.Element node, object eOpts){}
        public ViewEvents(params object[] args){}
    }
    #endregion
}
#endregion
