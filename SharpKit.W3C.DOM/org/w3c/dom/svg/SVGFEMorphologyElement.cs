//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.svg
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class SVGFEMorphologyElement : SVGElement
{

	// SVGFEMorphologyElement
	public static short SVG_MORPHOLOGY_OPERATOR_UNKNOWN = 0;
	public static short SVG_MORPHOLOGY_OPERATOR_ERODE = 1;
	public static short SVG_MORPHOLOGY_OPERATOR_DILATE = 2;
	public SVGAnimatedString in1 {get;private set;}
	public SVGAnimatedEnumeration @operator {get;private set;}
	public SVGAnimatedLength radiusX {get;private set;}
	public SVGAnimatedLength radiusY {get;private set;}
}

}