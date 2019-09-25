Module Module1

    Sub Main()
        'Las variables sirven para almacenar datos--> reservar memoria
        'Tipos de variables:
        'Numéricas : byte (8 bits) , short(16 bits) , integer , long
        'Declaración de variable sin inicializar
        Dim numeroAlumnos As Byte = 9
        'Dar de baja un alumno
        numeroAlumnos = numeroAlumnos - 1
        Dim temperatura As SByte = -2
        'Bajar 3 grados la temperatura del planeta
        temperatura = temperatura - 3
        'Declaración e inicialización de una variable
        Dim sociosCelta As Short = 20000

        'aumentar número de socios
        sociosCelta = sociosCelta + 1000

        'Mostrar por pantalla los valores de las variables
        Console.WriteLine("La temperatura es de " & temperatura & " grados.")
        Console.WriteLine("Socios del celta: " & sociosCelta)


        'Numéricas con decimales
        Dim notaMedia As Single = 5.3
        Dim notaMediaPrecisa As Double = 5.123456789

        'Letras
        Dim letra As Char = "a"
        Dim cadena As String = "Hay que programar bien"

        'Booleanas : true o false
        Dim condicion As Boolean = True

        Console.ReadLine()


    End Sub

End Module
