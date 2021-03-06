//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// The WidgetAutohide class provides the hideOn attribute which can
    /// be used to hide the widget when certain events occur.
    /// </summary>
    public partial class WidgetAutohide
    {
        /// <summary>
        /// Default function called when hideOn Attribute is changed. Remove existing listeners and create new listeners.
        /// </summary>
        public void _afterHideOnChange(){}
        /// <summary>
        /// Default function called when the visibility of the widget changes. Determines
        /// whether to attach or detach event listeners based on the visibility of the widget.
        /// </summary>
        protected void _afterHostVisibleChangeAutohide(){}
        /// <summary>
        /// Iterates through all objects in the hideOn attribute and creates event listeners.
        /// </summary>
        protected void _attachUIHandlesAutohide(){}
        /// <summary>
        /// Binds event listeners to the widget.
        /// <p>
        /// This method in invoked after bindUI is invoked for the Widget class
        /// using YUI's aop infrastructure.
        /// </p>
        /// </summary>
        protected void _bindUIAutohide(){}
        /// <summary>
        /// Detaches all event listeners created by this extension
        /// </summary>
        protected void _detachUIHandlesAutohide(){}
        /// <summary>
        /// Syncs up the widget based on its current state. In particular, removes event listeners if
        /// widget is not visible, and attaches them otherwise.
        /// <p>
        /// This method in invoked after syncUI is invoked for the Widget class
        /// using YUI's aop infrastructure.
        /// </p>
        /// </summary>
        protected void _syncUIAutohide(){}
        /// <summary>
        /// Removes event listeners if widget is not visible, and attaches them otherwise.
        /// </summary>
        protected void _uiSetHostVisibleAutohide(){}
        /// <summary>
        /// Static property used to define the default attribute
        /// configuration introduced by WidgetAutohide.
        /// </summary>
        public object ATTRS{get;set;}
    }
}
