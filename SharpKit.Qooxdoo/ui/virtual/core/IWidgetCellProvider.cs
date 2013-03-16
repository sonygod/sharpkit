// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.core
{
    /// <summary>
	/// <para>EXPERIMENTAL!</para>
	/// <para>A widget cell provider provides the <see cref="qx.ui.virtual.layer.WidgetCell"/>
	/// with configured widgets to render the cells and pools/releases unused
	/// cell widgets.</para>
	/// </summary>
	public interface IWidgetCellProvider
    {
		#region Methods

		/// <summary>
		/// <para>This method returns the configured cell for the given cell. The return
		/// value may be null to indicate that the cell should be empty.</para>
		/// </summary>
		/// <param name="row">The cell&#8217;s row index.</param>
		/// <param name="column">The cell&#8217;s column index.</param>
		/// <returns>The configured widget for the given cell.</returns>
		qx.ui.core.LayoutItem GetCellWidget(double row, double column);

		/// <summary>
		/// <para>Release the given cell widget. Either pool or destroy the widget.</para>
		/// </summary>
		/// <param name="widget">The cell widget to pool.</param>
		void PoolCellWidget(qx.ui.core.LayoutItem widget);

		#endregion Methods
    }
}