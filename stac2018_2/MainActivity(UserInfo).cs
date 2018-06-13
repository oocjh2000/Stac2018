using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace stac2018_2
{
    [Activity(Name="User.Info.Activity", Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageButton MoreOptionButton;
        private BackPressCloseHandler BackPressCloseHandler;
        ImageButton VideoCallButton;
       
        Drawable BackGround;
        Drawable BackGroundWhite;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.UserInfoLayout);

            BackGround = new ColorDrawable(Color.ParseColor("#3F51B5"));
            BackGroundWhite = new ColorDrawable(Color.ParseColor("#FFFFFF"));

            VideoCallButton = FindViewById<ImageButton>(Resource.Id.VideoCallButton);
            MoreOptionButton = FindViewById<ImageButton>(Resource.Id.MoreOptionButton);

            BackPressCloseHandler = new BackPressCloseHandler(this);


            VideoCallButton.Click += VideoCallButton_Click;
            MoreOptionButton.Click += MoreOptionButton_Click;
        }

        override public void OnBackPressed()
        {
            BackPressCloseHandler.OnBackPressed();
        }
        private void VideoCallButton_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(VideoCallActivity));
            OverridePendingTransition(0, 0);
        }

        private void MoreOptionButton_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(MoreInfoActivity));
            OverridePendingTransition(0, 0);
        }

        
    }
}

