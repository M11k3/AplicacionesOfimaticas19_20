Option Strict On
Module Module1

    Sub Main()
        Dim numero1, numero2 As Integer
        Dim condicion1, condicion2, condicion3 As Boolean
        numero1 = 9
        numero2 = 2
        'Operadores relacionales < , > , = ,<> ,<= , >=
        condicion1 = numero1 < 10
        condicion2 = numero1 Mod 2 = 0
        condicion3 = numero1 <> numero2

        'Operadores lógicos : AND , OR , Not
        Dim condicion4, condicion5, condicion6 As Boolean

        condicion4 = numero1 < 10 And numero1 > 5
        condicion5 = numero1 < 10 Or numero1 = 45
        condicion6 = Not condicion5

        'Operador de asignación = , += , -=
        numero1 += 10 '--> numero1 = numero1 + 10
        numero2 -= 10











    End Sub

End Module
