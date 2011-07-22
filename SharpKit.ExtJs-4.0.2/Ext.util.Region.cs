//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.util
namespace Ext.util
{
    #region Region
    /// <summary>
    /// This class represents a rectangular region in X,Y space, and performs geometric
    /// transformations or tests upon the region. This class may be used to compare the document regions occupied by elements.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Region
    {
        /// <summary>
        /// Creates a region from the bounding sides. ...
        /// </summary>
        public Region(JsNumber top, JsNumber right, JsNumber bottom, JsNumber left){}
        /// <summary>
        /// Modifies the current region to be adjusted by offsets. ...
        /// </summary>
        public object adjust(JsNumber top, JsNumber right, JsNumber bottom, JsNumber left){return null;}
        /// <summary>
        /// Modifies the current region to be constrained to the targetRegion. ...
        /// </summary>
        public object constrainTo(Region targetRegion){return null;}
        /// <summary>
        /// Checks if this region completely contains the region that is passed in. ...
        /// </summary>
        public object contains(Region region){return null;}
        /// <summary>
        /// Create a copy of this Region. ...
        /// </summary>
        public Region copy(){return null;}
        /// <summary>
        /// Copy the values of another Region to this Region ...
        /// </summary>
        public Region copyFrom(Region The){return null;}
        /// <summary>
        /// Check whether this region is equivalent to the given region ...
        /// </summary>
        public bool equals(Region region){return false;}
        /// <summary>
        /// Get the offset amount of a point outside the region ...
        /// </summary>
        public Offset getOutOfBoundOffset(JsString axis, Point p){return null;}
        /// <summary>
        /// Get the offset amount on the x-axis ...
        /// </summary>
        public JsNumber getOutOfBoundOffsetX(JsNumber p){return null;}
        /// <summary>
        /// Get the offset amount on the y-axis ...
        /// </summary>
        public JsNumber getOutOfBoundOffsetY(JsNumber p){return null;}
        /// <summary>
        /// Checks if this region intersects the region passed in. ...
        /// </summary>
        public object intersect(Region region){return null;}
        /// <summary>
        /// Check whether the point / offset is out of bound ...
        /// </summary>
        public bool isOutOfBound(JsString axis, object p){return false;}
        /// <summary>
        /// Check whether the offset is out of bound in the x-axis ...
        /// </summary>
        public bool isOutOfBoundX(JsNumber p){return false;}
        /// <summary>
        /// Check whether the offset is out of bound in the y-axis ...
        /// </summary>
        public bool isOutOfBoundY(JsNumber p){return false;}
        /// <summary>
        /// Round all the properties of this region ...
        /// </summary>
        public Region round(){return null;}
        /// <summary>
        /// Translate this region by the given offset amount ...
        /// </summary>
        public Region translateBy(object offset, JsNumber The){return null;}
        /// <summary>
        /// Returns the smallest region that contains the current AND targetRegion. ...
        /// </summary>
        public object union(Region region){return null;}
        public Region(RegionConfig config){}
        public Region(){}
    }
    #endregion
    #region RegionConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class RegionConfig
    {
    }
    #endregion
    #region RegionEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class RegionEvents
    {
    }
    #endregion
}
#endregion
