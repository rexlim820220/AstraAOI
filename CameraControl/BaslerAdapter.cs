// BaslerAdapter.cs
using Basler.Pylon;

public class BaslerAdapter : ICameraController
{
    private Camera _camera;

    public void Open()
    {
        _camera = new Camera();
        _camera.Open();
    }

    public void CaptureImage(string savePath)
    {
        var result = _camera.StreamGrabber.GrabOne(5000);
        if (result.GrabSucceeded)
        {
            Bitmap bitmap = new Bitmap(result.Width, result.Height, PixelFormat.Format24bppRgb);
            bitmap.Save(savePath);
        }
    }

    public void Close()
    {
        _camera.Close();
    }
}

