//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.DataTable_
{
    /// <summary>
    /// _API docs for this extension are included in the DataTable class._
    /// This DataTable class extension adds support for sorting the table data by API
    /// methods `table.sort(...)` or `table.toggleSort(...)` or by clicking on column
    /// headers in the rendered UI.
    /// Sorting by the API is enabled automatically when this module is `use()`d.  To
    /// enable UI triggered sorting, set the DataTable's `sortable` attribute to
    /// `true`.
    /// <pre><code>
    /// var table = new Y.DataTable({
    /// columns: [ 'id', 'username', 'name', 'birthdate' ],
    /// data: [ ... ],
    /// sortable: true
    /// });
    /// table.render('#table');
    /// </code></pre>
    /// Setting `sortable` to `true` will enable UI sorting for all columns.  To enable
    /// UI sorting for certain columns only, set `sortable` to an array of column keys,
    /// or just add `sortable: true` to the respective column configuration objects.
    /// This uses the default setting of `sortable: auto` for the DataTable instance.
    /// <pre><code>
    /// var table = new Y.DataTable({
    /// columns: [
    /// 'id',
    /// { key: 'username',  sortable: true },
    /// { key: 'name',      sortable: true },
    /// { key: 'birthdate', sortable: true }
    /// ],
    /// data: [ ... ]
    /// // sortable: 'auto' is the default
    /// });
    /// // OR
    /// var table = new Y.DataTable({
    /// columns: [ 'id', 'username', 'name', 'birthdate' ],
    /// data: [ ... ],
    /// sortable: [ 'username', 'name', 'birthdate' ]
    /// });
    /// </code></pre>
    /// To disable UI sorting for all columns, set `sortable` to `false`.  This still
    /// permits sorting via the API methods.
    /// As new records are inserted into the table's `data` ModelList, they will be inserted at the correct index to preserve the sort order.
    /// The current sort order is stored in the `sortBy` attribute.  Assigning this value at instantiation will automatically sort your data.
    /// Sorting is done by a simple value comparison using &lt; and &gt; on the field
    /// value.  If you need custom sorting, add a sort function in the column's
    /// `sortFn` property.  Columns whose content is generated by formatters, but don't
    /// relate to a single `key`, require a `sortFn` to be sortable.
    /// <pre><code>
    /// function nameSort(a, b, desc) {
    /// var aa = a.get('lastName') + a.get('firstName'),
    /// bb = a.get('lastName') + b.get('firstName'),
    /// order = (aa > bb) ? 1 : -(aa < bb);
    /// return desc ? -order : order;
    /// }
    /// var table = new Y.DataTable({
    /// columns: [ 'id', 'username', { key: name, sortFn: nameSort }, 'birthdate' ],
    /// data: [ ... ],
    /// sortable: [ 'username', 'name', 'birthdate' ]
    /// });
    /// </code></pre>
    /// See the user guide for more details.
    /// </summary>
    public partial class Sortable
    {
    }
}
