Option Strict On
Module Ejercicio5
    Sub Main()
        Dim numero As Integer = 5

        'Ver si es par
        If numero Mod 2 = 0 Then
            Console.WriteLine("Es par")
        Else
            Console.WriteLine("Es impar")
        End If
        Console.ReadLine()
    End Sub
End Module
