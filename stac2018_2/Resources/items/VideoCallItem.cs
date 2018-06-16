using Android.Graphics.Drawables;


public class VideoCallItem
{
   Drawable icon;
    string name;
    public void SetIcon(Drawable drawable)
    {
        icon = drawable;
    }
    public void SetIcon(string Name)
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
}
