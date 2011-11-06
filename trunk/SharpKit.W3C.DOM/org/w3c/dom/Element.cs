using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom
{

    using ClientRect = org.w3c.dom.views.ClientRect;
    using ClientRectList = org.w3c.dom.views.ClientRectList;

    public interface Element : Node
    {
        // Element
        JsString tagName {get;}
        JsString getAttribute(string name);
//TODO:
//ORIGINAL LINE: public void setAttribute(String name, String value) throws DOMException;
        void setAttribute(string name, JsString value);
//TODO:
//ORIGINAL LINE: public void removeAttribute(String name) throws DOMException;
        void removeAttribute(string name);
        Attr getAttributeNode(string name);
//TODO:
//ORIGINAL LINE: public Attr setAttributeNode(Attr newAttr) throws DOMException;
        Attr setAttributeNode(Attr newAttr);
//TODO:
//ORIGINAL LINE: public Attr removeAttributeNode(Attr oldAttr) throws DOMException;
        Attr removeAttributeNode(Attr oldAttr);
        NodeList getElementsByTagName(string name);
//TODO:
//ORIGINAL LINE: public String getAttributeNS(String namespaceURI, String localName) throws DOMException;
        JsString getAttributeNS(string namespaceURI, JsString localName);
//TODO:
//ORIGINAL LINE: public void setAttributeNS(String namespaceURI, String qualifiedName, String value) throws DOMException;
        void setAttributeNS(string namespaceURI, JsString qualifiedName, JsString value);
//TODO:
//ORIGINAL LINE: public void removeAttributeNS(String namespaceURI, String localName) throws DOMException;
        void removeAttributeNS(string namespaceURI, JsString localName);
//TODO:
//ORIGINAL LINE: public Attr getAttributeNodeNS(String namespaceURI, String localName) throws DOMException;
        Attr getAttributeNodeNS(string namespaceURI, JsString localName);
//TODO:
//ORIGINAL LINE: public Attr setAttributeNodeNS(Attr newAttr) throws DOMException;
        Attr setAttributeNodeNS(Attr newAttr);
//TODO:
//ORIGINAL LINE: public NodeList getElementsByTagNameNS(String namespaceURI, String localName) throws DOMException;
        NodeList getElementsByTagNameNS(string namespaceURI, JsString localName);
        bool hasAttribute(string name);
//TODO:
//ORIGINAL LINE: public boolean hasAttributeNS(String namespaceURI, String localName) throws DOMException;
        bool hasAttributeNS(string namespaceURI, JsString localName);
        TypeInfo schemaTypeInfo {get;}
//TODO:
//ORIGINAL LINE: public void setIdAttribute(String name, boolean isId) throws DOMException;
        void setIdAttribute(string name, bool isId);
//TODO:
//ORIGINAL LINE: public void setIdAttributeNS(String namespaceURI, String localName, boolean isId) throws DOMException;
        void setIdAttributeNS(string namespaceURI, JsString localName, bool isId);
//TODO:
//ORIGINAL LINE: public void setIdAttributeNode(Attr idAttr, boolean isId) throws DOMException;
        void setIdAttributeNode(Attr idAttr, bool isId);
        // Element-41
        ClientRectList clientRects {get;}
        ClientRect boundingClientRect {get;}
        int scrollTop {get;set;}
        int scrollLeft {get;set;}
        int scrollWidth {get;}
        int scrollHeight {get;}
        int clientTop {get;}
        int clientLeft {get;}
        int clientWidth {get;}
        int clientHeight {get;}
        // NodeSelector
        Element querySelector(string selectors);
        NodeList querySelectorAll(string selectors);
    }

}