Option Strict On
Module Module1
    Sub Main()
        Dim m1() As Integer = {5, 4, 2, 1}
        Dim m2() As Integer = {58, 42, 2, 1}
        m1 = m2
        'Si estos dos arrays son iguales

        If m1 Is m2 Then
            Console.WriteLine("Iguales")
        Else
            Console.WriteLine("Diferentes")
        End If
        Console.ForegroundColor = ConsoleColor.White
        m2(0) = -890
        m1(0) = 9000
        Console.WriteLine("m1(0) : " & m1(0))
        Console.WriteLine("m2(0) : " & m2(0))

        Console.ReadLine()



    End Sub

End Module
