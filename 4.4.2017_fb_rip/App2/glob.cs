using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace fb_rip {
    class glob {
        public static ListView listView;
        public static List<TableItem> tableItems = new List<TableItem>() {
            new TableItem() { img = Resource.Drawable.aronike, name = "Aaron Kyro", text = "postituse sisu", iscommenting = false },
            new TableItem() { img = Resource.Drawable.aronike, name = "Aaron Kyro", text = "postituse sisu", iscommenting = false }
        };
    }
}