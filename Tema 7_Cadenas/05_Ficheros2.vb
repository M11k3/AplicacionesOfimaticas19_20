Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim opcion As Integer = 2
        'Trabajar con ficheros series
        Dim raiz As String = Directory.GetCurrentDirectory()
        Console.WriteLine(raiz)
        Dim nombre As String = "datosSeries.txt"
        Dim rutaCompleta As String = raiz + "\" + nombre
        Console.WriteLine(rutaCompleta)

        Console.ReadLine()

        Console.WriteLine("1. Guardar serie.")
        Console.WriteLine("2. Mostrar series.")
        Select Case opcion
            Case 1
                'Guardar una serie en el fichero
                Dim serie As String
                Dim valoracion As Single
                Console.WriteLine("Introduzca una serie")
                serie = Console.ReadLine

                Console.WriteLine("Introduzca una valoracion")
                valoracion = Convert.ToSingle(Console.ReadLine())

                'Guardar datos en un fichero
                '1º Crear el escritor
                Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(rutaCompleta, True)

                '2º Conwriteline escribir en el fichero
                escritor.WriteLine(serie + "*" + valoracion.ToString())

                '3ºCerrar el flujo (streamwriter)
                escritor.Close()

            Case 2
                'Mostrar todas las series
                Dim lector As StreamReader = New StreamReader(rutaCompleta)

                'Leer registro a registro

                While Not lector.EndOfStream
                    Dim registro As String = lector.ReadLine()
                    Console.WriteLine(registro)
                End While


                'cerrar lector
                lector.Close()




            Case 3
            Case 4

        End Select
        Console.ReadLine()
    End Sub

End Module
