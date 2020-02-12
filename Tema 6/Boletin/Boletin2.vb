Option Strict On
Module Boletin2

    Public Function raizCuadrada(ByVal n As Double) As Double

        If n > 0 Then
            Return Math.Sqrt(n)
        Else
            Return 0
        End If

    End Function

    Public Function raizCuadrada(ByVal n As Double, ByVal decimales As Integer) As Double
        If n > 0 Then
            Return Math.Round(Math.Sqrt(n), decimales)
        Else
            Return 0
        End If
    End Function

    Public Function minimo(ByVal x As Integer, ByVal y As Integer) As Integer
        If x < y Then
            Return x
        Else
            Return y
        End If
    End Function

    Public Function minimo(ByVal x As Double, ByVal y As Double) As Double
        If x < y Then
            Return x
        Else
            Return y
        End If
    End Function

    'Función ejercicio 4

    Public Function isPrimo(ByVal n As Integer) As Boolean
        Dim contador As Integer = 0

        For i As Integer = 2 To Convert.ToInt32(n / 2) Step 1
            If n Mod i = 0 Then
                contador += 1
                Exit For
            End If
        Next

        If contador = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Ejercicio 6

    Public Sub intercambiar(ByRef x As Integer, ByRef y As Integer)
        Dim auxiliar As Integer = x
        x = y
        y = auxiliar
    End Sub

    'ejercicio 7
    Public Sub e(ByVal mensaje As String)
        Console.WriteLine(mensaje)
    End Sub

    'ejercicio 8

    Public Sub sumaReferencia(ByVal n As Integer, ByRef suma As Integer)
        For i As Integer = 1 To n Step 1
            If n Mod i = 0 Then
                suma += i
            End If
        Next
    End Sub

    'Ejercicio 9

    Public Function buscaPrimerCero(ByRef m() As Integer) As Integer
        Dim posicion As Integer = -1

        For i As Integer = 0 To m.Length - 1 Step 1
            If m(i) = 0 Then
                posicion = i
                Exit For
            End If
        Next

        Return posicion
    End Function

    'Ejercicio 13
    'Guardar String en una matriz

    Public Sub guardarString(ByRef matriz() As String, ByRef cadena As String)
        For i As Integer = 0 To matriz.Length - 1 Step 1
            If matriz(i) Is Nothing Then
                matriz(i) = cadena
                Exit For
            End If
        Next
    End Sub

    'mostrar matriz por consola
    Public Sub mostrarMatriz(ByRef m() As Integer)
        For Each valor As Integer In m
            Console.Write(valor & " ")
        Next
        Console.WriteLine()
    End Sub

    Public Sub mostrarMatriz(ByRef m() As String)
        For Each valor As String In m
            If valor Is Nothing Then
                Exit For
            Else
                Console.WriteLine(valor & " ")
            End If

        Next

    End Sub

    Public Function contarNegativos(ByRef m() As Integer) As Integer
        Dim contador As Integer = 0
        For i As Integer = 0 To m.Length - 1 Step 1
            If m(i) < 0 Then
                contador += 1
            End If
        Next
        Return contador
    End Function
    'Ejercicio 17
    Public Function crearMatrizNumerosNegativos(ByRef n() As Integer) As Integer()
        'Crear una matriz 
        Dim numerosNegativos As Integer = contarNegativos(n)
        Dim matrizLocal(numerosNegativos - 1) As Integer
        Dim contador As Integer = 0
        For i As Integer = 0 To n.Length - 1 Step 1
            If n(i) < 0 Then
                matrizLocal(contador) = n(i)
                contador += 1
            End If
        Next
        Return matrizLocal
    End Function

    'Ejercicio 19
    Public Sub guardarStringRedimensionando(ByRef m() As String, ByRef cadena As String)
        Dim exito As Boolean = False

        For i As Integer = 0 To m.Length - 1 Step 1
            If m(i) Is Nothing Then
                m(i) = cadena
                exito = True
                Exit For
            End If
        Next

        'Preguntar si fue capaz de guardar
        If Not exito Then
            'Redimensiono la matriz
            ReDim Preserve m(m.Length)
            'Vuelvo a llamar a la función --> Recursividad
            guardarStringRedimensionando(m, cadena)
        End If



    End Sub







End Module
