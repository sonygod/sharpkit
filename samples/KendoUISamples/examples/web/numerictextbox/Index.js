/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    $("#numeric").kendoNumericTextBox();
    $("#currency").kendoNumericTextBox( {format: "c", decimals: 3});
    $("#percentage").kendoNumericTextBox( {format: "p0", min: 0, max: 0.1, step: 0.01});
    $("#custom").kendoNumericTextBox( {format: "#.00 kg"});
};
