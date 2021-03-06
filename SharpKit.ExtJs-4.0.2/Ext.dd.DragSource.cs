//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
using Ext.direct;
#region Ext.dd
namespace Ext.dd
{
    #region DragSource
    /// <summary>
    /// A simple class that provides the basic implementation needed to make any element draggable.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class DragSource : DDProxy
    {
        /// <summary>
        /// Creates new drag-source. ...
        /// </summary>
        public DragSource(object el, object config=null){}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// after a valid drag drop has occurr...
        /// </summary>
        public object afterDragDrop(Ext.dd.DragDrop target, Event e, JsString id){return null;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// when the dragged item enters the d...
        /// </summary>
        public object afterDragEnter(Ext.dd.DragDrop target, Event e, JsString id){return null;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// after the dragged item is dragged ...
        /// </summary>
        public object afterDragOut(Ext.dd.DragDrop target, Event e, JsString id){return null;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// while the dragged item is over the...
        /// </summary>
        public object afterDragOver(Ext.dd.DragDrop target, Event e, JsString id){return null;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// after an invalid drop has occurred...
        /// </summary>
        public object afterInvalidDrop(Event e, JsString id){return null;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action before the dragged
        /// item is dropped...
        /// </summary>
        public bool beforeDragDrop(Ext.dd.DragDrop target, Event e, JsString id){return false;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// before the dragged item enters the...
        /// </summary>
        public bool beforeDragEnter(Ext.dd.DragDrop target, Event e, JsString id){return false;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action before the dragged
        /// item is dragged...
        /// </summary>
        public bool beforeDragOut(Ext.dd.DragDrop target, Event e, JsString id){return false;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action
        /// while the dragged item is over the...
        /// </summary>
        public bool beforeDragOver(Ext.dd.DragDrop target, Event e, JsString id){return false;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action after an invalid
        /// drop has occurred. ...
        /// </summary>
        public bool beforeInvalidDrop(Ext.dd.DragDrop target, Event e, JsString id){return false;}
        /// <summary>
        /// Returns the data object associated with this drag source ...
        /// </summary>
        public object getDragData(object e){return null;}
        /// <summary>
        /// Returns the drag source's underlying Ext.dd.StatusProxy ...
        /// </summary>
        public StatusProxy getProxy(){return null;}
        /// <summary>
        /// Hides the drag source's Ext.dd.StatusProxy ...
        /// </summary>
        public object hideProxy(){return null;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action before the initial
        /// drag event begi...
        /// </summary>
        public bool onBeforeDrag(object data, Event e){return false;}
        /// <summary>
        /// An empty function by default, but provided so that you can perform a custom action once the initial
        /// drag event has be...
        /// </summary>
        public object onStartDrag(JsNumber x, JsNumber y){return null;}
        public DragSource(DragSourceConfig config){}
        public DragSource(){}
    }
    #endregion
    #region DragSourceConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DragSourceConfig : DDProxyConfig
    {
        /// <summary>
        /// Defaults to true. ...
        /// </summary>
        public bool animRepair{get;set;}
        /// <summary>
        /// A named drag drop group to which this object belongs. ...
        /// </summary>
        public JsString ddGroup{get;set;}
        public JsString dropAllowed{get;set;}
        public JsString dropNotAllowed{get;set;}
        /// <summary>
        /// The color to use when visually highlighting the drag source in the afterRepair
        /// method after a failed drop (defaults t...
        /// </summary>
        public JsString repairHighlightColor{get;set;}
    }
    #endregion
    #region DragSourceEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DragSourceEvents : DDProxyEvents
    {
    }
    #endregion
}
#endregion
