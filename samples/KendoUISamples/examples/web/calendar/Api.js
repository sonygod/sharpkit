/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    $("#calendar").kendoCalendar();
    var calendar = $("#calendar").data("kendoCalendar");
    calendar.value(new Date());
    var navigate = function ()
    {
        var value = $("#direction").val();
        switch (value)
        {
            case "up":
                calendar.navigateUp();
                break;
            case "down":
                calendar.navigateDown(calendar.value());
                break;
            case "past":
                calendar.navigateToPast();
                break;
            default :
                calendar.navigateToFuture();
                break;
        }
    };
    var setValue = function ()
    {
        calendar.value($("#value").val());
    };
    $("#get").click(function ()
    {
        window.alert(calendar.value());
    });
    $("#value").kendoDatePicker( {change: setValue});
    $("#set").click(setValue);
    $("#direction").kendoDropDownList( {change: navigate});
    $("#navigate").click(navigate);
};
