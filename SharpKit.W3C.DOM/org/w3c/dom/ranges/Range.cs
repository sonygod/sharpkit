//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.ranges
{

using SharpKit.JavaScript;
using DOMException = org.w3c.dom.DOMException;
using DocumentFragment = org.w3c.dom.DocumentFragment;
using Node = org.w3c.dom.Node;
using ClientRect = org.w3c.dom.views.ClientRect;
using ClientRectList = org.w3c.dom.views.ClientRectList;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class Range
{

	// Range
	public Node startContainer {get;private set;}
	public int startOffset {get;private set;}
	public Node endContainer {get;private set;}
	public int endOffset {get;private set;}
	public bool collapsed {get;private set;}
	public Node commonAncestorContainer {get;private set;}
	public void setStart(Node refNode, int offset) {}
	public void setEnd(Node refNode, int offset) {}
	public void setStartBefore(Node refNode) {}
	public void setStartAfter(Node refNode) {}
	public void setEndBefore(Node refNode) {}
	public void setEndAfter(Node refNode) {}
	public void collapse(bool toStart) {}
	public void selectNode(Node refNode) {}
	public void selectNodeContents(Node refNode) {}
	public static short START_TO_START = 0;
	public static short START_TO_END = 1;
	public static short END_TO_END = 2;
	public static short END_TO_START = 3;
	public short compareBoundaryPoints(short how, Range sourceRange) { return default(short); }
	public void deleteContents() {}
	public DocumentFragment extractContents() { return default(DocumentFragment); }
	public DocumentFragment cloneContents() { return default(DocumentFragment); }
	public void insertNode(Node newNode) {}
	public void surroundContents(Node newParent) {}
	public Range cloneRange() { return default(Range); }
	public string toString() { return default(string); }
	public void detach() {}

	// Range-42
	public ClientRectList clientRects {get;private set;}
	public ClientRect boundingClientRect {get;private set;}
}

}