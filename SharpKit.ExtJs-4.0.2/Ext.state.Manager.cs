//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.state
namespace Ext.state
{
    #region Manager
    /// <summary>
    /// This is the global state manager. By default all components that are &quot;state aware&quot; check this class
    /// for state information if you don&#39;t pass them a custom state provider. In order for this class
    /// to be useful, it must be initialized with a provider when your application initializes. Example usage: // in your initialization function
    /// init : function(){
    /// Ext.state.Manager.setProvider(new Ext.state.CookieProvider());
    /// var win = new Window(...);
    /// win.restoreState();
    /// }
    /// This class passes on calls from components to the underlying Ext.state.Provider so that
    /// there is a common interface that can be used without needing to refer to a specific provider instance
    /// in every component.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Manager : Ext.Base
    {
        /// <summary>
        /// Gets the currently configured state provider ...
        /// </summary>
        public Provider getProvider(){return null;}
    }
    #endregion
    #region ManagerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ManagerConfig
    {
    }
    #endregion
    #region ManagerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ManagerEvents
    {
    }
    #endregion
}
#endregion
