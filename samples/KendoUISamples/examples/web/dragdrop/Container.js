/*Generated by SharpKit 5 v4.30.1000*/
$(OnReady);
function OnReady()
{
    $("#draggable-item").kendoDraggable(
    {
        container: $("#draggable-container"),
        hint: function ()
        {
            return $("#draggable-item").clone();
        }
    });
};
