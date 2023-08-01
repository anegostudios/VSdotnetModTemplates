# Vintage Story modding templates for dotnet
Following templates are included in the package:

```
Template Name                  Short Name  Language  Tags
-----------------------------  ----------  --------  -------------------
Vintage Story Mod              vsmod       [C#]      Games/Vintage Story             
Vintage Story Mod (.dll only)  vsmoddll    [C#]      Games/Vintage Story 
```
- vsmod

    Includes project using Cake build system
- vsmoddll

    Includes only a basic project and a Sample ModSystem to start modding. Will only output a .dll


## Build & and install locally

#### Requirements  
- [dotnet SKD 7.0](https://dotnet.microsoft.com/en-us/download)

```shell
cd VSModTemplates
dotnet pack
```
#### Install

change the below command to use the latest version
```
dotnet new install .\bin\Release\VintageStory.Mod.Templates.x.x.x.nupkg
```


#### Uninstall

```
dotnet new uninstall VintageStory.Mod.Templates
```
