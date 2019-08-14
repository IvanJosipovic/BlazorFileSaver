# BlazorFileSaver

Blazor Component wrapper for [FileSaver.js](https://github.com/eligrey/FileSaver.js/)


# Installation
[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/BlazorFileSaver.svg)](https://www.nuget.org/packages/BlazorFileSaver)



# Demo
[Sample](https://blazorfilesaver.netlify.com)


# Startup.cs
```csharp
namespace BlazorFileSaver.Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBlazorFileSaver(); // Add This!
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
```


# Example
```csharp
@page "/sample"
<h1>BlazorFileSaver.Sample</h1>

<input type="text" @bind="@FileName" />

<buton @onclick="@Save" class="btn btn-primary">Save</buton>

<textarea class="form-control" type="text" @bind="@Data" rows="20"></textarea>

@code {
    [Inject] private IBlazorFileSaver BlazorFileSaver { get; set; }
    private string FileName { get; set; } = "Sample.txt";

    private string Data { get; set; } = "Sample Text";

    private async Task Save()
    {
        await BlazorFileSaver.SaveAs(FileName, Data);
    }
}
```