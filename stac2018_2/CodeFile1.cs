using Android;
using Android.Widget;
using Android.Views;
using Android.Graphics.Drawables;
using Java.Lang;
using System.Collections.Generic;
using Android.Content;
using Android.Graphics;

public class VideoCallAdapter : BaseAdapter
{
     List<VideoCallItem> videoCallItems = new List<VideoCallItem>();

    public VideoCallAdapter() { }


    public override int Count => videoCallItems.Count;

    public override Object GetItem(int position)
    {
        return (Object)videoCallItems[position];
    }

    public override long GetItemId(int position)
    {
        return position;
    }

    public override View GetView(int position, View convertView, ViewGroup parent)
    {
        int pos = position;
        Context context = parent.Context;

        return convertView;
    }

    public void addItem(Drawable icon, string Name)
    {
        VideoCallItem callItem = new VideoCallItem();

        callItem.SetIcon(icon);
        callItem.SetName(Name);
        videoCallItems.Add(callItem);
    }
}