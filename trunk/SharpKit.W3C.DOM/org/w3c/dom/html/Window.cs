using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.html
{

    using Document = org.w3c.dom.Document;
    using Element = org.w3c.dom.Element;
    using CSSStyleDeclaration = org.w3c.dom.css.CSSStyleDeclaration;
    using Database = org.w3c.dom.webdatabase.Database;
    using DatabaseCallback = org.w3c.dom.webdatabase.DatabaseCallback;
    using Storage = org.w3c.dom.webstorage.Storage;

    public interface Window
    {
        // Window
        Window window {get;}
        Window self {get;}
        JsString name {get;set;}
        Location location {get;set;}
        History history {get;}
        UndoManager undoManager {get;}
        Selection selection {get;}
        object locationbar {get;set;}
        object menubar {get;set;}
        object personalbar {get;set;}
        object scrollbars {get;set;}
        object statusbar {get;set;}
        object toolbar {get;set;}
        void close();
        void stop();
        void focus();
        void blur();
        object frames {get;set;}
        object length {get;set;}
        Window top {get;}
        object opener {get;set;}
        Window parent {get;}
        Element frameElement {get;}
        Window open();
        Window open(string url);
        Window open(string url, JsString target);
        Window open(string url, JsString target, JsString features);
        Window open(string url, JsString target, JsString features, JsString replace);
        Window getElement(int index);
        object getElement(string name);
        void setElement(string name, object value);
        Navigator navigator {get;}
        ApplicationCache applicationCache {get;}
        void alert(string message);
        bool confirm(string message);
        JsString prompt(string message);
        JsString prompt(string message, JsString _default);
        void print();
        object showModalDialog(string url);
        object showModalDialog(string url, object argument);
        void postMessage(object message, JsString targetOrigin);
        void postMessage(object message, JsString targetOrigin, MessagePort[] ports);
        Function onabort {get;set;}
        Function onafterprint {get;set;}
        Function onbeforeprint {get;set;}
        Function onbeforeunload {get;set;}
        Function onblur {get;set;}
        Function oncanplay {get;set;}
        Function oncanplaythrough {get;set;}
        Function onchange {get;set;}
        Function onclick {get;set;}
        Function oncontextmenu {get;set;}
        Function ondblclick {get;set;}
        Function ondrag {get;set;}
        Function ondragend {get;set;}
        Function ondragenter {get;set;}
        Function ondragleave {get;set;}
        Function ondragover {get;set;}
        Function ondragstart {get;set;}
        Function ondrop {get;set;}
        Function ondurationchange {get;set;}
        Function onemptied {get;set;}
        Function onended {get;set;}
        Function onerror {get;set;}
        Function onfocus {get;set;}
        Function onformchange {get;set;}
        Function onforminput {get;set;}
        Function onhashchange {get;set;}
        Function oninput {get;set;}
        Function oninvalid {get;set;}
        Function onkeydown {get;set;}
        Function onkeypress {get;set;}
        Function onkeyup {get;set;}
        Function onload {get;set;}
        Function onloadeddata {get;set;}
        Function onloadedmetadata {get;set;}
        Function onloadstart {get;set;}
        Function onmessage {get;set;}
        Function onmousedown {get;set;}
        Function onmousemove {get;set;}
        Function onmouseout {get;set;}
        Function onmouseover {get;set;}
        Function onmouseup {get;set;}
        Function onmousewheel {get;set;}
        Function onoffline {get;set;}
        Function ononline {get;set;}
        Function onpause {get;set;}
        Function onplay {get;set;}
        Function onplaying {get;set;}
        Function onpagehide {get;set;}
        Function onpageshow {get;set;}
        Function onpopstate {get;set;}
        Function onprogress {get;set;}
        Function onratechange {get;set;}
        Function onreadystatechange {get;set;}
        Function onredo {get;set;}
        Function onresize {get;set;}
        Function onscroll {get;set;}
        Function onseeked {get;set;}
        Function onseeking {get;set;}
        Function onselect {get;set;}
        Function onshow {get;set;}
        Function onstalled {get;set;}
        Function onstorage {get;set;}
        Function onsubmit {get;set;}
        Function onsuspend {get;set;}
        Function ontimeupdate {get;set;}
        Function onundo {get;set;}
        Function onunload {get;set;}
        Function onvolumechange {get;set;}
        Function onwaiting {get;set;}
        // Window-1
        CSSStyleDeclaration getComputedStyle(Element elt);
        CSSStyleDeclaration getComputedStyle(Element elt, JsString pseudoElt);
        // Window-2
        Document document {get;}
        StyleMedia styleMedia {get;}
        Screen screen {get;}
        int innerWidth {get;}
        int innerHeight {get;}
        int pageXOffset {get;}
        int pageYOffset {get;}
        void scroll(int x, int y);
        void scrollTo(int x, int y);
        void scrollBy(int x, int y);
        int screenX {get;}
        int screenY {get;}
        int outerWidth {get;}
        int outerHeight {get;}
        // WindowTimers
        int setTimeout(JsAction handler);
        int setTimeout(JsAction handler, object timeout, params object[] args);
        void clearTimeout(int handle);
        int setInterval(JsAction handler);
        int setInterval(JsAction handler, object timeout, params object[] args);
        void clearInterval(int handle);
        // WindowDatabase
        Database openDatabase(string name, JsString version, JsString displayName, int estimatedSize);
        Database openDatabase(string name, JsString version, JsString displayName, int estimatedSize, DatabaseCallback creationCallback);
        // WindowSessionStorage
        Storage sessionStorage {get;}
        // WindowLocalStorage
        Storage localStorage {get;}
    }

}