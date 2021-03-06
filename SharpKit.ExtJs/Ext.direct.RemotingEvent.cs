//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.direct
{
    #region RemotingEvent
    /// <inheritdocs />
    /// <summary>
    /// <p>An event that is fired when data is received from a
    /// <see cref="Ext.direct.RemotingProvider">Ext.direct.RemotingProvider</see>. Contains a method to the
    /// related transaction for the direct request, see <see cref="Ext.direct.RemotingEvent.getTransaction">getTransaction</see></p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class RemotingEvent : Ext.direct.Event
    {
        /// <summary>
        /// Get the transaction associated with this event.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.direct.Transaction">Ext.direct.Transaction</see></span><div><p>The transaction</p>
        /// </div>
        /// </returns>
        public Transaction getTransaction(){return null;}
        public RemotingEvent(RemotingEventConfig config){}
        public RemotingEvent(){}
        public RemotingEvent(params object[] args){}
    }
    #endregion
    #region RemotingEventConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class RemotingEventConfig : Ext.direct.EventConfig
    {
        public RemotingEventConfig(params object[] args){}
    }
    #endregion
    #region RemotingEventEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class RemotingEventEvents : Ext.direct.EventEvents
    {
        public RemotingEventEvents(params object[] args){}
    }
    #endregion
}
