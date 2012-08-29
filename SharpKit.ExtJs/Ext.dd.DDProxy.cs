//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.dd
namespace Ext.dd
{
    #region DDProxy
    /// <inheritdocs />
    /// <summary>
    /// <p>A DragDrop implementation that inserts an empty, bordered div into
    /// the document that follows the cursor during drag operations.  At the time of
    /// the click, the frame div is resized to the dimensions of the linked html
    /// element, and moved to the exact location of the linked element.</p>
    /// <p>References to the "frame" element refer to the single proxy element that
    /// was created to be dragged in place of all DDProxy elements on the
    /// page.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class DDProxy : Ext.dd.DD
    {
        /// <summary>
        /// By default the frame is positioned exactly where the drag element is, so
        /// we use the cursor offset provided by Ext.dd.DD.  Another option that works only if
        /// you do not have constraints on the obj is to have the drag frame centered
        /// around the cursor.  Set centerFrame to true for this effect.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool centerFrame{get;set;}
        /// <summary>
        /// By default we resize the drag frame to be the same size as the element
        /// we want to drag (this is to get the frame effect).  We can turn it off
        /// if we want a different behavior.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool resizeFrame{get;set;}
        /// <summary>
        /// The proxy is automatically resized to the dimensions of the linked
        /// element when a drag is initiated, unless resizeFrame is set to false
        /// </summary>
        private void _resizeProxy(){}
        /// <summary>
        /// Creates the proxy element if it does not yet exist
        /// </summary>
        public void createFrame(){}
        /// <summary>
        /// Initialization for the drag frame element.  Must be called in the
        /// constructor of all subclasses
        /// </summary>
        public void initFrame(){}
        /// <summary>
        /// Resizes the drag frame to the dimensions of the clicked object, positions
        /// it over the object, and finally displays it
        /// </summary>
        /// <param name="iPageX"><p>X click position</p>
        /// </param>
        /// <param name="iPageY"><p>Y click position</p>
        /// </param>
        private void showFrame(JsNumber iPageX, JsNumber iPageY){}
        public DDProxy(DDProxyConfig config){}
        public DDProxy(){}
        public DDProxy(params object[] args){}
    }
    #endregion
    #region DDProxyConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DDProxyConfig : Ext.dd.DDConfig
    {
        public DDProxyConfig(params object[] args){}
    }
    #endregion
    #region DDProxyEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DDProxyEvents : Ext.dd.DDEvents
    {
        public DDProxyEvents(params object[] args){}
    }
    #endregion
}
#endregion