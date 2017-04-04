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
    class post : BaseAdapter<TableItem> {
        List<TableItem> items;
        Activity context;
        int lv_comment_height = 0;

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
            if (view == null) { // otherwise create a new one
                if (item.iscommenting == true)
                    view = context.LayoutInflater.Inflate(Resource.Layout.postc, null);
                else if (item.comments.Count != 0)
                    view = context.LayoutInflater.Inflate(Resource.Layout.postcd, null);
                else
                    view = context.LayoutInflater.Inflate(Resource.Layout.post, null);

                ImageView root_user_image = view.FindViewById<ImageView>(Resource.Id.root_user_image);
                TextView root_user_name = view.FindViewById<TextView>(Resource.Id.root_user_name);
                TextView root_user_text = view.FindViewById<TextView>(Resource.Id.root_user_text);
                ListView lv_comments = view.FindViewById<ListView>(Resource.Id.lv_comments);
                Button btn_comment = view.FindViewById<Button>(Resource.Id.btn_comment);
                Button btn_submit_comment = view.FindViewById<Button>(Resource.Id.btn_submit_comment);
                EditText ed_user_comment = view.FindViewById<EditText>(Resource.Id.ed_user_comment);

                root_user_image.SetImageResource(item.img);
                root_user_name.Text = item.name;
                root_user_text.Text = item.text;

                if (ed_user_comment != null)
                    ed_user_comment.Text = "Enter comment";

                if (lv_comments != null) {
                    //if (lv_comment_height == 0)
                    //    lv_comment_height = lv_comments.Height;

                    //Android.Widget.Toast.MakeText(context, lv_comments.Height + "", Android.Widget.ToastLength.Short).Show();

                    lv_comments.LayoutParameters.Height = 55 * item.comments.Count;
                    lv_comments.Adapter = new comment(context, item.comments);
                }

                btn_comment.Click += delegate {
                    item.iscommenting = !item.iscommenting;

                    glob.listView.Adapter = new post(context, items);
                };

                if (btn_submit_comment != null) {
                    btn_submit_comment.Click += delegate {
                        item.comments.Add(ed_user_comment.Text);
                        item.iscommenting = false;

                        glob.listView.Adapter = new post(context, items);
                    };
                }
            }

            return view;
        }
    }
}