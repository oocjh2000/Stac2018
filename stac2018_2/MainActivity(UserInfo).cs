using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace stac2018_2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageButton MoreOptionButton;
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

           
            VideoCallButton.Click += VideoCallButton_Click;
            MoreOptionButton.Click += MoreOptionButton_Click;
        }


        private void VideoCallButton_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(VideoCallActivity));
        }

        private void MoreOptionButton_Click(object sender, System.EventArgs e)
        {
     
        }

        
    }
}

