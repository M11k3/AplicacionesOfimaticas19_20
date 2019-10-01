Option Strict On
Module Ejercicio7
    Sub Main()
        'Establecemos el título de la consola
        Console.Title = "Ejercicio 7"
        'Cambiamos el color
        Console.ForegroundColor = ConsoleColor.White
        'Declaración de variables
        Dim celsius, fahrenheit As Double ' Lo declaramos como double ya
        'que pueden contener decimales y da menos problemas que declararlas de tipo Single aunque ocupen más memoria
        'Solicitamos por teclado que introduzca los celsius
        Console.WriteLine("Introduzca los grados celsius")
        'Guardamos la cantidad introducida en la variable celsius
        celsius = Convert.ToDouble(Console.ReadLine())
        'Como la función Console.ReadLine devuelve un String es necesario pasarla a Double
        'Ahora calculamos los fahrenheit según fórmula dada en el enunciado
        fahrenheit = (9 / 5) * celsius + 32
        'Finalmente mostramos el cálculo por pantalla

        Console.WriteLine(celsius & " celsius = " & fahrenheit & " fahrenheit")
        Console.ReadLine()
    End Sub
End Module
