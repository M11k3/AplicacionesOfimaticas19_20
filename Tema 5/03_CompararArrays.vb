Option Strict On
Module Module1
    Sub Main()
        Dim m1() As Integer = {5, 4, 2, 1}
        Dim m2() As Integer = {58, 42, 2, 1}
        'Para saber si dos arrays son iguales debemos ir posición por posición
        Dim distinto As Boolean = False
        For i As Integer = 0 To m1.Length - 1 Step 1
            If m1(i) <> m2(i) Then
                distinto = True
                Exit For
            End If

        Next




        'Al igualar las dos referencias lo que hacemos es que m1 apunte a m
        m1 = m2

        'If m1 Is m2 Then
        '    Console.WriteLine("Iguales")
        'Else
        '    Console.WriteLine("Diferentes")
        'End If
        Console.ForegroundColor = ConsoleColor.White
        m2(0) = -890
        m1(0) = 9000
        Console.WriteLine("m1(0) : " & m1(0))
        Console.WriteLine("m2(0) : " & m2(0))

        'Algoritmo que me identifique si dos arrays son iguales
        Dim x() As Integer = {1, 2, 3, 5, 0}
        Dim y() As Integer = {6, 2, 4, 3, 1}






        Console.ReadLine()



    End Sub

End Module
