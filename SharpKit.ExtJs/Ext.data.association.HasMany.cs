//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data.association
namespace Ext.data.association
{
    #region HasMany
    /// <inheritdocs />
    /// <summary>
    /// <p>Represents a one-to-many relationship between two models. Usually created indirectly via a model definition:</p>
    /// <pre><code><see cref="Ext.ExtContext.define">Ext.define</see>('Product', {
    /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
    /// fields: [
    /// {name: 'id',      type: 'int'},
    /// {name: 'user_id', type: 'int'},
    /// {name: 'name',    type: 'string'}
    /// ]
    /// });
    /// <see cref="Ext.ExtContext.define">Ext.define</see>('User', {
    /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
    /// fields: [
    /// {name: 'id',   type: 'int'},
    /// {name: 'name', type: 'string'}
    /// ],
    /// // we can use the hasMany shortcut on the model to create a hasMany association
    /// hasMany: {model: 'Product', name: 'products'}
    /// });
    /// </code></pre>
    /// <p>
    /// <p>Above we created Product and User models, and linked them by saying that a User hasMany Products. This gives
    /// us a new function on every User instance, in this case the function is called 'products' because that is the name
    /// we specified in the association configuration above.</p>
    /// <p>This new function returns a specialized <see cref="Ext.data.Store">Store</see> which is automatically filtered to load
    /// only Products for the given model instance:</p>
    /// <pre><code>//first, we load up a User with id of 1
    /// var user = <see cref="Ext.ExtContext.create">Ext.create</see>('User', {id: 1, name: 'Ed'});
    /// //the user.products function was created automatically by the association and returns a <see cref="Ext.data.Store">Store</see>
    /// //the created store is automatically scoped to the set of Products for the User with id of 1
    /// var products = user.products();
    /// //we still have all of the usual Store functions, for example it's easy to add a Product for this User
    /// products.add({
    /// name: 'Another Product'
    /// });
    /// //saves the changes to the store - this automatically sets the new Product's user_id to 1 before saving
    /// products.sync();
    /// </code></pre>
    /// <p>The new Store is only instantiated the first time you call products() to conserve memory and processing time,
    /// though calling products() a second time returns the same store instance.</p>
    /// <p><u>Custom filtering</u></p>
    /// <p>The Store is automatically furnished with a filter - by default this filter tells the store to only return
    /// records where the associated model's foreign key matches the owner model's primary key. For example, if a User
    /// with ID = 100 hasMany Products, the filter loads only Products with user_id == 100.</p>
    /// <p>Sometimes we want to filter by another field - for example in the case of a Twitter search application we may
    /// have models for Search and Tweet:</p>
    /// <pre><code><see cref="Ext.ExtContext.define">Ext.define</see>('Search', {
    /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
    /// fields: [
    /// 'id', 'query'
    /// ],
    /// hasMany: {
    /// model: 'Tweet',
    /// name : 'tweets',
    /// filterProperty: 'query'
    /// }
    /// });
    /// <see cref="Ext.ExtContext.define">Ext.define</see>('Tweet', {
    /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
    /// fields: [
    /// 'id', 'text', 'from_user'
    /// ]
    /// });
    /// //returns a Store filtered by the filterProperty
    /// var store = new Search({query: 'Sencha Touch'}).tweets();
    /// </code></pre>
    /// <p>The tweets association above is filtered by the query property by setting the <see cref="Ext.data.association.HasManyConfig.filterProperty">filterProperty</see>, and is
    /// equivalent to this:</p>
    /// <pre><code>var store = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.Store">Ext.data.Store</see>', {
    /// model: 'Tweet',
    /// filters: [
    /// {
    /// property: 'query',
    /// value   : 'Sencha Touch'
    /// }
    /// ]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class HasMany : Association
    {
        /// <summary>
        /// True to automatically load the related store from a remote source when instantiated.
        /// Defaults to false.
        /// </summary>
        public bool autoLoad;
        /// <summary>
        /// Optionally overrides the default filter that is set up on the associated Store. If
        /// this is not set, a filter is automatically created which filters the association based on the configured
        /// foreignKey. See intro docs for more details. Defaults to undefined
        /// </summary>
        public JsString filterProperty;
        /// <summary>
        /// The name of the foreign key on the associated model that links it to the owner
        /// model. Defaults to the lowercased name of the owner model plus "_id", e.g. an association with a where a
        /// model called Group hasMany Users would create 'group_id' as the foreign key. When the remote store is loaded,
        /// the store is automatically filtered so that only records with a matching foreign key are included in the
        /// resulting child store. This can be overridden by specifying the filterProperty.
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('Group', {
        /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
        /// fields: ['id', 'name'],
        /// hasMany: 'User'
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('User', {
        /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
        /// fields: ['id', 'name', 'group_id'], // refers to the id of the group that this user belongs to
        /// belongsTo: 'Group'
        /// });
        /// </code>
        /// </summary>
        public JsString foreignKey;
        /// <summary>
        /// The name of the function to create on the owner model to retrieve the child store.
        /// If not specified, the pluralized name of the child model is used.
        /// <code>// This will create a users() method on any Group model instance
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('Group', {
        /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
        /// fields: ['id', 'name'],
        /// hasMany: 'User'
        /// });
        /// var group = new Group();
        /// console.log(group.users());
        /// // The method to retrieve the users will now be getUserList
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('Group', {
        /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
        /// fields: ['id', 'name'],
        /// hasMany: {model: 'User', name: 'getUserList'}
        /// });
        /// var group = new Group();
        /// console.log(group.getUserList());
        /// </code>
        /// </summary>
        public JsString name;
        /// <summary>
        /// Optional configuration object that will be passed to the generated Store. Defaults to
        /// undefined.
        /// </summary>
        public JsObject storeConfig;
        /// <summary>
        /// The type configuration can be used when creating associations using a configuration object.
        /// Use 'hasMany' to create a HasMany association
        /// <code>associations: [{
        /// type: 'hasMany',
        /// model: 'User'
        /// }]
        /// </code>
        /// </summary>
        public JsString type;
        /// <summary>
        /// Creates a function that returns an Ext.data.Store which is configured to load a set of data filtered
        /// by the owner model's primary key - e.g. in a hasMany association where Group hasMany Users, this function
        /// returns a Store configured to return the filtered set of a single Group's Users.
        /// </summary>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div><p>The store-generating function</p>
        /// </div>
        /// </returns>
        private System.Delegate createStore(){return null;}
        /// <summary>
        /// Read associated data
        /// </summary>
        /// <param name="record"><p>The record we're writing to</p>
        /// </param>
        /// <param name="reader"><p>The reader for the associated model</p>
        /// </param>
        /// <param name="associationData"><p>The raw associated data</p>
        /// </param>
        private void read(Ext.data.Model record, Ext.data.reader.Reader reader, object associationData){}
        public HasMany(HasManyConfig config){}
        public HasMany(){}
        public HasMany(params object[] args){}
    }
    #endregion
    #region HasManyConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class HasManyConfig : AssociationConfig
    {
        /// <summary>
        /// True to automatically load the related store from a remote source when instantiated.
        /// Defaults to false.
        /// </summary>
        public bool autoLoad;
        /// <summary>
        /// Optionally overrides the default filter that is set up on the associated Store. If
        /// this is not set, a filter is automatically created which filters the association based on the configured
        /// foreignKey. See intro docs for more details. Defaults to undefined
        /// </summary>
        public JsString filterProperty;
        /// <summary>
        /// The name of the foreign key on the associated model that links it to the owner
        /// model. Defaults to the lowercased name of the owner model plus "_id", e.g. an association with a where a
        /// model called Group hasMany Users would create 'group_id' as the foreign key. When the remote store is loaded,
        /// the store is automatically filtered so that only records with a matching foreign key are included in the
        /// resulting child store. This can be overridden by specifying the filterProperty.
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('Group', {
        /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
        /// fields: ['id', 'name'],
        /// hasMany: 'User'
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('User', {
        /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
        /// fields: ['id', 'name', 'group_id'], // refers to the id of the group that this user belongs to
        /// belongsTo: 'Group'
        /// });
        /// </code>
        /// </summary>
        public JsString foreignKey;
        /// <summary>
        /// The name of the function to create on the owner model to retrieve the child store.
        /// If not specified, the pluralized name of the child model is used.
        /// <code>// This will create a users() method on any Group model instance
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('Group', {
        /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
        /// fields: ['id', 'name'],
        /// hasMany: 'User'
        /// });
        /// var group = new Group();
        /// console.log(group.users());
        /// // The method to retrieve the users will now be getUserList
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('Group', {
        /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
        /// fields: ['id', 'name'],
        /// hasMany: {model: 'User', name: 'getUserList'}
        /// });
        /// var group = new Group();
        /// console.log(group.getUserList());
        /// </code>
        /// </summary>
        public JsString name;
        /// <summary>
        /// Optional configuration object that will be passed to the generated Store. Defaults to
        /// undefined.
        /// </summary>
        public JsObject storeConfig;
        /// <summary>
        /// The type configuration can be used when creating associations using a configuration object.
        /// Use 'hasMany' to create a HasMany association
        /// <code>associations: [{
        /// type: 'hasMany',
        /// model: 'User'
        /// }]
        /// </code>
        /// </summary>
        public JsString type;
        public HasManyConfig(params object[] args){}
    }
    #endregion
    #region HasManyEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class HasManyEvents : AssociationEvents
    {
        public HasManyEvents(params object[] args){}
    }
    #endregion
}
#endregion