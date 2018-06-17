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
    [Activity(Label = "VideoCallActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
   
    public class VideoCallActivity : Activity
    {
        ImageButton UserIfoButton;
        ImageButton MoreInfoButton;

        ListView listView;
        VideoCallAdapter callAdapter = new VideoCallAdapter();

        private BackPressCloseHandler BackPressCloseHandler;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.VideoCallLayout);

            listView = FindViewById<ListView>(Resource.Id.CallListView);
            listView.SetAdapter(callAdapter);
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
            StartActivity(typeof(MoreInfoActivity));
            OverridePendingTransition(0, 0);
        }

        private void UserIfoButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
            OverridePendingTransition(0, 0);
        }
    }
}