![piper-banner](https://raw.githubusercontent.com/CanTalat-Yakan/USD.NET/main/Header.png)
## [NuGet Package - UniversalSceneDescription](https://www.nuget.org/packages/UniversalSceneDescription)

```Batch
dotnet add package UniversalSceneDescription
```
⠀
⠀
# OpenUSD - USD.NET
Universal Scene Description (USD) by Pixar and translated by Unity.

* USD is a high-performance extensible software platform for collaboratively constructing animated 3D scenes, designed to meet the needs of large-scale film and visual effects production.
* USD enables robust interchange between digital content creation tools with its expanding set of schemas, covering domains like geometry, shading, lighting, and physics.
* USD’s unique composition ability provides rich and varied ways to combine assets into larger assemblies, enables collaborative workflows so that many creators can work together with ease, and more.

[Introduction to USD](https://openusd.org/release/intro.html) - [Tutorial](https://openusd.org/release/tut_usd_tutorials.html) - [FAQ](https://openusd.org/release/usdfaq.html) - [Toolset](https://openusd.org/release/toolset.html)

[NVIDIA](https://developer.nvidia.com/usd) - Provides extensive resources and samples for USD.

### Example Projects and Files
* [Pixar Demo Assets](https://openusd.org/release/dl_downloads.html#assets) - The originators of USD.
* [NVIDIA USD Samples](https://developer.nvidia.com/usd#samples).

⠀
# USD Core Package by Unity
This project now includes the OpenUSD (Universal Scene Description) from Unity. For more information, please refer to the [Unity USD documentation](https://docs.unity3d.com/Packages/com.unity.usd.core@1.0/manual/index.html).

### Extracting Necessary DLLs
Extract the required native DLLs and the USD.NET managed DLL by following these steps:

1. Add the `com.unity.usd.core` package to a new Unity Project.
2. Include the sample and built the project.

#### Paths for DLLs

- **Native DLLs:** Obtained from the build path:
  ```
  Your_Build_Path/USD_Data/Plugins/x86_64/...
  ```
- **Managed DLL (USD.NET):** Obtained from the build path:
  ```
  Your_Build_Path/USD_Data/Managed/USD.NET.dll
  ```

### Additional Required Files

You will also need USDA files for schemas and JSON files for `plugInfo`. These can be found in the following Unity Project path:
```
Your_Unity_Project_Path\Library\PackageCache\com.unity.usd.core\Runtime\Plugins\x86_64\Windows\lib\usd\...
```

### Creating the NuGet Package

Remove the `.meta` files and include the necessary files into a Class Project. You can find the `.csproj` configuration for this project [here](https://github.com/CanTalat-Yakan/USD.NET/blob/main/UniversalSceneDescription.csproj).

---

For further details and updates, please visit the [project repository](https://github.com/CanTalat-Yakan/USD.NET).

Thank yu for your interest in the Universal Scene Description (USD.NET) project. Feel free to contribute and enhance the package further!
