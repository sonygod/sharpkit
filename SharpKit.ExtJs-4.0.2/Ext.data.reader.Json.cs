//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:50:57
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data.reader
namespace Ext.data.reader
{
    #region Json
    /// <summary>
    /// The JSON Reader is used by a Proxy to read a server response that is sent back in JSON format. This usually
    /// happens as a result of loading a Store - for example we might create something like this: Ext.define(&#39;User&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [&#39;id&#39;, &#39;name&#39;, &#39;email&#39;]
    /// });
    /// var store = new Ext.data.Store({
    /// model: &#39;User&#39;,
    /// proxy: {
    /// type: &#39;ajax&#39;,
    /// url : &#39;users.json&#39;,
    /// reader: {
    /// type: &#39;json&#39;
    /// }
    /// }
    /// });
    /// The example above creates a &#39;User&#39; model. Models are explained in the Model docs if you&#39;re
    /// not already familiar with them. We created the simplest type of JSON Reader possible by simply telling our Store&#39;s
    /// Proxy that we want a JSON Reader. The Store automatically passes the configured model to the
    /// Store, so it is as if we passed this instead:
    /// reader: {
    /// type : &#39;json&#39;,
    /// model: &#39;User&#39;
    /// }
    /// The reader we set up is ready to read data from our server - at the moment it will accept a response like this: [
    /// {
    /// &quot;id&quot;: 1,
    /// &quot;name&quot;: &quot;Ed Spencer&quot;,
    /// &quot;email&quot;: &quot;ed@sencha.com&quot;
    /// },
    /// {
    /// &quot;id&quot;: 2,
    /// &quot;name&quot;: &quot;Abe Elias&quot;,
    /// &quot;email&quot;: &quot;abe@sencha.com&quot;
    /// }
    /// ]
    /// Reading other JSON formats If you already have your JSON format defined and it doesn&#39;t look quite like what we have above, you can usually
    /// pass JsonReader a couple of configuration options to make it parse your format. For example, we can use the
    /// root configuration to parse data that comes back like this: {
    /// &quot;users&quot;: [
    /// {
    /// &quot;id&quot;: 1,
    /// &quot;name&quot;: &quot;Ed Spencer&quot;,
    /// &quot;email&quot;: &quot;ed@sencha.com&quot;
    /// },
    /// {
    /// &quot;id&quot;: 2,
    /// &quot;name&quot;: &quot;Abe Elias&quot;,
    /// &quot;email&quot;: &quot;abe@sencha.com&quot;
    /// }
    /// ]
    /// }
    /// To parse this we just pass in a root configuration that matches the &#39;users&#39; above: reader: {
    /// type: &#39;json&#39;,
    /// root: &#39;users&#39;
    /// }
    /// Sometimes the JSON structure is even more complicated. Document databases like CouchDB often provide metadata
    /// around each record inside a nested structure like this: {
    /// &quot;total&quot;: 122,
    /// &quot;offset&quot;: 0,
    /// &quot;users&quot;: [
    /// {
    /// &quot;id&quot;: &quot;ed-spencer-1&quot;,
    /// &quot;value&quot;: 1,
    /// &quot;user&quot;: {
    /// &quot;id&quot;: 1,
    /// &quot;name&quot;: &quot;Ed Spencer&quot;,
    /// &quot;email&quot;: &quot;ed@sencha.com&quot;
    /// }
    /// }
    /// ]
    /// }
    /// In the case above the record data is nested an additional level inside the &quot;users&quot; array as each &quot;user&quot; item has
    /// additional metadata surrounding it (&#39;id&#39; and &#39;value&#39; in this case). To parse data out of each &quot;user&quot; item in the
    /// JSON above we need to specify the record configuration like this: reader: {
    /// type  : &#39;json&#39;,
    /// root  : &#39;users&#39;,
    /// record: &#39;user&#39;
    /// }
    /// Response metadata The server can return additional data in its response, such as the total number of records
    /// and the success status of the response. These are typically included in the JSON response
    /// like this: {
    /// &quot;total&quot;: 100,
    /// &quot;success&quot;: true,
    /// &quot;users&quot;: [
    /// {
    /// &quot;id&quot;: 1,
    /// &quot;name&quot;: &quot;Ed Spencer&quot;,
    /// &quot;email&quot;: &quot;ed@sencha.com&quot;
    /// }
    /// ]
    /// }
    /// If these properties are present in the JSON response they can be parsed out by the JsonReader and used by the
    /// Store that loaded it. We can set up the names of these properties by specifying a final pair of configuration
    /// options: reader: {
    /// type : &#39;json&#39;,
    /// root : &#39;users&#39;,
    /// totalProperty  : &#39;total&#39;,
    /// successProperty: &#39;success&#39;
    /// }
    /// These final options are not necessary to make the Reader work, but can be useful when the server needs to report
    /// an error or if it needs to indicate that there is a lot of data available of which only a subset is currently being
    /// returned.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Json : Reader
    {
        /// <summary>
        /// Reads a JSON object and returns a ResultSet. ...
        /// </summary>
        public new ResultSet readRecords(object data){return null;}
        /// <summary>
        /// DEPRECATED - will be removed in Ext JS 5.0. ...
        /// </summary>
        public object jsonData{get;set;}
    }
    #endregion
    #region JsonConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class JsonConfig
    {
        /// <summary>
        /// The optional location within the JSON response that the record data itself can be found at. ...
        /// </summary>
        public JsString record{get;set;}
        /// <summary>
        /// True to ensure that field names/mappings are treated as literals when
        /// reading values. ...
        /// </summary>
        public bool useSimpleAccessors{get;set;}
    }
    #endregion
    #region JsonEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class JsonEvents
    {
    }
    #endregion
}
#endregion
