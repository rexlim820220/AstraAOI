public interface ICameraController
{
    void Open();
    void CaptureImage(string savePath);
    void Close();
}
