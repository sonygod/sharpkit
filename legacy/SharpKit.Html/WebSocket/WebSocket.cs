using SharpKit.JavaScript;
//AutoGenerated

namespace SharpKit.Html
{

    [JsType(JsMode.Prototype, Name = "WebSocket")]
    public class WebSocket
    {
        public WebSocket(string url) { }
        public WebSocket(string url, JsString protocol) { }
        public JsString uRL { get; private set; }
        public const short CONNECTING = 0;
        public const short OPEN = 1;
        public const short CLOSED = 2;
        public short readyState { get; private set; }
        public int bufferedAmount { get; private set; }
        public JsAction onopen { get; set; }
        public JsAction<MessageEvent> onmessage { get; set; }
        public JsAction<CloseEvent> onclose { get; set; }
        public JsAction<MessageEvent> onerror { get; set; }
        public bool send(string data) { return false; }
        public void close() { }
    }

}
