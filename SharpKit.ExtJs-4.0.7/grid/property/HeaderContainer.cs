//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.property
namespace Ext.grid.property
{
    #region HeaderContainer
    /// <summary>
    /// A custom HeaderContainer for the Ext.grid.property.Grid.  Generally it should not need to be used directly.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class HeaderContainer : Ext.grid.header.Container, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Creates new HeaderContainer. ...
        /// </summary>
        public HeaderContainer(Grid grid, object source){}
        public HeaderContainer(HeaderContainerConfig config){}
        public HeaderContainer(){}
    }
    #endregion
    #region HeaderContainerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class HeaderContainerConfig : Ext.grid.header.ContainerConfig
    {
    }
    #endregion
    #region HeaderContainerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class HeaderContainerEvents : Ext.grid.header.ContainerEvents
    {
    }
    #endregion
}
#endregion
