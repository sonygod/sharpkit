//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region Memento
    /// <inheritdocs />
    /// <summary>
    /// <p>This class manages a set of captured properties from an object. These captured properties
    /// can later be restored to an object.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Memento : Ext.Base
    {
        /// <summary>
        /// The collection of captured properties.
        /// Defaults to: <c>null</c>
        /// </summary>
        private JsObject data{get;set;}
        /// <summary>
        /// The default target object for capture/restore (passed to the constructor).
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsObject target{get;set;}
        /// <summary>
        /// Creates a new memento and optionally captures properties from the target object.
        /// </summary>
        /// <param name="target"><p>The target from which to capture properties. If specified in the
        /// constructor, this target becomes the default target for all other operations.</p>
        /// </param>
        /// <param name="props"><p>The property or array of properties to capture.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public Memento(object target, object props){}
        /// <summary>
        /// Captures the specified properties from the target object in this memento.
        /// </summary>
        /// <param name="props"><p>The property or array of properties to capture.</p>
        /// </param>
        /// <param name="target"><p>The object from which to capture properties.</p>
        /// </param>
        public void capture(object props, object target){}
        /// <summary>
        /// Removes the specified properties from this memento. These properties will not be
        /// restored later without re-capturing their values.
        /// </summary>
        /// <param name="props"><p>The property or array of properties to remove.</p>
        /// </param>
        public void remove(object props){}
        /// <summary>
        /// Restores the specified properties from this memento to the target object.
        /// </summary>
        /// <param name="props"><p>The property or array of properties to restore.</p>
        /// </param>
        /// <param name="clear"><p>True to remove the restored properties from this memento or
        /// false to keep them (default is true).</p>
        /// </param>
        /// <param name="target"><p>The object to which to restore properties.</p>
        /// </param>
        public void restore(object props, bool clear, object target){}
        /// <summary>
        /// Restores all captured properties in this memento to the target object.
        /// </summary>
        /// <param name="clear"><p>True to remove the restored properties from this memento or
        /// false to keep them (default is true).</p>
        /// </param>
        /// <param name="target"><p>The object to which to restore properties.</p>
        /// </param>
        public void restoreAll(bool clear, object target){}
        public Memento(MementoConfig config){}
        public Memento(){}
        public Memento(params object[] args){}
    }
    #endregion
    #region MementoConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class MementoConfig : Ext.BaseConfig
    {
        public MementoConfig(params object[] args){}
    }
    #endregion
    #region MementoEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class MementoEvents : Ext.BaseEvents
    {
        public MementoEvents(params object[] args){}
    }
    #endregion
}
#endregion
