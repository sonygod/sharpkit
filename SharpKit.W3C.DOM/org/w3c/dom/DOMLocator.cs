//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class DOMLocator
{

	// DOMLocator
	public int lineNumber {get;private set;}
	public int columnNumber {get;private set;}
	public int byteOffset {get;private set;}
	public int utf16Offset {get;private set;}
	public Node relatedNode {get;private set;}
	public string uri {get;private set;}
}

}