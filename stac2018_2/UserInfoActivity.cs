

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace stac2018_2
{
    [Activity(Label = "UserInfoActivity", Theme = "@style/AppTheme")]
    public class UserInfoActivity : Activity
    {
        ImageButton MoreOptionButton;
        ImageButton VideoCallButton;
        ImageButton UserInfoButton;
        Drawable BackGround;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.UserInfoLayout);
            BackGround = new ColorDrawable(Color.ParseColor("#3F51B5"));


            VideoCallButton = FindViewById<ImageButton>(Resource.Id.ViedoCallButton);
            MoreOptionButton = FindViewById<ImageButton>(Resource.Id.MoreOptionButton);
            UserInfoButton = FindViewById<ImageButton>(Resource.Id.UserInfoButton);

            // Create your application here
        }
    }
}