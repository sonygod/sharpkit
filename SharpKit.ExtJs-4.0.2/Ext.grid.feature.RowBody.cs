//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.feature
namespace Ext.grid.feature
{
    #region RowBody
    /// <summary>
    /// The rowbody feature enhances the grid&#39;s markup to have an additional
    /// tr -&gt; td -&gt; div which spans the entire width of the original row. This is useful to to associate additional information with a particular
    /// record in a grid. Rowbodies are initially hidden unless you override getAdditionalData. Will expose additional events on the gridview with the prefix of &#39;rowbody&#39;.
    /// For example: &#39;rowbodyclick&#39;, &#39;rowbodydblclick&#39;, &#39;rowbodycontextmenu&#39;.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class RowBody : Feature
    {
        /// <summary>
        /// Provide additional data to the prepareData call within the grid view. ...
        /// </summary>
        public new object getAdditionalData(object data, JsNumber idx, Ext.data.Model record, object orig){return null;}
        public RowBody(RowBodyConfig config){}
        public RowBody(){}
    }
    #endregion
    #region RowBodyConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class RowBodyConfig : FeatureConfig
    {
    }
    #endregion
    #region RowBodyEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class RowBodyEvents : FeatureEvents
    {
    }
    #endregion
}
#endregion
