//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:24
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data
namespace Ext.data
{
    #region ArrayStore
    /// <summary>
    /// Small helper class to make creating Ext.data.Stores from Array data easier. An ArrayStore will be
    /// automatically configured with a Ext.data.reader.Array. A store configuration would be something like: var store = Ext.create(&#39;Ext.data.ArrayStore&#39;, {
    /// // store configs
    /// autoDestroy: true,
    /// storeId: &#39;myStore&#39;,
    /// // reader configs
    /// idIndex: 0,
    /// fields: [
    /// &#39;company&#39;,
    /// {name: &#39;price&#39;, type: &#39;float&#39;},
    /// {name: &#39;change&#39;, type: &#39;float&#39;},
    /// {name: &#39;pctChange&#39;, type: &#39;float&#39;},
    /// {name: &#39;lastChange&#39;, type: &#39;date&#39;, dateFormat: &#39;n/j h:ia&#39;}
    /// ]
    /// });
    /// This store is configured to consume a returned object of the form: var myData = [
    /// [&#39;3m Co&#39;,71.72,0.02,0.03,&#39;9/1 12:00am&#39;],
    /// [&#39;Alcoa Inc&#39;,29.01,0.42,1.47,&#39;9/1 12:00am&#39;],
    /// [&#39;Boeing Co.&#39;,75.43,0.53,0.71,&#39;9/1 12:00am&#39;],
    /// [&#39;Hewlett-Packard Co.&#39;,36.53,-0.03,-0.08,&#39;9/1 12:00am&#39;],
    /// [&#39;Wal-Mart Stores, Inc.&#39;,45.45,0.73,1.63,&#39;9/1 12:00am&#39;]
    /// ];
    /// An object literal of this form could also be used as the data config option. Note: Although not listed here, this class accepts all of the configuration options of
    /// ArrayReader.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ArrayStore : Ext.data.Store, Ext.util.Observable, Ext.util.Sortable
    {
    }
    #endregion
    #region ArrayStoreConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ArrayStoreConfig : Ext.data.StoreConfig
    {
    }
    #endregion
    #region ArrayStoreEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ArrayStoreEvents : Ext.data.StoreEvents
    {
    }
    #endregion
}
#endregion
