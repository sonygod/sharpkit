//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.grid.column
{
    #region Template
    /// <inheritdocs />
    /// <summary>
    /// <p>A Column definition class which renders a value by processing a <see cref="Ext.data.Model">Model</see>'s
    /// <see cref="Ext.data.ModelConfig.persistenceProperty">data</see> using a <see cref="Ext.grid.column.TemplateConfig.tpl">configured</see>
    /// <see cref="Ext.XTemplate">XTemplate</see>.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.Store">Ext.data.Store</see>', {
    /// storeId:'employeeStore',
    /// fields:['firstname', 'lastname', 'seniority', 'department'],
    /// groupField: 'department',
    /// data:[
    /// { firstname: "Michael", lastname: "Scott",   seniority: 7, department: "Management" },
    /// { firstname: "Dwight",  lastname: "Schrute", seniority: 2, department: "Sales" },
    /// { firstname: "Jim",     lastname: "Halpert", seniority: 3, department: "Sales" },
    /// { firstname: "Kevin",   lastname: "Malone",  seniority: 4, department: "Accounting" },
    /// { firstname: "Angela",  lastname: "Martin",  seniority: 5, department: "Accounting" }
    /// ]
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.Panel">Ext.grid.Panel</see>', {
    /// title: 'Column Template Demo',
    /// store: <see cref="Ext.data.StoreManager.lookup">Ext.data.StoreManager.lookup</see>('employeeStore'),
    /// columns: [
    /// { text: 'Full Name',       xtype: 'templatecolumn', tpl: '{firstname} {lastname}', flex:1 },
    /// { text: 'Department (Yrs)', xtype: 'templatecolumn', tpl: '{department} ({seniority})' }
    /// ],
    /// height: 200,
    /// width: 300,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Template : Ext.grid.column.Column
    {
        public Template(Ext.grid.column.TemplateConfig config){}
        public Template(){}
        public Template(params object[] args){}
    }
    #endregion
    #region TemplateConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TemplateConfig : Ext.grid.column.ColumnConfig
    {
        public TemplateConfig(params object[] args){}
    }
    #endregion
    #region TemplateEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TemplateEvents : Ext.grid.column.ColumnEvents
    {
        public TemplateEvents(params object[] args){}
    }
    #endregion
}
