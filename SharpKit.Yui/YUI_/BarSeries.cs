//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_
{
    /// <summary>
    /// The BarSeries class renders bars positioned vertically along a category or time axis. The bars'
    /// lengths are proportional to the values they represent along a horizontal axis.
    /// and the relevant data points.
    /// </summary>
    public partial class BarSeries
    {
        /// <summary>
        /// Resizes and positions markers based on a mouse interaction.
        /// </summary>
        protected void updateMarkerState(object type, YUI_.DataType_.Number i){}
        /// <summary>
        /// Style properties used for drawing markers. This attribute is inherited from `MarkerSeries`. Below are the default values:
        /// <dl>
        /// <dt>fill</dt><dd>A hash containing the following values:
        /// <dl>
        /// <dt>color</dt><dd>Color of the fill. The default value is determined by the order of the series on the graph. The color
        /// will be retrieved from the below array:<br/>
        /// `["#66007f", "#a86f41", "#295454", "#996ab2", "#e8cdb7", "#90bdbd","#000000","#c3b8ca", "#968373", "#678585"]`
        /// </dd>
        /// <dt>alpha</dt><dd>Number from 0 to 1 indicating the opacity of the marker fill. The default value is 1.</dd>
        /// </dl>
        /// </dd>
        /// <dt>border</dt><dd>A hash containing the following values:
        /// <dl>
        /// <dt>color</dt><dd>Color of the border. The default value is determined by the order of the series on the graph. The color
        /// will be retrieved from the below array:<br/>
        /// `["#205096", "#b38206", "#000000", "#94001e", "#9d6fa0", "#e55b00", "#5e85c9", "#adab9e", "#6ac291", "#006457"]`
        /// <dt>alpha</dt><dd>Number from 0 to 1 indicating the opacity of the marker border. The default value is 1.</dd>
        /// <dt>weight</dt><dd>Number indicating the width of the border. The default value is 1.</dd>
        /// </dl>
        /// </dd>
        /// <dt>height</dt><dd>indicates the width of the marker. The default value is 12.</dd>
        /// <dt>over</dt><dd>hash containing styles for markers when highlighted by a `mouseover` event. The default
        /// values for each style is null. When an over style is not set, the non-over value will be used. For example,
        /// the default value for `marker.over.fill.color` is equivalent to `marker.fill.color`.</dd>
        /// </dl>
        /// </summary>
        public object styles{get;set;}
    }
}
