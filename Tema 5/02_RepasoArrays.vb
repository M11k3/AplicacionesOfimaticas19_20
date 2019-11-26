Option Strict On
Module Module1
    Sub Main()
        Dim capacidad As Integer = 3

        Dim notas(capacidad - 1) As Integer
        Dim nombres(9) As String
        Dim temperaturas() As Single = {2.3, 6.7, 9.8, 10.4, 20.4}
        Dim alumnos() As String = {"Pablo", "Maria", "Manolo"}

        'Inicializar la matriz a valores absurdos
        'Llenar la matriz notas de numeros negativos

        For i As Integer = 0 To notas.Length - 1 Step 1
            notas(i) = -1
        Next
        Dim continuar As Char
        Dim notaGuardadaConExito As Boolean = False
        'Solicitar al usuario que introdizca una nota en la primera posición sin nota
        Do
            Dim nota As Integer
            Dim contadorFallos As Integer = 0
            Do
                Console.WriteLine("Introduzca una nota:")
                nota = Convert.ToInt32(Console.ReadLine())
                contadorFallos += 1
                If contadorFallos > 1 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Céntrate , por favor")
                End If
                Console.ForegroundColor = ConsoleColor.White
            Loop While nota < 0
            notaGuardadaConExito = False
            For i As Integer = 0 To notas.Length - 1 Step 1
                If notas(i) = -1 Then
                    notas(i) = nota
                    notaGuardadaConExito = True
                    'Salir del bucle 
                    Exit For
                End If
            Next

            If notaGuardadaConExito = False Then
                Console.WriteLine("No se ha podido guardar la nota")
            End If

            Console.WriteLine("Desea meter más notas s/n")

            continuar = Convert.ToChar(Console.ReadLine())
        Loop While continuar = "s"c

        'Visulizar el array de notas

        'Con un while porque nos gusta la marcha

        Dim j As Integer = 0

        While j < notas.Length
            Console.Write(notas(j))
            j += 1
        End While

        'Calcular la nota media

        Dim suma As Integer = 0
        Dim media As Double = 0


        For i As Integer = 0 To notas.Length - 1 Step 1
            If notas(i) >= 0 Then
                suma = suma + notas(i)
            End If
        Next

        'Media : Suma/numero de notas

        media = suma / notas.Length














        Console.ReadLine()

    End Sub

End Module
