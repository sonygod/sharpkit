//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.column
namespace Ext.grid.column
{
    #region Boolean
    /// <summary>
    /// A Column definition class which renders boolean data fields.  See the xtype
    /// config option of Ext.grid.column.Column for more details.  Code Ext.create(&#39;Ext.data.Store&#39;, {
    /// storeId:&#39;sampleStore&#39;,
    /// fields:[
    /// {name: &#39;framework&#39;, type: &#39;string&#39;},
    /// {name: &#39;rocks&#39;, type: &#39;boolean&#39;}
    /// ],
    /// data:{&#39;items&#39;:[
    /// {&quot;framework&quot;:&quot;Ext JS 4&quot;, &quot;rocks&quot;:true},
    /// {&quot;framework&quot;:&quot;Sencha Touch&quot;, &quot;rocks&quot;:true},
    /// {&quot;framework&quot;:&quot;Ext GWT&quot;, &quot;rocks&quot;:true},
    /// {&quot;framework&quot;:&quot;Other Guys&quot;, &quot;rocks&quot;:false}
    /// ]},
    /// proxy: {
    /// type: &#39;memory&#39;,
    /// reader: {
    /// type: &#39;json&#39;,
    /// root: &#39;items&#39;
    /// }
    /// }
    /// });
    /// Ext.create(&#39;Ext.grid.Panel&#39;, {
    /// title: &#39;Boolean Column Demo&#39;,
    /// store: Ext.data.StoreManager.lookup(&#39;sampleStore&#39;),
    /// columns: [
    /// {text: &#39;Framework&#39;,  dataIndex: &#39;framework&#39;, flex: 1},
    /// {
    /// xtype: &#39;booleancolumn&#39;,
    /// text: &#39;Rocks&#39;,
    /// trueText: &#39;Yes&#39;,
    /// falseText: &#39;No&#39;,
    /// dataIndex: &#39;rocks&#39;}
    /// ],
    /// height: 200,
    /// width: 400,
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Boolean : Ext.grid.column.Column, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        public Boolean(BooleanConfig config){}
        public Boolean(){}
    }
    #endregion
    #region BooleanConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class BooleanConfig : Ext.grid.column.ColumnConfig
    {
        public JsString falseText{get;set;}
        public JsString trueText{get;set;}
        public JsString undefinedText{get;set;}
    }
    #endregion
    #region BooleanEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class BooleanEvents : Ext.grid.column.ColumnEvents
    {
    }
    #endregion
}
#endregion
