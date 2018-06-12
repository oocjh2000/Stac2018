using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Content;

namespace stac2018_2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageButton MoreOptionButton;
        ImageButton VideoCallButton;
        ImageButton UserInfoButton;
        Drawable BackGround;
        Drawable BackGroundWhite;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            BackGround = new ColorDrawable(Color.ParseColor("#3F51B5"));
            BackGroundWhite = new ColorDrawable(Color.ParseColor("#FFFFFF"));

            VideoCallButton = FindViewById<ImageButton>(Resource.Id.ViedoCallButton);
            MoreOptionButton = FindViewById<ImageButton>(Resource.Id.MoreOptionButton);
            UserInfoButton = FindViewById<ImageButton>(Resource.Id.UserInfoButton);

            VideoCallButton.Click += VideoCallButton_Click;
            UserInfoButton.Click += UserInfoButton_Click;
            MoreOptionButton.Click += MoreOptionButton_Click;
        }

        private void UserInfoButton_Click(object sender, System.EventArgs e)
        {
            UserInfoButton.SetImageResource(Resource.Drawable.userinfowhite);
            UserInfoButton.Background = (BackGround);
            var intent = new Intent(this, typeof(UserInfoActivity));
            StartActivity(intent);
            OverridePendingTransition(0, 0);
        }

        private void VideoCallButton_Click(object sender, System.EventArgs e)
        {
            VideoCallButton.SetImageResource(Resource.Drawable.videocallwhite);
            VideoCallButton.Background = BackGround;
        }

        private void MoreOptionButton_Click(object sender, System.EventArgs e)
        {
            MoreOptionButton.SetImageResource(Resource.Drawable.moreoptionwhite);
            MoreOptionButton.Background = (BackGround);
        }

        
    }
}

