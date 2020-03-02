Option Strict On
Imports System.IO
Module Module1

    Sub Main()

        Dim opcion As Integer = 3
        Dim ruta As String = Directory.GetCurrentDirectory()
        Dim nombreFichero As String = "misdatos.txt"
        Select Case opcion
            Case 1

                'Escribir info en un fichero
                'Obtener Ruta a bin debug

                Console.WriteLine(ruta)

                'Escribir en fichero--> StreamWriter
                Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta + "\" + nombreFichero, True)

                escritor.WriteLine("Yago tb es un crack")
                escritor.Close()

            Case 2
                Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta + "/" + nombreFichero)

                Dim contenido As String = lector.ReadToEnd()

                lector.Close()
                Console.WriteLine(contenido)
                Console.ReadLine()


            Case 3
                'Leer registro a registro
                Dim lector2 As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta + "/usuarios.txt")

                While Not lector2.EndOfStream
                    Dim registro As String = lector2.ReadLine()
                    Console.WriteLine(registro)
                End While

                lector2.Close()
        End Select


















        Console.ReadLine()
    End Sub

End Module
