//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class Location
{

	// Location
	public JsString href {get; set; }
	public void assign(string url) {}
	public void replace(string url) {}
	public void reload() {}
	public void reload(bool forceGet) { }
	public JsString protocol {get; set; }
	public JsString host {get; set; }
	public JsString hostname {get; set; }
	public JsString port {get; set; }
	public JsString pathname {get; set; }
	public JsString search {get; set; }
	public JsString hash {get; set; }
	public JsString resolveURL(string url) { return default(JsString); }
}

}