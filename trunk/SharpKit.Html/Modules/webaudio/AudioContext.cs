
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/Modules/webaudio/AudioContext.idl

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

namespace SharpKit.Html.webaudio
{

using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.threads;
using SharpKit.Html.audio;
using SharpKit.Html.webaudio;
using SharpKit.Html.svg;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
public partial class AudioContext
{
	public  AudioDestinationNode destination {get; set; }
	public  double currentTime {get; set; }
	public  double sampleRate {get; set; }
	public  AudioListener listener {get; set; }
	public  int activeSourceCount {get; set; }
	public  AudioBuffer createBuffer(int numberOfChannels, int numberOfFrames, double sampleRate) { return default(AudioBuffer); }
	public  AudioBuffer createBuffer(ArrayBuffer buffer, bool mixToMono) { return default(AudioBuffer); }
	public  void decodeAudioData(ArrayBuffer audioData, AudioBufferCallback successCallback) {}
	public  void decodeAudioData(ArrayBuffer audioData, AudioBufferCallback successCallback, AudioBufferCallback errorCallback) {}
	public  AudioBufferSourceNode createBufferSource() { return default(AudioBufferSourceNode); }
	public  AudioGainNode createGainNode() { return default(AudioGainNode); }
	public  DelayNode createDelayNode() { return default(DelayNode); }
	public  DelayNode createDelayNode(double maxDelayTime) { return default(DelayNode); }
	public  BiquadFilterNode createBiquadFilter() { return default(BiquadFilterNode); }
	public  WaveShaperNode createWaveShaper() { return default(WaveShaperNode); }
	public  AudioPannerNode createPanner() { return default(AudioPannerNode); }
	public  ConvolverNode createConvolver() { return default(ConvolverNode); }
	public  DynamicsCompressorNode createDynamicsCompressor() { return default(DynamicsCompressorNode); }
	public  RealtimeAnalyserNode createAnalyser() { return default(RealtimeAnalyserNode); }
	public  JavaScriptAudioNode createJavaScriptNode(int bufferSize) { return default(JavaScriptAudioNode); }
	public  JavaScriptAudioNode createJavaScriptNode(int bufferSize, int numberOfInputChannels) { return default(JavaScriptAudioNode); }
	public  JavaScriptAudioNode createJavaScriptNode(int bufferSize, int numberOfInputChannels, int numberOfOutputChannels) { return default(JavaScriptAudioNode); }
	public  Oscillator createOscillator() { return default(Oscillator); }
	public  WaveTable createWaveTable(Float32Array real, Float32Array imag) { return default(WaveTable); }
	public  AudioChannelSplitter createChannelSplitter() { return default(AudioChannelSplitter); }
	public  AudioChannelSplitter createChannelSplitter(int numberOfOutputs) { return default(AudioChannelSplitter); }
	public  AudioChannelMerger createChannelMerger() { return default(AudioChannelMerger); }
	public  AudioChannelMerger createChannelMerger(int numberOfInputs) { return default(AudioChannelMerger); }
	public  EventListener oncomplete {get; set; }
	public  void startRendering() {}
}

}