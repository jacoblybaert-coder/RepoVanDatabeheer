Imports System

Public Class Wielrenner
    Public strNaam As String
    Public intLeeftijd As Integer
    Public strPloeg As String

    Public Sub ToonNaam()
        Console.WriteLine($"Naam: {strNaam}")
    End Sub

    Public Sub ToonLeeftijd()
        Console.WriteLine($"Leeftijd: {intLeeftijd}")
    End Sub

    Public Sub ToonPloeg()
        Console.WriteLine($"Ploeg: {strPloeg}")
    End Sub
End Class

Public Class Profwielrenner
    Inherits Wielrenner

    Public strAantalOverwinningen As String
    Public dblSalaris As Double

    Public Sub ToonAantalOverwinningen()
        Console.WriteLine($"Aantal overwinningen: {strAantalOverwinningen}")
    End Sub

    Public Sub ToonSalaris()
        Console.WriteLine($"Salaris: {dblSalaris:C}")
    End Sub
End Class

Public Class Amateurwielrenner
    Inherits Wielrenner

    Public intAantalDeelnames As Integer
    Public intAantalOverwinningen As Integer

    Public Sub ToonAantalOverwinningen()
        Console.WriteLine($"Aantal overwinningen: {intAantalOverwinningen}")
    End Sub

    Public Sub ToonAantalDeelnames()
        Console.WriteLine($"Aantal deelnames: {intAantalDeelnames}")
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim prof1 As New Profwielrenner With {
            .strNaam = "Wout van Aert",
            .intLeeftijd = 29,
            .strPloeg = "Team Visma | Lease a Bike",
            .strAantalOverwinningen = "95",
            .dblSalaris = 2500000
        }

        Dim prof2 As New Profwielrenner With {
            .strNaam = "Lotte Kopecky",
            .intLeeftijd = 29,
            .strPloeg = "SD Worx - Protime",
            .strAantalOverwinningen = "85",
            .dblSalaris = 1500000
        }

        Dim amateur1 As New Amateurwielrenner With {
            .strNaam = "Jan Janssens",
            .intLeeftijd = 24,
            .strPloeg = "WTC De Sprint",
            .intAantalDeelnames = 18,
            .intAantalOverwinningen = 3
        }

        Dim amateur2 As New Amateurwielrenner With {
            .strNaam = "Sofie Peeters",
            .intLeeftijd = 21,
            .strPloeg = "WTC De Koers",
            .intAantalDeelnames = 12,
            .intAantalOverwinningen = 2
        }

        ToonProfwielrenner(prof1)
        ToonProfwielrenner(prof2)
        ToonAmateurwielrenner(amateur1)
        ToonAmateurwielrenner(amateur2)
    End Sub

    Private Sub ToonProfwielrenner(profwielrenner As Profwielrenner)
        Console.WriteLine("--- Profwielrenner ---")
        profwielrenner.ToonNaam()
        profwielrenner.ToonLeeftijd()
        profwielrenner.ToonAantalOverwinningen()
        Console.WriteLine()
    End Sub

    Private Sub ToonAmateurwielrenner(amateurwielrenner As Amateurwielrenner)
        Console.WriteLine("--- Amateurwielrenner ---")
        amateurwielrenner.ToonNaam()
        amateurwielrenner.ToonLeeftijd()
        amateurwielrenner.ToonAantalOverwinningen()
        Console.WriteLine()
    End Sub
End Module
