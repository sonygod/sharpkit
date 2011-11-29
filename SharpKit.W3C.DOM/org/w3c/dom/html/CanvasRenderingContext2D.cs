//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;
using Element = org.w3c.dom.Element;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class CanvasRenderingContext2D
{

	// CanvasRenderingContext2D
	public HTMLCanvasElement canvas {get { return default(HTMLCanvasElement); } }
	public void save() {}
	public void restore() {}
	public void scale(float x, float y) {}
	public void rotate(float angle) {}
	public void translate(float x, float y) {}
	public void transform(float m11, float m12, float m21, float m22, float dx, float dy) {}
	public void setTransform(float m11, float m12, float m21, float m22, float dx, float dy) {}
	public float globalAlpha {get { return default(float); } set {}}
	public string globalCompositeOperation {get { return default(string); } set {}}
	public object strokeStyle {get { return default(object); } set {}}
	public object fillStyle {get { return default(object); } set {}}
	public CanvasGradient createLinearGradient(float x0, float y0, float x1, float y1) { return default(CanvasGradient); }
	public CanvasGradient createRadialGradient(float x0, float y0, float r0, float x1, float y1, float r1) { return default(CanvasGradient); }
	public CanvasPattern createPattern(HTMLImageElement image, string repetition) { return default(CanvasPattern); }
	public CanvasPattern createPattern(HTMLCanvasElement image, string repetition) { return default(CanvasPattern); }
	public CanvasPattern createPattern(HTMLVideoElement image, string repetition) { return default(CanvasPattern); }
	public float lineWidth {get { return default(float); } set {}}
	public string lineCap {get { return default(string); } set {}}
	public string lineJoin {get { return default(string); } set {}}
	public float miterLimit {get { return default(float); } set {}}
	public float shadowOffsetX {get { return default(float); } set {}}
	public float shadowOffsetY {get { return default(float); } set {}}
	public float shadowBlur {get { return default(float); } set {}}
	public string shadowColor {get { return default(string); } set {}}
	public void clearRect(float x, float y, float w, float h) {}
	public void fillRect(float x, float y, float w, float h) {}
	public void strokeRect(float x, float y, float w, float h) {}
	public void beginPath() {}
	public void closePath() {}
	public void moveTo(float x, float y) {}
	public void lineTo(float x, float y) {}
	public void quadraticCurveTo(float cpx, float cpy, float x, float y) {}
	public void bezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y) {}
	public void arcTo(float x1, float y1, float x2, float y2, float radius) {}
	public void rect(float x, float y, float w, float h) {}
	public void arc(float x, float y, float radius, float startAngle, float endAngle, bool anticlockwise) {}
	public void fill() {}
	public void stroke() {}
	public void clip() {}
	public bool isPointInPath(float x, float y) { return default(bool); }
	public bool drawFocusRing(Element element, float xCaret, float yCaret) { return default(bool); }
	public bool drawFocusRing(Element element, float xCaret, float yCaret, bool canDrawCustom) { return default(bool); }
	public string font {get { return default(string); } set {}}
	public string textAlign {get { return default(string); } set {}}
	public string textBaseline {get { return default(string); } set {}}
	public void fillText(string text, float x, float y) {}
	public void fillText(string text, float x, float y, float maxWidth) {}
	public void strokeText(string text, float x, float y) {}
	public void strokeText(string text, float x, float y, float maxWidth) {}
	public TextMetrics measureText(string text) { return default(TextMetrics); }
	public void drawImage(HTMLImageElement image, float dx, float dy) {}
	public void drawImage(HTMLImageElement image, float dx, float dy, float dw, float dh) {}
	public void drawImage(HTMLImageElement image, float sx, float sy, float sw, float sh, float dx, float dy, float dw, float dh) {}
	public void drawImage(HTMLCanvasElement image, float dx, float dy) {}
	public void drawImage(HTMLCanvasElement image, float dx, float dy, float dw, float dh) {}
	public void drawImage(HTMLCanvasElement image, float sx, float sy, float sw, float sh, float dx, float dy, float dw, float dh) {}
	public void drawImage(HTMLVideoElement image, float dx, float dy) {}
	public void drawImage(HTMLVideoElement image, float dx, float dy, float dw, float dh) {}
	public void drawImage(HTMLVideoElement image, float sx, float sy, float sw, float sh, float dx, float dy, float dw, float dh) {}
	public ImageData createImageData(float sw, float sh) { return default(ImageData); }
	public ImageData createImageData(ImageData imagedata) { return default(ImageData); }
	public ImageData getImageData(float sx, float sy, float sw, float sh) { return default(ImageData); }
	public void putImageData(ImageData imagedata, float dx, float dy) {}
	public void putImageData(ImageData imagedata, float dx, float dy, float dirtyX, float dirtyY, float dirtyWidth, float dirtyHeight) {}
}

}