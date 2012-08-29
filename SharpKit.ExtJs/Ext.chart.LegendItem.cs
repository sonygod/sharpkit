//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart
namespace Ext.chart
{
    #region LegendItem
    /// <inheritdocs />
    /// <summary>
    /// <p>A single item of a legend (marker plus label)</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class LegendItem : Ext.draw.CompositeSprite
    {
        /// <summary>
        /// Creates all the individual sprites for this legend item
        /// </summary>
        /// <param name="config">
        /// </param>
        public void createLegend(object config){}
        /// <summary>
        /// Update the positions of all this item's sprites to match the root position
        /// of the legend box.
        /// </summary>
        /// <param name="relativeTo"><p>If specified, this object's 'x' and 'y' values will be used</p>
        /// <pre><code>            as the reference point for the relative positioning. Defaults to the Legend.
        /// </code></pre>
        /// </param>
        public void updatePosition(object relativeTo=null){}
        public LegendItem(LegendItemConfig config){}
        public LegendItem(){}
        public LegendItem(params object[] args){}
    }
    #endregion
    #region LegendItemConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LegendItemConfig : Ext.draw.CompositeSpriteConfig
    {
        public LegendItemConfig(params object[] args){}
    }
    #endregion
    #region LegendItemEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LegendItemEvents : Ext.draw.CompositeSpriteEvents
    {
        public LegendItemEvents(params object[] args){}
    }
    #endregion
}
#endregion