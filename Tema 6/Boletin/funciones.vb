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

End Module
