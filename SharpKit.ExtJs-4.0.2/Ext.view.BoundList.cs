//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.view
namespace Ext.view
{
    #region BoundList
    /// <summary>
    /// An internal used DataView for ComboBox, MultiSelect and ItemSelector.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class BoundList : Ext.view.View, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// A reference to the PagingToolbar instance in this view. ...
        /// </summary>
        public Ext.toolbar.Paging pagingToolbar{get;set;}
        public BoundList(BoundListConfig config){}
        public BoundList(){}
    }
    #endregion
    #region BoundListConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class BoundListConfig : Ext.view.ViewConfig
    {
        /// <summary>
        /// If greater than 0, a Ext.toolbar.Paging is displayed at the
        /// bottom of the list and store queries will execute with pa...
        /// </summary>
        public JsNumber pageSize{get;set;}
    }
    #endregion
    #region BoundListEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class BoundListEvents : Ext.view.ViewEvents
    {
    }
    #endregion
}
#endregion
