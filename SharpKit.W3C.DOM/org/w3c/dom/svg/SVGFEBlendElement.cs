//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.svg
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class SVGFEBlendElement : SVGElement
{

	// SVGFEBlendElement
	public static short SVG_FEBLEND_MODE_UNKNOWN = 0;
	public static short SVG_FEBLEND_MODE_NORMAL = 1;
	public static short SVG_FEBLEND_MODE_MULTIPLY = 2;
	public static short SVG_FEBLEND_MODE_SCREEN = 3;
	public static short SVG_FEBLEND_MODE_DARKEN = 4;
	public static short SVG_FEBLEND_MODE_LIGHTEN = 5;
	public SVGAnimatedString in1 {get;private set;}
	public SVGAnimatedString in2 {get;private set;}
	public SVGAnimatedEnumeration mode {get;private set;}
}

}