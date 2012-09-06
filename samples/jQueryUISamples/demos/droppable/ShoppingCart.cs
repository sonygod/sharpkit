﻿using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html4;

namespace jQueryUISamples.demos.droppable
{
    [JsType(JsMode.Global)]
    public class ShoppingCart
    {
        static ShoppingCart()
        {
            new jQuery(OnReady);
        }

        static void OnReady()
        {
            new jQuery("#catalog").accordion();
            new jQuery("#catalog li").draggable(new DraggableOptions
            {
                appendTo = "body",
                helper = "clone"
            });
            new jQuery("#cart ol").droppable(new DroppableOptions
            {
                activeClass = "ui-state-default",
                hoverClass = "ui-state-hover",
                accept = ":not(.ui-sortable-helper)",
                drop = (e, ui) =>
                    {
                        new jQuery(e.currentTarget).find(".placeholder").remove();
                        new jQuery("<li></li>").text(ui.draggable.text()).appendTo(e.currentTarget);
                    }
            })
                    .sortable(new SortableOptions
                    {
                        items = "li:not(.placeholder)",
                        sort = (e, ui) =>
                            // gets added unintentionally by droppable interacting with sortable
                            // using connectWithSortable fixes this, but doesn't allow you to customize active/hoverClass options
                    new jQuery(e.currentTarget).removeClass("ui-state-default")
                    });   


    //        $(function() {
    //    $( "#catalog" ).accordion();
    //    $( "#catalog li" ).draggable({
    //        appendTo: "body",
    //        helper: "clone"
    //    });
    //    $( "#cart ol" ).droppable({
    //        activeClass: "ui-state-default",
    //        hoverClass: "ui-state-hover",
    //        accept: ":not(.ui-sortable-helper)",
    //        drop: function( event, ui ) {
    //            $( this ).find( ".placeholder" ).remove();
    //            $( "<li></li>" ).text( ui.draggable.text() ).appendTo( this );
    //        }
    //    }).sortable({
    //        items: "li:not(.placeholder)",
    //        sort: function() {
    //            // gets added unintentionally by droppable interacting with sortable
    //            // using connectWithSortable fixes this, but doesn't allow you to customize active/hoverClass options
    //            $( this ).removeClass( "ui-state-default" );
    //        }
    //    });
    //});
        }
    }
}