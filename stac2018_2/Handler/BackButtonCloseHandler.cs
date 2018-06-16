
using Android.App;
using System;
using Android.Widget;
using Java.Lang;

namespace stac2018_2
{
    public class BackPressCloseHandler
    {
        private long BackPressedTime = 0;
        private Toast toast;
        private Activity activity;
        public BackPressCloseHandler(Activity context)
        {
            this.activity = context;
        }
        public void OnBackPressed()
        {
      
            if (JavaSystem.CurrentTimeMillis() > BackPressedTime + 2000)
            {
                BackPressedTime = JavaSystem.CurrentTimeMillis();
                ShowGuide();
                return;
            }
            if (JavaSystem.CurrentTimeMillis() <= BackPressedTime + 2000)
            {
                //Android.OS.Process.KillProcess();
                activity.MoveTaskToBack(true);
                activity.Finish();
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
                toast.Cancel();
            }
        }
        public void ShowGuide()
        {
            toast = Toast.MakeText(activity, "한번 더 누르시면 종료됩니다.ㅎㅎ",ToastLength.Short);
            toast.Show();
        }
    }
}