![piper-banner](https://raw.githubusercontent.com/CanTalat-Yakan/USD.NET/main/Header.png)

# OpenUSD - USD.NET
Universal Scene Description (USD) by Pixar and translated by Unity.

* USD is a high-performance extensible software platform for collaboratively constructing animated 3D scenes, designed to meet the needs of large-scale film and visual effects production.
* USD enables robust interchange between digital content creation tools with its expanding set of schemas, covering domains like geometry, shading, lighting, and physics.
* USD’s unique composition ability provides rich and varied ways to combine assets into larger assemblies, enables collaborative workflows so that many creators can work together with ease, and more.

[Introduction to USD](https://openusd.org/release/intro.html) - [Tutorial](https://openusd.org/release/tut_usd_tutorials.html) - [FAQ](https://openusd.org/release/usdfaq.html) - [Toolset](https://openusd.org/release/toolset.html)

[NVIDIA](https://developer.nvidia.com/usd) - Provides extensive resources and samples for USD.

## Example Projects and Files
* [Pixar Demo Assets](https://openusd.org/release/dl_downloads.html#assets) - The originators of USD.
* [NVIDIA USD Samples](https://developer.nvidia.com/usd#samples).

## [Unity](https://docs.unity3d.com/Packages/com.unity.usd.core@1.0/manual/index.html)
This project now features the OpenUSD (Universal Scene Description) from Unity.
For more information, refer to the [Unity USD documentation](https://docs.unity3d.com/Packages/com.unity.usd.core@1.0/manual/index.html).

I have extracted the necessary native DLLs and managed USD.NET DLL by adding the package into a new Unity Project named `com.unity.usd.core` with the sample included and building the project. The native DLLs were extracted from the build path `Your_Build_Path/USD_Data/Plugins/x86_64/...`, and the managed DLL from `Your_Build_Path/USD_Data/Managed/USD.NET.dll`.

Additionally, we need USDA files for schemas and JSON files for `plugInfo`, which you can find in the following Unity Project path:
`Your_Unity_Project_Path\Library\PackageCache\com.unity.usd.core\Runtime\Plugins\x86_64\Windows\lib\usd\...`

By removing the `.meta` files and including them into a Class Project, I created this NuGet Package with the following `.csproj` configuration:
[UniversalSceneDescription.csproj](https://github.com/CanTalat-Yakan/USD.NET/blob/main/UniversalSceneDescription.csproj)

## [NuGet](https://www.nuget.org/packages/UniversalSceneDescription)

```Batch
dotnet add package UniversalSceneDescription
```

Thank you for your interest in the Universal Scene Description (USD.NET) project. Feel free to contribute and enhance the package further!
