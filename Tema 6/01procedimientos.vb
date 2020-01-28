Module Procedimientos

    'Printar por consola una matriz
    Public Sub printaMatriz(ByRef matriz() As Integer)

        For i As Integer = 0 To matriz.Length - 1 Step 1
            Console.Write(matriz(i) & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
