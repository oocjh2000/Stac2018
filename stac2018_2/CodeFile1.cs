using Android;
using Android.Widget;
using Android.Views;
using Android.Graphics.Drawables;
using Java.Lang;
using System.Collections.Generic;

public class VideoCallAdapter : BaseAdapter
{
     List<VideoCallItem> videoCallItems = new List<VideoCallItem>();

    public VideoCallAdapter() { }


    public override int Count => throw new System.NotImplementedException();

    public override Object GetItem(int position)
    {
        throw new System.NotImplementedException();
    }

    public override long GetItemId(int position)
    {
        throw new System.NotImplementedException();
    }

    public override View GetView(int position, View convertView, ViewGroup parent)
    {
        throw new System.NotImplementedException();
    }
}