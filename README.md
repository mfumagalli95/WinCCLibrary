# WinCCLibrary
Source code to generate a simple DLL library that can be use in WinCC's script.


## Compile the project and get the DLL
Compile the project with Visual Studio and get the DLL in project path ".../WinCCLibrary/bin/release/WinCCLibrary.dll"

## Register DLL on system
To use the DLL in WinCC is necessary to register with the following prompt command
```console
C:\Windows\Microsoft.NET\Framework\V4.0.30319>RegAsm /CODEBASE C:\...\WinCCLibrary.dll pause
```
