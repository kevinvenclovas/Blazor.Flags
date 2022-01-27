# Blazor.FLags
Add easy country flags to your blazor project.
Inspired by [vue-country-flag](vue-country-flag) ❤️

Easy to use for Blazor Server and Blazor WebAssembly

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

**Only on Blazor Server you need to add css to your _Host.cshtml file**
```
<link href="_content/Blazor.Flags/flags.css" rel="stylesheet" />
```

## Using

Use the Country component to show a flag. 

```
<CountryFlag Country="Country.DE" Size="FlagSize.Small"></CountryFlag>
```

### Parameters

| Parameter | Description |
| ------ | ------ |
| Country | ISO-Alpha-2-Code |
| Size | Size of the flag - Small, Normal, Large  |
| IsRounded | Add rounded corners to flag icon |
| HasShadow | Add small shadow to flag |
| Class | Add custom class to flag |
| Style | Add custom style to flag |


[vue-country-flag]: <https://github.com/P3trur0/vue-country-flag>
  


