/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    $("#button").click(function (e)
    {
        runEffect();
        return false;
    });
};
function runEffect()
{
    var selectedEffect = $("#effectTypes").val();
    var options = new Object();
    if (selectedEffect === "scale")
    {
        options = {percent: 0};
    }
    else if (selectedEffect === "transfer")
    {
        options = {to: "#button", className: "ui-effects-transfer"};
    }
    else if (selectedEffect === "size")
    {
        options =
        {
            to: {width: 200, height: 60}
        };
    }
    $("#effect").effect(selectedEffect, options, 500, callback);
};
function callback(ev, ui)
{
    window.setTimeout(function ()
    {
        $("#effect").removeAttr("style").hide().fadeIn();
    }, 1000);
};
