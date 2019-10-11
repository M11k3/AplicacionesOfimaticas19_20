Option Strict On
Module Ejercicio4
    Sub Main()
        Dim a, b, c, d, menor As Integer

        Console.WriteLine("Valor de a ? : ")
        a = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Valor de b ? : ")
        b = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Valor de c ? : ")
        c = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Valor de d ? : ")
        d = Convert.ToInt32(Console.ReadLine())

        If a > b Then
            menor = b
        Else
            menor = a
        End If

        If menor > c Then
            menor = c

        End If

        If menor > d Then
            menor = d
        End If

        Console.WriteLine("El más pequeño es: " & menor)
        Console.ReadLine()








    End Sub
End Module
