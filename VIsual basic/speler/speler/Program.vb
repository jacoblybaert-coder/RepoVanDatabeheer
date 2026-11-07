Imports System

Module Program
    Sub Main(args As String())
        Dim verdediger As New Verdediger("Jan")
        Dim aanvaller As New Aanvaller("Pieter")

        verdediger.TrapBal()
        aanvaller.TrapBal()
    End Sub
End Module

Public Class Speler
    Public ReadOnly Naam As String

    Public Sub New(strNaam As String)
        Naam = strNaam
    End Sub

    Public Overridable Sub TrapBal()
        Console.WriteLine($"{Naam} trapt de bal.")
    End Sub
End Class

Public Class Verdediger
    Inherits Speler

    Public Sub New(strNaam As String)
        MyBase.New(strNaam)
    End Sub

    Public Overrides Sub TrapBal()
        If Random.Shared.Next(2) = 0 Then
            Console.WriteLine($"{Naam} verliest de bal.")
        Else
            Console.WriteLine($"{Naam} geeft de bal goed af aan een ploeggenoot.")
        End If
    End Sub
End Class

Public Class Aanvaller
    Inherits Speler

    Public Sub New(strNaam As String)
        MyBase.New(strNaam)
    End Sub

    Public Overrides Sub TrapBal()
        If Random.Shared.Next(100) < 30 Then
            Console.WriteLine($"{Naam} maakt een goal!")
        Else
            Console.WriteLine($"{Naam} maakt geen goal.")
        End If
    End Sub
End Class
