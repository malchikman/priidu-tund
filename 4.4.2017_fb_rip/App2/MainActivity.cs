using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace fb_rip {
    [Activity(Label = "fb_rip", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            glob.listView = FindViewById<ListView>(Resource.Id.lv_posts);
            glob.listView.SetAdapter(new post(this, glob.tableItems));
        }

        public override bool OnCreateOptionsMenu(IMenu menu) {
            MenuInflater.Inflate(Resource.Menu.actionbar, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item) {
            switch (item.ItemId) {
                case Resource.Id.add:
                    StartActivity(typeof(PostitaActivity));

                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}

