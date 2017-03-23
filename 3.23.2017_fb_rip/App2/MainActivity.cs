using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        List<TableItem> tableItems = new List<TableItem>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            /*
            Android.Widget.Toast.MakeText(this, "yello", Android.Widget.ToastLength.Short).Show();

            ImageView root_user_image = FindViewById<ImageView>(Resource.Id.root_user_image);
            TextView root_user_name = FindViewById<TextView>(Resource.Id.root_user_name);

            root_user_image.SetImageResource(Resource.Drawable.aronike);
            root_user_name.Text = "Aaron Kyro";
            */

            ListView listView = FindViewById<ListView>(Resource.Id.lv_posts);

            tableItems.Add(new TableItem() { img = Resource.Drawable.aronike, name = "Aaron Kyro", text = "postituse sisu", iscommenting = false });
            tableItems.Add(new TableItem() { img = Resource.Drawable.aronike, name = "Aaron Kyro", text = "postituse sisu", iscommenting = false });

            listView.Adapter = new post(this, tableItems);
            

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

