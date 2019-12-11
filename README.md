# BlazorFileSaver

[![Demo](https://img.shields.io/badge/Live-Demo-Blue?style=flat-square)](https://blazorfilesaver.netlify.com)
[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/BlazorFileSaver.svg?style=flat-square)](https://www.nuget.org/packages/BlazorTable)
[![Nuget (with prereleases)](https://img.shields.io/nuget/dt/BlazorFileSaver.svg?style=flat-square)](https://www.nuget.org/packages/BlazorTable)
![](https://github.com/IvanJosipovic/BlazorFileSaver/workflows/CI/CD/badge.svg)

Blazor Component wrapper for [FileSaver.js](https://github.com/eligrey/FileSaver.js/)

# Demo
[Sample](https://blazorfilesaver.netlify.com)


# Installation

- Add Nuget BlazorFileSaver
- Add ``<script src="_content/BlazorFileSaver/BlazorFileSaver.min.js"></script>`` to the index.html or _Hosts.cshtml
- Add AddBlazorFileSaver() to the ConfigureServices in Startup.cs as noted below


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

<input type="text" @bind="FileName" />

<buton @onclick="Save" class="btn btn-primary">Save</buton>

<textarea class="form-control" type="text" @bind="Data" rows="20"></textarea>

@code {
    [Inject]
    private IBlazorFileSaver BlazorFileSaver { get; set; }
    
    private string FileName { get; set; } = "Sample.txt";

    private string Data { get; set; } = "Sample Text";

    private async Task Save()
    {
        await BlazorFileSaver.SaveAs(FileName, Data);
    }
}
```

# More Examples
[SaveAsBase64 Zip](https://github.com/IvanJosipovic/BlazorFileSaver/blob/master/src/BlazorFileSaver.Sample/Pages/Index.razor)
