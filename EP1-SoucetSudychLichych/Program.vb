Imports System

Module Program
  Sub Main(args As String())
        Dim pocet, cislo, soucet As Integer



        Console.WriteLine("Zadej po�et ��sel:")
        pocet = Console.ReadLine
        Do Until pocet = 0
            Console.WriteLine("Napi� ��slo:")
            cislo = Console.ReadLine
            soucet += cislo
            pocet = pocet - 1
        Loop
        Console.WriteLine($"Sou�et ��sel je: {soucet}")
    End Sub
End Module
