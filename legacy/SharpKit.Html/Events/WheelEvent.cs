//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class WheelEvent : MouseEvent
{

	// WheelEvent
	public static int DOM_DELTA_PIXEL = 0x00;
	public static int DOM_DELTA_LINE = 0x01;
	public static int DOM_DELTA_PAGE = 0x02;
	public int deltaX {get; private set; }
	public int deltaY {get; private set; }
	public int deltaZ {get; private set; }
	public int deltaMode {get; private set; }
	public void initWheelEvent(string typeArg, bool canBubbleArg, bool cancelableArg, AbstractView viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, short buttonArg, EventTarget relatedTargetArg, string modifiersListArg, int deltaXArg, int deltaYArg, int deltaZArg, int deltaMode) {}
}

}