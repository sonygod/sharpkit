using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.indexeddb
{

    public interface IDBIndexSync
    {
        // IDBIndexSync
//TODO:
//ORIGINAL LINE: public void openObjectCursor() throws IDBDatabaseException;
        void openObjectCursor();
//TODO:
//ORIGINAL LINE: public void openObjectCursor(IDBKeyRange range) throws IDBDatabaseException;
        void openObjectCursor(IDBKeyRange range);
//TODO:
//ORIGINAL LINE: public void openObjectCursor(IDBKeyRange range, short direction) throws IDBDatabaseException;
        void openObjectCursor(IDBKeyRange range, short direction);
//TODO:
//ORIGINAL LINE: public void openCursor() throws IDBDatabaseException;
        void openCursor();
//TODO:
//ORIGINAL LINE: public void openCursor(IDBKeyRange range) throws IDBDatabaseException;
        void openCursor(IDBKeyRange range);
//TODO:
//ORIGINAL LINE: public void openCursor(IDBKeyRange range, short direction) throws IDBDatabaseException;
        void openCursor(IDBKeyRange range, short direction);
//TODO:
//ORIGINAL LINE: public Object put(Object value) throws IDBDatabaseException;
        object put(object value);
//TODO:
//ORIGINAL LINE: public Object put(Object value, Object key) throws IDBDatabaseException;
        object put(object value, object key);
//TODO:
//ORIGINAL LINE: public Object put(Object value, Object key, boolean noOverwrite) throws IDBDatabaseException;
        object put(object value, object key, bool noOverwrite);
//TODO:
//ORIGINAL LINE: public Object getObject(Object key) throws IDBDatabaseException;
        object getObject(object key);
//TODO:
//ORIGINAL LINE: public Object get(Object key) throws IDBDatabaseException;
        object get(object key);
//TODO:
//ORIGINAL LINE: public void remove(Object key) throws IDBDatabaseException;
        void remove(object key);
    }

}
