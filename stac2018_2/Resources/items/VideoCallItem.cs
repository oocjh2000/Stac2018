using System;
using Android.Graphics.Drawables;
using Java.Lang;

public class VideoCallItem
{
   Drawable icon;
    string name;
    public void SetIcon(Drawable drawable)
    {
        icon = drawable;
    }
    public void SetName(string Name)
    {
        name = Name;
    }
    public Drawable GetIcon()
    {
        return icon;
    }
    public string GetName()
    {
        return name;
    }

    public static explicit operator Java.Lang.Object(VideoCallItem v)
    {
        throw new NotImplementedException();
    }
}
