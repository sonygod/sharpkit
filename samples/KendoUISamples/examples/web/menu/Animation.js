/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function getEffects()
{
    var expand = $("#expand")[0].checked;
    var slide = $("#slide")[0].checked;
    var opacity = $("#opacity")[0].checked;
    var s = "";
    if (expand)
        s += "expand:vertical ";
    if (slide)
        s += "slideIn:down ";
    if (opacity)
        s += "fadeIn";
    if (s == "")
        return false;
    return s;
};
function initMenu()
{
    $("#menu").kendoMenu(
    {
        animation:
        {
            open: {effects: getEffects()}
        },
        hoverDelay: $("#delay")[0].value
    }).css( {marginRight: "220px"});
};
function OnReady()
{
    var original = $("#menu").clone(true);
    original.find(".k-state-active").removeClass("k-state-active");
    $(".configuration input").change(function (e)
    {
        var menu = $("#menu");
        var clone = original.clone(true);
        menu.data("kendoMenu").close($("#menu .k-link"));
        menu.replaceWith(clone);
        initMenu();
    });
    initMenu();
};
