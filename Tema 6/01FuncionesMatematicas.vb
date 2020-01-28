Module FuncionesMatematicas

    Public Function sumar2Numeros(ByVal x1 As Integer, ByVal x2 As Integer) As Integer
        'Dim suma As Integer = x1 + x2
        'Return suma
        Return x1 + x2
    End Function

    'Función que devuelve una matriz de tamaño n llena con números aleatorios entre 0 y 100

    Public Function generarMatriz(ByVal n As Integer) As Integer()
        Dim matrizLocal(n - 1) As Integer
        Dim aleatorio As Random = New Random()

        For i As Integer = 0 To matrizLocal.Length - 1 Step 1
            matrizLocal(i) = aleatorio.Next(0, 101)
        Next
        Return matrizLocal

    End Function

    Public Function generarMatriz(ByVal n As Integer, ByVal min As Integer, ByVal max As Integer) As Integer()
        Dim matrizLocal(n - 1) As Integer
        Dim aleatorio As Random = New Random()

        For i As Integer = 0 To matrizLocal.Length - 1 Step 1
            matrizLocal(i) = aleatorio.Next(min, max + 1)
        Next
        Return matrizLocal
    End Function

End Module
