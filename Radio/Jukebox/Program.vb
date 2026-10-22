
Imports System

Module Program

    Class Radio

        Public Sub SpeelLiedje()
            SpeelLiedjeRadio()
        End Sub

        Private Sub SpeelLiedjeRadio()
            Dim random As New Random()
            Dim getal As Integer = random.Next(1, 4)

            Console.WriteLine("Ik ga een liedje spelen")

            If getal = 1 Then
                Console.WriteLine("life is a highway")
            ElseIf getal = 2 Then
                Console.WriteLine("just the two of us")
            Else
                Console.WriteLine("nothing else matters")
            End If
        End Sub

    End Class

    Sub Main(args As String())
        Dim newRadio As New Radio()
        newRadio.SpeelLiedje()

        Console.ReadLine()
    End Sub

End Module
