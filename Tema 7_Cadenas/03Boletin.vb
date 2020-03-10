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

    Public Function contarSubstrings(ByRef mensaje As String) As Integer
        Dim partes() As String = mensaje.Split(" "c)
        Dim contador As Integer = 0
        For Each p As String In partes
            If p.Contains("aba") Then
                contador += 1
            End If
        Next
        Return contador
    End Function
    Public Function contarSubstrings(ByRef mensaje As String, ByRef patron As String) As Integer
        Dim partes() As String = mensaje.Split(" "c)
        Dim contador As Integer = 0
        For Each p As String In partes
            If p.Contains(patron) Then
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
        Dim ejercicio As Integer = 9

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
                Dim dni As String = "53817232P"
                Dim caracteres9, digitos8, ultimaLetra As Boolean
                digitos8 = True
                '1º Comprobar que tenemos 9 caracteres
                If dni.Length = 9 Then
                    caracteres9 = True
                    '2º 8 primeros son dígitos y el último es una letra
                    Dim ochoDigitos As String = dni.Substring(0, 8)
                    For i As Integer = 0 To ochoDigitos.Length - 1 Step 1
                        If Not Char.IsDigit(ochoDigitos(i)) Then
                            digitos8 = False
                            Exit For
                        End If
                    Next

                    'El último es una letra?
                    If Char.IsLetter(dni(dni.Length - 1)) And Char.IsUpper(dni(8)) Then
                        ultimaLetra = True
                    End If
                Else
                    caracteres9 = False
                End If

                'Si el dni tiene el formato correcto compruebo la letra
                If caracteres9 And digitos8 And ultimaLetra Then
                    'Dividir entre 23 el número del DNI
                    Dim numeroDNI As Integer = Convert.ToInt32(dni.Substring(0, 8))
                    Dim resto As Integer = numeroDNI Mod 23

                    If letras(resto) = dni(dni.Length - 1) Then
                        Console.WriteLine("Su dni es correcto")
                    Else
                        Console.WriteLine("La letra no se corresponde con el dni")
                    End If
                Else
                    If caracteres9 = False Then
                        Console.WriteLine("Número de caracteres incorrecro")
                    End If
                    If digitos8 = False Then
                        Console.WriteLine("Hay una letra en el número de DNI")
                    End If
                    If ultimaLetra = False Then
                        Console.WriteLine("Error en última letra")
                    End If

                End If
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

            Case 5
                Dim frase As String = "Caminaba por el bosque y soñaba con las mariposas"
                Dim palabrasConAba As Integer = contarSubstrings(frase)
                Dim palabrasConOsas As Integer = contarSubstrings(frase, "osas")

            Case 6
                Dim correo As String = "direccion@gmail.com"
                Dim partes() As String = correo.Split("@"c)(1).Split("."c)

                For Each trozo As String In partes
                    Console.WriteLine(trozo)
                Next

            Case 7
                Dim codigo As String = "ER34"

                If codigo.Length = 4 Then
                    If Char.IsLetter(codigo(0)) And Char.IsLetter(codigo(1)) And Char.IsDigit(codigo(2)) And Char.IsDigit(codigo(3)) Then
                        Console.WriteLine("Correcto")
                    Else
                        Console.WriteLine("Incorrecto")
                    End If
                Else
                    Console.WriteLine("Incorrecto")
                End If

            Case 8
                Dim cadena As String = "- a - - a -"
                cadena = cadena.Replace(" "c, "*"c)
                'Alerta Spoiler Ahorcado!!!!!!!!!
                Dim caracteres() As Char = cadena.ToCharArray()

                caracteres(1) = "a"c
                caracteres(4) = "a"c
                cadena = caracteres.ToString()

                '************ FIN SPOILER********************

            Case 9
                Dim cadena1 As String = "Miguel*14deJulio?7000"
                Dim posInterrogacion As Integer = cadena1.IndexOf("?"c)
                Dim salario As String = cadena1.Substring(posInterrogacion + 1)

                Console.WriteLine(salario)

                Dim salarioNumero As Integer = Convert.ToInt32(salario)

                If salarioNumero > 1000 Then
                    Console.WriteLine("Salario > 1000")
                Else
                    Console.WriteLine("Salario < 1000")
                End If





















        End Select
        Console.ReadLine()
    End Sub

End Module
