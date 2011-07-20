//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:51:08
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.env
namespace Ext.env
{
    #region OS
    /// <summary>
    /// Provide useful information about the current operating system environment. Access the global instance stored in Ext.os. Example: if (Ext.os.is.Windows) {
    /// // Windows specific code here
    /// }
    /// if (Ext.os.is.iOS) {
    /// // iPad, iPod, iPhone, etc.
    /// }
    /// console.log(&quot;Version &quot; + Ext.os.version);
    /// For a full list of supported values, refer to: Ext.env.OS.is
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class OS : Ext.Base
    {
        /// <summary>
        /// A "hybrid" property, can be either accessed as a method call, i.e:
        /// if (Ext.os.is('Android')) { ... ...
        /// </summary>
        public bool @is(JsString value){return false;}
        /// <summary>
        /// Read-only - the full name of the current operating system
        /// Possible values are: iOS, Android, WebOS, BlackBerry, MacOS...
        /// </summary>
        public JsString name{get;set;}
        public Version version{get;set;}
    }
    #endregion
    #region OSConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class OSConfig
    {
    }
    #endregion
    #region OSEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class OSEvents
    {
    }
    #endregion
}
#endregion
