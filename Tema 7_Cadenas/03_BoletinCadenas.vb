Option Strict On
Module Module1

    'función ejercicio 1
    Public Function contarCaracteres(ByRef cadena As String, ByVal caracter As Char) As Integer
        Dim contador As Integer = 0

        For i As Integer = 0 To cadena.Length - 1 Step 1
            If cadena(i) = caracter Then
                contador += 1
            End If
        Next
        Return contador
    End Function

    Public Function detectarArroba(ByRef email As String) As Boolean
        If email.Contains("@") Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub Main()
        Dim ejercicio As Integer = 1

        Select Case ejercicio
            Case 1
                Dim cadena As String = "Hola caracola"
                Dim caracter As Char = "a"c
                Dim contador As Integer = contarCaracteres(cadena, caracter)


                If contador = 0 Then
                    Console.WriteLine("No está el caracter en la frase")
                Else
                    Console.WriteLine(caracter & " aparece " & contador & " veces")
                End If

            Case 2
                Dim letras() As Char = {"T"c, "R"c, "W"c, "A"c, "G"c, "M"c, "Y"c, "F"c, "P"c, "D"c, "X"c, "B"c, "N"c, "J"c, "Z"c, "S"c, "Q"c, "V"c, "H"c, "L"c, "C"c, "K"c, "E"c}
                Dim dni As String = "12345780E"
                Dim caracteres9, digitos8, ultimaLetra As Boolean

                '1º Comprobar que tenemos 9 caracteres
                '2º 8 primeros son dígitos y el último es una letra
                '3º La letra se corresponde con la correcta
                ' a) Obtener la parte numérica del dni-> substring
                ' b) Pasar a integer

                ' c) Dividir ese número entre 23 y coger el resto

            Case 3
                Dim frase As String = "El Madrid este año no gana nada y el depor desciende"
                Dim palabras() As String = frase.Split(" "c)

                For Each p As String In palabras
                    If p.StartsWith("b") Or p.StartsWith("O") Then
                        Console.WriteLine(p)
                    End If
                Next

            Case 4
                Dim email As String = "josedacosta@atiende.com"

                If detectarArroba(email) Then
                    Console.WriteLine("Contiene una arroba")
                Else
                    Console.WriteLine("No tiene arrobas")
                End If











        End Select
    End Sub

End Module
