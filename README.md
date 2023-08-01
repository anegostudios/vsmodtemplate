# vsmodtemplate

This repository contains a configured .NET 7 mod for VisualStudio, VisualStudioCode and Rider that let's you start Vintage Story and add your own code to it. Supports logging and as well as debugging.


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
