Imports System

Module Program
  Sub Main(args As String())
        Dim pocet, cislo, soucet As Integer



        Console.WriteLine("Zadej po�et ��sel:")
        pocet = Console.ReadLine
        Console.WriteLine($"Bude se s��tat {pocet} ��sla/��sel ")
        Console.WriteLine("------------------------------------")
        If pocet < 0 Then
            Console.WriteLine("Mus� zadat kladn� ��slo")
            End
        End If

        Do Until pocet = 0
            Console.WriteLine("Napi� ��slo:")
            cislo = Console.ReadLine
            soucet += cislo
            pocet = pocet - 1
        Loop
        Console.WriteLine($"Sou�et ��sel je: {soucet}")
    End Sub
End Module
