//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class Node
{

	// Node
	public static short ELEMENT_NODE = 1;
	public static short ATTRIBUTE_NODE = 2;
	public static short TEXT_NODE = 3;
	public static short CDATA_SECTION_NODE = 4;
	public static short ENTITY_REFERENCE_NODE = 5;
	public static short ENTITY_NODE = 6;
	public static short PROCESSING_INSTRUCTION_NODE = 7;
	public static short COMMENT_NODE = 8;
	public static short DOCUMENT_NODE = 9;
	public static short DOCUMENT_TYPE_NODE = 10;
	public static short DOCUMENT_FRAGMENT_NODE = 11;
	public static short NOTATION_NODE = 12;
	public JsString nodeName {get; private set; }
	public JsString nodeValue {get; set; }
	public short nodeType {get; private set; }
	public Node parentNode {get; private set; }
	public NodeList childNodes {get; private set; }
	public Node firstChild {get; private set; }
	public Node lastChild {get; private set; }
	public Node previousSibling {get; private set; }
	public Node nextSibling {get; private set; }
	public NamedNodeMap attributes {get; private set; }
	public Document ownerDocument {get; private set; }
	public Node insertBefore(Node newChild, Node refChild) { return default(Node); }
	public Node replaceChild(Node newChild, Node oldChild) { return default(Node); }
	public Node removeChild(Node oldChild) { return default(Node); }
	public Node appendChild(Node newChild) { return default(Node); }
	public bool hasChildNodes() { return default(bool); }
	public Node cloneNode(bool deep) { return default(Node); }
	public void normalize() {}
	public bool isSupported(string feature, string version) { return default(bool); }
	public JsString namespaceURI {get; private set; }
	public JsString prefix {get; set; }
	public JsString localName {get; private set; }
	public bool hasAttributes() { return default(bool); }
	public JsString baseURI {get; private set; }
	public static short DOCUMENT_POSITION_DISCONNECTED = 0x01;
	public static short DOCUMENT_POSITION_PRECEDING = 0x02;
	public static short DOCUMENT_POSITION_FOLLOWING = 0x04;
	public static short DOCUMENT_POSITION_CONTAINS = 0x08;
	public static short DOCUMENT_POSITION_CONTAINED_BY = 0x10;
	public static short DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 0x20;
	public short compareDocumentPosition(Node other) { return default(short); }
	public JsString textContent {get; set; }
	public bool isSameNode(Node other) { return default(bool); }
	public JsString lookupPrefix(string namespaceURI) { return default(JsString); }
	public bool isDefaultNamespace(string namespaceURI) { return default(bool); }
	public JsString lookupNamespaceURI(string prefix) { return default(JsString); }
	public bool isEqualNode(Node arg) { return default(bool); }
	public object getFeature(string feature, string version) { return default(object); }
	public object setUserData(string key, object data, UserDataHandler handler) { return default(object); }
	public object getUserData(string key) { return default(object); }
}

}