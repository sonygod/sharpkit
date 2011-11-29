//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.indexeddb
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class IDBRequest
{

	// IDBRequest
	public void abort() {}
	public static short INITIAL = 0;
	public static short LOADING = 1;
	public static short DONE = 2;
	public short readyState {get;private set;}
	public IDBDatabaseError error {get;private set;}
	public object result {get;private set;}
	public JsAction onsuccess {get;set;}
	public JsAction onerror {get;set;}
}

}