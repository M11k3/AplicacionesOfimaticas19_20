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

                Case 13
                    Dim numero As Integer
                    Dim suma As Integer = 0

                    Console.WriteLine("Intro numero:")
                    numero = Convert.ToInt32(Console.ReadLine())

                    For i As Integer = 1 To Convert.ToInt32(numero / 2) Step 1
                        If numero Mod i = 0 Then
                            suma = suma + i
                        End If
                    Next

                    'Perfecto = suma de sus divisores
                    If numero = suma Then
                        Console.WriteLine("Perfecto")
                    Else
                        Console.WriteLine("No perfecto")
                    End If


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

                Case 19
                    Dim n, m As Integer
                    Dim multiplos As Boolean = False
                    Console.WriteLine("Introduzca limite inferior")
                    n = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Introduzca limite superior")
                    m = Convert.ToInt32(Console.ReadLine())

                    'Detectar el primer número que sea múltiplo de 3 , 5 y 7 a la vez

                    For i As Integer = n To m Step 1
                        If i Mod 3 = 0 And i Mod 5 = 0 And i Mod 7 = 0 Then
                            multiplos = True
                            Console.WriteLine(i & " primer múltiplo de 3 , 5 y 7")
                            Exit For
                        End If
                    Next

                    If Not multiplos Then
                        Console.WriteLine("No hay múltiplos de 3,5 y 7 a la vez")
                    End If
                    'Mismo algoritmo con un while para que repaséis
                    Dim j As Integer = n
                    While j <= m
                        If j Mod 3 = 0 And j Mod 5 = 0 And j Mod 7 = 0 Then
                            Console.WriteLine(j & " primer múltiplo de 3 , 5 y 7")
                            Exit While
                        End If
                        j += 1
                    End While

                Case 21
                    'Tabla de multiplicar de los n primeros números

                    'Tabla de multiplicar del 1

                    ' Dim n As Integer = 5
                    For j As Integer = 0 To 10 Step 1
                        Console.WriteLine("Alexandre esta es la tabla del " & j)
                        For i As Integer = 1 To 10 Step 1
                            Console.WriteLine(i & " * " & j & " = " & j * i)
                        Next
                        Console.WriteLine("***************")
                    Next






                Case 22

                    'a) 

                    '********
                    '*******
                    '*****
                    '***
                    Dim locura As Integer = 7
                    For j As Integer = 0 To 7 Step 1
                        For i As Integer = 0 To locura Step 1
                            Console.Write("* ")
                        Next
                        Console.WriteLine()
                        locura -= 1
                    Next
                    Console.WriteLine()
                    'b)
                    For i As Integer = 1 To 9 Step 1
                        For j As Integer = 1 To i Step 1
                            Console.Write("* ")
                        Next
                        Console.WriteLine()
                    Next
                    'c)


                    'd)
                    For i As Integer = 9 To 1 Step -1
                        For j As Integer = 1 To i Step 1
                            Console.Write(j & " ")
                        Next
                        Console.WriteLine()
                    Next
                Case 23

                    Dim n As Integer = 90000000 'Limite superior 
                    Dim suma As Integer = 0

                    'Obtener suma divisores
                    For k As Integer = 6 To n Step 1
                        'Resetear el la suma que viene viciada de la iteración anterior
                        suma = 0
                        For i As Integer = 1 To Convert.ToInt32(k / 2) Step 1
                            If k Mod i = 0 Then
                                suma = suma + i
                            End If
                        Next
                        'Es perfecto si suma = n

                        If suma = k Then
                            Console.WriteLine(k & " es perfecto")
                        End If

                    Next
                Case 24
                    Dim n As Integer = 0
                    Dim contadorDivisores, contadorPrimos As Integer
                    Console.WriteLine("Introduzca n")
                    n = Convert.ToInt32(Console.ReadLine())

                    contadorPrimos = 0
                    contadorDivisores = 0
                    Console.WriteLine("Números primos por debajo de " & n)
                    For i As Integer = 3 To n Step 1
                        'Reiniciar contador divisores
                        contadorDivisores = 0
                        For k As Integer = 2 To i - 1 Step 1
                            If i Mod k = 0 Then
                                contadorDivisores += 1
                                Exit For
                            End If
                        Next
                        If contadorDivisores = 0 Then
                            contadorPrimos += 1
                            Console.Write(i & " ")
                        End If
                    Next
                    Console.WriteLine()
                Case 25
                    Dim contadorPositivos As Integer = 0
                    Dim contadorNegativos As Integer = 0
                    Dim contadorRango As Integer = 0
                    'Generar numeros aleatorios
                    Dim aleatorio As Random = New Random()
                    For k As Integer = 1 To 10 Step 1
                        contadorPositivos = 0
                        contadorNegativos = 0
                        Console.ForegroundColor = ConsoleColor.White
                        For i As Integer = 1 To 10 Step 1

                            Dim z As Integer = aleatorio.Next(-5, 6)
                            Console.Write(z & " ")

                            If z >= 0 Then
                                contadorPositivos += 1
                            Else
                                contadorNegativos += 1
                            End If
                            If z < 2 And z > -2 Then
                                contadorRango += 1
                            End If

                        Next
                        Console.ForegroundColor = ConsoleColor.Yellow
                        Console.WriteLine()

                        Console.WriteLine("     numeros positivos: " & contadorPositivos)
                        Console.WriteLine("     numeros negativos: " & contadorNegativos)
                        Dim porcentaje As Double = (contadorRango / 10) * 100
                        Console.WriteLine("     Porcentaje entre -2 y 2: " & contadorRango & " %")
                    Next

                    Console.WriteLine()

                Case 26
                    'Explicación While
                    'Suma de los n primeros números















            End Select

            Console.WriteLine("Desea continuar s/n")
            continuar = Convert.ToChar(Console.ReadLine())

            Console.Clear()
        Loop While continuar = "s"
        Console.ReadLine()
    End Sub

End Module
