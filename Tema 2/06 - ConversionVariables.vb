Option Strict On
Module Module1

    Sub Main()
        'Operador : Es un símbole que realiza una acción
        'Operadores matemáticos
        '+ (suma) , - (resta) , * (multiplicacion) ,
        '/ (division) , Mod (resto de la division entera)
        Dim x As Integer = 4 + 5
        Dim y As Integer = x + 10

        'Operador division:Devuelve double
        'Si quiero almacenar el resultado en un Integer
        'Tengo que realizar una conversión explícita de Double a Integer

        Dim resultado As Integer = Convert.ToInt32(x / 7)
        Console.WriteLine("Resultado de x/7 = " & resultado)

        'Conversiones implícitas permitidas:
        'byte-->short
        Dim b1 As Byte = 10
        Dim s2 As Short = b1
        'Prohibido b1 = s2 , la debo de forzar

        b1 = Convert.ToByte(s2)

        'short-->Integer
        Dim entero As Integer = s2

        'Prohibido s2 = entero , tengo que hacer con un convert
        s2 = Convert.ToInt16(entero)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("S2 = " & s2)

        'Integer-->Long
        Dim enteroLargo As Long = entero
        entero = Convert.ToInt32(enteroLargo)

        'single --> double
        Dim decimalSimple As Single = 5.6
        Dim decimalDoble As Double = decimalSimple
        decimalSimple = Convert.ToSingle(decimalDoble)



        Console.ReadLine()
    End Sub

End Module
