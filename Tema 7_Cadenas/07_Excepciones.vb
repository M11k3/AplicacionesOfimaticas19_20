Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim ruta As String = Directory.GetCurrentDirectory() + "\datos.txt"
        Dim registros(49) As String
        Dim i As Integer = 0
        Dim lector As StreamReader = New StreamReader(ruta)

        While Not lector.EndOfStream
            Dim registro As String = lector.ReadLine()
            If registros(i) Is Nothing Then
                registros(i) = registro
                i = i + 1
            End If

        End While

        lector.Close()

        'Mostrar registros matriz

        For Each valor As String In registros
            If Not valor Is Nothing Then
                Console.WriteLine(valor)
            Else
                Exit For
            End If

        Next
        Console.ReadLine()
    End Sub

End Module
