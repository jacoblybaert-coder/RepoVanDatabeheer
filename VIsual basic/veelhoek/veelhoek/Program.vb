Imports System

Public Class Veelhoek
    Private aantalzijden As Integer

    Public Sub New(aantalzijden As Integer)
        Me.aantalzijden = aantalzijden
    End Sub
End Class

Public Class Vierkant
    Inherits Veelhoek

    Public Sub New()
        MyBase.New(4)
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim vierkant As New Vierkant()
        Console.WriteLine("Aantal zijden van het vierkant: {0}", vierkant.aantalzijden)
    End Sub
End Module
