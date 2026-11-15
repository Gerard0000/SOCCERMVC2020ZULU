namespace SOCCERMVC2020ZULU.Web.Helpers;

public interface IImageHelper
{
    Task<string> UploadImageAsync(IFormFile imageFile, string folder);
}