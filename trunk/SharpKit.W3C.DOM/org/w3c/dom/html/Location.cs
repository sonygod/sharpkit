using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    public interface Location
    {
        // Location
        JsString href {get;set;}
        void assign(string url);
        void replace(string url);
        void reload();
        JsString protocol {get;set;}
        JsString host {get;set;}
        JsString hostname {get;set;}
        JsString port {get;set;}
        JsString pathname {get;set;}
        JsString search {get;set;}
        JsString hash {get;set;}
        JsString resolveURL(string url);
    }

}