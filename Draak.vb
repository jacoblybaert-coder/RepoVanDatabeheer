Imports System

Module Program
    Class Draak
        Public strNaam As String
        Public strOrigin As String
        Public intLeeftijd As Integer
        Public strGender As String
        Public strClassifiction As String

        Public Sub New()
            Me.strNaam = "Drogon"
            Me.intLeeftijd = 6
            Me.strOrigin = "België"
            Me.strGender = "Today"
            Me.strClassifiction = "larper dragon"
        End Sub

        Public Overrides Function ToString() As String
            Return $"Naam: {strNaam}" & vbCrLf &
                   $"Origin: {strOrigin}" & vbCrLf &
                   $"Leeftijd: {intLeeftijd}" & vbCrLf &
                   $"Gender: {strGender}" & vbCrLf &
                   $"Classification: {strClassifiction}"
        End Function
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello Westeros")
        Dim objDraak As New Draak()
        Console.WriteLine(objDraak)
    End Sub
End Module
