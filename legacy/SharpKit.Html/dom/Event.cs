
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser" at Sun, 29 Jul 2012 15:47:54 GMT

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/dom/Event.idl

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

namespace SharpKit.Html
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, OmitCasts = true, Name = "Event")]
public partial class DOMEvent
{
	public  static int NONE = 0;
	public  static int CAPTURING_PHASE = 1;
	public  static int AT_TARGET = 2;
	public  static int BUBBLING_PHASE = 3;
	public  static int MOUSEDOWN = 1;
	public  static int MOUSEUP = 2;
	public  static int MOUSEOVER = 4;
	public  static int MOUSEOUT = 8;
	public  static int MOUSEMOVE = 16;
	public  static int MOUSEDRAG = 32;
	public  static int CLICK = 64;
	public  static int DBLCLICK = 128;
	public  static int KEYDOWN = 256;
	public  static int KEYUP = 512;
	public  static int KEYPRESS = 1024;
	public  static int DRAGDROP = 2048;
	public  static int FOCUS = 4096;
	public  static int BLUR = 8192;
	public  static int SELECT = 16384;
	public  static int CHANGE = 32768;
	public  JsString type {get; set; }
	public  EventTarget target {get; set; }
	public  EventTarget currentTarget {get; set; }
	public  int eventPhase {get; set; }
	public  bool bubbles {get; set; }
	public  bool cancelable {get; set; }
	public  object timeStamp {get; set; }
	public  void stopPropagation() {}
	public  void preventDefault() {}
	public  void initEvent(string eventTypeArg, bool canBubbleArg, bool cancelableArg) {}
	public  bool defaultPrevented {get; set; }
	public  void stopImmediatePropagation() {}
	public  EventTarget srcElement {get; set; }
	public  bool returnValue {get; set; }
	public  bool cancelBubble {get; set; }
	public  Clipboard clipboardData {get; set; }
}

}