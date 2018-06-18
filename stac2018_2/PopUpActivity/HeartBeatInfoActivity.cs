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

namespace stac2018_2.PopUpActivity
{
    [Activity(Label = "Activity1")]
    public class HeartBeatInfoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.HeartBeatInfo);
            // Create your application here
        }
        //public override bool OnTouchEvent(MotionEvent e)
        //{
        //    if (e.Action == MotionEventActions.Outside)
        //    {
        //        Finish();
        //        return false;
        //    }
        //    else return true;
        //}
    }
}