namespace CurrencyConverter.Services.Interfaces
{
    public interface IPictureStorage
    {
        string[] GetAllPhotos();

        string GetOnePhoto(string path);

        void UploadPhoto();

    }
}
