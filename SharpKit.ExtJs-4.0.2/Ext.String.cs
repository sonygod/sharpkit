//***************************************************
//* This file was generated by tool
//* 20/07/2011 19:12:25
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region String
    /// <summary>
    /// A collection of useful static methods to deal with strings
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class String
    {
        /// <summary>
        /// Capitalize the given string ...
        /// </summary>
        public JsString capitalize(JsString @string){return null;}
        /// <summary>
        /// Truncate a string and add an ellipsis ('...') to the end if it exceeds the specified length ...
        /// </summary>
        public JsString ellipsis(JsString value, JsNumber length, bool word){return null;}
        /// <summary>
        /// Escapes the passed string for ' and \ ...
        /// </summary>
        public JsString escape(JsString @string){return null;}
        /// <summary>
        /// Escapes the passed string for use in a regular expression ...
        /// </summary>
        public JsString escapeRegex(JsString @string){return null;}
        /// <summary>
        /// Allows you to define a tokenized string and pass an arbitrary number of arguments to replace the tokens. ...
        /// </summary>
        public JsString format(JsString @string, JsString value1, JsString value2){return null;}
        /// <summary>
        /// Convert certain characters (&amp;, &lt;, >, and ') from their HTML character equivalents. ...
        /// </summary>
        public JsString htmlDecode(JsString value){return null;}
        /// <summary>
        /// Convert certain characters (&amp;, &lt;, >, and ') to their HTML character equivalents for literal display in web pages. ...
        /// </summary>
        public JsString htmlEncode(JsString value){return null;}
        /// <summary>
        /// Pads the left side of a string with a specified character. ...
        /// </summary>
        public JsString leftPad(JsString @string, JsNumber size, JsString character=null){return null;}
        /// <summary>
        /// Utility function that allows you to easily switch a string between two alternating values. ...
        /// </summary>
        public JsString toggle(JsString @string, JsString value, JsString other){return null;}
        /// <summary>
        /// Trims whitespace from either end of a string, leaving spaces within the string intact. ...
        /// </summary>
        public JsString trim(JsString @string){return null;}
        /// <summary>
        /// Appends content to the query string of a URL, handling logic for whether to place
        /// a question mark or ampersand. ...
        /// </summary>
        public object urlAppend(JsString url, JsString @string){return null;}
    }
    #endregion
    #region StringConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class StringConfig
    {
    }
    #endregion
    #region StringEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class StringEvents
    {
    }
    #endregion
}
#endregion
