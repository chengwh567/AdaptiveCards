﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml;
using MarkedNet;
using Xceed.Wpf.Toolkit;

namespace Adaptive
{
    public partial class InputDate
    {
        /// <summary>
        /// Input.Date
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override FrameworkElement Render(RenderContext context)
        {
            var datePicker = new DatePicker();
            datePicker.ToolTip = this.Placeholder;
            DateTime value;
            if (DateTime.TryParse(this.Value, out value))
                datePicker.SelectedDate = value;
            DateTime minValue;
            if (DateTime.TryParse(this.Min, out minValue))
                datePicker.DisplayDateStart = minValue;
            DateTime maxValue;
            if (DateTime.TryParse(this.Max, out maxValue))
                datePicker.DisplayDateEnd = maxValue;
            datePicker.Style = context.GetStyle("Adaptive.Input.Date");
            datePicker.DataContext = this;
            context.InputControls.Add(datePicker);
            return datePicker;
        }
    }
}