/*Generated by SharpKit v4.28.3000*/
function jQuerySelectorsSample_Load()
{
    $(".MyExpander > #Header").mousedown(function(e)
    {
        $(this).siblings(".MyExpander > #Content").toggle();
    });
};
