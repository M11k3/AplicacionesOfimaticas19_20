Option Strict On
Module Module1

    Sub Main()
        Dim edad As Byte
        Dim nombre As String
        'Para leer por teclado seguimos los siguientes pasos:
        '1. Mostrar mensaje solicitando el dato
        Console.WriteLine("Introduzca su edad: ")
        '2. Guardar el dato introducido en una variable
        '3. Convertir , si es necesario de String al tipo de variable destino
        edad = Convert.ToByte(Console.ReadLine())
        'Solicitar el nombre
        '1. Mensaje solicitando nombre:
        Console.WriteLine("Dime tu nombre: ")
        '2. Asignar el valor a la variable nombre
        nombre = Console.ReadLine()

        Console.WriteLine(nombre & " Tienes " & edad & " años.")

        Console.ReadLine()

    End Sub

End Module
