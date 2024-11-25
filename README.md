<h1 align="center"> 🌆 Dynamic Language Runtime</h1>

<p align="center">
  <a style="text-decoration:none" href="https://github.com/RiversideValley/Dynamic/actions/workflows/ci.yml">
    <img src="https://github.com/RiversideValley/Dynamic/actions/workflows/ci.yml/badge.svg" alt="CI Status" /></a>
  <!--<a style="text-decoration:none" href="https://nuget.org/packages/Riverside.Dynamic">
    <img src="https://img.shields.io/nuget/v/Riverside.Dynamic.svg" alt="NuGet" /></a>-->
  <a style="text-decoration:none" href="http://stackoverflow.com/questions/tagged/dynamic-language-runtime">
    <img src="https://img.shields.io/stackexchange/stackoverflow/t/dynamic-language-runtime?logo=dotnet&label=StackOverflow" alt="Discuss on StackOverflow" /></a>
</p>

Introducing the **Dynamic Language Runtime**, an efficient, CLR-friendly language platform that allows developers to create languages that integrate tightly with .NET.
In addition to being a pluggable back-end for dynamic language compilers, the DLR provides language interop for dynamic operations on objects. The DLR has common hosting APIs for using dynamic languages as libraries or for scripting in your .NET applications.

## 🛠️ Building from source

#### 1. Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/vs/) 2019 16.8.0 or later with the following individual components:
    - .NET SDK 
- Git

#### 2. Clone the repository

```
git clone https://github.com/RiversideValley/Dynamic
```

This will create a local copy of the repository.

#### 3. Build the project

To build the DLR for development, open the `Dynamic.sln` item in Visual Studio. Right-click on the `Riverside.Dynamic` project in solution explorer and select ‘Set as Startup item’, then build the project.

> Since the main development is on Windows, cross-platform bugs may inadvertantly be introduced - please report them!

## ⌛ History of the project

The original DLR site was available on CodePlex at `dlr.codeplex.com`. The DLR was part of a much larger repository containing IronPython and IronRuby as well; you can find it at the [main](https://github.com/IronLanguages/main) repository (now `IronLanguages/IronRuby` and `IronLanguages/IronPython3`).
This is a smaller repository containing just the DLR, which makes it easier to package and should make it easier to do more regular releases.

Since this used to be a Microsoft project, the documentation is written in Microsoft Word format (of course) inside the `Microsoft` directory.

## 🙋 Contributing

There are multiple ways to participate in the community:

- Upvote popular feature requests
- [Submit a new feature](https://github.com/RiversideValley/Dynamic/pulls)
- [File bugs and feature requests](https://github.com/RiversideValley/Dynamic/issues/new/choose).
- Review source [code changes](https://github.com/RiversideValley/Dynamic/commits)

We thank all contributors and users for their continued support.

### 🤗 Code of Conduct

This project has adopted the code of conduct defined by the Contributor Covenant to clarify expected behavior in our community.
For more information see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct). 

### ⚖️ License

Copyright (c) 2006-2024 .NET Foundation. All Rights Reserved.

Licensed under the `Apache-2.0` license as stated in the [LICENSE](https://github.com/RiversideValley/Dynamic/blob/ec74320579aca1d02013d2294253263e848f448b/LICENSE.md).

> The `Apache-2.0` license requires that a changelog is created to state significant changes to the codebase. This can be found at [`.github/CHANGELOG.md`](https://github.com/RiversideValley/Dynamic/blob/HEAD/.github/CHANGELOG.md) which provides a simple summary of the changes in a table.
