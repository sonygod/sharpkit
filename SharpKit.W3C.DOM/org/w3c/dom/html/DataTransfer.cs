//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;
using DOMStringList = org.w3c.dom.DOMStringList;
using Element = org.w3c.dom.Element;
using File = org.w3c.dom.file.File;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class DataTransfer
{

	// DataTransfer
	public string dropEffect {get;set;}
	public string effectAllowed {get;set;}
	public DOMStringList types {get;private set;}
	public void clearData() {}
	public void clearData(string format) {}
	public void setData(string format, string data) {}
	public string getData(string format) { return default(string); }
	public File files {get;private set;}
	public void setDragImage(Element image, int x, int y) {}
	public void addElement(Element element) {}
}

}