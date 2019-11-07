Module Module1

    Sub Main()
        Dim ejercicio As Integer
        Dim continuar As Char
        Do

            Console.WriteLine("Escoja el ejercicio: ")
            Console.WriteLine("1. Ejercicio1")
            Console.WriteLine("5. Ejercicio5")
            Console.WriteLine("6. Ejercicio6")
            Console.WriteLine("7. Ejercicio7")
            Console.WriteLine("8. Ejercicio8")
            Console.WriteLine("9. Ejercicio9")
            Console.WriteLine("10. Ejercicio10")

            ejercicio = Convert.ToInt32(Console.ReadLine())
            Select Case ejercicio
                Case 1
                    'a ) 1 ,3 ,5 ,7, 9, 11 , 13 , 15, ...

                    For i As Integer = 1 To 15 Step 2
                        Console.Write(i & " ")
                    Next

                    Console.WriteLine()

                    'b ) 

                    Dim j As Integer = 2

                    While j <= 10
                        Console.Write(j & " ")
                        j += 2
                    End While
                    Console.WriteLine()

                    Dim k As Integer = 5
                    While k <= 25
                        Console.Write(k & " ")
                        k += 5
                    End While
                    Console.WriteLine()

                    'd) 100 , 90 , 80 , 70 , 60 , 50

                    Dim z As Integer = 100
                    While z >= 50
                        Console.Write(z & " ")
                        z -= 10
                    End While

                Case 7
                    Dim n As Integer
                    'n >= 1 y <=10
                    Do
                        Console.WriteLine("Introduzca numero ")
                        n = Convert.ToInt32(Console.ReadLine())
                    Loop While n < 1 Or n > 10

                    For i As Integer = 1 To 10 Step 1
                        Console.WriteLine(n & " * " & i & " = " & n * i)
                    Next

                Case 8

                    Dim numero As Integer = 100
                    Console.WriteLine("numero cuadrado  cubo")
                    Dim digitos As Integer = numero.ToString().Length
                    For i As Integer = numero To numero + 4 Step 1

                        Console.WriteLine(i & "      " & Math.Pow(i, 2) & "  " & Math.Pow(i, 3))
                    Next

                Case 9
                    Console.WriteLine("n     raiz(n)")

                    For i As Double = 16 To 1 Step -2.5
                        Console.WriteLine(i & "    " & Math.Round(Math.Sqrt(i), 2))
                    Next

            End Select

            Console.WriteLine("Desea continuar s/n")
            continuar = Convert.ToChar(Console.ReadLine())
            Console.Clear()
        Loop While continuar = "s"c
        Console.ReadLine()
    End Sub

End Module
