//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.tinymce.dom
{
    /// <summary>
    /// This class handles asynchronous/synchronous loading of JavaScript files it will execute callbacks when various items get...
    /// </summary>
    public  partial class ScriptLoader
    {
        /// <summary>
        /// Adds a specific script to the load queue of the script loader.
        /// </summary>
        /// <param name="url">Absolute URL to script to add.</param>
        /// <param name="callback">Optional callback function to execute ones this script gets loaded.</param>
        /// <param name="scope">Optional scope to execute callback in.</param>
        public object add(string url, object callback, object scope){return null;}
        /// <summary>
        /// Returns true/false if a script has been loaded or not.
        /// </summary>
        /// <param name="url">URL to check for.</param>
        public object isDone(string url){return null;}
        /// <summary>
        /// Loads a specific script directly without adding it to the load queue.
        /// </summary>
        /// <param name="url">Absolute URL to script to add.</param>
        /// <param name="callback">Optional callback function to execute ones this script gets loaded.</param>
        /// <param name="scope">Optional scope to execute callback in.</param>
        public object load(string url, object callback, object scope){return null;}
        /// <summary>
        /// Starts the loading of the queue.
        /// </summary>
        /// <param name="callback">Optional callback to execute when all queued items are loaded.</param>
        /// <param name="scope">Optional scope to execute the callback in.</param>
        public object loadQueue(object callback, object scope){return null;}
        /// <summary>
        /// Loads the specified queue of files and executes the callback ones they are loaded.
        /// This method is generally not used outside this class but it might be useful in some scenarios.
        /// </summary>
        /// <param name="scripts">Array of queue items to load.</param>
        /// <param name="callback">Optional callback to execute ones all items are loaded.</param>
        /// <param name="scope">Optional scope to execute callback in.</param>
        public object loadScripts(Array scripts, object callback, object scope){return null;}
        /// <summary>
        /// Marks a specific script to be loaded. This can be useful if a script got loaded outside
        /// the script loader or to skip it from loading some script.
        /// </summary>
        /// <param name="u">Absolute URL to the script to mark as loaded.</param>
        public object markDone(string u){return null;}
    }
}
