/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#from").datepicker(
    {
        defaultDate:"+1w",
        changeMonth:true,
        numberOfMonths:3,
        onSelect:function(selectedDate,inst)
        {
            $("#to").datepicker("option","minDate",selectedDate);
        }
    });
    $("#to").datepicker(
    {
        defaultDate:"+1w",
        changeMonth:true,
        numberOfMonths:3,
        onSelect:function(selectedDate,inst)
        {
            $("#from").datepicker("option","maxDate",selectedDate);
        }
    });
};
