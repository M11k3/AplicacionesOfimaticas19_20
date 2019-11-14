Option Strict On
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

                Case 10
                    Dim m As Integer
                    Dim suma As Integer

                    'm sea positivo
                    Do
                        Console.WriteLine("Intro numero positivo")
                        m = Convert.ToInt32(Console.ReadLine())
                    Loop While m < 0

                    'suma = 1 + 2 + 3 + ... m
                    'reiniciar la suma a cero
                    suma = 0
                    For i As Integer = 1 To m Step 1
                        suma = suma + i
                    Next

                    Console.WriteLine("La suma de los " & m & " primeros números es : " & suma)

                Case 11
                    Dim n As Integer = 100
                    Dim suma As Double = 0

                    For i As Integer = 1 To n Step 1
                        suma = suma + 1 / Math.Pow(i, 3)
                    Next

                    Console.WriteLine("La suma es " & suma)

                Case 12
                    Dim n As Integer
                    Dim suma As Integer = 0
                    Do
                        Console.WriteLine("Intro numero positivo")
                        n = Convert.ToInt32(Console.ReadLine())

                    Loop While n < 0

                    For i As Integer = 1 To Convert.ToInt32(n / 2) Step 1
                        If n Mod i = 0 Then
                            'suma = suma + i
                            suma += i
                        End If
                    Next
                    'Si quiero sumar n
                    suma += n
                    Console.WriteLine("La suma de los divisores es : " & suma)
                Case 15
                    Dim numero As Integer = 3
                    Dim factorial As Long = 1
                    'factorial de n = n*(n-1)*(n-2)...*1

                    Dim i As Integer = numero

                    While i >= 1

                        factorial = factorial * i

                        i = i - 1
                    End While

                    Console.WriteLine(factorial)


                Case 17
                    'Contar los divisores

                    Dim n As Integer = 14
                    Dim contador As Integer = 1 'Inicializo a 1 para contar n , ya que en el bucle no llego hasta n

                    For i As Integer = 1 To Convert.ToInt32(n / 2) Step 1
                        If n Mod i = 0 Then
                            contador = contador + 1
                        End If
                    Next

                    Console.WriteLine(n & " tiene " & contador & " divisores")

                Case 18
                    Dim numero As Integer = 9
                    Dim contador As Integer = 0
                    Dim primo As Boolean = True

                    For i As Integer = 2 To Convert.ToInt32(numero / 2) Step 1
                        If numero Mod i = 0 Then
                            primo = False
                            Exit For

                        End If
                    Next

                    If primo Then
                        Console.WriteLine("Primo")
                    Else
                        Console.WriteLine("No primo")
                    End If

            End Select

            Console.WriteLine("Desea continuar s/n")
            continuar = Convert.ToChar(Console.ReadLine())

            Console.Clear()
        Loop While continuar = "s"
        Console.ReadLine()
    End Sub

End Module
