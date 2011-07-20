//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data
namespace Ext.data
{
    #region TreeStore
    /// <summary>
    /// The TreeStore is a store implementation that is backed by by an Ext.data.Tree.
    /// It provides convenience methods for loading nodes, as well as the ability to use
    /// the hierarchical tree structure combined with a store. This class is generally used
    /// in conjunction with Ext.tree.Panel. This class also relays many events from
    /// the Tree for convenience. Using Models If no Model is specified, an implicit model will be created that implements Ext.data.NodeInterface.
    /// The standard Tree fields will also be copied onto the Model for maintaining their state. Reading Nested Data For the tree to read nested data, the Ext.data.reader.Reader must be configured with a root property,
    /// so the reader can find nested data for each node. If a root is not specified, it will default to
    /// &#39;children&#39;.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class TreeStore : AbstractStore, Ext.util.Observable, Ext.util.Sortable
    {
        /// <summary>
        /// Returns the root node for this tree. ...
        /// </summary>
        public NodeInterface getRootNode(){return null;}
        /// <summary>
        /// If we have no fields declare for the store, add some defaults. ...
        /// </summary>
        public object fields{get;set;}
    }
    #endregion
    #region TreeStoreConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TreeStoreConfig
    {
        /// <summary>
        /// Remove previously existing child nodes before loading. ...
        /// </summary>
        public bool clearOnLoad{get;set;}
        /// <summary>
        /// The default root id. ...
        /// </summary>
        public JsString defaultRootId{get;set;}
        public JsString defaultRootProperty{get;set;}
        /// <summary>
        /// Set to true to automatically prepend a leaf sorter. ...
        /// </summary>
        public bool folderSort{get;set;}
        /// <summary>
        /// The name of the parameter sent to the server which contains the identifier of the node. ...
        /// </summary>
        public JsString nodeParam{get;set;}
        /// <summary>
        /// The root node for this store. ...
        /// </summary>
        public object root{get;set;}
    }
    #endregion
    #region TreeStoreEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TreeStoreEvents
    {
        /// <summary>
        /// Fires when a new child node is appended to a node in this store's tree. ...
        /// </summary>
        public static JsString append="append";
        /// <summary>
        /// Fires before a new child is appended to a node in this store's tree, return false to cancel the append. ...
        /// </summary>
        public static JsString beforeappend="beforeappend";
        /// <summary>
        /// Fires before this node is collapsed. ...
        /// </summary>
        public static JsString beforecollapse="beforecollapse";
        /// <summary>
        /// Fires before this node is expanded. ...
        /// </summary>
        public static JsString beforeexpand="beforeexpand";
        /// <summary>
        /// Fires before a new child is inserted in a node in this store's tree, return false to cancel the insert. ...
        /// </summary>
        public static JsString beforeinsert="beforeinsert";
        /// <summary>
        /// Fires before a node is moved to a new location in the store's tree. ...
        /// </summary>
        public static JsString beforemove="beforemove";
        /// <summary>
        /// Fires before a child is removed from a node in this store's tree, return false to cancel the remove. ...
        /// </summary>
        public static JsString beforeremove="beforeremove";
        /// <summary>
        /// Fires when this node is collapsed. ...
        /// </summary>
        public static JsString collapse="collapse";
        /// <summary>
        /// Fires when this node is expanded. ...
        /// </summary>
        public static JsString expand="expand";
        /// <summary>
        /// Fires when a new child node is inserted in a node in this store's tree. ...
        /// </summary>
        public static JsString insert="insert";
        /// <summary>
        /// Fires when a node is moved to a new location in the store's tree ...
        /// </summary>
        public static JsString move="move";
        /// <summary>
        /// Fires when a child node is removed from a node in this store's tree. ...
        /// </summary>
        public static JsString remove="remove";
        /// <summary>
        /// Fires when the root node on this TreeStore is changed. ...
        /// </summary>
        public static JsString rootchange="rootchange";
        /// <summary>
        /// Fires when this TreeStore is sorted. ...
        /// </summary>
        public static JsString sort="sort";
    }
    #endregion
}
#endregion
