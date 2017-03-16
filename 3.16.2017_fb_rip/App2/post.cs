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

namespace App2 {
    class post : BaseAdapter<TableItem> {
        List<TableItem> items;
        Activity context;


        public post(Activity context, List<TableItem> items) : base() {
            this.context = context;
            this.items = items;
        }

        public override TableItem this[int position] {
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
                view = context.LayoutInflater.Inflate(Resource.Layout.post, null);

            ImageView root_user_image = view.FindViewById<ImageView>(Resource.Id.root_user_image);
            TextView root_user_name = view.FindViewById<TextView>(Resource.Id.root_user_name);
            TextView root_user_text = view.FindViewById<TextView>(Resource.Id.root_user_text);

            root_user_image.SetImageResource(item.img);
            root_user_name.Text = item.name;
            root_user_text.Text = item.text;

            return view;
        }
    }
}