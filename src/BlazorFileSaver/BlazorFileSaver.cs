using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorFileSaver.JSInterop
{
    public static class BlazorFileSaver
    {
        public static Task SaveAs(string fileName, string text)
        {
            // Implemented in BlazorFileSaver.min.js
            return JSRuntime.Current.InvokeAsync<object>(
                "BlazorFileSaver.saveAs",
                fileName, text);
        }
    }
}
