Option Strict On
Module Module1

    Sub Main()
        Dim opcion As Integer
        Do

            Console.WriteLine("5. Ejercicio 5")
            Console.WriteLine("6. Ejercicio 6")
            Console.WriteLine("7. Ejercicio 7")
            Console.WriteLine("8. Ejercicio 8")
            Console.WriteLine("9. Ejercicio 9")
            Console.WriteLine("10. Ejercicio 10")
            Console.WriteLine("13. Salir")

            'Leer la opción escogida por teclado
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion

                Case 5
                    Dim nota As Double
                    Console.WriteLine("Introducir la nota: ")
                    nota = Convert.ToDouble(Console.ReadLine())

                    If nota < 0 Or nota > 10 Then
                        Console.WriteLine("Error en la nota")
                    ElseIf nota < 5 Then
                        Console.WriteLine("Suspenso")
                    ElseIf nota < 6.5 Then
                        Console.WriteLine("Aprobado")
                    ElseIf nota < 8.5 Then
                        Console.WriteLine("Notable")
                    Else
                        Console.WriteLine("Sobresaliente")
                    End If


                Case 6
                    Dim numero As Integer
                    Console.WriteLine("Dime un numero:")
                    numero = Convert.ToInt32(Console.ReadLine())

                    If numero Mod 4 = 0 Then
                        '  numero = numero+25
                        numero += 25
                    ElseIf numero Mod 5 = 0 Then
                        numero += 50
                    Else
                        numero += 100

                    End If
                    Console.WriteLine("Número vale finalmente : " & numero)
                Case 7
                    Dim temperatura As Double
                    Console.WriteLine("Introduce una temperatura.")
                    temperatura = Convert.ToDouble(Console.ReadLine())



                    If temperatura < 0 Then
                        Console.WriteLine("Hielo")
                    ElseIf temperatura < 100 Then
                        Console.WriteLine("Agua")
                    Else
                        Console.WriteLine("Vapor")
                    End If
                Case 8
                    Dim op As Char
                    Dim n1, n2 As Integer
                    'En esta variable guardaremos la opción que
                    'desea realizar el usuario , para ello mostramos el siguiente menu
                    Console.WriteLine("Introduzca la operacion que desea realizar:")
                    Console.WriteLine("a. Sumar")
                    Console.WriteLine("b. Restar")
                    Console.WriteLine("c. Multiplicar")
                    Console.WriteLine("d. Dividir")
                    Console.WriteLine("e. Raíz de la suma.")
                    op = Convert.ToChar(Console.ReadLine())

                    Console.WriteLine("Intro n1:")
                    n1 = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Intro n2:")
                    n2 = Convert.ToInt32(Console.ReadLine())

                    Select Case op
                        Case "a"c
                            Dim suma As Integer = n1 + n2
                            Console.WriteLine("La suma es : " & suma)
                        Case "b"c
                            Dim resta As Integer = n1 - n2
                            Console.WriteLine("La resta es: " & resta)

                        Case "c"c
                            Dim multiplicacion As Long = n1 * n2
                            Console.WriteLine("La multiplicacion es : " & multiplicacion)

                        Case "d"c
                            Dim division As Double
                            If n2 = 0 Then
                                Console.WriteLine("No existe la division")
                            Else
                                division = n1 / n2
                                Console.WriteLine("La division es : " & division)
                            End If
                        Case "e"c
                            Dim suma As Integer = n1 + n2

                            If suma > 0 Then
                                Dim raiz As Double = Math.Sqrt(suma)
                            Else
                                Console.WriteLine("No existe la raiz cuadrada")
                            End If

                    End Select



                Case 9
                    Dim litros, gasto As Double
                    'Solicitamos los litros
                    Console.WriteLine("Introduzca los litros:")
                    litros = Convert.ToDouble(Console.ReadLine())

                    If litros < 50 Then
                        gasto = 0
                    ElseIf litros < 200 Then
                        gasto = (litros - 50) * 10

                    Else
                        gasto = (litros - 200) * 20 + 150 * 10

                    End If
                    'Si el gasto < 500 -->gasto = 500
                    If gasto < 500 Then
                        gasto = 500
                    End If
                    Console.WriteLine("Litros consumidos : " & litros)
                    Console.WriteLine("Gasto : " & gasto)
                Case 10
                    Dim horas, tasa, extras, salarioBruto, salarioNeto As Double

                    Console.WriteLine("Horas trabajadas:")
                    horas = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("Tasa: ")
                    tasa = Convert.ToDouble(Console.ReadLine())

                    If horas < 38 Then
                        salarioBruto = horas * tasa
                    Else
                        extras = (horas - 38)
                        salarioBruto = extras * (tasa * 1.5) + 38 * tasa
                    End If

                    If salarioBruto < 300 Then
                        salarioNeto = salarioBruto
                    Else
                        salarioNeto = salarioBruto * 0.9
                    End If

                    Console.WriteLine("Salario bruto: " & salarioBruto)
                    Console.WriteLine("Salario neto : " & salarioNeto)

                Case 11
                    Dim indicador As Integer
                    Console.WriteLine("Introduzca el indicador:")
                    indicador = Convert.ToInt32(Console.ReadLine())

                    Select Case indicador
                        Case 1
                            Console.WriteLine("Calor")
                        Case 2
                            Console.WriteLine("templado")
                        Case 3
                            Console.WriteLine("Frío")
                        Case 4
                            Console.WriteLine("Fuera de Rango")
                        Case Else
                            Console.WriteLine("Error")
                    End Select
                Case 12
                    Dim color As Char
                    Console.WriteLine("Introduce r,v,a")
                    color = Convert.ToChar(Console.ReadLine())

                    Select Case color
                        Case "r"c, "R"c
                            Console.WriteLine("ROJO")
                        Case "v"c, "V"c
                            Console.WriteLine("Verde")
                        Case "a"c, "A"c
                            Console.WriteLine("Azul")
                        Case Else
                            Console.WriteLine("Negro")

                    End Select
                Case 13
                    Dim charSeguridad As Char
                    Console.WriteLine("Desea salir s/n?")
                    charSeguridad = Convert.ToChar(Console.ReadLine())

                    If charSeguridad = "n"c Then
                        opcion = 1
                    Else
                        Console.WriteLine("Vuelva pronto")
                        System.Threading.Thread.Sleep(2000)
                        End
                    End If
                Case Else
                    Console.WriteLine("Opción errónea")
            End Select
            Console.ReadLine()
            Console.Clear()
        Loop While opcion <> 13

        Console.WriteLine("Hasta pronto!!")
        Console.ReadLine()

    End Sub

End Module
