﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SharpKit.Html4;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Json, Export = false)]
    public class WebGLRenderTargetOptions
    {
        //todo add all other properties
        public JsBoolean generateMipmaps { get; set; }
    }
}