//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
using Ext.Unknown;
#region Ext
namespace Ext
{
    #region DomQuery
    /// <summary>
    /// Provides high performance selector/xpath processing by compiling queries into reusable functions. New pseudo classes and matchers can be plugged. It works on HTML and XML documents (if a content node is passed in).
    /// DomQuery supports most of the CSS3 selectors spec, along with some custom selectors and basic XPath.
    /// All selectors, attribute filters and pseudos below can be combined infinitely in any order. For example &quot;div.foo:nth-child(odd)[@foo=bar].bar:first&quot; would be a perfectly valid selector. Node filters are processed in the order in which they appear, which allows you to optimize your queries for your document structure.
    /// Element Selectors:   * any element  E an element with the tag E  E F All descendent elements of E that have the tag F  E &gt; F or E/F all direct children elements of E that have the tag F  E + F all elements with the tag F that are immediately preceded by an element with the tag E  E ~ F all elements with the tag F that are preceded by a sibling element with the tag E  Attribute Selectors: The use of &amp;#64; and quotes are optional. For example, div[&amp;#64;foo=&#39;bar&#39;] is also a valid attribute selector.   E[foo] has an attribute &quot;foo&quot;  E[foo=bar] has an attribute &quot;foo&quot; that equals &quot;bar&quot;  E[foo^=bar] has an attribute &quot;foo&quot; that starts with &quot;bar&quot;  E[foo$=bar] has an attribute &quot;foo&quot; that ends with &quot;bar&quot;  E[foo*=bar] has an attribute &quot;foo&quot; that contains the substring &quot;bar&quot;  E[foo%=2] has an attribute &quot;foo&quot; that is evenly divisible by 2  E[foo!=bar] attribute &quot;foo&quot; does not equal &quot;bar&quot;  Pseudo Classes:   E:first-child E is the first child of its parent  E:last-child E is the last child of its parent  E:nth-child(n) E is the nth child of its parent (1 based as per the spec)  E:nth-child(odd) E is an odd child of its parent  E:nth-child(even) E is an even child of its parent  E:only-child E is the only child of its parent  E:checked E is an element that is has a checked attribute that is true (e.g. a radio or checkbox)   E:first the first E in the resultset  E:last the last E in the resultset  E:nth(n) the nth E in the resultset (1 based)  E:odd shortcut for :nth-child(odd)  E:even shortcut for :nth-child(even)  E:contains(foo) E&#39;s innerHTML contains the substring &quot;foo&quot;  E:nodeValue(foo) E contains a textNode with a nodeValue that equals &quot;foo&quot;  E:not(S) an E element that does not match simple selector S  E:has(S) an E element that has a descendent that matches simple selector S  E:next(S) an E element whose next sibling matches simple selector S  E:prev(S) an E element whose previous sibling matches simple selector S  E:any(S1|S2|S2) an E element which matches any of the simple selectors S1, S2 or S3//\\  CSS Value Selectors:   E{display=none} css value &quot;display&quot; that equals &quot;none&quot;  E{display^=none} css value &quot;display&quot; that starts with &quot;none&quot;  E{display$=none} css value &quot;display&quot; that ends with &quot;none&quot;  E{display*=none} css value &quot;display&quot; that contains the substring &quot;none&quot;  E{display%=2} css value &quot;display&quot; that is evenly divisible by 2  E{display!=none} css value &quot;display&quot; that does not equal &quot;none&quot;
    /// </summary>
    [JsType(JsMode.Prototype, Export=false,OmitOptionalParameters = true)]
    public partial class DomQuery
    {
        /// <summary>
        /// Compiles a selector/xpath query into a reusable function. ...
        /// </summary>
        public static JsAction compile(JsString selector, JsString type=null){return null;}
        /// <summary>
        /// Filters an array of elements to only include matches of a simple selector (e.g. ...
        /// </summary>
        public static JsArray filter(JsArray el, JsString selector, bool nonMatches=false){return null;}
        /// <summary>
        /// Returns true if the passed element(s) match the passed simple selector (e.g. ...
        /// </summary>
        public static bool @is(object el, JsString selector){return false;}
        /// <summary>
        /// Selects an array of DOM nodes by CSS/XPath selector. ...
        /// </summary>
        public static JsArray select(JsString path, Node root=null){return null;}
        /// <summary>
        /// Selects a single element. ...
        /// </summary>
        public static Ext.core.Element selectNode(JsString selector, Node root=null){return null;}
        /// <summary>
        /// Collection of matching regular expressions and code snippets. ...
        /// </summary>
        public static object matchers{get;set;}
        /// <summary>
        /// Collection of operator comparison functions. ...
        /// </summary>
        public static object operators{get;set;}
        /// <summary>
        /// Object hash of "pseudo class" filter functions which are used when filtering selections. ...
        /// </summary>
        public static object pseudos{get;set;}
        public DomQuery(DomQueryConfig config){}
        public DomQuery(){}
    }
    #endregion
    #region DomQueryConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DomQueryConfig
    {
    }
    #endregion
    #region DomQueryEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DomQueryEvents
    {
    }
    #endregion
}
#endregion
