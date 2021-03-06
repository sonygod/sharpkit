/*Generated by SharpKit 5 v5.00.0000*/
var detailsTemplate = null;
var wnd = null;
$(OnReady);
function OnReady()
{
    var grid = $("#grid").kendoGrid(
    {
        dataSource: {pageSize: 10, data: createRandomData(50)},
        pageable: true,
        height: 260,
        columns:  [ {field: "FirstName", title: "First Name"}, {field: "LastName", title: "Last Name"}, {field: "Title"},
        {
            command: {text: "Details", click: showDetails},
            title: " ",
            width: "110px"
        }]
    }).data("kendoGrid");
    wnd = $("#details").kendoWindow( {title: "Customer Details", modal: true, visible: false, resizable: false, width: "300"}).data("kendoWindow");
    detailsTemplate = kendo.template($("#template").html());
};
function showDetails(e)
{
    e.preventDefault();
    var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
    wnd.center().open();
};
