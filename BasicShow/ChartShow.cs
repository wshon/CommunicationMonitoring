using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicShow
{
    class ChartShow
    {
        //private void Current_Graphic_Input(int series, double current)
        //{
        //    if (startTime == null) startTime = DateTime.Now;
        //    Invoke((MethodInvoker)delegate ()
        //    {
        //        //chartShow.Series[series].Points.AddY(current);
        //        chartShow.Series[series].Points.AddXY((long)((DateTime.Now - startTime).TotalSeconds), current);
        //    });
        //}
        //private void ShowSeriesSource(CheckBox checkBoxTmp)
        //{
        //    string seriesName = checkBoxTmp.Name.Replace("checkBox", "Series");
        //    Invoke((MethodInvoker)delegate ()
        //    {
        //        chartShow.Series[seriesName].Enabled = checkBoxTmp.Checked;
        //        //chartShow.Series[seriesName].Color = checkBoxTmp.ForeColor;
        //    });
        //}
        //private void ShowSeriesSource(CheckBox checkBoxTmp, Color colorTmp)
        //{
        //    string seriesName = checkBoxTmp.Name.Replace("checkBox", "Series");
        //    Invoke((MethodInvoker)delegate ()
        //    {
        //        chartShow.Series[seriesName].Enabled = checkBoxTmp.Checked;
        //        chartShow.Series[seriesName].Color = colorTmp;
        //    });
        //}

        //private void IsShowSeriesSource(CheckBox checkBoxTmp)
        //{
        //    string seriesName = checkBoxTmp.Name.Replace("checkBox", "Series");

        //    Invoke((MethodInvoker)delegate ()
        //    {
        //        checkBoxTmp.Checked = chartShow.Series[seriesName].Enabled;
        //        checkBoxTmp.ForeColor = chartShow.Series[seriesName].Color;
        //    });
        //}

        //private void checkBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    ShowSeriesSource((sender as CheckBox));
        //}

        //private void checkBox_ForeColorChanged(object sender, EventArgs e)
        //{
        //    ShowSeriesSource((sender as CheckBox), (sender as CheckBox).ForeColor);
        //}

        //private void tabPageSetSeries_Enter(object sender, EventArgs e)
        //{



        //}

        //private void tabPageSeries_Enter(object sender, EventArgs e)
        //{
        //    chartShow.ResetAutoValues();

        //    Control.ControlCollection controlsTmp;
        //    controlsTmp = (sender as TabPage).Controls[0].Controls[1].Controls["flowLayoutPanelSeriesSet"].Controls;
        //    if (controlsTmp.Count == 0)
        //    {
        //        foreach (Series item in chartShow.Series)
        //        {
        //            CheckBox checkBoxTmp = new CheckBox();
        //            checkBoxTmp.Name = (item as Series).Name.Replace("Series", "checkBox");
        //            checkBoxTmp.Text = (item as Series).LegendText;
        //            checkBoxTmp.CheckedChanged += checkBox_CheckedChanged;
        //            checkBoxTmp.ForeColorChanged += checkBox_ForeColorChanged;
        //            checkBoxTmp.ContextMenuStrip = contextMenuStrip1;
        //            controlsTmp.Add(checkBoxTmp);
        //            IsShowSeriesSource(checkBoxTmp);
        //        }
        //    }
        //    else
        //    {
        //        foreach (Control item in controlsTmp)
        //        {
        //            IsShowSeriesSource((item as CheckBox));
        //        }
        //    }
        //    (sender as TabPage).Refresh();
        //}
    }
}
