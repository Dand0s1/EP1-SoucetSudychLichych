Imports System

Module Program
  Sub Main(args As String())
        Dim pocet, cislo, soucet As Integer



        Console.WriteLine("Zadej poèet èísel:")
        pocet = Console.ReadLine
        Console.WriteLine($"Bude se sèítat {pocet} èísla/èísel ")
        Console.WriteLine("------------------------------------")
        If pocet < 0 Then
            Console.WriteLine("Musíš zadat kladné èíslo")
            End
        End If

        Do Until pocet = 0
            Console.WriteLine("Napiš èíslo:")
            cislo = Console.ReadLine
            soucet += cislo
            pocet = pocet - 1
        Loop
        Console.WriteLine($"Souèet èísel je: {soucet}")
    End Sub
End Module
