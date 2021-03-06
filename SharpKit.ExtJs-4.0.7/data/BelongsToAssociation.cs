//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data
namespace Ext.data
{
    #region BelongsToAssociation
    /// <summary>
    /// Represents a many to one association with another model. The owner model is expected to have
    /// a foreign key which references the primary key of the associated model: Ext.define(&#39;Category&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [
    /// {name: &#39;id&#39;,   type: &#39;int&#39;},
    /// {name: &#39;name&#39;, type: &#39;string&#39;}
    /// ]
    /// });
    /// Ext.define(&#39;Product&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [
    /// {name: &#39;id&#39;,          type: &#39;int&#39;},
    /// {name: &#39;category_id&#39;, type: &#39;int&#39;},
    /// {name: &#39;name&#39;,        type: &#39;string&#39;}
    /// ],
    /// // we can use the belongsTo shortcut on the model to create a belongsTo association
    /// belongsTo: {type: &#39;belongsTo&#39;, model: &#39;Category&#39;}
    /// });
    /// In the example above we have created models for Products and Categories, and linked them together
    /// by saying that each Product belongs to a Category. This automatically links each Product to a Category
    /// based on the Product&#39;s category_id, and provides new functions on the Product model: Generated getter function The first function that is added to the owner model is a getter function: var product = new Product({
    /// id: 100,
    /// category_id: 20,
    /// name: &#39;Sneakers&#39;
    /// });
    /// product.getCategory(function(category, operation) {
    /// //do something with the category object
    /// alert(category.get(&#39;id&#39;)); //alerts 20
    /// }, this);
    /// The getCategory function was created on the Product model when we defined the association. This uses the
    /// Category&#39;s configured proxy to load the Category asynchronously, calling the provided
    /// callback when it has loaded. The new getCategory function will also accept an object containing success, failure and callback properties
    /// - callback will always be called, success will only be called if the associated model was loaded successfully
    /// and failure will only be called if the associatied model could not be loaded: product.getCategory({
    /// callback: function(category, operation) {}, //a function that will always be called
    /// success : function(category, operation) {}, //a function that will only be called if the load succeeded
    /// failure : function(category, operation) {}, //a function that will only be called if the load did not succeed
    /// scope   : this //optionally pass in a scope object to execute the callbacks in
    /// });
    /// In each case above the callbacks are called with two arguments - the associated model instance and the
    /// operation object that was executed to load that instance. The Operation object is
    /// useful when the instance could not be loaded. Generated setter function The second generated function sets the associated model instance - if only a single argument is passed to
    /// the setter then the following two calls are identical: //this call
    /// product.setCategory(10);
    /// //is equivalent to this call:
    /// product.set(&#39;category_id&#39;, 10);
    /// If we pass in a second argument, the model will be automatically saved and the second argument passed to
    /// the owner model&#39;s save method: product.setCategory(10, function(product, operation) {
    /// //the product has been saved
    /// alert(product.get(&#39;category_id&#39;)); //now alerts 10
    /// });
    /// //alternative syntax:
    /// product.setCategory(10, {
    /// callback: function(product, operation), //a function that will always be called
    /// success : function(product, operation), //a function that will only be called if the load succeeded
    /// failure : function(product, operation), //a function that will only be called if the load did not succeed
    /// scope   : this //optionally pass in a scope object to execute the callbacks in
    /// })
    /// Customisation Associations reflect on the models they are linking to automatically set up properties such as the
    /// primaryKey and foreignKey. These can alternatively be specified: Ext.define(&#39;Product&#39;, {
    /// fields: [...],
    /// associations: [
    /// {type: &#39;belongsTo&#39;, model: &#39;Category&#39;, primaryKey: &#39;unique_id&#39;, foreignKey: &#39;cat_id&#39;}
    /// ]
    /// });
    /// Here we replaced the default primary key (defaults to &#39;id&#39;) and foreign key (calculated as &#39;category_id&#39;)
    /// with our own settings. Usually this will not be needed.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class BelongsToAssociation : Association
    {
        public BelongsToAssociation(BelongsToAssociationConfig config) : base(null){}
        public BelongsToAssociation() : base(null){}
    }
    #endregion
    #region BelongsToAssociationConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class BelongsToAssociationConfig : AssociationConfig
    {
        /// <summary>
        /// The name of the foreign key on the owner model that links it to the associated
        /// model. ...
        /// </summary>
        public JsString foreignKey{get;set;}
        /// <summary>
        /// The name of the getter function that will be added to the local model's prototype. ...
        /// </summary>
        public JsString getterName{get;set;}
        /// <summary>
        /// The name of the setter function that will be added to the local model's prototype. ...
        /// </summary>
        public JsString setterName{get;set;}
        /// <summary>
        /// The type configuration can be used when creating associations using a configuration object. ...
        /// </summary>
        public JsString type{get;set;}
    }
    #endregion
    #region BelongsToAssociationEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class BelongsToAssociationEvents : AssociationEvents
    {
    }
    #endregion
}
#endregion
