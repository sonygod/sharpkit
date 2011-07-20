//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:24
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.dd
namespace Ext.dd
{
    #region DropTarget
    /// <summary>
    /// A simple class that provides the basic implementation needed to make any element a drop target that can have
    /// draggable items dropped onto it.  The drop has no effect until an implementation of notifyDrop is provided.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class DropTarget : DDTarget
    {
        /// <summary>
        /// Creates new DropTarget. ...
        /// </summary>
        public object constructor(object el, object config){return null;}
        /// <summary>
        /// The function a Ext.dd.DragSource calls once to notify this drop target that the dragged item has
        /// been dropped on it. ...
        /// </summary>
        public bool notifyDrop(DragSource source, Event e, object data){return false;}
        /// <summary>
        /// The function a Ext.dd.DragSource calls once to notify this drop target that the source is now over the
        /// target. ...
        /// </summary>
        public JsString notifyEnter(DragSource source, Event e, object data){return null;}
        /// <summary>
        /// The function a Ext.dd.DragSource calls once to notify this drop target that the source has been dragged
        /// out of the ta...
        /// </summary>
        public object notifyOut(DragSource source, Event e, object data){return null;}
        /// <summary>
        /// The function a Ext.dd.DragSource calls continuously while it is being dragged over the target. ...
        /// </summary>
        public JsString notifyOver(DragSource source, Event e, object data){return null;}
    }
    #endregion
    #region DropTargetConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DropTargetConfig : DDTargetConfig
    {
        /// <summary>
        /// A named drag drop group to which this object belongs. ...
        /// </summary>
        public JsString ddGroup{get;set;}
        public JsString dropAllowed{get;set;}
        public JsString dropNotAllowed{get;set;}
        public JsString overClass{get;set;}
    }
    #endregion
    #region DropTargetEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DropTargetEvents : DDTargetEvents
    {
    }
    #endregion
}
#endregion
