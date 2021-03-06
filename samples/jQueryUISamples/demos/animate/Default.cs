﻿using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.animate
{
    [JsType(JsMode.Global)]
    public class Default
    {
        static Default()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#button").toggle(
                e =>
                        new jQuery("#effect").animate(new AnimationPropertiesEx
                {
                    backgroundColor = "#aa0000",
                    color = "#fff",
                    width = "500"
                }, 1000),

                    e => new jQuery("#effect").animate(new AnimationPropertiesEx
                    {
                        backgroundColor = "#fff",
                        color = "#000",
                        width = "240"
                    }, 1000));
        }
    }
}