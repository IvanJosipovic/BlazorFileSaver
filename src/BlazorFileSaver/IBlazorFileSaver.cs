using System.Threading.Tasks;

namespace BlazorFileSaver
{
    public interface IBlazorFileSaver
    {
        Task SaveAs(string fileName, object data, string type = "application/zip");
        Task SaveAs(string fileName, string text, string type = "text/plain;charset=utf-8");
    }
}