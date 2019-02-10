using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazor.FileSaver
{
    public static class BlazorFileSaver
    {
        public static Task SaveAs(string fileName, string text)
        {
            // Implemented in exampleJsInterop.js
            return JSRuntime.Current.InvokeAsync<object>(
                "BlazorFileSaver.saveAs",
                fileName, text);
        }
    }
}
