//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext
{
    #region Loader
    /// <summary>
    /// <p><see cref="Ext.Loader">Ext.Loader</see> is the heart of the new dynamic dependency loading capability in Ext JS 4+. It is most commonly used
    /// via the <see cref="Ext.ExtContext.require">Ext.require</see> shorthand. <see cref="Ext.Loader">Ext.Loader</see> supports both asynchronous and synchronous loading
    /// approaches, and leverage their advantages for the best development flow. We'll discuss about the pros and cons of each approach:</p>
    /// <h1>Asynchronous Loading</h1>
    /// <ul>
    /// <li><p>Advantages:</p>
    /// <ul>
    /// <li>Cross-domain</li>
    /// <li>No web server needed: you can run the application via the file system protocol (i.e: <code>file://path/to/your/index
    /// .html</code>)</li>
    /// <li>Best possible debugging experience: error messages come with the exact file name and line number</li>
    /// </ul>
    /// </li>
    /// <li><p>Disadvantages:</p>
    /// <ul>
    /// <li>Dependencies need to be specified before-hand</li>
    /// </ul>
    /// </li>
    /// </ul>
    /// <h3>Method 1: Explicitly include what you need:</h3>
    /// <pre><code>// Syntax
    /// <see cref="Ext.ExtContext.require">Ext.require</see>({String/Array} expressions);
    /// // Example: Single alias
    /// <see cref="Ext.ExtContext.require">Ext.require</see>('widget.window');
    /// // Example: Single class name
    /// <see cref="Ext.ExtContext.require">Ext.require</see>('<see cref="Ext.window.Window">Ext.window.Window</see>');
    /// // Example: Multiple aliases / class names mix
    /// <see cref="Ext.ExtContext.require">Ext.require</see>(['widget.window', 'layout.border', '<see cref="Ext.data.Connection">Ext.data.Connection</see>']);
    /// // Wildcards
    /// <see cref="Ext.ExtContext.require">Ext.require</see>(['widget.*', 'layout.*', 'Ext.data.*']);
    /// </code></pre>
    /// <h3>Method 2: Explicitly exclude what you don't need:</h3>
    /// <pre><code>// Syntax: Note that it must be in this chaining format.
    /// <see cref="Ext.ExtContext.exclude">Ext.exclude</see>({String/Array} expressions)
    /// .require({String/Array} expressions);
    /// // Include everything except Ext.data.*
    /// <see cref="Ext.ExtContext.exclude">Ext.exclude</see>('Ext.data.*').require('*');
    /// // Include all widgets except widget.checkbox*,
    /// // which will match widget.checkbox, widget.checkboxfield, widget.checkboxgroup, etc.
    /// <see cref="Ext.ExtContext.exclude">Ext.exclude</see>('widget.checkbox*').require('widget.*');
    /// </code></pre>
    /// <h1>Synchronous Loading on Demand</h1>
    /// <ul>
    /// <li><p>Advantages:</p>
    /// <ul>
    /// <li>There's no need to specify dependencies before-hand, which is always the convenience of including ext-all.js
    /// before</li>
    /// </ul>
    /// </li>
    /// <li><p>Disadvantages:</p>
    /// <ul>
    /// <li>Not as good debugging experience since file name won't be shown (except in Firebug at the moment)</li>
    /// <li>Must be from the same domain due to XHR restriction</li>
    /// <li>Need a web server, same reason as above</li>
    /// </ul>
    /// </li>
    /// </ul>
    /// <p>There's one simple rule to follow: Instantiate everything with <see cref="Ext.ExtContext.create">Ext.create</see> instead of the <c>new</c> keyword</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('widget.window', { ... }); // Instead of new <see cref="Ext.window.Window">Ext.window.Window</see>({...});
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.window.Window">Ext.window.Window</see>', {}); // Same as above, using full class name instead of alias
    /// <see cref="Ext.ExtContext.widget">Ext.widget</see>('window', {}); // Same as above, all you need is the traditional `xtype`
    /// </code></pre>
    /// <p>Behind the scene, <see cref="Ext.ClassManager">Ext.ClassManager</see> will automatically check whether the given class name / alias has already
    /// existed on the page. If it's not, <see cref="Ext.Loader">Ext.Loader</see> will immediately switch itself to synchronous mode and automatic load the given
    /// class and all its dependencies.</p>
    /// <h1>Hybrid Loading - The Best of Both Worlds</h1>
    /// <p>It has all the advantages combined from asynchronous and synchronous loading. The development flow is simple:</p>
    /// <h3>Step 1: Start writing your application using synchronous approach.</h3>
    /// <p><see cref="Ext.Loader">Ext.Loader</see> will automatically fetch all dependencies on demand as they're needed during run-time. For example:</p>
    /// <pre><code><see cref="Ext.ExtContext.onReady">Ext.onReady</see>(function(){
    /// var window = <see cref="Ext.ExtContext.widget">Ext.widget</see>('window', {
    /// width: 500,
    /// height: 300,
    /// layout: {
    /// type: 'border',
    /// padding: 5
    /// },
    /// title: 'Hello Dialog',
    /// items: [{
    /// title: 'Navigation',
    /// collapsible: true,
    /// region: 'west',
    /// width: 200,
    /// html: 'Hello',
    /// split: true
    /// }, {
    /// title: 'TabPanel',
    /// region: 'center'
    /// }]
    /// });
    /// window.show();
    /// })
    /// </code></pre>
    /// <h3>Step 2: Along the way, when you need better debugging ability, watch the console for warnings like these:</h3>
    /// <pre><code>[<see cref="Ext.Loader">Ext.Loader</see>] Synchronously loading '<see cref="Ext.window.Window">Ext.window.Window</see>'; consider adding <see cref="Ext.ExtContext.require">Ext.require</see>('<see cref="Ext.window.Window">Ext.window.Window</see>') before your application's code
    /// ClassManager.js:432
    /// [<see cref="Ext.Loader">Ext.Loader</see>] Synchronously loading '<see cref="Ext.layout.container.Border">Ext.layout.container.Border</see>'; consider adding <see cref="Ext.ExtContext.require">Ext.require</see>('<see cref="Ext.layout.container.Border">Ext.layout.container.Border</see>') before your application's code
    /// </code></pre>
    /// <p>Simply copy and paste the suggested code above <c><see cref="Ext.ExtContext.onReady">Ext.onReady</see></c>, i.e:</p>
    /// <pre><code><see cref="Ext.ExtContext.require">Ext.require</see>('<see cref="Ext.window.Window">Ext.window.Window</see>');
    /// <see cref="Ext.ExtContext.require">Ext.require</see>('<see cref="Ext.layout.container.Border">Ext.layout.container.Border</see>');
    /// <see cref="Ext.ExtContext.onReady">Ext.onReady</see>(...);
    /// </code></pre>
    /// <p>Everything should now load via asynchronous mode.</p>
    /// <h1>Deployment</h1>
    /// <p>It's important to note that dynamic loading should only be used during development on your local machines.
    /// During production, all dependencies should be combined into one single JavaScript file. <see cref="Ext.Loader">Ext.Loader</see> makes
    /// the whole process of transitioning from / to between development / maintenance and production as easy as
    /// possible. Internally <see cref="Ext.Loader.history">Ext.Loader.history</see> maintains the list of all dependencies your application
    /// needs in the exact loading sequence. It's as simple as concatenating all files in this array into one,
    /// then include it on top of your application.</p>
    /// <p>This process will be automated with Sencha Command, to be released and documented towards Ext JS 4 Final.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Loader
    {
        /// <summary>
        /// Appends current timestamp to script files to prevent caching.
        /// Defaults to: <c>true</c>
        /// </summary>
        public static bool disableCaching;
        /// <summary>
        /// The get parameter name for the cache buster's timestamp.
        /// Defaults to: <c>&quot;_dc&quot;</c>
        /// </summary>
        public static JsString disableCachingParam;
        /// <summary>
        /// Whether or not to enable the dynamic dependency loading feature.
        /// Defaults to: <c>false</c>
        /// </summary>
        public static bool enabled;
        /// <summary>
        /// True to prepare an asynchronous script tag for garbage collection (effective only
        /// if preserveScripts is false)
        /// Defaults to: <c>false</c>
        /// </summary>
        public static bool garbageCollect;
        /// <summary>
        /// The mapping from namespaces to file paths
        /// <code>{
        /// 'Ext': '.', // This is set by default, <see cref="Ext.layout.container.Container">Ext.layout.container.Container</see> will be
        /// // loaded from ./layout/Container.js
        /// 'My': './src/my_own_folder' // My.layout.Container will be loaded from
        /// // ./src/my_own_folder/layout/Container.js
        /// }
        /// </code>
        /// Note that all relative paths are relative to the current HTML document.
        /// If not being specified, for example, <c>Other.awesome.Class</c>
        /// will simply be loaded from <c>./Other/awesome/Class.js</c>
        /// Defaults to: <c>{&quot;Ext&quot;: &quot;.&quot;}</c>
        /// </summary>
        public static JsObject paths;
        /// <summary>
        /// False to remove and optionally garbage-collect asynchronously loaded scripts,
        /// True to retain script element for browser debugger compatibility and improved load performance.
        /// Defaults to: <c>true</c>
        /// </summary>
        public static bool preserveScripts;
        /// <summary>
        /// millisecond delay between asynchronous script injection (prevents stack overflow on some user agents)
        /// 'false' disables delay but potentially increases stack load.
        /// Defaults to: <c>false</c>
        /// </summary>
        public static bool scriptChainDelay;
        /// <summary>
        /// Optional charset to specify encoding of dynamic script content.
        /// </summary>
        public static JsString scriptCharset;
        /// <summary>
        /// </summary>
        private static JsObject classNameToFilePathMap{get;set;}
        /// <summary>
        /// Configuration
        /// </summary>
        private static JsObject config{get;set;}
        /// <summary>
        /// </summary>
        private static JsObject documentHead{get;set;}
        /// <summary>
        /// Defaults to: <c>false</c>
        /// </summary>
        private static bool hasFileLoadError{get;set;}
        /// <summary>
        /// An array of class names to keep track of the dependency loading order.
        /// This is not guaranteed to be the same everytime due to the asynchronous
        /// nature of the Loader.
        /// </summary>
        public static JsArray history{get;set;}
        /// <summary>
        /// Maintain the list of files that have already been handled so that they never get double-loaded
        /// </summary>
        private static JsObject isClassFileLoaded{get;set;}
        /// <summary>
        /// </summary>
        private static JsObject isFileLoaded{get;set;}
        /// <summary>
        /// </summary>
        private static JsObject isInHistory{get;set;}
        /// <summary>
        /// Flag indicating whether there are still files being loaded
        /// Defaults to: <c>false</c>
        /// </summary>
        private static bool isLoading{get;set;}
        /// <summary>
        /// Defaults to: <c>0</c>
        /// </summary>
        private static JsNumber numLoadedFiles{get;set;}
        /// <summary>
        /// Defaults to: <c>0</c>
        /// </summary>
        private static JsNumber numPendingFiles{get;set;}
        /// <summary>
        /// Contains classes referenced in uses properties.
        /// </summary>
        private static JsObject optionalRequires{get;set;}
        /// <summary>
        /// Maintain the queue for all dependencies. Each item in the array is an object of the format:
        /// <code>{
        /// requires: [...], // The required classes for this queue item
        /// callback: function() { ... } // The function to execute when all classes specified in requires exist
        /// }
        /// </code>
        /// </summary>
        private static JsObject queue{get;set;}
        /// <summary>
        /// Maintain the list of listeners to execute when all required scripts are fully loaded
        /// </summary>
        private static JsObject readyListeners{get;set;}
        /// <summary>
        /// Map of fully qualified class names to an array of dependent classes.
        /// </summary>
        private static JsObject requiresMap{get;set;}
        /// <summary>
        /// The number of scripts loading via loadScript.
        /// Defaults to: <c>0</c>
        /// </summary>
        private static JsNumber scriptsLoading{get;set;}
        /// <summary>
        /// Defaults to: <c>false</c>
        /// </summary>
        private static bool syncModeEnabled{get;set;}
        /// <summary>
        /// Ensure that any classes referenced in the uses property are loaded.
        /// </summary>
        /// <param name="classes">
        /// </param>
        private static void addUsedClasses(object classes){}
        /// <summary>
        /// Parameters<li><span>script</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>remove</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>collect</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="script">
        /// </param>
        /// <param name="remove">
        /// </param>
        /// <param name="collect">
        /// </param>
        private static void cleanupScriptElement(object script, object remove, object collect){}
        /// <summary>
        /// Turns on or off the "cache buster" applied to dynamically loaded scripts. Normally
        /// dynamically loaded scripts have an extra query parameter appended to avoid stale
        /// cached scripts. This method can be used to disable this mechanism, and is primarily
        /// useful for testing. This is done using a cookie.
        /// </summary>
        /// <param name="disable"><p>True to disable the cache buster.</p>
        /// </param>
        /// <param name="path"><p>An optional path to scope the cookie.</p>
        /// <p>Defaults to: <c>&quot;/&quot;</c></p></param>
        private static void disableCacheBuster(bool disable, object path=null){}
        /// <summary>
        /// Explicitly exclude files from being loaded. Useful when used in conjunction with a broad include expression.
        /// Can be chained with more require and exclude methods, eg:
        /// <code><see cref="Ext.ExtContext.exclude">Ext.exclude</see>('Ext.data.*').require('*');
        /// <see cref="Ext.ExtContext.exclude">Ext.exclude</see>('widget.button*').require('widget.*');
        /// </code>
        /// </summary>
        /// <param name="excludes">
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>object contains <c>require</c> method for chaining</p>
        /// </div>
        /// </returns>
        public static object exclude(JsArray excludes){return null;}
        /// <summary>
        /// Get the config value corresponding to the specified name. If no name is given, will return the config object
        /// </summary>
        /// <param name="name"><p>The config property name</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public static object getConfig(JsString name){return null;}
        /// <summary>
        /// Translates a className to a file path by adding the
        /// the proper prefix and converting the .'s to /'s. For example:
        /// <code><see cref="Ext.Loader.setPath">Ext.Loader.setPath</see>('My', '/path/to/My');
        /// alert(<see cref="Ext.Loader.getPath">Ext.Loader.getPath</see>('My.awesome.Class')); // alerts '/path/to/My/awesome/Class.js'
        /// </code>
        /// Note that the deeper namespace levels, if explicitly set, are always resolved first. For example:
        /// <code><see cref="Ext.Loader.setPath">Ext.Loader.setPath</see>({
        /// 'My': '/path/to/lib',
        /// 'My.awesome': '/other/path/for/awesome/stuff',
        /// 'My.awesome.more': '/more/awesome/path'
        /// });
        /// alert(<see cref="Ext.Loader.getPath">Ext.Loader.getPath</see>('My.awesome.Class')); // alerts '/other/path/for/awesome/stuff/Class.js'
        /// alert(<see cref="Ext.Loader.getPath">Ext.Loader.getPath</see>('My.awesome.more.Class')); // alerts '/more/awesome/path/Class.js'
        /// alert(<see cref="Ext.Loader.getPath">Ext.Loader.getPath</see>('My.cool.Class')); // alerts '/path/to/lib/cool/Class.js'
        /// alert(<see cref="Ext.Loader.getPath">Ext.Loader.getPath</see>('Unknown.strange.Stuff')); // alerts 'Unknown/strange/Stuff.js'
        /// </code>
        /// </summary>
        /// <param name="className">
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>path</p>
        /// </div>
        /// </returns>
        public static JsString getPath(JsString className){return null;}
        /// <summary>
        /// Parameters<li><span>className</span> : <see cref="String">String</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="className">
        /// </param>
        private static void getPrefix(JsString className){}
        /// <summary>
        /// Parameters<li><span>className</span> : <see cref="String">String</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="className">
        /// </param>
        private static void historyPush(JsString className){}
        /// <summary>
        /// Inject a script element to document's head, call onLoad and onError accordingly
        /// </summary>
        /// <param name="url">
        /// </param>
        /// <param name="onLoad">
        /// </param>
        /// <param name="onError">
        /// </param>
        /// <param name="scope">
        /// </param>
        /// <param name="charset">
        /// </param>
        private static void injectScriptElement(object url, object onLoad, object onError, object scope, object charset){}
        /// <summary>
        /// Parameters<li><span>className</span> : <see cref="String">String</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="className">
        /// </param>
        private static void isAClassNameWithAKnownPrefix(JsString className){}
        /// <summary>
        /// Loads the specified script URL and calls the supplied callbacks. If this method
        /// is called before Ext.isReady, the script's load will delay the transition
        /// to ready. This can be used to load arbitrary scripts that may contain further
        /// Ext.require calls.
        /// </summary>
        /// <param name="options"><p>The options object or simply the URL to load.</p>
        /// <ul><li><span>url</span> : <see cref="String">String</see><div><p>The URL from which to load the script.</p>
        /// </div></li><li><span>onLoad</span> : <see cref="Function">Function</see> (optional)<div><p>The callback to call on successful load.</p>
        /// </div></li><li><span>onError</span> : <see cref="Function">Function</see> (optional)<div><p>The callback to call on failure to load.</p>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see> (optional)<div><p>The scope (<c>this</c>) for the supplied callbacks.</p>
        /// </div></li></ul></param>
        public static void loadScript(object options=null){}
        /// <summary>
        /// Load a script file, supports both asynchronous and synchronous approaches
        /// </summary>
        /// <param name="url">
        /// </param>
        /// <param name="onLoad">
        /// </param>
        /// <param name="onError">
        /// </param>
        /// <param name="scope">
        /// </param>
        /// <param name="synchronous">
        /// </param>
        private static void loadScriptFile(object url, object onLoad, object onError, object scope, object synchronous){}
        /// <summary>
        /// Parameters<li><span>className</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>filePath</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>errorMessage</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>isSynchronous</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="className">
        /// </param>
        /// <param name="filePath">
        /// </param>
        /// <param name="errorMessage">
        /// </param>
        /// <param name="isSynchronous">
        /// </param>
        private static void onFileLoadError(object className, object filePath, object errorMessage, object isSynchronous){}
        /// <summary>
        /// Parameters<li><span>className</span> : <see cref="String">String</see><div>
        /// </div></li><li><span>filePath</span> : <see cref="String">String</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="className">
        /// </param>
        /// <param name="filePath">
        /// </param>
        private static void onFileLoaded(JsString className, JsString filePath){}
        /// <summary>
        /// Add a new listener to be executed when all required scripts are fully loaded
        /// </summary>
        /// <param name="fn"><p>The function callback to be executed</p>
        /// </param>
        /// <param name="scope"><p>The execution scope (<c>this</c>) of the callback function</p>
        /// </param>
        /// <param name="withDomReady"><p>Whether or not to wait for document dom ready as well</p>
        /// </param>
        public static void onReady(System.Delegate fn, object scope, bool withDomReady){}
        /// <summary>
        /// Refresh all items in the queue. If all dependencies for an item exist during looping,
        /// it will execute the callback and call refreshQueue again. Triggers onReady when the queue is
        /// empty
        /// </summary>
        private static void refreshQueue(){}
        /// <summary>
        /// Parameters<li><span>url</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="url">
        /// </param>
        private static void removeScriptElement(object url){}
        /// <summary>
        /// Loads all classes by the given names and all their direct dependencies; optionally executes the given callback function when
        /// finishes, within the optional scope. This method is aliased by Ext.require for convenience
        /// </summary>
        /// <param name="expressions"><p>Can either be a string or an array of string</p>
        /// </param>
        /// <param name="fn"><p>The callback function</p>
        /// </param>
        /// <param name="scope"><p>The execution scope (<c>this</c>) of the callback function</p>
        /// </param>
        /// <param name="excludes"><p>Classes to be excluded, useful when being used with expressions</p>
        /// </param>
        public static void require(object expressions, System.Delegate fn=null, object scope=null, object excludes=null){}
        /// <summary>
        /// Set the configuration for the loader. This should be called right after ext-(debug).js
        /// is included in the page, and before Ext.onReady. i.e:
        /// <code>&lt;script type="text/javascript" src="ext-core-debug.js"&gt;&lt;/script&gt;
        /// &lt;script type="text/javascript"&gt;
        /// <see cref="Ext.Loader.setConfig">Ext.Loader.setConfig</see>({
        /// enabled: true,
        /// paths: {
        /// 'My': 'my_own_path'
        /// }
        /// });
        /// &lt;/script&gt;
        /// &lt;script type="text/javascript"&gt;
        /// <see cref="Ext.ExtContext.require">Ext.require</see>(...);
        /// <see cref="Ext.ExtContext.onReady">Ext.onReady</see>(function() {
        /// // application code here
        /// });
        /// &lt;/script&gt;
        /// </code>
        /// Refer to config options of <see cref="Ext.Loader">Ext.Loader</see> for the list of possible properties
        /// </summary>
        /// <param name="config"><p>The config object to override the default values</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Loader">Ext.Loader</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public static Loader setConfig(object config){return null;}
        /// <summary>
        /// Sets the path of a namespace.
        /// For Example:
        /// <code><see cref="Ext.Loader.setPath">Ext.Loader.setPath</see>('Ext', '.');
        /// </code>
        /// </summary>
        /// <param name="name"><p>See <see cref="Ext.Function.flexSetter">flexSetter</see></p>
        /// </param>
        /// <param name="path"><p>See <see cref="Ext.Function.flexSetter">flexSetter</see></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Loader">Ext.Loader</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public static Loader setPath(object name, JsString path){return null;}
        /// <summary>
        /// Synchronously loads all classes by the given names and all their direct dependencies; optionally executes the given callback function when finishes, within the optional scope. This method is aliased by Ext.syncRequire for convenience
        /// </summary>
        /// <param name="expressions"><p>Can either be a string or an array of string</p>
        /// </param>
        /// <param name="fn"><p>The callback function</p>
        /// </param>
        /// <param name="scope"><p>The execution scope (<c>this</c>) of the callback function</p>
        /// </param>
        /// <param name="excludes"><p>Classes to be excluded, useful when being used with expressions</p>
        /// </param>
        public static void syncRequire(object expressions, System.Delegate fn=null, object scope=null, object excludes=null){}
        /// <summary>
        /// </summary>
        private static void triggerReady(){}
        public Loader(LoaderConfig config){}
        public Loader(){}
        public Loader(params object[] args){}
    }
    #endregion
    #region LoaderConfig
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LoaderConfig
    {
        /// <summary>
        /// Appends current timestamp to script files to prevent caching.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool disableCaching;
        /// <summary>
        /// The get parameter name for the cache buster's timestamp.
        /// Defaults to: <c>&quot;_dc&quot;</c>
        /// </summary>
        public JsString disableCachingParam;
        /// <summary>
        /// Whether or not to enable the dynamic dependency loading feature.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool enabled;
        /// <summary>
        /// True to prepare an asynchronous script tag for garbage collection (effective only
        /// if preserveScripts is false)
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool garbageCollect;
        /// <summary>
        /// The mapping from namespaces to file paths
        /// <code>{
        /// 'Ext': '.', // This is set by default, <see cref="Ext.layout.container.Container">Ext.layout.container.Container</see> will be
        /// // loaded from ./layout/Container.js
        /// 'My': './src/my_own_folder' // My.layout.Container will be loaded from
        /// // ./src/my_own_folder/layout/Container.js
        /// }
        /// </code>
        /// Note that all relative paths are relative to the current HTML document.
        /// If not being specified, for example, <c>Other.awesome.Class</c>
        /// will simply be loaded from <c>./Other/awesome/Class.js</c>
        /// Defaults to: <c>{&quot;Ext&quot;: &quot;.&quot;}</c>
        /// </summary>
        public JsObject paths;
        /// <summary>
        /// False to remove and optionally garbage-collect asynchronously loaded scripts,
        /// True to retain script element for browser debugger compatibility and improved load performance.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool preserveScripts;
        /// <summary>
        /// millisecond delay between asynchronous script injection (prevents stack overflow on some user agents)
        /// 'false' disables delay but potentially increases stack load.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool scriptChainDelay;
        /// <summary>
        /// Optional charset to specify encoding of dynamic script content.
        /// </summary>
        public JsString scriptCharset;
        public LoaderConfig(params object[] args){}
    }
    #endregion
    #region LoaderEvents
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LoaderEvents
    {
        public LoaderEvents(params object[] args){}
    }
    #endregion
}
