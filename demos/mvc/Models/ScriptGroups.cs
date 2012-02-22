﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Models
{
    public static class ScriptGroups
    {
        public static readonly IList<string> All = new string[]
        {
#if DEBUG
            "jquery.js",
            "kendo.core.js",
            "kendo.fx.js",
            "kendo.data.odata.js",
            "kendo.data.xml.js",
            "kendo.model.js",
            "kendo.data.js",
            "kendo.draganddrop.js",
            "kendo.popup.js",
            "kendo.list.js",
            "kendo.autocomplete.js",
            "kendo.calendar.js",
            "kendo.chart.js",
            "kendo.combobox.js",
            "kendo.datepicker.js",
            "kendo.dropdownlist.js",
            "kendo.numerictextbox.js",
            "kendo.validator.js",
            "kendo.binder.js",
            "kendo.editable.js",
            "kendo.filtermenu.js",
            "kendo.groupable.js",
            "kendo.pager.js",
            "kendo.selectable.js",
            "kendo.sortable.js",
            "kendo.grid.js",
            "kendo.listview.js",
            "kendo.menu.js",
            "kendo.panelbar.js",
            "kendo.slider.js",
            "kendo.resizable.js",
            "kendo.splitter.js",
            "kendo.tabstrip.js",
            "kendo.timepicker.js",
            "kendo.treeview.js",
            "kendo.upload.js",
            "kendo.window.js"
#else
            "http://code.jquery.com/jquery-1.7.1.min.js",
            "kendo.all.min.js"
#endif
        };

        public static readonly IList<string> Mobile = new string[]
        {
#if DEBUG
            "jquery.js",
            "kendo.core.js",
            "kendo.fx.js",
            "kendo.data.odata.js",
            "kendo.data.xml.js",
            "kendo.model.js",
            "kendo.data.js",
            "kendo.selectable.js",
            "kendo.list.js",
            "kendo.dropdownlist.js",
            "kendo.tabstrip.js",
            "kendo.panelbar.js",
            "kendo.popup.js",
            "kendo.history.js",
            "kendo.mobile.core.js",
            "kendo.mobile.swipe.js",
            "kendo.mobile.view.js",
            "kendo.mobile.application.js",
            "kendo.mobile.button.js",
            "kendo.mobile.listview.js",
            "kendo.mobile.scrollview.js",
            "kendo.mobile.navbar.js",
            "kendo.mobile.scroller.js",
            "kendo.mobile.buttongroup.js",
            "kendo.mobile.switch.js",
            "kendo.mobile.tabstrip.js"
#else
            "http://code.jquery.com/jquery-1.7.1.min.js",
            "kendo.all.min.js"
#endif
            };
    }
}
