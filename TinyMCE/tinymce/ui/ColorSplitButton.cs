//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.tinymce.ui
{
    /// <summary>
    /// Fires when the menu is hidden.
    /// </summary>
    public  partial class ColorSplitButton
    {
        /// <summary>
        /// Constructs a new color split button control instance.
        /// </summary>
        /// <param name="id">Control id for the color split button.</param>
        /// <param name="s">Optional name/value settings object.</param>
        /// <param name="ed">The editor instance this button is for.</param>
        public ColorSplitButton(string id, object s, SharpKit.TinyMCE.tinymce.Editor ed){}
        /// <summary>
        /// Destroys the control. This means it will be removed from the DOM and any
        /// events tied to it will also be removed.
        /// </summary>
        public object destroy(){return null;}
        /// <summary>
        /// Change the currently selected color for the control.
        /// </summary>
        /// <param name="c">Color code value in hex for example: #FF00FF</param>
        public object displayColor(string c){return null;}
        /// <summary>
        /// Hides the color menu. The optional event parameter is used to check where the event occured so it
        /// doesn't close them menu if it was a event inside the menu.
        /// </summary>
        /// <param name="e">Optional event object.</param>
        public object hideMenu(object e){return null;}
        public object isActive(){return null;}
        public object isDisabled(){return null;}
        public object isRendered(){return null;}
        /// <summary>
        /// Post render event. This will be executed after the control has been rendered and can be used to
        /// set states, add events to the control etc. It's recommended for subclasses of the control to call this method by using this.parent().
        /// </summary>
        public object postRender(){return null;}
        public object remove(){return null;}
        public object renderHTML(){return null;}
        /// <summary>
        /// Renders the menu to the DOM.
        /// </summary>
        public object renderMenu(){return null;}
        public object renderTo(){return null;}
        public object setActive(){return null;}
        /// <summary>
        /// Sets the current color for the control and hides the menu if it should be visible.
        /// </summary>
        /// <param name="c">Color code value in hex for example: #FF00FF</param>
        public object setColor(string c){return null;}
        public object setDisabled(){return null;}
        public object setState(){return null;}
        /// <summary>
        /// Shows the color menu. The color menu is a layer places under the button
        /// and displays a table of colors for the user to pick from.
        /// </summary>
        public object showMenu(){return null;}
        /// <summary>
        /// Settings object.
        /// </summary>
        public object settings{get;set;}
        /// <summary>
        /// Current color value.
        /// </summary>
        public string value{get;set;}
    }
}
