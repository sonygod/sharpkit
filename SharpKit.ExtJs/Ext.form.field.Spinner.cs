//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.form.field
{
    #region Spinner
    /// <inheritdocs />
    /// <summary>
    /// <p>A field with a pair of up/down spinner buttons. This class is not normally instantiated directly,
    /// instead it is subclassed and the <see cref="Ext.form.field.Spinner.onSpinUp">onSpinUp</see> and <see cref="Ext.form.field.Spinner.onSpinDown">onSpinDown</see> methods are implemented
    /// to handle when the buttons are clicked. A good example of this is the <see cref="Ext.form.field.Number">Ext.form.field.Number</see>
    /// field which uses the spinner to increment and decrement the field's value by its
    /// <see cref="Ext.form.field.NumberConfig.step">step</see> config value.</p>
    /// <p>For example:</p>
    /// <pre><code><see cref="Ext.ExtContext.define">Ext.define</see>('Ext.ux.CustomSpinner', {
    /// extend: '<see cref="Ext.form.field.Spinner">Ext.form.field.Spinner</see>',
    /// alias: 'widget.customspinner',
    /// // override onSpinUp (using step isn't neccessary)
    /// onSpinUp: function() {
    /// var me = this;
    /// if (!me.readOnly) {
    /// var val = parseInt(me.getValue().split(' '), 10)||0; // gets rid of " Pack", defaults to zero on parse failure
    /// me.setValue((val + me.step) + ' Pack');
    /// }
    /// },
    /// // override onSpinDown
    /// onSpinDown: function() {
    /// var val, me = this;
    /// if (!me.readOnly) {
    /// var val = parseInt(me.getValue().split(' '), 10)||0; // gets rid of " Pack", defaults to zero on parse failure
    /// if (val &lt;= me.step) {
    /// me.setValue('Dry!');
    /// } else {
    /// me.setValue((val - me.step) + ' Pack');
    /// }
    /// }
    /// }
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.Panel">Ext.form.FormPanel</see>', {
    /// title: 'Form with SpinnerField',
    /// bodyPadding: 5,
    /// width: 350,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// items:[{
    /// xtype: 'customspinner',
    /// fieldLabel: 'How Much Beer?',
    /// step: 6
    /// }]
    /// });
    /// </code></pre>
    /// <p>By default, pressing the up and down arrow keys will also trigger the onSpinUp and onSpinDown methods;
    /// to prevent this, set <c><see cref="Ext.form.field.SpinnerConfig.keyNavEnabled">keyNavEnabled</see> = false</c>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Spinner : Ext.form.field.Trigger
    {
        /// <summary>
        /// Specifies whether the up and down arrow keys should trigger spinning up and down. Defaults to true.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool keyNavEnabled;
        /// <summary>
        /// Specifies whether the mouse wheel should trigger spinning up and down while the field has focus.
        /// Defaults to true.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool mouseWheelEnabled;
        /// <summary>
        /// Specifies whether the down spinner button is enabled. Defaults to true. To change this after the component is
        /// created, use the setSpinDownEnabled method.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool spinDownEnabled;
        /// <summary>
        /// Specifies whether the up spinner button is enabled. Defaults to true. To change this after the component is
        /// created, use the setSpinUpEnabled method.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool spinUpEnabled;
        /// <summary>
        /// The spinner down button element
        /// </summary>
        public Ext.dom.Element spinDownEl{get;set;}
        /// <summary>
        /// The spinner up button element
        /// </summary>
        public Ext.dom.Element spinUpEl{get;set;}
        /// <summary>
        /// Handles mousewheel events on the field
        /// </summary>
        /// <param name="e">
        /// </param>
        private void onMouseWheel(object e){}
        /// <summary>
        /// Override.
        /// Overrides: <see cref="Ext.util.Renderable.onRender">Ext.util.Renderable.onRender</see>
        /// </summary>
        private void onRender(){}
        /// <summary>
        /// This method is called when the spinner down button is clicked, or when the down arrow key is pressed if
        /// keyNavEnabled is true. Must be implemented by subclasses.
        /// </summary>
        protected void onSpinDown(){}
        /// <summary>
        /// This method is called when the spinner up button is clicked, or when the up arrow key is pressed if
        /// keyNavEnabled is true. Must be implemented by subclasses.
        /// </summary>
        protected void onSpinUp(){}
        /// <summary>
        /// Handles the spinner up button clicks.
        /// </summary>
        private void onTrigger1Click(){}
        /// <summary>
        /// Handles the spinner down button clicks.
        /// </summary>
        private void onTrigger2Click(){}
        /// <summary>
        /// Sets whether the spinner down button is enabled.
        /// </summary>
        /// <param name="enabled"><p>true to enable the button, false to disable it.</p>
        /// </param>
        public void setSpinDownEnabled(bool enabled){}
        /// <summary>
        /// Sets whether the spinner up button is enabled.
        /// </summary>
        /// <param name="enabled"><p>true to enable the button, false to disable it.</p>
        /// </param>
        public void setSpinUpEnabled(bool enabled){}
        /// <summary>
        /// Triggers the spinner to step down; fires the spin and spindown events and calls the
        /// onSpinDown method. Does nothing if the field is disabled or if spinDownEnabled
        /// is false.
        /// </summary>
        public void spinDown(){}
        /// <summary>
        /// Triggers the spinner to step up; fires the spin and spinup events and calls the
        /// onSpinUp method. Does nothing if the field is disabled or if spinUpEnabled
        /// is false.
        /// </summary>
        public void spinUp(){}
        public Spinner(SpinnerConfig config){}
        public Spinner(){}
        public Spinner(params object[] args){}
    }
    #endregion
    #region SpinnerConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SpinnerConfig : Ext.form.field.TriggerConfig
    {
        /// <summary>
        /// Specifies whether the up and down arrow keys should trigger spinning up and down. Defaults to true.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool keyNavEnabled;
        /// <summary>
        /// Specifies whether the mouse wheel should trigger spinning up and down while the field has focus.
        /// Defaults to true.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool mouseWheelEnabled;
        /// <summary>
        /// Specifies whether the down spinner button is enabled. Defaults to true. To change this after the component is
        /// created, use the setSpinDownEnabled method.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool spinDownEnabled;
        /// <summary>
        /// Specifies whether the up spinner button is enabled. Defaults to true. To change this after the component is
        /// created, use the setSpinUpEnabled method.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool spinUpEnabled;
        public SpinnerConfig(params object[] args){}
    }
    #endregion
    #region SpinnerEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SpinnerEvents : Ext.form.field.TriggerEvents
    {
        /// <summary>
        /// Fires when the spinner is made to spin up or down.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="direction"><p>Either 'up' if spinning up, or 'down' if spinning down.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void spin(Spinner @this, JsString direction, object eOpts){}
        /// <summary>
        /// Fires when the spinner is made to spin down.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void spindown(Spinner @this, object eOpts){}
        /// <summary>
        /// Fires when the spinner is made to spin up.
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void spinup(Spinner @this, object eOpts){}
        public SpinnerEvents(params object[] args){}
    }
    #endregion
}
