//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data
namespace Ext.data
{
    #region HasManyAssociation
    /// <summary>
    /// Represents a one-to-many relationship between two models. Usually created indirectly via a model definition: Ext.define(&#39;Product&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [
    /// {name: &#39;id&#39;,      type: &#39;int&#39;},
    /// {name: &#39;user_id&#39;, type: &#39;int&#39;},
    /// {name: &#39;name&#39;,    type: &#39;string&#39;}
    /// ]
    /// });
    /// Ext.define(&#39;User&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [
    /// {name: &#39;id&#39;,   type: &#39;int&#39;},
    /// {name: &#39;name&#39;, type: &#39;string&#39;}
    /// ],
    /// // we can use the hasMany shortcut on the model to create a hasMany association
    /// hasMany: {model: &#39;Product&#39;, name: &#39;products&#39;}
    /// });
    /// Above we created Product and User models, and linked them by saying that a User hasMany Products. This gives
    /// us a new function on every User instance, in this case the function is called &#39;products&#39; because that is the name
    /// we specified in the association configuration above. This new function returns a specialized Store which is automatically filtered to load
    /// only Products for the given model instance: //first, we load up a User with id of 1
    /// var user = Ext.ModelManager.create({id: 1, name: &#39;Ed&#39;}, &#39;User&#39;);
    /// //the user.products function was created automatically by the association and returns a Store
    /// //the created store is automatically scoped to the set of Products for the User with id of 1
    /// var products = user.products();
    /// //we still have all of the usual Store functions, for example it&#39;s easy to add a Product for this User
    /// products.add({
    /// name: &#39;Another Product&#39;
    /// });
    /// //saves the changes to the store - this automatically sets the new Product&#39;s user_id to 1 before saving
    /// products.sync();
    /// The new Store is only instantiated the first time you call products() to conserve memory and processing time,
    /// though calling products() a second time returns the same store instance. Custom filtering The Store is automatically furnished with a filter - by default this filter tells the store to only return
    /// records where the associated model&#39;s foreign key matches the owner model&#39;s primary key. For example, if a User
    /// with ID = 100 hasMany Products, the filter loads only Products with user_id == 100. Sometimes we want to filter by another field - for example in the case of a Twitter search application we may
    /// have models for Search and Tweet: Ext.define(&#39;Search&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [
    /// &#39;id&#39;, &#39;query&#39;
    /// ],
    /// hasMany: {
    /// model: &#39;Tweet&#39;,
    /// name : &#39;tweets&#39;,
    /// filterProperty: &#39;query&#39;
    /// }
    /// });
    /// Ext.define(&#39;Tweet&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [
    /// &#39;id&#39;, &#39;text&#39;, &#39;from_user&#39;
    /// ]
    /// });
    /// //returns a Store filtered by the filterProperty
    /// var store = new Search({query: &#39;Sencha Touch&#39;}).tweets();
    /// The tweets association above is filtered by the query property by setting the filterProperty, and is
    /// equivalent to this: var store = new Ext.data.Store({
    /// model: &#39;Tweet&#39;,
    /// filters: [
    /// {
    /// property: &#39;query&#39;,
    /// value   : &#39;Sencha Touch&#39;
    /// }
    /// ]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class HasManyAssociation : Association
    {
    }
    #endregion
    #region HasManyAssociationConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class HasManyAssociationConfig
    {
        /// <summary>
        /// True to automatically load the related store from a remote source when instantiated. ...
        /// </summary>
        public bool autoLoad{get;set;}
        /// <summary>
        /// Optionally overrides the default filter that is set up on the associated Store. ...
        /// </summary>
        public JsString filterProperty{get;set;}
        /// <summary>
        /// The name of the foreign key on the associated model that links it to the owner
        /// model. ...
        /// </summary>
        public JsString foreignKey{get;set;}
        /// <summary>
        /// The name of the function to create on the owner model to retrieve the child store. ...
        /// </summary>
        public JsString name{get;set;}
        /// <summary>
        /// Optional configuration object that will be passed to the generated Store. ...
        /// </summary>
        public object storeConfig{get;set;}
        /// <summary>
        /// The type configuration can be used when creating associations using a configuration object. ...
        /// </summary>
        public JsString type{get;set;}
    }
    #endregion
    #region HasManyAssociationEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class HasManyAssociationEvents
    {
    }
    #endregion
}
#endregion
