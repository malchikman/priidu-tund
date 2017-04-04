using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace fb_rip {
    [Activity(Label = "PostitaActivity", MainLauncher = false)]
    public class PostitaActivity : Activity {
        EditText et_post;

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.postita);

            et_post = FindViewById<EditText>(Resource.Id.et_post);
        }

        public override bool OnCreateOptionsMenu(IMenu menu) {
            MenuInflater.Inflate(Resource.Menu.postita_actionbar, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item) {
            switch (item.ItemId) {
                case Resource.Id.add_post:
                    glob.tableItems.Add(new TableItem() { img = Resource.Drawable.aronike, name = "Aaron Kyro", text = et_post.Text, iscommenting = false });
                    StartActivity(typeof(MainActivity));
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}

