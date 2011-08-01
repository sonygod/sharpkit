using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.webstorage
{

    using Event = org.w3c.dom.events.Event;

    public interface StorageEvent : org.w3c.dom.events.Event
    {
        // StorageEvent
        JsString key {get;}
        object oldValue {get;}
        object newValue {get;}
        JsString url {get;}
        Storage storageArea {get;}
        void initStorageEvent(string typeArg, bool canBubbleArg, bool cancelableArg, JsString keyArg, object oldValueArg, object newValueArg, JsString urlArg, Storage storageAreaArg);
    }

}
