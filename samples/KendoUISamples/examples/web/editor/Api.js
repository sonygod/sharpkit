/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#editor").kendoEditor();
    var editor=$("#editor").data("kendoEditor");
    var setValue=function()
    {
        editor.value($("#value").val());
    };
    $("#get").click(function()
    {
        window.alert(editor.value());
    });
    $("#set").click(setValue);
};
