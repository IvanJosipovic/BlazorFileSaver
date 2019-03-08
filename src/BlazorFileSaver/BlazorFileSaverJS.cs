using Microsoft.AspNetCore.Components;
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

        public Task SaveAs(string fileName, string text, string type = "text/plain;charset=utf-8")
        {
            // Implemented in BlazorFileSaver.min.js
            return JSRuntime.InvokeAsync<object>(
                "BlazorFileSaver.saveAs",
                fileName, text, type);
        }

        public Task SaveAs(string fileName, object data, string type = "application/zip")
        {
            // Implemented in BlazorFileSaver.min.js
            return JSRuntime.InvokeAsync<object>(
                "BlazorFileSaver.saveAs",
                fileName, data, type);
        }
    }
}
