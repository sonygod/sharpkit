using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.events
{

    using AbstractView = org.w3c.dom.views.AbstractView;

    public interface MouseEvent : UIEvent
    {
        // MouseEvent
        int screenX {get;}
        int screenY {get;}
        int clientX {get;}
        int clientY {get;}
        bool ctrlKey {get;}
        bool shiftKey {get;}
        bool altKey {get;}
        bool metaKey {get;}
        short button {get;}
        short buttons {get;}
        EventTarget relatedTarget {get;}
        void initMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, AbstractView viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, short buttonsArg, EventTarget relatedTargetArg);
        bool getModifierState(string keyArg);
        // MouseEvent-43
        int pageX {get;}
        int pageY {get;}
        int x {get;}
        int y {get;}
        int offsetX {get;}
        int offsetY {get;}
    }

}
