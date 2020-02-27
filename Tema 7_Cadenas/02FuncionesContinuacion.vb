Option Strict On
Imports LibreriaProyecto.MiConsola
Module Module1

    Sub Main()
        Dim cadena As String = " 12345678A*Manuel Sanchez Fernandez*manusa@gmasil.com*45 "
        'indexOf(c as Char)--> Devuelve la posición de la primera aparición de un caracter
        Dim posPrimerAsterisco As Integer = cadena.IndexOf("*")
        Dim posSegundoAsterisco As Integer = cadena.IndexOf("*", posPrimerAsterisco + 1)
        'substring(index as Integer)-->Devuelve los caracteres desde el índice indicado hasta el final
        Dim dni As String = cadena.Substring(0, posPrimerAsterisco)
        Dim nombre As String = cadena.Substring(posPrimerAsterisco + 1, posSegundoAsterisco - posPrimerAsterisco - 1)
        Console.WriteLine("El dni es : " & dni)
        Console.WriteLine("Segundo asterisco: " & posSegundoAsterisco)
        Console.WriteLine("Nombre: " & nombre)

        'split(c as Char)--> Devuelve una matriz de strings
        Dim trocitos() As String = cadena.Split("*"c)

        'Recorremos matriz de trocitos:

        For Each trozo As String In trocitos
            Console.WriteLine(trozo)
        Next

        'Comprobar que el dominio de la direccion de correo es de gmail

        If trocitos(2).EndsWith("gmail.com") Then
            Console.WriteLine("El correo es de gmail")
        Else
            Console.WriteLine("No es de gmail")
        End If

        'replace(old as Char, new as Char)--> Genera un nuevo String con el nuevo
        Dim cadenaNueva As String = cadena.Replace("*"c, "?"c)
        Console.WriteLine(cadenaNueva)
        Console.WriteLine(cadena)

        'trim()
        Dim cadena3 As String = cadena.Trim().Replace("*"c, "-"c)

        Console.WriteLine(cadena3)

        'concat() --> Operador + --> Concatenar dos Strings

        Dim c1 As String = "Ángel e Iago"
        Dim c2 As String = "no están atendiendo"
        Dim c3 As String = c1 + c2
        Dim c4 As String = c1.Concat(c2)
        Dim c5 As String = String.Concat(c1, " ", c2, " y van a suspender")

        Dim z As Integer = 34
        Dim z2 As Integer = 45
        '3445
        Dim zFinal As String = z.ToString() + z2.ToString()
        'Pasar cualquier variable a String -->toString
        Dim zCadena As String = z.ToString()



        Console.WriteLine(c5)
        e("Lo que tu quieras")

        Console.ReadLine()


    End Sub

End Module
