//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data.proxy
namespace Ext.data.proxy
{
    #region Memory
    /// <summary>
    /// In-memory proxy. This proxy simply uses a local variable for data storage/retrieval, so its contents are lost on
    /// every page refresh. Usually this Proxy isn&#39;t used directly, serving instead as a helper to a Store where a
    /// reader is required to load data. For example, say we have a Store for a User model and have some inline data we want
    /// to load, but this data isn&#39;t in quite the right format: we can use a MemoryProxy with a JsonReader to read it into
    /// our Store: //this is the model we will be using in the store
    /// Ext.define(&#39;User&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [
    /// {name: &#39;id&#39;,    type: &#39;int&#39;},
    /// {name: &#39;name&#39;,  type: &#39;string&#39;},
    /// {name: &#39;phone&#39;, type: &#39;string&#39;, mapping: &#39;phoneNumber&#39;}
    /// ]
    /// });
    /// //this data does not line up to our model fields - the phone field is called phoneNumber
    /// var data = {
    /// users: [
    /// {
    /// id: 1,
    /// name: &#39;Ed Spencer&#39;,
    /// phoneNumber: &#39;555 1234&#39;
    /// },
    /// {
    /// id: 2,
    /// name: &#39;Abe Elias&#39;,
    /// phoneNumber: &#39;666 1234&#39;
    /// }
    /// ]
    /// };
    /// //note how we set the &#39;root&#39; in the reader to match the data structure above
    /// var store = new Ext.data.Store({
    /// autoLoad: true,
    /// model: &#39;User&#39;,
    /// data : data,
    /// proxy: {
    /// type: &#39;memory&#39;,
    /// reader: {
    /// type: &#39;json&#39;,
    /// root: &#39;users&#39;
    /// }
    /// }
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Memory : Client, Ext.util.Observable
    {
        /// <summary>
        /// Reads data from the configured data object. ...
        /// </summary>
        public new object read(Operation operation, JsAction callback, object scope){return null;}
        public Memory(MemoryConfig config){}
        public Memory(){}
    }
    #endregion
    #region MemoryConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class MemoryConfig : ClientConfig
    {
        public JsArray data{get;set;}
    }
    #endregion
    #region MemoryEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class MemoryEvents : ClientEvents
    {
    }
    #endregion
}
#endregion
