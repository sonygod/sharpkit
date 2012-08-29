//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.dom
{
    #region Helper
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>The actual class of which <see cref="Ext.DomHelper">Ext.DomHelper</see> is instance of.</p>
    /// <p>Use singleton <see cref="Ext.DomHelper">Ext.DomHelper</see> instead.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Helper : AbstractHelper
    {
        /// <summary>
        /// True to force the use of DOM instead of html fragments.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool useDom{get;set;}
        /// <summary>
        /// Fix for IE9 createContextualFragment missing method
        /// </summary>
        /// <param name="html">
        /// </param>
        private void createContextualFragment(object html){}
        /// <summary>
        /// Creates new DOM element(s) without inserting them to the document.
        /// </summary>
        /// <param name="o"><p>The DOM object spec (and children) or raw HTML blob</p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement</span><div><p>The new uninserted node</p>
        /// </div>
        /// </returns>
        public JsObject createDom(object o){return null;}
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
        public JsString createHtml(object spec){return null;}
        /// <summary>
        /// Creates a new Ext.Template from the DOM object spec.
        /// </summary>
        /// <param name="o"><p>The DOM object spec (and children)</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Template">Ext.Template</see></span><div><p>The new template</p>
        /// </div>
        /// </returns>
        public Ext.Template createTemplate(object o){return null;}
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
        private void insertIntoTable(object tag, object where, object destinationEl, object html){}
        public Helper(HelperConfig config){}
        public Helper(){}
        public Helper(params object[] args){}
    }
    #endregion
    #region HelperConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class HelperConfig : AbstractHelperConfig
    {
        public HelperConfig(params object[] args){}
    }
    #endregion
    #region HelperEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class HelperEvents : AbstractHelperEvents
    {
        public HelperEvents(params object[] args){}
    }
    #endregion
}
