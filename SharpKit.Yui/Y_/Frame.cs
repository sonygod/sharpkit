//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// Creates a wrapper around an iframe. It loads the content either from a local
    /// file or from script and creates a local YUI instance bound to that new window and document.
    /// </summary>
    public partial class Frame : Y_.Base
    {
        [JsMethod(JsonInitializers=true)]
        public Frame(){}
        /// <summary>
        /// A delegate method passed to the instance's delegate method
        /// </summary>
        public EventHandle @delegate(object type, JsAction fn, object cont, object sel){return null;}
        /// <summary>
        /// Set the focus to the iframe
        /// </summary>
        public Frame focus(JsAction fn){return null;}
        /// <summary>
        /// Parses document.doctype and generates a DocType to match the parent page, if supported.
        /// For IE8, it grabs document.all[0].nodeValue and uses that. For IE < 8, it falls back to Frame.DOC_TYPE.
        /// </summary>
        public object getDocType(){return null;}
        /// <summary>
        /// Get a reference to the internal YUI instance.
        /// </summary>
        public YUI getInstance(){return null;}
        /// <summary>
        /// Hide the iframe instance
        /// </summary>
        public Frame hide(){return null;}
        /// <summary>
        /// Render the iframe into the container config option or open the window.
        /// </summary>
        public Frame render(object node){return null;}
        /// <summary>
        /// Show the iframe instance
        /// </summary>
        public Frame show(){return null;}
        /// <summary>
        /// This is a scoped version of the normal YUI.use method & is bound to this frame/window.
        /// At setup, the inst.use method is mapped to this method.
        /// </summary>
        public void use(){}
        /// <summary>
        /// The DomEvents that the frame automatically attaches and bubbles
        /// </summary>
        public object DOM_EVENTS{get;set;}
        /// <summary>
        /// A reference to the Editor instance
        /// </summary>
        public object host{get;set;}
        /// <summary>
        /// The Node instance of the iframe.
        /// </summary>
        public Node node{get;set;}
        /// <summary>
        /// The throttle time for key events in IE
        /// </summary>
        public Y_.DataType_.Number THROTTLE_TIME{get;set;}
    }
}
