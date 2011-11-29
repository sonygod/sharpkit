//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.indexeddb
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class IDBObjectStoreRequest : IDBObjectStore
{

	// IDBObjectStoreRequest
	public IDBRequest request {get;private set;}
	public void put(object value) {}
	public void put(object value, object key) {}
	public void put(object value, object key, bool noOverwrite) {}
	public void remove(object key) {}
	public void get(object key) {}
	public void openCursor() {}
	public void openCursor(IDBKeyRange range) {}
	public void openCursor(IDBKeyRange range, short direction) {}
}

}