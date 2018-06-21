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

            videoCallAdapter = new VideoCallAdapter();

            UserIfoButton = FindViewById<ImageButton>(Resource.Id.UserInfoButton);
            VideoCallButton = FindViewById<ImageButton>(Resource.Id.ViedoCallButton);

            listView = FindViewById<ListView>(Resource.Id.OptionListView);
#pragma warning disable CS0618 // 형식 또는 멤버는 사용되지 않습니다.
            listView.SetAdapter(videoCallAdapter);
#pragma warning disable CS0618 // 형식 또는 멤버는 사용되지 않습니다.
            videoCallAdapter.AddItem(GetDrawable(Resource.Drawable.peopleicon), "정보등록 / 수정");
            videoCallAdapter.AddItem(GetDrawable(Resource.Drawable.settingicon), "환경설정");
            videoCallAdapter.AddItem(GetDrawable(Resource.Drawable.infoicon), "앱정보");


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