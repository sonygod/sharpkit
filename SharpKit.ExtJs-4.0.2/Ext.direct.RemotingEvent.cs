//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.direct
namespace Ext.direct
{
    #region RemotingEvent
    /// <summary>
    /// An event that is fired when data is received from a
    /// Ext.direct.RemotingProvider. Contains a method to the
    /// related transaction for the direct request, see getTransaction
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class RemotingEvent : Ext.direct.Event
    {
        /// <summary>
        /// Get the transaction associated with this event. ...
        /// </summary>
        public Transaction getTransaction(){return null;}
        public RemotingEvent(RemotingEventConfig config) : base(null){}
        public RemotingEvent() : base(null){}
    }
    #endregion
    #region RemotingEventConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class RemotingEventConfig : EventConfig
    {
    }
    #endregion
    #region RemotingEventEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class RemotingEventEvents : EventEvents
    {
    }
    #endregion
}
#endregion
