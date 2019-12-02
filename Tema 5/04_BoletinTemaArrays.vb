Option Strict On
Module Module1

    Sub Main()

        Dim ejercicio As Integer = 2

        Select Case ejercicio
            Case 1
                Dim array(4) As Short
                array(0) = 4
                array(1) = 8
                array(3) = 14

                'Mostrar todos los valores

                Console.WriteLine("Valores guardados en el array del ej 1")

                For i As Integer = 0 To array.Length - 1 Step 1
                    Console.Write(array(i) & " ")
                Next

                'Solicitar valor al usuario y guardarlo en la última posición
                Console.WriteLine("Intro valor para guardar en la última posicición")
                array(array.Length - 1) = Convert.ToInt16(Console.ReadLine())

                Console.WriteLine("ültima posición: " & array(array.Length - 1))

            Case 2
                Dim matriz() As Integer = {4, 7, 2, 7, 9}

                Dim suma As Integer = 0
                Dim media As Double = 0

                For i As Integer = 0 To matriz.Length - 1 Step 1
                    suma = suma + matriz(i)

                Next
                media = suma / matriz.Length


                Console.WriteLine("La media es : " & media)

                'solicitar al usuario 5 nuevos valores

                For i As Integer = 0 To matriz.Length - 1 Step 1
                    Console.WriteLine("Intro nuevo valor posición : " & i)
                    matriz(i) = Convert.ToInt32(Console.ReadLine())
                Next

                'resetear suma y media
                suma = 0
                media = 0

                For i As Integer = 0 To matriz.Length - 1 Step 1
                    suma = suma + matriz(i)

                Next
                media = suma / matriz.Length


                Console.WriteLine("La nueva media es : " & media)















        End Select




        Console.ReadLine()







    End Sub

End Module
