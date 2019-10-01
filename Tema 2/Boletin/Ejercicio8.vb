Option Strict On
Module Ejercicio8
    Sub Main()
        'Establecemos título de la consola
        Console.Title = "Ejercicio 8"
        'Cambiamos el color
        Console.ForegroundColor = ConsoleColor.White

        'Declaramos las variables
        Dim presion, volumen, temperatura, numeroMoles As Double
        'Declaramos la constante R
        Const R As Double = 0.082

        'Solicitamos al usuario la temperatura , el volumen y el número de moles
        Console.WriteLine("Introduzca la temperatura: ")
        temperatura = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca el volumen: ")
        volumen = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca número de moles: ")
        numeroMoles = Convert.ToDouble(Console.ReadLine())

        'Calculamos la presion según formula

        presion = (numeroMoles * R * temperatura) / volumen

    End Sub
End Module
