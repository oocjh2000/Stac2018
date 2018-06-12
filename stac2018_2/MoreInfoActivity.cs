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

namespace stac2018_2
{
    [Activity(Label = "MoreInfoActivity")]
    public class MoreInfoActivity : Activity
    {
        ImageButton UserIfoButton;
        ImageButton VideoCallButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MoreInfoLayout);
            UserIfoButton = FindViewById<ImageButton>(Resource.Id.UserInfoButton);
            VideoCallButton = FindViewById<ImageButton>(Resource.Id.ViedoCallButton);

            UserIfoButton.Click += UserIfoButton_Click;
            VideoCallButton.Click += VideoCallButton_Click;
            // Create your application here
        }

        private void VideoCallButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(VideoCallActivity));
        }

        private void UserIfoButton_Click(object sender, EventArgs e)
        {
           StartActivity(typeof(MainActivity));
        }
    }
}