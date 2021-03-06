//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.fx.target
namespace Ext.fx.target
{
    #region Target
    /// <summary>
    /// This class specifies a generic target for an animation. It provides a wrapper around a
    /// series of different types of objects to allow for a generic animation API.
    /// A target can be a single object or a Composite object containing other objects that are
    /// to be animated. This class and it&#39;s subclasses are generally not created directly, the
    /// underlying animation will create the appropriate Ext.fx.target.Target object by passing
    /// the instance to be animated. The following types of objects can be animated:  Components Elements Sprites
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Target : Ext.Base
    {
        /// <summary>
        /// Creates new Target. ...
        /// </summary>
        public Target(object target){}
        public Target(TargetConfig config){}
        public Target(){}
    }
    #endregion
    #region TargetConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TargetConfig : Ext.BaseConfig
    {
    }
    #endregion
    #region TargetEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TargetEvents : Ext.BaseEvents
    {
    }
    #endregion
}
#endregion
