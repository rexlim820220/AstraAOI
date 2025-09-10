using Basler.Pylon;

class Program
{
    static void Main()
    {
        Camera camera = new Camera();
        camera.Open();
        camera.Parameters[PLCameraInstance.MaxNumBuffer].SetValue(5);
        camera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);

        IGrabResult result = camera.StreamGrabber.RetrieveResult(5000, TimeoutHandling.ThrowException);
        if (result.GrabSucceeded)
        {
            Console.WriteLine($"Image Size: {result.Width} x {result.Height}");
        }

        result.Dispose();
        camera.Close();
    }
}
