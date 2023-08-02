# Vintage Story Mod Template

This repository contains a configured .NET 7 mod for Visual Studio, Visual Studio Code and Rider that let's you start Vintage Story and add your own code to it. Supports logging and as well as debugging.



## Usage
- Get a copy of this template by either using the "Use this Template" on github or cloning it or downloading a .zip file.
- Open the Project with your preferred IDE
- Run the template


The template uses the Cake build system to produce a mod ready to release for you.
You can create a release with one of the following methods:
- In Visual Studio and Rider Select to run the CakeBuilder Project.
- In Visual Studio Code click on "Terminal" > "Run Task" > "package"
- run the build.ps1 or build.sh

This will then produce the `mymodid_1.0.0.zip` inside the `Release` folder in the project root folder.


##  Linux / Mac
This sample is preconfigured for Windows if you want to use it on Linux or Mac you need to change the path for the Vintage Story (Server) binaries since those are now platform dependent with .NET 7. 

### Rider
If you use Rider on Linux or Mac you will need to change in
`modtemplate/Properties/launchSettings.json`
```
"executablePath": "$(VINTAGE_STORY)/Vintagestory.exe",
"executablePath": "$(VINTAGE_STORY)/VintagestoryServer.exe",
```
to 
```
"executablePath": "$(VINTAGE_STORY)/Vintagestory",
"executablePath": "$(VINTAGE_STORY)/VintagestoryServer",
```

## Info General

Since version 1.18.8-rc1 Vintage Story uses .NET 7 as its base framework. This means from now on mods can be targeted towards it and make use of the latest C# 11 language features.

Further the new way of creating mods uses a [dotnet template package](https://www.nuget.org/packages/VintageStory.Mod.Templates/).

This basically allows you to create a mod directly from Visual Studio, Rider or the command line (`dotnet new vsmod`) for more details how to use it see our [wiki page](https://wiki.vintagestory.at/index.php/Modding:Setting_up_your_Development_Environment).

It supports options so you can easily add what ever dependency you may need in you next modding project.

The new template also just houses a single mod by default (you can still manually add more if wanted). We think it is better to have the mods separated in their own repositories and Solutions.

Further with the new template package and the cake build system there is not much need for the `vsmodtools` tool hopefully, which means less code to be maintained by us.

We are also now supporting Visual Studio, Visual Studio Code and Rider with the new SDK style project and templates.

## Cake build system

The new template also comes with the cake build system https://cakebuild.net/ found in the file [CakeBuild/Program.cs](CakeBuild/Program.cs).
It is also used in the games repo to build the game for each platform (Windows x64, Linux x64, MacOs x64) and eventually Arm x64 as well at some point.

But that is not all cake can do for us.
Since we use the `Cake Frosting` setup which essentially adds another Project to our solution where we can write C# code to define our build and package procedure. Further we added a Json Validation step to it so before a build is made it will verify that all json files are at least parsable by `Newtonsoft.Json` to avoid simple mistakes. And if you want to use any Testing library you can also add it to the Cake build system to run your test when you create a mod.zip for release.


## Migrating Mods to .NET 7

To migrate your mod to .NET 7 we would recommend you to create a new project with our new template (checkout our updated [wiki page](https://wiki.vintagestory.at/index.php/Modding:Setting_up_your_Development_Environment) for that) and copy over your old code. Additionally you may need to add any special references you need for your mod.

Then you may have to make some code changes so your mod works with the .NET 7 version of the game. For most mods this should be just minor changes.

Once that is done it should be ready to be started within you preferred IDE. So you can also benefit from new C# 11 language features as well as the cake build system.

