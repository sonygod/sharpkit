//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class MutationNameEvent : MutationEvent
{

	// MutationNameEvent
	public JsString prevNamespaceURI {get; private set; }
	public JsString prevNodeName {get; private set; }
	public void initMutationNameEvent(string typeArg, bool canBubbleArg, bool cancelableArg, Node relatedNodeArg, string prevNamespaceURIArg, string prevNodeNameArg) {}
}

}