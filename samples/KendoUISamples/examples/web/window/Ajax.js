/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    var window = $("#window");
    var undo = $("#undo").bind("click", function (e)
    {
        window.data("kendoWindow").open();
    });
    undo.hide();
    var onClose = function ()
    {
        undo.show();
    };
    if (window.data("kendoWindow") == null)
    {
        window.kendoWindow( {width: "615px", title: "Rams\'s Ten Principles of Good Design", content: "../../content/web/window/ajax/ajaxContent.html", close: onClose});
    }
};
