//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.menu
namespace Ext.menu
{
    #region Manager
    /// <summary>
    /// Provides a common registry of all menus on a page.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Manager : Ext.Base
    {
        /// <summary>
        /// Returns a Ext.menu.Menu object ...
        /// </summary>
        public static Menu get(object menu){return null;}
        /// <summary>
        /// Hides all menus that are currently visible ...
        /// </summary>
        public static bool hideAll(){return false;}
        public Manager(Ext.menu.ManagerConfig config){}
        public Manager(){}
    }
    #endregion
    #region ManagerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ManagerConfig : Ext.BaseConfig
    {
    }
    #endregion
    #region ManagerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ManagerEvents : Ext.BaseEvents
    {
    }
    #endregion
}
#endregion
