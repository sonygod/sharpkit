/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#draggable").draggable({snap:true});
    $("#draggable2").draggable({snap:".ui-widget-header"});
    $("#draggable3").draggable({snap:".ui-widget-header",snapMode:"outer"});
    $("#draggable4").draggable({grid:[20,20]});
    $("#draggable5").draggable({grid:[80,80]});
};
