//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.geolocation
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class PositionError
{

	// PositionError
	public static short PERMISSION_DENIED = 1;
	public static short POSITION_UNAVAILABLE = 2;
	public static short TIMEOUT = 3;
	public short code {get;private set;}
	public string message {get;private set;}
}

}