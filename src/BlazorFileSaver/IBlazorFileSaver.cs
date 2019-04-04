using System.Threading.Tasks;

namespace BlazorFileSaver
{
    public interface IBlazorFileSaver
    {
        Task SaveAs(string fileName, string data, string type = "text/plain;charset=utf-8");
        Task SaveAsBase64(string fileName, string base64String, string type = "application/zip");
    }
}