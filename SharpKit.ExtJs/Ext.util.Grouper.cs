//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.util
{
    #region Grouper
    /// <inheritdocs />
    /// <summary>
    /// <p>Represents a single grouper that can be applied to a Store. The grouper works
    /// in the same fashion as the <see cref="Ext.util.Sorter">Ext.util.Sorter</see>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Grouper : Sorter
    {
        /// <summary>
        /// Returns the value for grouping to be used.
        /// </summary>
        /// <param name="instance"><p>The Model instance</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The group string for this model</p>
        /// </div>
        /// </returns>
        public JsString getGroupString(Ext.data.Model instance){return null;}
        public Grouper(GrouperConfig config){}
        public Grouper(){}
        public Grouper(params object[] args){}
    }
    #endregion
    #region GrouperConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class GrouperConfig : SorterConfig
    {
        public GrouperConfig(params object[] args){}
    }
    #endregion
    #region GrouperEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class GrouperEvents : SorterEvents
    {
        public GrouperEvents(params object[] args){}
    }
    #endregion
}
