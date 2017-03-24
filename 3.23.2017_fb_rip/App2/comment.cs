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
    class comment : BaseAdapter<string> {
        List<string> items;
        Activity context;


        public comment(Activity context, List<string> items) : base() {
            this.context = context;
            this.items = items;
        }
        
        public override string this[int position] {
            get {
                return items[position];
            }
        }
        
        public override long GetItemId(int position) {
            return position;
        }


        public override int Count {
            get { return items.Count; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent) {
            var item = items[position];
            View view = convertView; // re-use an existing view, if one is available
            if (view == null) // otherwise create a new one
                view = context.LayoutInflater.Inflate(Resource.Layout.comment, null);

            Android.Widget.Toast.MakeText(context, items.Count + "", Android.Widget.ToastLength.Short).Show();

            TextView root_user_comment = view.FindViewById<TextView>(Resource.Id.root_user_comment);

            root_user_comment.Text = item;

            return view;
        }
    }
}