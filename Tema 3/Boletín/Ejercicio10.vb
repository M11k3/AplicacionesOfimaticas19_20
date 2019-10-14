Module Ejercicio10
    Sub Main()
        Dim presion, temperatura As Double

        Console.WriteLine("Introduzca la temperatura: ")
        temperatura = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca la presión: ")
        presion = Convert.ToDouble(Console.ReadLine())

        If presion > 2 Then
            Console.WriteLine("Abrir válvula de seguridad.")
        End If

        If temperatura > 500 Then
            Console.WriteLine("Reducir la temperatura.")
        End If

        If presion < 2 And temperatura <= 500 Then
            Console.WriteLine("Todo en orden.")
        End If






    End Sub
End Module
