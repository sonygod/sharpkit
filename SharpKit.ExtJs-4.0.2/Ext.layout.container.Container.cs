//***************************************************
//* This file was generated by tool
//* 20/07/2011 20:05:54
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.layout.container
namespace Ext.layout.container
{
    #region Container
    /// <summary>
    /// This class is intended to be extended or created via the layout
    /// configuration property.  See Ext.container.Container.layout for additional details.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Container : Ext.layout.container.AbstractContainer
    {
        /// <summary>
        /// Returns all items that are rendered ...
        /// </summary>
        public JsArray getRenderedItems(){return null;}
        /// <summary>
        /// Returns all items that are both rendered and visible ...
        /// </summary>
        public JsArray getVisibleItems(){return null;}
        public Container(Ext.layout.container.ContainerConfig config){}
        public Container(){}
    }
    #endregion
    #region ContainerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ContainerConfig : Ext.layout.container.AbstractContainerConfig
    {
    }
    #endregion
    #region ContainerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ContainerEvents : Ext.layout.container.AbstractContainerEvents
    {
    }
    #endregion
}
#endregion
