//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.slider
{
    #region Single
    /// <inheritdocs />
    /// <summary>
    /// <p>Slider which supports vertical or horizontal orientation, keyboard adjustments, configurable snapping, axis clicking
    /// and animation. Can be added as an item to any container.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.slider.Single">Ext.slider.Single</see>', {
    /// width: 200,
    /// value: 50,
    /// increment: 10,
    /// minValue: 0,
    /// maxValue: 100,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// <p>The class <see cref="Ext.slider.Single">Ext.slider.Single</see> is aliased to <see cref="Ext.slider.Single">Ext.Slider</see> for backwards compatibility.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Single : Multi
    {
        /// <summary>
        /// Programmatically sets the value of the Slider. Ensures that the value is constrained within the minValue and
        /// maxValue.
        /// </summary>
        /// <param name="value"><p>The value to set the slider to. (This will be constrained within minValue and maxValue)</p>
        /// </param>
        /// <param name="animate"><p>Turn on or off animation</p>
        /// </param>
        public void setValue(JsNumber value, object animate=null){}
        public Single(SingleConfig config){}
        public Single(){}
        public Single(params object[] args){}
    }
    #endregion
    #region SingleConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SingleConfig : MultiConfig
    {
        public SingleConfig(params object[] args){}
    }
    #endregion
    #region SingleEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SingleEvents : MultiEvents
    {
        public SingleEvents(params object[] args){}
    }
    #endregion
}
