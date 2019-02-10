# BlazorFileSaver

Blazor Component wrapper for [FileSaver.js](https://github.com/eligrey/FileSaver.js/)


# Instalation
[![NuGet Pre Release](https://img.shields.io/badge/nuget-0.8.0-orange.svg)](https://www.nuget.org/packages/BlazorFileSaver)



# Demo
[Sample](https://blazorfilesaver.netlify.com)




# Example
```csharp
@page "/sample"
@using BlazorFileSaver.JSInterop
<h1>BlazorFileSaver.Sample</h1>

<input type="text" bind="@FileName" />

<buton onclick="@Save" class="btn btn-primary">Save</buton>

<textarea class="form-control" type="text" bind="@Data" rows="20"></textarea>

@functions {
    private string FileName { get; set; } = "Sample.txt";

    private string Data { get; set; } = "Sample Text";

    private async Task Save()
    {
        await BlazorFileSaver.SaveAs(FileName, Data);
    }
}
```