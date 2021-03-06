//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.tree
namespace Ext.tree
{
    #region ViewDDPlugin
    /// <summary>
    /// This plugin provides drag and/or drop functionality for a TreeView. It creates a specialized instance of DragZone which knows how to drag out of a TreeView
    /// and loads the data object which is passed to a cooperating DragZone&#39;s methods with the following properties: copy : Boolean
    /// The value of the TreeView&#39;s copy property, or true if the TreeView was configured
    /// with allowCopy: true and the control key was pressed when the drag operation was begun. view : TreeView
    /// The source TreeView from which the drag originated. ddel : HtmlElement
    /// The drag proxy element which moves with the mouse item : HtmlElement
    /// The TreeView node upon which the mousedown event was registered. records : Array
    /// An Array of Models representing the selected data being dragged from the source TreeView.  It also creates a specialized instance of Ext.dd.DropZone which cooperates with other DropZones which are members of the same
    /// ddGroup which processes such data objects. Adding this plugin to a view means that two new events may be fired from the client TreeView, beforedrop and
    /// drop
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ViewDDPlugin : AbstractPlugin
    {
        public ViewDDPlugin(ViewDDPluginConfig config){}
        public ViewDDPlugin(){}
    }
    #endregion
    #region ViewDDPluginConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ViewDDPluginConfig : AbstractPluginConfig
    {
        public JsString allowContainerDrop{get;set;}
        /// <summary>
        /// Allow inserting a dragged node between an expanded parent node and its first child that will become a
        /// sibling of the ...
        /// </summary>
        public bool allowParentInsert{get;set;}
        public JsString appendOnly{get;set;}
        /// <summary>
        /// A named drag drop group to which this object belongs. ...
        /// </summary>
        public JsString ddGroup{get;set;}
        /// <summary>
        /// The ddGroup to which the DragZone will belong. ...
        /// </summary>
        public JsString dragGroup{get;set;}
        /// <summary>
        /// The ddGroup to which the DropZone will belong. ...
        /// </summary>
        public JsString dropGroup{get;set;}
        public bool enableDrag{get;set;}
        public bool enableDrop{get;set;}
        /// <summary>
        /// The delay in milliseconds to wait before expanding a target tree node while dragging a droppable node
        /// over the target...
        /// </summary>
        public JsString expandDelay{get;set;}
        /// <summary>
        /// The color to use when visually highlighting the dragged
        /// or dropped node (defaults to 'c3daf9' - light blue). ...
        /// </summary>
        public JsString nodeHighlightColor{get;set;}
        /// <summary>
        /// Whether or not to highlight any nodes after they are
        /// successfully dropped on their target. ...
        /// </summary>
        public bool nodeHighlightOnDrop{get;set;}
        /// <summary>
        /// Whether or not to highlight any nodes after they are
        /// repaired from an unsuccessful drag/drop. ...
        /// </summary>
        public bool nodeHighlightOnRepair{get;set;}
    }
    #endregion
    #region ViewDDPluginEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ViewDDPluginEvents : AbstractPluginEvents
    {
        /// <summary>
        /// This event is fired through the TreeView. ...
        /// </summary>
        public static JsString beforedrop="beforedrop";
        /// <summary>
        /// This event is fired through the TreeView. ...
        /// </summary>
        public static JsString drop="drop";
    }
    #endregion
}
#endregion
