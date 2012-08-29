//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.ux.ajax
namespace Ext.ux.ajax
{
    #region SimXhr
    /// <inheritdocs />
    /// <summary>
    /// <p>Simulates an XMLHttpRequest object's methods and properties but is backed by a
    /// <see cref="Ext.ux.ajax.Simlet">Ext.ux.ajax.Simlet</see> instance that provides the data.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class SimXhr : Ext.Base
    {
        public SimXhr(SimXhrConfig config){}
        public SimXhr(){}
        public SimXhr(params object[] args){}
    }
    #endregion
    #region SimXhrConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SimXhrConfig : Ext.BaseConfig
    {
        public SimXhrConfig(params object[] args){}
    }
    #endregion
    #region SimXhrEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SimXhrEvents : Ext.BaseEvents
    {
        public SimXhrEvents(params object[] args){}
    }
    #endregion
}
#endregion
