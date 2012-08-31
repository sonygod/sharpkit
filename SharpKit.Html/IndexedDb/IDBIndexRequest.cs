//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class IDBIndexRequest : IDBIndex
{

	// IDBIndexRequest
	public IDBRequest request {get; private set; }
	public void openObjectCursor() {}
	public void openObjectCursor(IDBKeyRange range) {}
	public void openObjectCursor(IDBKeyRange range, short direction) {}
	public void openCursor() {}
	public void openCursor(IDBKeyRange range) {}
	public void openCursor(IDBKeyRange range, short direction) {}
	public void put(object value) {}
	public void put(object value, object key) {}
	public void put(object value, object key, bool noOverwrite) {}
	public void getObject(object key) {}
	public void get(object key) {}
	public void remove(object key) {}
}

}