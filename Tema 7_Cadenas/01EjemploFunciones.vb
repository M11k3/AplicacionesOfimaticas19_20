Option Strict On
Module Module1

    Sub Main()
        'Strings y Ficheros
        Dim mensaje As String = "En un lugar de la Mancha"

        'Array de caracteres
        Dim numeroDeCaracteres As Integer = mensaje.Length
        Console.WriteLine(numeroDeCaracteres)

        Dim primerCaracter As Char = mensaje(0)

        Console.WriteLine("Primera letra: " & primerCaracter)

        'indexOf(c as char)--> Me devuelve la posición de la primera aparición de c

        Dim posicion As Integer = mensaje.IndexOf("z"c)

        Console.WriteLine("primera aparicion de a" & posicion)

        'indexOfAny(matriz() as Char)--<Busca la primera aparición de un array de chars
        Dim vocales() As Char = {"a"c, "e"c, "E"c, "i"c}
        Dim primeraVocal As Integer = mensaje.IndexOfAny(vocales)

        'contains(cadena as String)-->Devuelve true si encuentra ese String dentro del String
        Dim condicion As Boolean = mensaje.Contains("Man")
        If condicion Then
            Console.WriteLine("Aparece")
        Else
            Console.WriteLine("No aparece")
        End If

        'Métodos para saber que tipo de caracter contiene una variable de tipo Char
        Dim c1 As Char = "t"c

        If Char.IsDigit(c1) Then

        ElseIf Char.IsLetter(c1) Then
            If Char.IsUpper(c1) Then

            ElseIf Char.IsLower(c1) Then

            End If
        ElseIf Char.IsSymbol(c1) Then
        ElseIf Char.IsWhiteSpace(c1) Then

        Else

        End If

        'Algoritmo que detecte la primera posición un digito en un String
        Dim posicionDigito As Integer = -1
        For i As Integer = 0 To mensaje.Length - 1 Step 1

            If Char.IsDigit(mensaje(i)) Then
                posicionDigito = i
                Exit For
            End If

        Next

        Console.ReadLine()
    End Sub

End Module
