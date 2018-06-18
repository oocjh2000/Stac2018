using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Content;
using stac2018_2.PopUpActivity;
using Android.Views;

namespace stac2018_2
{
    [Activity(Name="User.Info.Activity", Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true,ScreenOrientation =Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity
    {
        ImageButton MoreOptionButton; 
        ImageButton VideoCallButton;

        ImageButton HeartInfoButton;
        ImageButton PeelSetButton;
        ImageButton TimerSetButton;

        private BackPressCloseHandler BackPressCloseHandler;

        Drawable BackGround;
        Drawable BackGroundWhite;
        View view;
        PopupWindow popupWindow;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
          
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.UserInfoLayout);

            BackGround = new ColorDrawable(Color.ParseColor("#3F51B5"));
            BackGroundWhite = new ColorDrawable(Color.ParseColor("#FFFFFF"));

            VideoCallButton = FindViewById<ImageButton>(Resource.Id.VideoCallButton);
            MoreOptionButton = FindViewById<ImageButton>(Resource.Id.MoreOptionButton);

            HeartInfoButton = FindViewById<ImageButton>(Resource.Id.HeartIcon);
            PeelSetButton = FindViewById<ImageButton>(Resource.Id.PeelICon);
            TimerSetButton = FindViewById<ImageButton>(Resource.Id.TimerIcon);

            BackPressCloseHandler = new BackPressCloseHandler(this);

          


            VideoCallButton.Click += VideoCallButton_Click;
            MoreOptionButton.Click += MoreOptionButton_Click;
            HeartInfoButton.Click += HeartInfoButton_Click;
            PeelSetButton.Click += PeelSetButton_Click;
        }

        private void PeelSetButton_Click(object sender, System.EventArgs e)
        {
            view = LayoutInflater.Inflate(Resource.Layout.PeelSetLayout, null);
            popupWindow = new PopupWindow(view, LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.WrapContent);
            popupWindow.Focusable = true;
            popupWindow.ShowAtLocation(view, GravityFlags.Center, 0, -200);
        }

        private void HeartInfoButton_Click(object sender, System.EventArgs e)
        {
            view = LayoutInflater.Inflate(Resource.Layout.HeartBeatInfo, null);
            popupWindow = new PopupWindow(view, LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.WrapContent);
            popupWindow.Focusable = true;
            popupWindow.ShowAtLocation(view, GravityFlags.Center, 0, -200);
        }

      
        private void VideoCallButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(VideoCallActivity));
            intent.SetFlags(ActivityFlags.NoHistory);
            StartActivity(intent);
            OverridePendingTransition(0,0);
        }

        private void MoreOptionButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MoreInfoActivity));
            intent.SetFlags(ActivityFlags.NoHistory);
            StartActivity(intent);
            OverridePendingTransition(0, 0);
        }

        override public void OnBackPressed()
        {
            BackPressCloseHandler.OnBackPressed();
        }
        
    }
}

