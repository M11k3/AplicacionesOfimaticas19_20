Option Strict On
Module Ejercicio6
    Sub Main()
        Dim n1, n2, n3 As Integer
        Dim media As Double

        Console.WriteLine("Introduce nota 1: ")
        n1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Introduce nota 2: ")
        n2 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Introduce nota 2: ")
        n3 = Convert.ToInt32(Console.ReadLine())

        media = (n1 + n2 + n3) / 3

        If media >= 5 Then
            Console.WriteLine("Aprobado")
        Else
            Console.WriteLine("Suspenso")
        End If

    End Sub
End Module
