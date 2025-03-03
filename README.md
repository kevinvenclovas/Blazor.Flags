# Blazor.Flags
Add easy country flags to your blazor project.
Inspired by [vue-country-flag](https://github.com/P3trur0/vue-country-flag) ❤️

Easy to use for Blazor Server and Blazor WebAssembly

![image](https://user-images.githubusercontent.com/7681603/151586606-e7b9d73e-9a4a-43d7-98fc-fbace092ed9d.png)


[![Nuget version](https://img.shields.io/nuget/v/Blazor.Flags?color=ff4081&label=nuget%20version&logo=nuget&style=flat-square)](https://www.nuget.org/packages/Blazor.Flags/)
[![Nuget downloads](https://img.shields.io/nuget/dt/Blazor.Flags?color=ff4081&label=nuget%20downloads&logo=nuget&style=flat-square)](https://www.nuget.org/packages/Blazor.Flags/)

## Installation

Install nuget
```
Install-Package Blazor.Flags -Version 1.0.0
```


Add using to your _Imports.razor file
```
@using Blazor.Flags
```

If your project name ends with .Blazor you need to import Blazor.Flags with global
```
@using global::Blazor.Flags
```


**Only on Blazor Server you need to add css to your _Host.cshtml file**
```
<link href="_content/Blazor.Flags/flags.css" rel="stylesheet" />
```

## Using

Use the Country component to show a flag. 

#### With Blazor.Flags defined country enum
```
<CountryFlag Country="Country.DE" Size="FlagSize.Small"></CountryFlag>
```

#### or with ISOA2 string
```
<CountryFlag InputType="InputType.ISOA2" ISOA2="DE" Size="FlagSize.Small"></CountryFlag>
```

### Parameters

| Parameter | Description | Type | Value |
|:--|:--|:--|:--|
| InputType | Input type to show flag | `Enum` | `ISOA2` or `Country` |
| Country | Definded Country Enum Type | `Enum` | `Country.DE`, `Country.US` ... |
| ISOA2 | ISO-Alpha-2-Code | `String` | `DE` , `US` , `TR` ... |
| Size | Size of the flag| `Enum` | `Small` , `Normal` , `Large` |
| IsRounded | Flag with rounded borders | `Boolean` | `false` by default |
| HasShadow | Flag with box shadow around | `Boolean` | `false` by default |
| Class | Add custom class to flag | `String` | `null` by default |
| Style | Add custom style to flag | `String` | `null` by default |


