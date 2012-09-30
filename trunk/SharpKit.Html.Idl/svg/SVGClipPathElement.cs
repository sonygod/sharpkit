
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Thu, 20 Sep 2012 15:27:33 GMT

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGClipPathElement.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

  Copyright (C) 2012 Sebastian Loncar, Web: http://loncar.de
  Copyright (C) 2009 Apple Inc. All Rights Reserved.

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;

namespace SharpKit.Html.svg
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "SVGClipPathElement")]
public partial class SvgClipPathElement : SvgElement, SvgTests, SvgLangSpace, SvgExternalResourcesRequired, SvgStylable, SvgTransformable
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('clippath')")]
	public   SvgClipPathElement() {}
	public  SvgAnimatedEnumeration clipPathUnits {get; set; }
	public  SvgStringList requiredFeatures {get; set; }
	public  SvgStringList requiredExtensions {get; set; }
	public  SvgStringList systemLanguage {get; set; }
	public  bool hasExtension(string extension) { return default(bool); }
	public  JsString xmllang {get; set; }
	public  JsString xmlspace {get; set; }
	public  SvgAnimatedBoolean externalResourcesRequired {get; set; }
	public  SvgAnimatedString className {get; set; }
	public  CssStyleDeclaration style {get; set; }
	public  CssValue getPresentationAttribute(string name) { return default(CssValue); }
	public  SvgAnimatedTransformList transform {get; set; }
	public  SvgElement nearestViewportElement {get; set; }
	public  SvgElement farthestViewportElement {get; set; }
	public  SvgRect getBBox() { return default(SvgRect); }
	public  SvgMatrix getCTM() { return default(SvgMatrix); }
	public  SvgMatrix getScreenCTM() { return default(SvgMatrix); }
	public  SvgMatrix getTransformToElement(SvgElement element) { return default(SvgMatrix); }
}

}