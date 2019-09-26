Option Strict On
Module Ejercicio4
    Sub Main()
        Console.WriteLine("Ejercicio 4")
        'Declarar las variables
        Dim radio As Double
        Dim longitud, area, volumen As Double
        '  Const PI As Double = 3.141526
        'Solicitar el radio
        Console.WriteLine("Introduzca el radio : ")
        radio = Convert.ToDouble(Console.ReadLine())

        'Calculamos la longitud , el area y el volumen
        longitud = 2 * Math.PI * radio
        area = Math.PI * Math.Pow(radio, 2)
        volumen = (4 / 3) * Math.PI * Math.Pow(radio, 3)



        'Modificar la variable area para que almacene el resultado con dos decimales
        area = Math.Round(area, 2)
        Console.WriteLine("Longitud : " & Math.Round(longitud, 2) & " Area: " & area & " Volumen: " & volumen)

        Console.ReadLine()
    End Sub
End Module
