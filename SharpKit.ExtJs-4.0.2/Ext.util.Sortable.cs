//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:55
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region Sortable
    /// <summary>
    /// A mixin which allows a data component to be sorted. This is used by e.g. Ext.data.Store and Ext.data.TreeStore. *NOTE**: This mixin is mainly for internal library use and most users should not need to use it directly. It
    /// is more likely you will want to use one of the component classes that import this mixin, such as
    /// Ext.data.Store or Ext.data.TreeStore.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial interface Sortable
    {
        /// <summary>
        /// Performs initialization of this mixin. ...
        /// </summary>
        object initSortable();
        /// <summary>
        /// Sorts the data in the Store by one or more of its properties. ...
        /// </summary>
        object sort(object sorters, JsString direction, object where, object doSort);
        JsString sortRoot{get;set;}
        JsString defaultSortDirection{get;set;}
        /// <summary>
        /// Flag denoting that this object is sortable. ...
        /// </summary>
        bool isSortable{get;set;}
        Ext.util.MixedCollection sorters{get;set;}
    }
    #endregion
    #region SortableConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class SortableConfig : Ext.BaseConfig
    {
    }
    #endregion
    #region SortableEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class SortableEvents : Ext.BaseEvents
    {
    }
    #endregion
}
#endregion
