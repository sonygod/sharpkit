//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.data
{
    #region NodeStore
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Node Store</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class NodeStore : Ext.data.Store
    {
        /// <summary>
        /// The Record you want to bind this Store to. Note that
        /// this record will be decorated with the Ext.data.NodeInterface if this is not the
        /// case yet.
        /// Defaults to: <c>null</c>
        /// </summary>
        public Ext.data.Model node;
        /// <summary>
        /// Set this to true if you want this NodeStore to represent
        /// all the descendents of the node in its flat data collection. This is useful for
        /// rendering a tree structure to a DataView and is being used internally by
        /// the TreeView. Any records that are moved, removed, inserted or appended to the
        /// node at any depth below the node this store is bound to will be automatically
        /// updated in this Store's internal flat data structure.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool recursive;
        /// <summary>
        /// False to not include the root node in this Stores collection.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool rootVisible;
        /// <summary>
        /// The TreeStore that is used by this NodeStore's Ext.tree.View.
        /// </summary>
        public TreeStore treeStore;
        public NodeStore(NodeStoreConfig config){}
        public NodeStore(){}
        public NodeStore(params object[] args){}
    }
    #endregion
    #region NodeStoreConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NodeStoreConfig : Ext.data.StoreConfig
    {
        /// <summary>
        /// The Record you want to bind this Store to. Note that
        /// this record will be decorated with the Ext.data.NodeInterface if this is not the
        /// case yet.
        /// Defaults to: <c>null</c>
        /// </summary>
        public Ext.data.Model node;
        /// <summary>
        /// Set this to true if you want this NodeStore to represent
        /// all the descendents of the node in its flat data collection. This is useful for
        /// rendering a tree structure to a DataView and is being used internally by
        /// the TreeView. Any records that are moved, removed, inserted or appended to the
        /// node at any depth below the node this store is bound to will be automatically
        /// updated in this Store's internal flat data structure.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool recursive;
        /// <summary>
        /// False to not include the root node in this Stores collection.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool rootVisible;
        /// <summary>
        /// The TreeStore that is used by this NodeStore's Ext.tree.View.
        /// </summary>
        public TreeStore treeStore;
        public NodeStoreConfig(params object[] args){}
    }
    #endregion
    #region NodeStoreEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NodeStoreEvents : Ext.data.StoreEvents
    {
        public NodeStoreEvents(params object[] args){}
    }
    #endregion
}
