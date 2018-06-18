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
using static Android.App.AlertDialog;

namespace stac2018_2
{
    [Activity(Label = "VideoCallActivity", Theme = "@style/AppTheme", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
   
    public class VideoCallActivity : Activity
    {
        ImageButton UserIfoButton;
        ImageButton MoreInfoButton;

        ListView listView;
        VideoCallAdapter callAdapter;

        private BackPressCloseHandler BackPressCloseHandler;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.VideoCallLayout);

            callAdapter = new VideoCallAdapter();

            listView = FindViewById<ListView>(Resource.Id.CallListView);
#pragma warning disable CS0618 // 형식 또는 멤버는 사용되지 않습니다.
            listView.SetAdapter(callAdapter);
#pragma warning restore CS0618 // 형식 또는 멤버는 사용되지 않습니다.
            callAdapter.AddItem(GetDrawable(Resource.Drawable.peopleicon), "강용현");
            callAdapter.AddItem(GetDrawable(Resource.Drawable.peopleicon), "안용욱");
            callAdapter.AddItem(GetDrawable(Resource.Drawable.peopleicon), "차재훈");


            UserIfoButton = FindViewById<ImageButton>(Resource.Id.UserInfoButton);
            MoreInfoButton = FindViewById<ImageButton>(Resource.Id.MoreOptionButton);

            BackPressCloseHandler = new BackPressCloseHandler(this);

            UserIfoButton.Click += UserIfoButton_Click;
            MoreInfoButton.Click += MoreInfoButton_Click;
            // Create your application here
        }
        public override void OnBackPressed()
        {
            BackPressCloseHandler.OnBackPressed();
        }

        private void MoreInfoButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MoreInfoActivity));
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