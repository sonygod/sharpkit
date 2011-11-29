//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.webstorage
{

using SharpKit.JavaScript;
using Event = org.w3c.dom.events.Event;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class StorageEvent : Event
{

	// StorageEvent
	public string key {get { return default(string); } }
	public object oldValue {get { return default(object); } }
	public object newValue {get { return default(object); } }
	public string url {get { return default(string); } }
	public Storage storageArea {get { return default(Storage); } }
	public void initStorageEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string keyArg, object oldValueArg, object newValueArg, string urlArg, Storage storageAreaArg) {}
}

}