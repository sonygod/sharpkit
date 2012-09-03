﻿using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.draggable
{
    [JsType(JsMode.Global)]
    public class Events
    {
        static Events()
        {
        }

        //TODO
        static void OnReady()
        {

            var start_counter = "#event-start"; 
            var drag_counter = "#event-drag";
            var stop_counter = "#event-stop";
            int[] counts = new int[3] { 0, 0, 0 };
            new jQuery( "#draggable" ).draggable(new DraggableOptions { 
                start = (e, ui) => {counts[0]++; updateCounterStatus(drag_counter, counts[0] )},
                drag = (e, ui)
            
            };


    //        $(function() {
    //    var $start_counter = $( "#event-start" ),
    //        $drag_counter = $( "#event-drag" ),
    //        $stop_counter = $( "#event-stop" ),
    //        counts = [ 0, 0, 0 ];

    //    $( "#draggable" ).draggable({
    //        start: function() {
    //            counts[ 0 ]++;
    //            updateCounterStatus( $start_counter, counts[ 0 ] );
    //        },
    //        drag: function() {
    //            counts[ 1 ]++;
    //            updateCounterStatus( $drag_counter, counts[ 1 ] );
    //        },
    //        stop: function() {
    //            counts[ 2 ]++;
    //            updateCounterStatus( $stop_counter, counts[ 2 ] );
    //        }
    //    });

    //    function updateCounterStatus( $event_counter, new_count ) {
    //        // first update the status visually...
    //        if ( !$event_counter.hasClass( "ui-state-hover" ) ) {
    //            $event_counter.addClass( "ui-state-hover" )
    //                .siblings().removeClass( "ui-state-hover" );
    //        }
    //        // ...then update the numbers
    //        $( "span.count", $event_counter ).text( new_count );
    //    }
    //});

            //static void updateCounterStatus(int event_counter,  int new_count ) 
            //{
            //    if (event_counter.hasClass("ui-state-hover")) {
            //        event_counter.addclass("ui-state-hover").siblings().removeclass("ui-state-hover");
            //    }
            //    new jQuery( "span.count", event_counter ).text(new_count);
            // }
        }
        //jQuery updateCounterStatus(JsString event_counter, int new_count)
        //{
        //    if (event_counter.hasClass("ui-state-hover"))
        //    {
        //        return event_counter.addclass("ui-state-hover").siblings().removeclass("ui-state-hover");
        //    }
        //    //TODO: $( "span.count", $event_counter ).text( new_count );
        //    return new jQuery("span.count", event_counter).text("new_count");
        //}
    }
}