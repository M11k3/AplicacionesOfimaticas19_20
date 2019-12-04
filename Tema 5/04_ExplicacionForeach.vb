Option Strict On
Module Module1

    Sub Main()
        Dim alumnos() As String = {"Szymon", "Alexandre", "Carni", "Ucha", "Angel"}
        Console.ForegroundColor = ConsoleColor.White
        For i As Integer = 0 To alumnos.Length - 1 Step 1
            Console.Write(alumnos(i) & " ")

        Next
        'Recorrer la matriz con un For Each
        Console.WriteLine()
        For Each alumno As String In alumnos
            Console.Write(alumno & " ")

        Next

        Dim alumnoBuscado As String
        Dim encontrado As Boolean = False
        Console.WriteLine("Introduzca alumno que desea buscar:")
        alumnoBuscado = Console.ReadLine()

        For Each a As String In alumnos
            If alumnoBuscado = a Then
                Console.WriteLine("Alumno encontrado")
                encontrado = True
                Exit For

            End If
        Next

        If Not encontrado Then
            Console.WriteLine("Alumno no encontrado")
        End If

        Dim notas() As Integer = {3, 8, 3, 1, 2}

        Dim suma As Integer = 0
        Dim media As Double = 0

        For Each n As Integer In notas
            suma = suma + n
        Next
        media = suma / notas.Length





        Console.WriteLine()
        Console.ReadLine()






    End Sub

End Module
