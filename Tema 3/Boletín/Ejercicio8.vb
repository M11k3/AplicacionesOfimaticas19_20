
Module Ejercicio8
    Sub Main()
        Dim password1, password2 As String
        password1 = "montecastelogmi1920"

        'Solicitar password al usuario
        Console.WriteLine("Introduzca su password")
        password2 = Console.ReadLine()

        If password1 = password2 Then
            Console.WriteLine("Contraseña correcta , puede acceder")
        Else
            Console.Beep(450, 1000)
            Console.WriteLine("LLamando al F.B.I.")
        End If
        Console.ReadLine()





    End Sub
End Module
