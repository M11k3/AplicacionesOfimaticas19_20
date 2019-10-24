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
            Console.WriteLine("11. Ejercicio 11")
            Console.WriteLine("12. Ejercicio 12")
            Console.WriteLine("13. Ejercicio 13")
            Console.WriteLine("14. Ejercicio 14")
            Console.WriteLine("15. Ejercicio 15")
            Console.WriteLine("16. Ejercicio 16")
            Console.WriteLine("17. Salir")

            'Leer la opción escogida por teclado
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 4
                    Dim a, b, c, d, menor As Integer
                    a = 9
                    a = 8
                    a = 3
                    a = 1

                    If a < b Then
                        If a < c Then
                            If a < d Then
                                menor = a
                            Else
                                menor = d
                            End If
                        ElseIf c < d Then
                            menor = c
                        Else
                            menor = d
                        End If
                    ElseIf b < c Then
                        If b < d Then
                            menor = b
                        Else
                            menor = d
                        End If
                    ElseIf c < d Then
                        menor = c
                    Else
                        menor = d
                    End If
                    Console.WriteLine(menor)
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

                    If horas <= 38 Then
                        salarioBruto = horas * tasa
                    Else
                        extras = (horas - 38)
                        '  Dim tasaExtra As Double = tasa + 0.5 * tasa

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
                    'Ecuación de segundo grado ax2 + bx + c = 0
                    'Declaramos variables para los coeficientes
                    Dim a, b, c As Integer

                    'Declaramos variables para las dos soluciones
                    Dim solucion1, solucion2 As Double
                    'declaro una booleano para registrar cuando no tiene solucion
                    Dim solucion As Boolean = True
                    'solicitamos al usuario que introduzca los 3 coeficientes
                    Console.WriteLine("Coeficiente a : ")
                    a = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Coeficiente b : ")
                    b = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Coeficiente c : ")
                    c = Convert.ToInt32(Console.ReadLine())

                    ' Caso a = 0
                    If a = 0 Then
                        'En este caso la solución es la misma -c/b
                        'Debemos de comprobar que b es <> 0
                        If b <> 0 Then
                            solucion1 = -c / b
                            solucion2 = solucion1
                        Else
                            'Registro que no hay solución
                            solucion = False
                        End If
                        ' Caso b = 0
                    ElseIf b = 0 Then
                        Dim radicando As Double = -c / a

                        'Debemos comprobar que radicando >  0
                        If radicando >= 0 Then
                            solucion1 = -Math.Sqrt(-c / a)
                            solucion2 = Math.Sqrt(-c / a)

                        Else
                            'Registramos que no hay solucion
                            solucion = False
                        End If
                        ' Caso c = 0
                    ElseIf c = 0 Then
                        solucion1 = 0
                        solucion2 = -b / a

                    Else
                        Dim radicando As Double = Math.Pow(b, 2) - 4 * a * c
                        'Debemos comprobar que radicando >0
                        If radicando >= 0 Then
                            solucion1 = (-b + Math.Sqrt(radicando)) / (2 * a)
                            solucion2 = (-b - Math.Sqrt(radicando)) / (2 * a)
                        Else
                            'Registramos que no hay solución
                            solucion = False
                        End If
                    End If

                    'Si hay solucion lo mostramos
                    If solucion Then
                        Console.WriteLine("Solucion 1: " & solucion1)
                        Console.WriteLine("Solucion 2: " & solucion2)
                    Else
                        Console.WriteLine("No hay solución.")
                    End If
                Case 14
                    Dim anho As Integer
                    Dim bisiesto As Boolean

                    Console.WriteLine("Introduzca el año")
                    anho = Convert.ToInt32(Console.ReadLine())

                    If anho Mod 100 = 0 And anho Mod 400 = 0 Then
                        bisiesto = True
                    ElseIf anho Mod 4 = 0 And Not anho Mod 100 = 0 Then
                        bisiesto = True
                    Else
                        bisiesto = False
                    End If


                    If anho Mod 4 = 0 Then
                        If anho Mod 100 = 0 Then
                            If anho Mod 400 = 0 Then
                                bisiesto = True
                            Else
                                bisiesto = False
                            End If
                        Else
                            bisiesto = True
                        End If
                    Else
                        bisiesto = False

                    End If

                    If bisiesto Then
                        Console.WriteLine("Bisiesto")
                    Else
                        Console.WriteLine("No bisiesto.")
                    End If

                Case 15
                    Dim n1, n2, n3 As Integer
                    Dim menor, medio, mayor As Integer
                    Console.WriteLine("Introduce n1:")
                    n1 = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Introduce n1:")
                    n2 = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Introduce n1:")
                    n3 = Convert.ToInt32(Console.ReadLine())

                    If n1 < n2 And n1 < n3 Then
                        menor = n1
                        If n2 < n3 Then
                            medio = n2
                            mayor = n3
                        Else
                            medio = n3
                            mayor = n2
                        End If
                    ElseIf n2 < n1 And n2 < n3 Then
                        menor = n2
                        If n1 < n3 Then
                            medio = n1
                            mayor = n3
                        Else
                            medio = n3
                            mayor = n1
                        End If
                    Else
                        menor = n3
                        If n2 < n1 Then
                            medio = n2
                            mayor = n1
                        Else
                            medio = n1
                            mayor = n2
                        End If

                    End If

                    Console.WriteLine(menor & " " & medio & " " & mayor)

                Case 16
                    Dim precio1, precio2, precio3, precioTotal, precioDescuento As Double
                    precio1 = 90
                    precio2 = 123
                    precio3 = 900

                    precioTotal = precio1 + precio2 + precio3

                    If precioTotal < 500 Then
                        precioDescuento = precioTotal
                    ElseIf precioTotal < 1000 Then
                        precioDescuento = precioTotal * 0.97
                    ElseIf precioTotal < 2000 Then
                        precioDescuento = precioTotal * 0.95
                    ElseIf precioTotal <= 3000 Then
                        precioDescuento = precioTotal * 0.93
                    Else
                        precioDescuento = precioTotal * 0.9
                    End If

                    Console.WriteLine("Precio final : " & precioTotal)
                    Console.WriteLine("Precio rebajado : " & precioDescuento)















                Case 20
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
        Loop While opcion <> 20

        Console.WriteLine("Hasta pronto!!")
        Console.ReadLine()

    End Sub

End Module
