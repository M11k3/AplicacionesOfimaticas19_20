Option Strict On

Module MenuBoletin3
    Sub Main()
        Dim ejercicio As Integer
        Do


            Console.WriteLine("Escoja un ejercicio: 4 - 12")
            Console.WriteLine("4. Menor de 4 variables")
            Console.WriteLine("5. Comprobar número par.")
            Console.WriteLine("6. Alumno aprobado o suspenso")
            Console.WriteLine("13. Salir.")

            ejercicio = Convert.ToInt32(Console.ReadLine())

            Select Case ejercicio
                Case 4
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

                Case 5
                    Console.WriteLine("Se está ejecutando ejercicio 5")

                Case Else
                    Console.WriteLine("Opción errónea")
            End Select
            Console.ReadLine()
            Console.Clear()
        Loop While ejercicio <> 13
        Console.WriteLine("Ha salido del programa")
        Console.ReadLine()







    End Sub
End Module
