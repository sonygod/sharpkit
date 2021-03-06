//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.layout.container
namespace Ext.layout.container
{
    #region Table
    /// <summary>
    /// This layout allows you to easily render content into an HTML table.  The total number of columns can be
    /// specified, and rowspan and colspan can be used to create complex layouts within the table.
    /// This class is intended to be extended or created via the layout: {type: &#39;table&#39;} Ext.container.Container.layout config, and should generally not need to be created directly via the new keyword. Note that when creating a layout via config, the layout-specific config properties must be passed in via
    /// the Ext.container.Container.layout object which will then be applied internally to the layout.  In the
    /// case of TableLayout, the only valid layout config properties are columns and tableAttrs.
    /// However, the items added to a TableLayout can supply the following table-specific config properties:  rowspan Applied to the table cell containing the item. colspan Applied to the table cell containing the item. cellId An id applied to the table cell containing the item. cellCls A CSS class name added to the table cell containing the item.  The basic concept of building up a TableLayout is conceptually very similar to building up a standard
    /// HTML table.  You simply add each panel (or &quot;cell&quot;) that you want to include along with any span attributes
    /// specified as the special config properties of rowspan and colspan which work exactly like their HTML counterparts.
    /// Rather than explicitly creating and nesting rows and columns as you would in HTML, you simply specify the
    /// total column count in the layoutConfig and start adding panels in their natural order from left to right,
    /// top to bottom.  The layout will automatically figure out, based on the column count, rowspans and colspans,
    /// how to position each panel within the table.  Just like with HTML tables, your rowspans and colspans must add
    /// up correctly in your overall layout or you&#39;ll end up with missing and/or extra cells!  Example usage:  // This code will generate a layout table that is 3 columns by 2 rows
    /// // with some spanning included.  The basic layout will be:
    /// // +--------+-----------------+
    /// // |   A    |   B             |
    /// // |        |--------+--------|
    /// // |        |   C    |   D    |
    /// // +--------+--------+--------+
    /// Ext.create(&#39;Ext.panel.Panel&#39;, {
    /// title: &#39;Table Layout&#39;,
    /// width: 300,
    /// height: 150,
    /// layout: {
    /// type: &#39;table&#39;,
    /// // The total column count must be specified here
    /// columns: 3
    /// },
    /// defaults: {
    /// // applied to each contained panel
    /// bodyStyle:&#39;padding:20px&#39;
    /// },
    /// items: [{
    /// html: &#39;Cell A content&#39;,
    /// rowspan: 2
    /// },{
    /// html: &#39;Cell B content&#39;,
    /// colspan: 2
    /// },{
    /// html: &#39;Cell C content&#39;,
    /// cellCls: &#39;highlight&#39;
    /// },{
    /// html: &#39;Cell D content&#39;
    /// }],
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Table : Auto
    {
        public Table(Ext.layout.container.TableConfig config){}
        public Table(){}
    }
    #endregion
    #region TableConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class TableConfig : AutoConfig
    {
        /// <summary>
        /// The total number of columns to create in the table for this layout. ...
        /// </summary>
        public JsNumber columns{get;set;}
        /// <summary>
        /// An object containing properties which are added to the DomHelper specification
        /// used to create the layout's table...
        /// </summary>
        public object tableAttrs{get;set;}
        /// <summary>
        /// An object containing properties which are added to the DomHelper specification
        /// used to create the layout's &lt;td&gt;...
        /// </summary>
        public object tdAttrs{get;set;}
        /// <summary>
        /// An object containing properties which are added to the DomHelper specification
        /// used to create the layout's &lt;tr&gt;...
        /// </summary>
        public object trAttrs{get;set;}
    }
    #endregion
    #region TableEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class TableEvents : AutoEvents
    {
    }
    #endregion
}
#endregion
