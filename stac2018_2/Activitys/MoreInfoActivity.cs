using System;

using Android.App;
using Android.OS;
using Android.Widget;

namespace stac2018_2
{
    [Activity(Label = "MoreInfoActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MoreInfoActivity : Activity
    {
        ImageButton UserIfoButton;
        ImageButton VideoCallButton;
        private BackPressCloseHandler BackPressCloseHandler;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MoreInfoLayout);
            UserIfoButton = FindViewById<ImageButton>(Resource.Id.UserInfoButton);
            VideoCallButton = FindViewById<ImageButton>(Resource.Id.ViedoCallButton);

            BackPressCloseHandler = new BackPressCloseHandler(this);

            UserIfoButton.Click += UserIfoButton_Click;
            VideoCallButton.Click += VideoCallButton_Click;
            // Create your application here
        }
        public override void OnBackPressed()
        {
            BackPressCloseHandler.OnBackPressed();
        }

        private void VideoCallButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(VideoCallActivity));
            OverridePendingTransition(0, 0);
        }

        private void UserIfoButton_Click(object sender, EventArgs e)
        {
           StartActivity(typeof(MainActivity));
            OverridePendingTransition(0, 0);
        }
    }
}