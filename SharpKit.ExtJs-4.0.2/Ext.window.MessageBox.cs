//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:52:01
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.window
namespace Ext.window
{
    #region MessageBox
    /// <summary>
    /// Utility class for generating different styles of message boxes.  The singleton instance, Ext.Msg can also be used.
    /// Note that a MessageBox is asynchronous.  Unlike a regular JavaScript alert (which will halt
    /// browser execution), showing a MessageBox will not cause the code to stop.  For this reason, if you have code
    /// that should only run after some user feedback from the MessageBox, you must use a callback function
    /// (see the function parameter for show for more details).    Example usage: // Basic alert:
    /// Ext.Msg.alert(&#39;Status&#39;, &#39;Changes saved successfully.&#39;);
    /// // Prompt for user data and process the result using a callback:
    /// Ext.Msg.prompt(&#39;Name&#39;, &#39;Please enter your name:&#39;, function(btn, text){
    /// if (btn == &#39;ok&#39;){
    /// // process text value and close...
    /// }
    /// });
    /// // Show a dialog using config options:
    /// Ext.Msg.show({
    /// title:&#39;Save Changes?&#39;,
    /// msg: &#39;You are closing a tab that has unsaved changes. Would you like to save your changes?&#39;,
    /// buttons: Ext.Msg.YESNOCANCEL,
    /// fn: processResult,
    /// animateTarget: &#39;elId&#39;,
    /// icon: Ext.window.MessageBox.QUESTION
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class MessageBox : Window, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Displays a standard read-only message box with an OK button (comparable to the basic JavaScript alert prompt). ...
        /// </summary>
        public MessageBox alert(JsString title, JsString msg, JsAction fn=null, object scope=null){return null;}
        /// <summary>
        /// Displays a confirmation message box with Yes and No buttons (comparable to JavaScript's confirm). ...
        /// </summary>
        public MessageBox confirm(JsString title, JsString msg, JsAction fn=null, object scope=null){return null;}
        /// <summary>
        /// Displays a message box with a progress bar. ...
        /// </summary>
        public MessageBox progress(JsString title, JsString msg, JsString progressText=null){return null;}
        /// <summary>
        /// Displays a message box with OK and Cancel buttons prompting the user to enter some text (comparable to JavaScript's p...
        /// </summary>
        public MessageBox prompt(JsString title, JsString msg, JsAction fn=null, object scope=null, object multiline=null, JsString value=null){return null;}
        /// <summary>
        /// Adds the specified icon to the dialog. ...
        /// </summary>
        public MessageBox setIcon(JsString icon){return null;}
        /// <summary>
        /// Displays a new message box, or reinitializes an existing message box, based on the config options
        /// passed in. ...
        /// </summary>
        public MessageBox show(object config){return null;}
        /// <summary>
        /// Updates a progress-style message box's text and progress bar. ...
        /// </summary>
        public MessageBox updateProgress(JsNumber value, JsString progressText, JsString msg){return null;}
        /// <summary>
        /// Displays a message box with an infinitely auto-updating progress bar. ...
        /// </summary>
        public MessageBox wait(JsString msg, JsString title=null, object config=null){return null;}
        public JsNumber CANCEL{get;set;}
        public JsString ERROR{get;set;}
        public JsString INFO{get;set;}
        public JsNumber NO{get;set;}
        public JsNumber OK{get;set;}
        public JsNumber OKCANCEL{get;set;}
        public JsString QUESTION{get;set;}
        public JsString WARNING{get;set;}
        public JsNumber YES{get;set;}
        public JsNumber YESNO{get;set;}
        public JsNumber YESNOCANCEL{get;set;}
        /// <summary>
        /// An object containing the default button text strings that can be overriden for localized language support. ...
        /// </summary>
        public object buttonText{get;set;}
        public JsNumber defaultTextHeight{get;set;}
        /// <summary>
        /// The minimum width in pixels of the message box if it is a progress-style dialog. ...
        /// </summary>
        public JsNumber minProgressWidth{get;set;}
        /// <summary>
        /// The minimum width in pixels of the message box if it is a prompt dialog. ...
        /// </summary>
        public JsNumber minPromptWidth{get;set;}
    }
    #endregion
    #region MessageBoxConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class MessageBoxConfig
    {
    }
    #endregion
    #region MessageBoxEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class MessageBoxEvents
    {
    }
    #endregion
}
#endregion
