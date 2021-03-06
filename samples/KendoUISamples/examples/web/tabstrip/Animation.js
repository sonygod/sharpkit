/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    var original = $("#tabstrip").clone(true);
    original.find(".k-state-active").removeClass("k-state-active");
    $(".configuration input").change(function (e)
    {
        var tabStrip = $("#tabstrip"), clone = original.clone(true);
        var selectedIndex = tabStrip.data("kendoTabStrip").select();
        clone.children("ul").children("li").eq(selectedIndex).addClass("k-state-active").end();
        tabStrip.replaceWith(clone);
        initTabStrip();
    });
    initTabStrip();
};
function getEffects()
{
    var expand = $("#expand")[0].checked;
    var opacity = $("#opacity")[0].checked;
    var s = "";
    if (expand)
        s += "expand:vertical ";
    if (opacity)
        s += "fadeIn";
    if (s == "")
        return false;
    return s;
};
function initTabStrip()
{
    $("#tabstrip").kendoTabStrip(
    {
        animation:
        {
            open: {effects: getEffects()}
        }
    }).css( {marginRight: "220px"});
};
