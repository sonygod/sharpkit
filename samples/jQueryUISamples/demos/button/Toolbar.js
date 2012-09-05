/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#beginning").button(
    {
        text:false,
        icons:{primary:"ui-icon-seek-start"}
    });
    $("#rewind").button(
    {
        text:false,
        icons:{primary:"ui-icon-seek-prev"}
    });
    $("#play").button(
    {
        text:false,
        icons:{primary:"ui-icon-play"}
    }).click(function(e)
    {
        var option=($(e.currentTarget).text() === "play")?
        {
            label:"pause",
            icons:{primary:"ui-icon-pause"}
        }:
        {
            label:"play",
            icons:{primary:"ui-icon-play"}
        };
        $(e.currentTarget).button("option",option);
    });
    $("#stop").button(
    {
        text:false,
        icons:{primary:"ui-icon-stop"}
    }).click(function(e)
    {
        $("#play").button("option",
        {
            label:"play",
            icons:{primary:"ui-icon-slay"}
        });
    });
    $("#forward").button(
    {
        text:false,
        icons:{primary:"ui-icon-seek-next"}
    });
    $("#end").button(
    {
        text:false,
        icons:{primary:"ui-icon-seek-end"}
    });
    $("#shuffle").button();
    $("#repeat").buttonset();
};
