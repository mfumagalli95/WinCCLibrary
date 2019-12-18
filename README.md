# WinCCLibrary
Source code to generate a simple DLL library that can be use in WinCC's script.


## Compile the project and get the DLL
Compile the project with Visual Studio and get the DLL in project path ".../WinCCLibrary/bin/release/WinCCLibrary.dll"

![1](https://user-images.githubusercontent.com/34168918/71070506-36110300-217b-11ea-8e75-1e860f18824d.png)



## Register DLL on system
To use the DLL in WinCC is necessary to register with the following prompt command
```console
C:\Windows\Microsoft.NET\Framework\V4.0.30319>RegAsm /CODEBASE C:\...\WinCCLibrary.dll pause
```
