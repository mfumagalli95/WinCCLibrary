Imports System.Runtime.InteropServices

Namespace WinCCLibrary
    <ComVisible(True)>
    <ProgId("TiaLib.DLL")>
    Public Class LibraryClass

        Public Sub New()
            MyBase.New()
        End Sub

        Public Function Info() As String
            Return "WinCC Library, .NET Framework Version 4.0"
        End Function

        Public Function GetDateTime() As String
            Dim dateTime As String = Format(Now(), "MM/dd/yyyy HH:mm:ss")
            Return dateTime
        End Function

        Public Function GetDate() As String
            Dim dt As String = Format(Now(), "MM/dd/yyyy")
            Return dt
        End Function

        Public Function GetTime() As String
            Dim t As String = Format(Now(), "HH:mm:ss")
            Return t
        End Function

        Public Function GetRandomInteger() As Integer
            Return CInt(Rnd())
        End Function

    End Class
End Namespace

