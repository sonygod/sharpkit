# sharpkit
Automatically exported from code.google.com/p/sharpkit


how to debug sharpkit


Debugging

Debugging of C# code from within the browser is currently supported in Google Chrome only.

A demo of debugging is available in our open-source SVN repository, named: SharpKitSourceMappingSample

http://code.google.com/p/sharpkit/source/checkout

To enable debugging of C# code, please follow these steps:

In your AssemblyInfo.cs file, add the following code:

   [JsExport(GenerateSourceMaps = true)]

Add a reference to SharpKit.Web assembly (found in .NET references dialog, or in the SharpKit program files folder)

Add the SourceMaps handler in your web.config file:

   <add name="SourceMapsHandler" type="SharpKit.Web.Server.Handlers.SourceMapsHandler, SharpKit.Web" verb="*" path="SourceMaps.ashx" />

full xml like

       <?xml version="1.0"?>
    
    <configuration>
      <system.web>
        <compilation debug="true" targetFramework="4.0" />
        <httpRuntime requestPathInvalidCharacters="" />
      </system.web>
      <system.webServer>
        <modules runAllManagedModulesForAllRequests="true" />
        <handlers>
          <add name="SourceMapsHandler" type="SharpKit.Web.Server.Handlers.SourceMapsHandler, SharpKit.Web" verb="*"
               path="SourceMaps.ashx" />
        </handlers>
      </system.webServer>
    
    </configuration>
     
Enable source maps in chrome: show development bar, click options wheel, check enable source maps.

Build your project

View in Google Chrome browser

Debug!



