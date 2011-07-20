//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:24
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.core
namespace Ext.core
{
    #region DomHelper
    /// <summary>
    /// The DomHelper class provides a layer of abstraction from DOM and transparently supports creating
    /// elements via DOM or using HTML fragments. It also has the ability to create HTML fragment templates
    /// from your DOM building code. DomHelper element specification object A specification object is used when creating elements. Attributes of this object
    /// are assumed to be element attributes, except for 4 special attributes:
    /// tag : The tag name of the element children : or cnAn array of the
    /// same kind of element definition objects to be created and appended. These can be nested
    /// as deep as you want. cls : The class attribute of the element.
    /// This will end up being either the &quot;class&quot; attribute on a HTML fragment or className
    /// for a DOM node, depending on whether DomHelper is using fragments or DOM. html : The innerHTML for the element  NOTE: For other arbitrary attributes, the value will currently not be automatically
    /// HTML-escaped prior to building the element&#39;s HTML string. This means that if your attribute value
    /// contains special characters that would not normally be allowed in a double-quoted attribute value,
    /// you must manually HTML-encode it beforehand (see Ext.String.htmlEncode) or risk
    /// malformed HTML being created. This behavior may change in a future release. Insertion methods Commonly used insertion methods:
    /// append :  insertBefore :  insertAfter :  overwrite :  createTemplate :  insertHtml :   Example This is an example, where an unordered list with 3 children items is appended to an existing
    /// element with id &#39;my-div&#39;: var dh = Ext.core.DomHelper; // create shorthand alias
    /// // specification object
    /// var spec = {
    /// id: &#39;my-ul&#39;,
    /// tag: &#39;ul&#39;,
    /// cls: &#39;my-list&#39;,
    /// // append children after creating
    /// children: [     // may also specify &#39;cn&#39; instead of &#39;children&#39;
    /// {tag: &#39;li&#39;, id: &#39;item0&#39;, html: &#39;List Item 0&#39;},
    /// {tag: &#39;li&#39;, id: &#39;item1&#39;, html: &#39;List Item 1&#39;},
    /// {tag: &#39;li&#39;, id: &#39;item2&#39;, html: &#39;List Item 2&#39;}
    /// ]
    /// };
    /// var list = dh.append(
    /// &#39;my-div&#39;, // the context element &#39;my-div&#39; can either be the id or the actual node
    /// spec      // the specification object
    /// );
    /// Element creation specification parameters in this class may also be passed as an Array of
    /// specification objects. This can be used to insert multiple sibling nodes into an existing
    /// container very efficiently. For example, to add more list items to the example above:
    /// dh.append(&#39;my-ul&#39;, [
    /// {tag: &#39;li&#39;, id: &#39;item3&#39;, html: &#39;List Item 3&#39;},
    /// {tag: &#39;li&#39;, id: &#39;item4&#39;, html: &#39;List Item 4&#39;}
    /// ]);
    /// Templating The real power is in the built-in templating. Instead of creating or appending any elements,
    /// createTemplate returns a Template object which can be used over and over to
    /// insert new elements. Revisiting the example above, we could utilize templating this time:
    /// // create the node
    /// var list = dh.append(&#39;my-div&#39;, {tag: &#39;ul&#39;, cls: &#39;my-list&#39;});
    /// // get template
    /// var tpl = dh.createTemplate({tag: &#39;li&#39;, id: &#39;item{0}&#39;, html: &#39;List Item {0}&#39;});
    /// for(var i = 0; i  An example using a template:
    /// var html = &#39;{2}&#39;;
    /// var tpl = new Ext.core.DomHelper.createTemplate(html);
    /// tpl.append(&#39;blog-roll&#39;, [&#39;link1&#39;, &#39;http://www.edspencer.net/&#39;, &quot;Ed&amp;#39;s Site&quot;]);
    /// tpl.append(&#39;blog-roll&#39;, [&#39;link2&#39;, &#39;http://www.dustindiaz.com/&#39;, &quot;Dustin&amp;#39;s Site&quot;]);
    /// The same example using named parameters:
    /// var html = &#39;{text}&#39;;
    /// var tpl = new Ext.core.DomHelper.createTemplate(html);
    /// tpl.append(&#39;blog-roll&#39;, {
    /// id: &#39;link1&#39;,
    /// url: &#39;http://www.edspencer.net/&#39;,
    /// text: &quot;Ed&amp;#39;s Site&quot;
    /// });
    /// tpl.append(&#39;blog-roll&#39;, {
    /// id: &#39;link2&#39;,
    /// url: &#39;http://www.dustindiaz.com/&#39;,
    /// text: &quot;Dustin&amp;#39;s Site&quot;
    /// });
    /// Compiling Templates Templates are applied using regular expressions. The performance is great, but if
    /// you are adding a bunch of DOM elements using the same template, you can increase
    /// performance even further by &amp;quot;compiling&amp;quot; the template.
    /// The way &quot;compile()&quot; works is the template is parsed and
    /// broken up at the different variable points and a dynamic function is created and eval&#39;ed.
    /// The generated function performs string concatenation of these parts and the passed
    /// variables instead of using regular expressions.
    /// var html = &#39;{text}&#39;;
    /// var tpl = new Ext.core.DomHelper.createTemplate(html);
    /// tpl.compile();
    /// //... use template like normal
    /// Performance Boost DomHelper will transparently create HTML fragments when it can. Using HTML fragments instead
    /// of DOM can significantly boost performance. Element creation specification parameters may also be strings. If useDom is false,
    /// then the string is used as innerHTML. If useDom is true, a string specification
    /// results in the creation of a text node. Usage: Ext.core.DomHelper.useDom = true; // force it to use DOM; reduces performance
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class DomHelper
    {
        /// <summary>
        /// Creates new DOM element(s) and appends them to el. ...
        /// </summary>
        public object append(object el, object o, bool returnElement=false){return null;}
        /// <summary>
        /// Applies a style specification to an element. ...
        /// </summary>
        public object applyStyles(object el, object styles){return null;}
        /// <summary>
        /// Creates new DOM element(s) without inserting them to the document. ...
        /// </summary>
        public HTMLElement createDom(object o){return null;}
        /// <summary>
        /// Creates a new Ext.Template from the DOM object spec. ...
        /// </summary>
        public Ext.Template createTemplate(object o){return null;}
        /// <summary>
        /// Creates new DOM element(s) and inserts them after el. ...
        /// </summary>
        public object insertAfter(object el, object o, bool returnElement=false){return null;}
        /// <summary>
        /// Creates new DOM element(s) and inserts them before el. ...
        /// </summary>
        public object insertBefore(object el, object o, bool returnElement=false){return null;}
        /// <summary>
        /// Creates new DOM element(s) and inserts them as the first child of el. ...
        /// </summary>
        public object insertFirst(object el, object o, bool returnElement=false){return null;}
        /// <summary>
        /// Inserts an HTML fragment into the DOM. ...
        /// </summary>
        public HTMLElement insertHtml(JsString where, object el, JsString html){return null;}
        /// <summary>
        /// Returns the markup for the passed Element(s) config. ...
        /// </summary>
        public JsString markup(object o){return null;}
        /// <summary>
        /// Creates new DOM element(s) and overwrites the contents of el with them. ...
        /// </summary>
        public object overwrite(object el, object o, bool returnElement=false){return null;}
        public bool useDom{get;set;}
    }
    #endregion
    #region DomHelperConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DomHelperConfig
    {
    }
    #endregion
    #region DomHelperEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DomHelperEvents
    {
    }
    #endregion
}
#endregion
