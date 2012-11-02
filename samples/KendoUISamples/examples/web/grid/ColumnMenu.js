/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    var fields = new Object();
    fields["OrderID"] = {type: "number"};
    fields["ShipCountry"] = {type: "string"};
    fields["ShipName"] = {type: "string"};
    fields["ShipAddress"] = {type: "string"};
    $("#grid").kendoGrid(
    {
        dataSource:
        {
            type: "odata",
            transport: {read: "http://demos.kendoui.com/service/Northwind.svc/Orders"},
            schema:
            {
                model: {fields: fields}
            },
            pageSize: 10,
            serverPaging: true,
            serverFiltering: true,
            serverSorting: true
        },
        height: 250,
        sortable: true,
        filterable: true,
        columnMenu: true,
        pageable: true,
        columns:  [ {field: "OrderID"}, {field: "ShipCountry"}, {field: "ShipName"}, {field: "ShipAddress", filterable: false}]
    });
};
