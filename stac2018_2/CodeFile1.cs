//using System;
//using Android.Runtime;
//using Android.Views;
//using Android.Appwidget;
//using Android.Widget;
//using Java.Lang;

//namespace stac2018_2 {
//    public class Mylisenter : Java.Lang.Object,View.IOnClickListener
//    {
//        public IntPtr Handle => throw new NotImplementedException();
    
//        PopupWindow popupWindow;
//        void IDisposable.Dispose()
//        {
//        }

//        void View.IOnClickListener.OnClick(View v)
//        {
//            View view;
//            view = LayoutInflater.Inflate(Resource.Layout.PeelSetLayout,);
//            popupWindow = new PopupWindow(view, LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.WrapContent);
//            popupWindow.Focusable = true;
//            popupWindow.ShowAtLocation(view, GravityFlags.Center, 0, -200);

//        }
//    }
//}