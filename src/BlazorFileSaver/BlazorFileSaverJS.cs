using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorFileSaver
{
    public class BlazorFileSaverJS : IBlazorFileSaver
    {
        private IJSRuntime JSRuntime { get; }

        public BlazorFileSaverJS(IJSRuntime jSRuntime)
        {
            JSRuntime = jSRuntime;
        }

        public async Task SaveAs(string fileName, string data, string type = "text/plain;charset=utf-8")
        {
            // Implemented in BlazorFileSaver.min.js
            await JSRuntime.InvokeAsync<object>(
                "BlazorFileSaver.saveAs",
                fileName, data, type);
        }

        public async Task SaveAsBase64(string fileName, string base64String, string type = "application/zip")
        {
            // Implemented in BlazorFileSaver.min.js
            await JSRuntime.InvokeAsync<object>(
                "BlazorFileSaver.saveAsBase64",
                fileName, base64String, type);
        }
    }
}
