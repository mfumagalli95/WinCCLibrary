# WinCCLibrary
Source code to generate a simple DLL library that can be use in WinCC's script.


## Compile the project and get the DLL
Compile the project with Visual Studio and get the DLL in project path ".../WinCCLibrary/bin/release/WinCCLibrary.dll"

![1](https://user-images.githubusercontent.com/34168918/71070506-36110300-217b-11ea-8e75-1e860f18824d.png)



## Register DLL on system
To use the DLL in WinCC is necessary to register with the following Command Prompt
```console
C:\Windows\Microsoft.NET\Framework\V4.0.30319>RegAsm /CODEBASE C:\...\WinCCLibrary.dll pause
```
If all went well you can see the following text in Command Prompt
![Untitled](https://user-images.githubusercontent.com/34168918/71071012-1e864a00-217c-11ea-8b9d-a84904b0d6bd.png)

## Use library's methods in WinCC VBS script
Create a new VBS script file and try library's method as following
```
Sub WinCCLibTest()

On Error Resume Next
Dim obj
Set obj = CreateObject("WinCCLibrary.dll")
MsgBox(obj.Info())

End Sub
```

## Versions
WinCC Professional v15.1, Visual Studio Community 2019
