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
    /// Matrix is a class that allows for the manipulation of a transform matrix.
    /// This class is a work in progress.
    /// </summary>
    public partial class Matrix
    {
        /// <summary>
        /// Parses a string and updates the matrix.
        /// </summary>
        public void applyCSSText(object val){}
        /// <summary>
        /// Returns an array of transform commands that represent the matrix.
        /// </summary>
        public YUI_.Array decompose(){return null;}
        /// <summary>
        /// Converts a degree value to a radian.
        /// </summary>
        public YUI_.DataType_.Number deg2rad(YUI_.DataType_.Number deg){return null;}
        /// <summary>
        /// Returns the left, top, right and bottom coordinates for a transformed
        /// item.
        /// </summary>
        public object getContentRect(YUI_.DataType_.Number width, YUI_.DataType_.Number height, YUI_.DataType_.Number x, YUI_.DataType_.Number y){return null;}
        /// <summary>
        /// Returns the determinant of the matrix.
        /// </summary>
        public YUI_.DataType_.Number getDeterminant(){return null;}
        /// <summary>
        /// Returns a 3x3 Matrix array
        /// /                                             \
        /// | matrix[0][0]   matrix[1][0]    matrix[2][0] |
        /// | matrix[0][1]   matrix[1][1]    matrix[2][1] |
        /// | matrix[0][2]   matrix[1][2]    matrix[2][2] |
        /// \                                             /
        /// </summary>
        public YUI_.Array getMatrixArray(){return null;}
        /// <summary>
        /// Parses a string and returns an array of transform arrays.
        /// </summary>
        public YUI_.Array getTransformArray(object val){return null;}
        /// <summary>
        /// Returns an identity matrix.
        /// </summary>
        public object identity(){return null;}
        /// <summary>
        /// Initializes a matrix.
        /// </summary>
        public void init(object config){}
        /// <summary>
        /// Returns the inverse (in array form) of the matrix.
        /// </summary>
        public YUI_.Array inverse(){return null;}
        /// <summary>
        /// Updates the matrix.
        /// </summary>
        public void multiple(YUI_.DataType_.Number a, YUI_.DataType_.Number b, YUI_.DataType_.Number c, YUI_.DataType_.Number d, YUI_.DataType_.Number dx, YUI_.DataType_.Number dy){}
        /// <summary>
        /// Converts a radian value to a degree.
        /// </summary>
        public YUI_.DataType_.Number rad2deg(YUI_.DataType_.Number rad){return null;}
        /// <summary>
        /// Applies a rotate transform.
        /// </summary>
        public void rotate(YUI_.DataType_.Number deg){}
        /// <summary>
        /// Applies a scale transform
        /// </summary>
        public void scale(YUI_.DataType_.Number val){}
        /// <summary>
        /// Applies a skew transformation.
        /// </summary>
        public void skew(YUI_.DataType_.Number x, YUI_.DataType_.Number y){}
        /// <summary>
        /// Applies a skew to the x-coordinate
        /// </summary>
        public void skewX(YUI_.DataType_.Number x){}
        /// <summary>
        /// Applies a skew to the y-coordinate
        /// </summary>
        public void skewY(YUI_.DataType_.Number y){}
        /// <summary>
        /// Returns a string of text that can be used to populate a the css transform property of an element.
        /// </summary>
        public object toCSSText(){return null;}
        /// <summary>
        /// Returns a string that can be used to populate the css filter property of an element.
        /// </summary>
        public object toFilterText(){return null;}
        /// <summary>
        /// Applies translate transformation.
        /// </summary>
        public void translate(YUI_.DataType_.Number x, YUI_.DataType_.Number y){}
        /// <summary>
        /// Returns the transpose of the matrix
        /// </summary>
        public YUI_.Array transpose(){return null;}
    }
}
