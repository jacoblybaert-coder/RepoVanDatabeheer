
Imports System
Imports System.Reflection
Class bestelling
    Protected strKlantNaam As String
    Protected dblTotaalBedrag As Double

    Public Function ToonBestelDetails() As String
        Console.WriteLine($"Klant met naam: {strKlantNaam}")
        Console.WriteLine($"Totaal bedrag van bestelling: {dblTotaalBedrag}")
    End Function

    Public Overridable Function BerekenVerzendkosten() As Integer
        Return 5
    End Function
End Class

Class SnelleLevering
    Inherits bestelling
    Private dblSpoedToeslag As Double


    Public Sub New(spoedToeslag As Double, klantnaam As String, totaalbedrag As Integer)
        Me.dblSpoedToeslag = 10
        MyBase.New(strKlantNaam = klantnaam)
        MyBase.New(dblTotaalBedrag = totaalbedrag)
    End Sub

    Public Overrides Function BerekenVerzendkosten() As Integer
        Return MyBase.BerekenVerzendkosten() + dblSpoedToeslag
    End Function
End Class

Class InternationaleBestelling
    Inherits bestelling
    Private strLand As String
    Public Function BerekenDouaneKosten()
        Return dblTotaalBedrag / 10
    End Function

    Public Overrides Function BerekenVerzendKosten() As Integer
        Return MyBase.BerekenVerzendkosten() + BerekenDouaneKosten()
    End Function
End Class

Class Verzending
    Protected strVerzendType As String
    Public Overridable Function BerekenVerzendKosten() As Integer
        Return 3
    End Function
End Class

Class PakketVerzending
    Inherits Verzending

    Private strPakketGrootte As String

    Public Overrides Function BerekenVerzendKosten(input) As Integer
        If strPakketGrootte = "klein" Then
            Return 3
        ElseIf strPakketGrootte = "middelgroot" Then
            Return 5
        ElseIf strPakketGrootte = "groot" Then
            Return 8
        Else
            Return "geen juiste grootte"
        End If

    End Function

End Class

Class Luchtpost
    Inherits Verzending
    Private dblLuchttarief As Double

    Public Sub New(dblLuchttarief As Double)
        Me.dblLuchttarief = 15
    End Sub

    Public Overrides Function BerekenVerzendKosten() As Integer
        Return MyBase.BerekenVerzendKosten() + dblLuchttarief
    End Function
End Class

Module Program
    Sub Main(args As String())
        Dim objSnelleLevering As New SnelleLevering
        Console.WriteLine(objSnelleLevering.ToonBestelDetails)
        Console.WriteLine($"Totale verzendkosten zijn: {objSnelleLevering.BerekenVerzendkosten")
        Console.WriteLine("---")
        Dim objInternationaleBestelling As New InternationaleBestelling
        Console.WriteLine(objInternationaleBestelling.ToonBestelDetails)
        Console.WriteLine($"douanekosten zijn: {objInternationaleBestelling.BerekenDouaneKosten}")
        Console.WriteLine($"Totale verzendkosten zijn: {objInternationaleBestelling.BerekenVerzendKosten}")
        Console.WriteLine("---")
        Dim objPakketVerzending As New PakketVerzending
        Console.WriteLine($"Verzendkosten voor pakket met grootte: middelgroot is: {objPakketVerzending.BerekenVerzendKosten(middelgroot)} euro")
        Console.WriteLine("---")
        Dim objLuchtpost As New Luchtpost
        Console.WriteLine($"Verzendksoten voor luchtpakket zijn: {objLuchtpost.BerekenVerzendKosten} euro")

    End Sub
End Module
