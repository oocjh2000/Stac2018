using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace stac2018_2
{
    [Activity(Label = "MoreInfoActivity", Theme = "@style/AppTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MoreInfoActivity : Activity
    {
        ImageButton UserIfoButton;
        ImageButton VideoCallButton;
        private BackPressCloseHandler BackPressCloseHandler;

        ListView listView;
        VideoCallAdapter videoCallAdapter;
            

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MoreInfoLayout);
        
            UserIfoButton = FindViewById<ImageButton>(Resource.Id.UserInfoButton);
            VideoCallButton = FindViewById<ImageButton>(Resource.Id.ViedoCallButton);

            listView = FindViewById<ListView>(Resource.Id.OptionListView);
            videoCallAdapter.AddItem(GetDrawable(Resource.Drawable.peopleicon), "정보등록 / 수정");
            videoCallAdapter.AddItem(GetDrawable(Resource.Drawable.icon_setting), "정보등록 / 수정");
            videoCallAdapter.AddItem(GetDrawable(Resource.Drawable.icon_info), "정보등록 / 수정");


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
            Intent intent = new Intent(this, typeof(VideoCallActivity));
            intent.SetFlags(ActivityFlags.NoHistory);
            StartActivity(intent);
            OverridePendingTransition(0, 0);
        }

        private void UserIfoButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.SetFlags(ActivityFlags.NoHistory);
            StartActivity(intent);
            OverridePendingTransition(0, 0);
        }
    }
}