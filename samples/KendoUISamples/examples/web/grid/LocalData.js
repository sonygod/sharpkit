/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    var fields = new Object();
    fields["FirstName"] = {type: "string"};
    fields["LastName"] = {type: "string"};
    fields["City"] = {type: "string"};
    fields["Title"] = {type: "string"};
    fields["BirthDate"] = {type: "date"};
    fields["Age"] = {type: "number"};
    $("#grid").kendoGrid(
    {
        dataSource:
        {
            data: createRandomData(50),
            schema:
            {
                model: {fields: fields}
            },
            pageSize: 10
        },
        height: 250,
        scrollable: true,
        sortable: true,
        filterable: true,
        pageable: true,
        columns:  [ {field: "FirstName", title: "First Name", width: 100}, {field: "LastName", title: "LastName", width: 100}, {field: "City", width: 100}, {field: "Title"}, {field: "BirthDate", title: "Birth Date", template: "#= kendo.toString(BirthDate,\'MM/dd/yyyy\') #"}, {field: " Age", width: 50}]
    });
};
