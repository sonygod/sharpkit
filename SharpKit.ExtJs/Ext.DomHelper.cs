//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext
{
    #region DomHelper
    /// <inheritdocs />
    /// <summary>
    /// <p>The DomHelper class provides a layer of abstraction from DOM and transparently supports creating elements via DOM or
    /// using HTML fragments. It also has the ability to create HTML fragment templates from your DOM building code.</p>
    /// <h1>DomHelper element specification object</h1>
    /// <p>A specification object is used when creating elements. Attributes of this object are assumed to be element
    /// attributes, except for 4 special attributes:</p>
    /// <ul>
    /// <li><strong>tag</strong> - The tag name of the element.</li>
    /// <li><strong>children</strong> or <strong>cn</strong> - An array of the same kind of element definition objects to be created and appended.
    /// These can be nested as deep as you want.</li>
    /// <li><strong>cls</strong> - The class attribute of the element. This will end up being either the "class" attribute on a HTML
    /// fragment or className for a DOM node, depending on whether DomHelper is using fragments or DOM.</li>
    /// <li><strong>html</strong> - The innerHTML for the element.</li>
    /// </ul>
    /// <p><strong>NOTE:</strong> For other arbitrary attributes, the value will currently <strong>not</strong> be automatically HTML-escaped prior to
    /// building the element's HTML string. This means that if your attribute value contains special characters that would
    /// not normally be allowed in a double-quoted attribute value, you <strong>must</strong> manually HTML-encode it beforehand (see
    /// <see cref="Ext.String.htmlEncode">Ext.String.htmlEncode</see>) or risk malformed HTML being created. This behavior may change in a future release.</p>
    /// <h1>Insertion methods</h1>
    /// <p>Commonly used insertion methods:</p>
    /// <ul>
    /// <li><strong><see cref="Ext.DomHelper.append">append</see></strong></li>
    /// <li><strong><see cref="Ext.DomHelper.insertBefore">insertBefore</see></strong></li>
    /// <li><strong><see cref="Ext.DomHelper.insertAfter">insertAfter</see></strong></li>
    /// <li><strong><see cref="Ext.DomHelper.overwrite">overwrite</see></strong></li>
    /// <li><strong><see cref="Ext.DomHelper.createTemplate">createTemplate</see></strong></li>
    /// <li><strong><see cref="Ext.DomHelper.insertHtml">insertHtml</see></strong></li>
    /// </ul>
    /// <h1>Example</h1>
    /// <p>This is an example, where an unordered list with 3 children items is appended to an existing element with
    /// id 'my-div':</p>
    /// <pre><code>var dh = <see cref="Ext.DomHelper">Ext.DomHelper</see>; // create shorthand alias
    /// // specification object
    /// var spec = {
    /// id: 'my-ul',
    /// tag: 'ul',
    /// cls: 'my-list',
    /// // append children after creating
    /// children: [     // may also specify 'cn' instead of 'children'
    /// {tag: 'li', id: 'item0', html: 'List Item 0'},
    /// {tag: 'li', id: 'item1', html: 'List Item 1'},
    /// {tag: 'li', id: 'item2', html: 'List Item 2'}
    /// ]
    /// };
    /// var list = dh.append(
    /// 'my-div', // the context element 'my-div' can either be the id or the actual node
    /// spec      // the specification object
    /// );
    /// </code></pre>
    /// <p>Element creation specification parameters in this class may also be passed as an Array of specification objects. This
    /// can be used to insert multiple sibling nodes into an existing container very efficiently. For example, to add more
    /// list items to the example above:</p>
    /// <pre><code>dh.append('my-ul', [
    /// {tag: 'li', id: 'item3', html: 'List Item 3'},
    /// {tag: 'li', id: 'item4', html: 'List Item 4'}
    /// ]);
    /// </code></pre>
    /// <h1>Templating</h1>
    /// <p>The real power is in the built-in templating. Instead of creating or appending any elements, <see cref="Ext.DomHelper.createTemplate">createTemplate</see>
    /// returns a Template object which can be used over and over to insert new elements. Revisiting the example above, we
    /// could utilize templating this time:</p>
    /// <pre><code>// create the node
    /// var list = dh.append('my-div', {tag: 'ul', cls: 'my-list'});
    /// // get template
    /// var tpl = dh.createTemplate({tag: 'li', id: 'item{0}', html: 'List Item {0}'});
    /// for(var i = 0; i &lt; 5, i++){
    /// tpl.append(list, [i]); // use template to append to the actual node
    /// }
    /// </code></pre>
    /// <p>An example using a template:</p>
    /// <pre><code>var html = '&lt;a id="{0}" href="{1}" class="nav"&gt;{2}&lt;/a&gt;';
    /// var tpl = new <see cref="Ext.DomHelper.createTemplate">Ext.DomHelper.createTemplate</see>(html);
    /// tpl.append('blog-roll', ['link1', 'http://www.edspencer.net/', "Ed's Site"]);
    /// tpl.append('blog-roll', ['link2', 'http://www.dustindiaz.com/', "Dustin's Site"]);
    /// </code></pre>
    /// <p>The same example using named parameters:</p>
    /// <pre><code>var html = '&lt;a id="{id}" href="{url}" class="nav"&gt;{text}&lt;/a&gt;';
    /// var tpl = new <see cref="Ext.DomHelper.createTemplate">Ext.DomHelper.createTemplate</see>(html);
    /// tpl.append('blog-roll', {
    /// id: 'link1',
    /// url: 'http://www.edspencer.net/',
    /// text: "Ed's Site"
    /// });
    /// tpl.append('blog-roll', {
    /// id: 'link2',
    /// url: 'http://www.dustindiaz.com/',
    /// text: "Dustin's Site"
    /// });
    /// </code></pre>
    /// <h1>Compiling Templates</h1>
    /// <p>Templates are applied using regular expressions. The performance is great, but if you are adding a bunch of DOM
    /// elements using the same template, you can increase performance even further by <see cref="Ext.Template.compile">&quot;compiling&quot;</see> the template. The way "<see cref="Ext.Template.compile">compile()</see>" works is the template is parsed and
    /// broken up at the different variable points and a dynamic function is created and eval'ed. The generated function
    /// performs string concatenation of these parts and the passed variables instead of using regular expressions.</p>
    /// <pre><code>var html = '&lt;a id="{id}" href="{url}" class="nav"&gt;{text}&lt;/a&gt;';
    /// var tpl = new <see cref="Ext.DomHelper.createTemplate">Ext.DomHelper.createTemplate</see>(html);
    /// tpl.compile();
    /// //... use template like normal
    /// </code></pre>
    /// <h1>Performance Boost</h1>
    /// <p>DomHelper will transparently create HTML fragments when it can. Using HTML fragments instead of DOM can significantly
    /// boost performance.</p>
    /// <p>Element creation specification parameters may also be strings. If <see cref="Ext.DomHelper.useDom">useDom</see> is false, then the string is used
    /// as innerHTML. If <see cref="Ext.DomHelper.useDom">useDom</see> is true, a string specification results in the creation of a text node. Usage:</p>
    /// <pre><code><see cref="Ext.DomHelper.useDom">Ext.DomHelper.useDom</see> = true; // force it to use DOM; reduces performance
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class DomHelper : Ext.dom.Helper
    {
        /// <summary>
        /// Defaults to: <c>&quot;Ext.Base&quot;</c>
        /// </summary>
        [JsProperty(Name="$className")]
        private static JsString @className{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject configMap{get;set;}
        /// <summary>
        /// Defaults to: <c>[]</c>
        /// </summary>
        private static JsArray initConfigList{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject initConfigMap{get;set;}
        /// <summary>
        /// Defaults to: <c>true</c>
        /// </summary>
        private static bool isInstance{get;set;}
        /// <summary>
        /// Get the reference to the current class from which this object was instantiated. Unlike statics,
        /// this.self is scope-dependent and it's meant to be used for dynamic inheritance. See statics
        /// for a detailed comparison
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// alert(this.self.speciesName); // dependent on 'this'
        /// },
        /// clone: function() {
        /// return new this.self();
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'         // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// }
        /// });
        /// var cat = new My.Cat();                     // alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard();     // alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));             // alerts 'My.SnowLeopard'
        /// </code>
        /// </summary>
        protected static Class self{get;set;}
        /// <summary>
        /// True to force the use of DOM instead of html fragments.
        /// Defaults to: <c>false</c>
        /// </summary>
        public static bool useDom{get;set;}
        /// <summary>
        /// Creates new DOM element(s) and appends them to el.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="o"><p>The DOM object spec (and children) or raw HTML blob</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see></p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public static object append(object el, object o, object returnElement=null){return null;}
        /// <summary>
        /// Applies a style specification to an element.
        /// </summary>
        /// <param name="el"><p>The element to apply styles to</p>
        /// </param>
        /// <param name="styles"><p>A style specification string e.g. 'width:100px', or object in the form {width:'100px'}, or
        /// a function which returns such a specification.</p>
        /// </param>
        public static void applyStyles(object el, object styles){}
        /// <summary>
        /// Call the original method that was previously overridden with override
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// constructor: function() {
        /// alert("I'm a cat!");
        /// }
        /// });
        /// My.Cat.override({
        /// constructor: function() {
        /// alert("I'm going to be a cat!");
        /// this.callOverridden();
        /// alert("Meeeeoooowwww");
        /// }
        /// });
        /// var kitty = new My.Cat(); // alerts "I'm going to be a cat!"
        /// // alerts "I'm a cat!"
        /// // alerts "Meeeeoooowwww"
        /// </code>
        /// <p>This method has been <strong>deprecated</strong> </p>
        /// <p>as of 4.1. Use <see cref="Ext.Base.callParent">callParent</see> instead.</p>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callOverridden(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the overridden method</p>
        /// </div>
        /// </returns>
        protected static object callOverridden(object args=null){return null;}
        /// <summary>
        /// Call the "parent" method of the current method. That is the method previously
        /// overridden by derivation or by an override (see Ext.define).
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Base', {
        /// constructor: function (x) {
        /// this.x = x;
        /// },
        /// statics: {
        /// method: function (x) {
        /// return x;
        /// }
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived', {
        /// extend: 'My.Base',
        /// constructor: function () {
        /// this.callParent([21]);
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // alerts 21
        /// </code>
        /// This can be used with an override as follows:
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.DerivedOverride', {
        /// override: 'My.Derived',
        /// constructor: function (x) {
        /// this.callParent([x*2]); // calls original My.Derived constructor
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // now alerts 42
        /// </code>
        /// This also works with static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2', {
        /// extend: 'My.Base',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Base.method
        /// }
        /// }
        /// });
        /// alert(My.Base.method(10);     // alerts 10
        /// alert(My.Derived2.method(10); // alerts 20
        /// </code>
        /// Lastly, it also works with overridden static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2Override', {
        /// override: 'My.Derived2',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Derived2.method
        /// }
        /// }
        /// });
        /// alert(My.Derived2.method(10); // now alerts 40
        /// </code>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callParent(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the parent method</p>
        /// </div>
        /// </returns>
        protected static object callParent(object args=null){return null;}
        /// <summary>
        /// </summary>
        private static void configClass(){}
        /// <summary>
        /// Fix for IE9 createContextualFragment missing method
        /// </summary>
        /// <param name="html">
        /// </param>
        private static void createContextualFragment(object html){}
        /// <summary>
        /// Creates new DOM element(s) without inserting them to the document.
        /// </summary>
        /// <param name="o"><p>The DOM object spec (and children) or raw HTML blob</p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement</span><div><p>The new uninserted node</p>
        /// </div>
        /// </returns>
        public static JsObject createDom(object o){return null;}
        /// <summary>
        /// Alias for markup.
        /// Returns the markup for the passed Element(s) config.
        /// </summary>
        /// <param name="spec"><p>The DOM object spec (and children)</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div>
        /// </div>
        /// </returns>
        public static JsString createHtml(object spec){return null;}
        /// <summary>
        /// Creates a new Ext.Template from the DOM object spec.
        /// </summary>
        /// <param name="o"><p>The DOM object spec (and children)</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Template">Ext.Template</see></span><div><p>The new template</p>
        /// </div>
        /// </returns>
        public static Ext.Template createTemplate(object o){return null;}
        /// <summary>
        /// Overrides: <see cref="Ext.AbstractComponent.destroy">Ext.AbstractComponent.destroy</see>, <see cref="Ext.AbstractPlugin.destroy">Ext.AbstractPlugin.destroy</see>, <see cref="Ext.layout.Layout.destroy">Ext.layout.Layout.destroy</see>
        /// </summary>
        private static void destroy(){}
        /// <summary>
        /// Converts the styles from the given object to text. The styles are CSS style names
        /// with their associated value.
        /// The basic form of this method returns a string:
        /// <code> var s = <see cref="Ext.DomHelper.generateStyles">Ext.DomHelper.generateStyles</see>({
        /// backgroundColor: 'red'
        /// });
        /// // s = 'background-color:red;'
        /// </code>
        /// Alternatively, this method can append to an output array.
        /// <code> var buf = [];
        /// ...
        /// <see cref="Ext.DomHelper.generateStyles">Ext.DomHelper.generateStyles</see>({
        /// backgroundColor: 'red'
        /// }, buf);
        /// </code>
        /// In this case, the style text is pushed on to the array and the array is returned.
        /// </summary>
        /// <param name="styles"><p>The object describing the styles.</p>
        /// </param>
        /// <param name="buffer"><p>The output buffer.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see>/<see cref="String">String</see>[]</span><div><p>If buffer is passed, it is returned. Otherwise the style
        /// string is returned.</p>
        /// </div>
        /// </returns>
        public static object[] generateStyles(object styles, object buffer=null){return null;}
        /// <summary>
        /// Parameters<li><span>name</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="name">
        /// </param>
        private static void getConfig(object name){}
        /// <summary>
        /// Returns the initial configuration passed to constructor when instantiating
        /// this class.
        /// </summary>
        /// <param name="name"><p>Name of the config option to return.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see>/Mixed</span><div><p>The full config object or a single config value
        /// when <c>name</c> parameter specified.</p>
        /// </div>
        /// </returns>
        public static object getInitialConfig(object name=null){return null;}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        private static void hasConfig(object config){}
        /// <summary>
        /// Initialize configuration for this class. a typical example:
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.awesome.Class', {
        /// // The default config
        /// config: {
        /// name: 'Awesome',
        /// isAwesome: true
        /// },
        /// constructor: function(config) {
        /// this.initConfig(config);
        /// }
        /// });
        /// var awesome = new My.awesome.Class({
        /// name: 'Super Awesome'
        /// });
        /// alert(awesome.getName()); // 'Super Awesome'
        /// </code>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Base">Ext.Base</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        protected static Ext.Base initConfig(object config){return null;}
        /// <summary>
        /// Creates new DOM element(s) and inserts them after el.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="o"><p>The DOM object spec (and children)</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see></p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public static object insertAfter(object el, object o, object returnElement=null){return null;}
        /// <summary>
        /// Creates new DOM element(s) and inserts them before el.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="o"><p>The DOM object spec (and children) or raw HTML blob</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see></p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public static object insertBefore(object el, object o, object returnElement=null){return null;}
        /// <summary>
        /// Creates new DOM element(s) and inserts them as the first child of el.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="o"><p>The DOM object spec (and children) or raw HTML blob</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see></p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public static object insertFirst(object el, object o, object returnElement=null){return null;}
        /// <summary>
        /// Inserts an HTML fragment into the DOM.
        /// </summary>
        /// <param name="where"><p>Where to insert the html in relation to el - beforeBegin, afterBegin, beforeEnd, afterEnd.</p>
        /// <p>For example take the following HTML: <c>&lt;div&gt;Contents&lt;/div&gt;</c></p>
        /// <p>Using different <c>where</c> values inserts element to the following places:</p>
        /// <ul>
        /// <li>beforeBegin: <c>&lt;HERE&gt;&lt;div&gt;Contents&lt;/div&gt;</c></li>
        /// <li>afterBegin: <c>&lt;div&gt;&lt;HERE&gt;Contents&lt;/div&gt;</c></li>
        /// <li>beforeEnd: <c>&lt;div&gt;Contents&lt;HERE&gt;&lt;/div&gt;</c></li>
        /// <li>afterEnd: <c>&lt;div&gt;Contents&lt;/div&gt;&lt;HERE&gt;</c></li>
        /// </ul>
        /// </param>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="html"><p>The HTML fragment</p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement</span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public static JsObject insertHtml(object where, object el, JsString html){return null;}
        /// <summary>
        /// Nasty code for IE's broken table implementation
        /// </summary>
        /// <param name="tag">
        /// </param>
        /// <param name="where">
        /// </param>
        /// <param name="destinationEl">
        /// </param>
        /// <param name="html">
        /// </param>
        private static void insertIntoTable(object tag, object where, object destinationEl, object html){}
        /// <summary>
        /// Returns the markup for the passed Element(s) config.
        /// </summary>
        /// <param name="spec"><p>The DOM object spec (and children)</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div>
        /// </div>
        /// </returns>
        public static JsString markup(object spec){return null;}
        /// <summary>
        /// Parameters<li><span>names</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>callback</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="names">
        /// </param>
        /// <param name="callback">
        /// </param>
        /// <param name="scope">
        /// </param>
        private static void onConfigUpdate(object names, object callback, object scope){}
        /// <summary>
        /// Creates new DOM element(s) and overwrites the contents of el with them.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="o"><p>The DOM object spec (and children) or raw HTML blob</p>
        /// </param>
        /// <param name="returnElement"><p>true to return an <see cref="Ext.dom.Element">Ext.Element</see></p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node</p>
        /// </div>
        /// </returns>
        public static object overwrite(object el, object o, object returnElement=null){return null;}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>applyIfNotSet</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <param name="applyIfNotSet">
        /// </param>
        private static void setConfig(object config, object applyIfNotSet){}
        /// <summary>
        /// Get the reference to the class from which this object was instantiated. Note that unlike self,
        /// this.statics() is scope-independent and it always returns the class from which it was called, regardless of what
        /// this points to during run-time
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// totalCreated: 0,
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// var statics = this.statics();
        /// alert(statics.speciesName);     // always equals to 'Cat' no matter what 'this' refers to
        /// // equivalent to: My.Cat.speciesName
        /// alert(this.self.speciesName);   // dependent on 'this'
        /// statics.totalCreated++;
        /// },
        /// clone: function() {
        /// var cloned = new this.self;                      // dependent on 'this'
        /// cloned.groupName = this.statics().speciesName;   // equivalent to: My.Cat.speciesName
        /// return cloned;
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'     // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// },
        /// constructor: function() {
        /// this.callParent();
        /// }
        /// });
        /// var cat = new My.Cat();                 // alerts 'Cat', then alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard(); // alerts 'Cat', then alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));         // alerts 'My.SnowLeopard'
        /// alert(clone.groupName);                 // alerts 'Cat'
        /// alert(My.Cat.totalCreated);             // alerts 3
        /// </code>
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.Class">Ext.Class</see></span><div>
        /// </div>
        /// </returns>
        protected static Class statics(){return null;}
        public DomHelper(DomHelperConfig config){}
        public DomHelper(){}
        public DomHelper(params object[] args){}
    }
    #endregion
    #region DomHelperConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DomHelperConfig : Ext.dom.HelperConfig
    {
        public DomHelperConfig(params object[] args){}
    }
    #endregion
    #region DomHelperEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DomHelperEvents : Ext.dom.HelperEvents
    {
        public DomHelperEvents(params object[] args){}
    }
    #endregion
}
