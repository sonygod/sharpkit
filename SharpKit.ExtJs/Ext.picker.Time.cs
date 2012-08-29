//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.picker
{
    #region Time
    /// <inheritdocs />
    /// <summary>
    /// <p>A time picker which provides a list of times from which to choose. This is used by the <see cref="Ext.form.field.Time">Ext.form.field.Time</see>
    /// class to allow browsing and selection of valid times, but could also be used with other components.</p>
    /// <p>By default, all times starting at midnight and incrementing every 15 minutes will be presented. This list of
    /// available times can be controlled using the <see cref="Ext.picker.TimeConfig.minValue">minValue</see>, <see cref="Ext.picker.TimeConfig.maxValue">maxValue</see>, and <see cref="Ext.picker.TimeConfig.increment">increment</see>
    /// configuration properties. The format of the times presented in the list can be customized with the <see cref="Ext.picker.TimeConfig.format">format</see>
    /// config.</p>
    /// <p>To handle when the user selects a time from the list, you can subscribe to the <see cref="Ext.picker.TimeEvents.selectionchange">selectionchange</see> event.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.picker.Time">Ext.picker.Time</see>', {
    /// width: 60,
    /// minValue: <see cref="Ext.Date.parse">Ext.Date.parse</see>('04:30:00 AM', 'h:i:s A'),
    /// maxValue: <see cref="Ext.Date.parse">Ext.Date.parse</see>('08:00:00 AM', 'h:i:s A'),
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Time : Ext.view.BoundList
    {
        /// <summary>
        /// The default time format string which can be overriden for localization support. The format must be valid
        /// according to Ext.Date.parse.
        /// Defaults to <c>'g:i A'</c>, e.g., <c>'3:15 PM'</c>. For 24-hour time format try <c>'H:i'</c> instead.
        /// </summary>
        public JsString format;
        /// <summary>
        /// The number of minutes between each time value in the list.
        /// Defaults to: <c>15</c>
        /// </summary>
        public JsNumber increment;
        /// <summary>
        /// The maximum time to be shown in the list of times. This must be a Date object (only the time fields will be
        /// used); no parsing of String values will be done.
        /// </summary>
        public JsDate maxValue;
        /// <summary>
        /// The minimum time to be shown in the list of times. This must be a Date object (only the time fields will be
        /// used); no parsing of String values will be done.
        /// </summary>
        public JsDate minValue;
        /// <summary>
        /// Year, month, and day that all times will be normalized into internally.
        /// Defaults to: <c>[2008, 0, 1]</c>
        /// </summary>
        private JsArray initDate{get;set;}
        /// <summary>
        /// Creates the internal Ext.data.Store that contains the available times. The store
        /// is loaded with all possible times, and it is later filtered to hide those times outside
        /// the minValue/maxValue.
        /// </summary>
        private void createStore(){}
        /// <summary>
        /// Sets the year/month/day of the given Date object to the initDate, so that only
        /// the time fields are significant. This makes values suitable for time comparison.
        /// </summary>
        /// <param name="date">
        /// </param>
        private void normalizeDate(JsDate date){}
        /// <summary>
        /// Set the maxValue and update the list of available times. This must be a Date object (only the time
        /// fields will be used); no parsing of String values will be done.
        /// </summary>
        /// <param name="value">
        /// </param>
        public void setMaxValue(JsDate value){}
        /// <summary>
        /// Set the minValue and update the list of available times. This must be a Date object (only the time
        /// fields will be used); no parsing of String values will be done.
        /// </summary>
        /// <param name="value">
        /// </param>
        public void setMinValue(JsDate value){}
        /// <summary>
        /// Update the list of available times in the list to be constrained within the minValue
        /// and maxValue.
        /// </summary>
        public void updateList(){}
        public Time(Ext.picker.TimeConfig config){}
        public Time(){}
        public Time(params object[] args){}
    }
    #endregion
    #region TimeConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TimeConfig : Ext.view.BoundListConfig
    {
        /// <summary>
        /// The default time format string which can be overriden for localization support. The format must be valid
        /// according to Ext.Date.parse.
        /// Defaults to <c>'g:i A'</c>, e.g., <c>'3:15 PM'</c>. For 24-hour time format try <c>'H:i'</c> instead.
        /// </summary>
        public JsString format;
        /// <summary>
        /// The number of minutes between each time value in the list.
        /// Defaults to: <c>15</c>
        /// </summary>
        public JsNumber increment;
        /// <summary>
        /// The maximum time to be shown in the list of times. This must be a Date object (only the time fields will be
        /// used); no parsing of String values will be done.
        /// </summary>
        public JsDate maxValue;
        /// <summary>
        /// The minimum time to be shown in the list of times. This must be a Date object (only the time fields will be
        /// used); no parsing of String values will be done.
        /// </summary>
        public JsDate minValue;
        public TimeConfig(params object[] args){}
    }
    #endregion
    #region TimeEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TimeEvents : Ext.view.BoundListEvents
    {
        public TimeEvents(params object[] args){}
    }
    #endregion
}
