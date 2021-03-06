//Generated by a tool of Sebastian Loncar

namespace SharpKit.Html
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true)]
public partial class SVGFECompositeElement : SVGElement
{

	// SVGFECompositeElement
	public static short SVG_FECOMPOSITE_OPERATOR_UNKNOWN = 0;
	public static short SVG_FECOMPOSITE_OPERATOR_OVER = 1;
	public static short SVG_FECOMPOSITE_OPERATOR_IN = 2;
	public static short SVG_FECOMPOSITE_OPERATOR_OUT = 3;
	public static short SVG_FECOMPOSITE_OPERATOR_ATOP = 4;
	public static short SVG_FECOMPOSITE_OPERATOR_XOR = 5;
	public static short SVG_FECOMPOSITE_OPERATOR_ARITHMETIC = 6;
	public SVGAnimatedString in1 {get; private set; }
	public SVGAnimatedString in2 {get; private set; }
	public SVGAnimatedEnumeration @operator {get; private set; }
	public SVGAnimatedNumber k1 {get; private set; }
	public SVGAnimatedNumber k2 {get; private set; }
	public SVGAnimatedNumber k3 {get; private set; }
	public SVGAnimatedNumber k4 {get; private set; }
}

}