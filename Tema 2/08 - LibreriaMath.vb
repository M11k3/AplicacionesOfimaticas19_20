
Module Module1

    Sub Main()
        'Librería Math: Librería que contiene las principales
        'funciones matemáticas. No es necesario importarla.
        'Raíz cuadrada : Math.sqrt(numero)--> devuelve siempre un double
        Dim numero As Integer = 4
        Dim raizCuadrada As Double = Math.Sqrt(numero)
        'Vamos a comprobar el cálculo:
        Console.WriteLine("Raiz cuadrada de " & numero & " = " & raizCuadrada)

        'Potencias: x elevado a y
        'Math.pow(base , exponente) --> Devuelve un double
        'Solicitar al usuario la base y el exponente
        Dim base, exponente As Integer
        Dim potencia As Double
        Console.Write("Introduzca la base : ")
        base = Convert.ToInt32(Console.ReadLine())
        'Solicitamos el exponente
        Console.Write("Introduzca el exponente: ")
        exponente = Convert.ToInt32(Console.ReadLine())

        potencia = Math.Pow(base, exponente)
        'Otra forma de calcular potencias en VB.net es con el operador ^
        potencia = base ^ exponente

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(base & " elevado a " & exponente & " = " & potencia)

        'Funciones de redondeo de decimales
        'Estas funciones no modifican la variable original , sino que generan
        'un nuevo valor con la aproximación deseada
        Console.WriteLine()
        Console.WriteLine("****************************************")
        Console.WriteLine(" Funciones de redondeo y ajuste de decimales :")
        raizCuadrada = Math.Sqrt(13)
        Console.WriteLine()
        Console.WriteLine("Raiz de 13 = " & raizCuadrada)
        'Función Math.floor(numero) -->Devuelve el numero entero más cercano por abajo
        Console.WriteLine("Math.floor(raizCuadrada) : " & Math.Floor(raizCuadrada))
        'Función Math.ceiling(numero) --> Devuelve el número entero más cercano por arriba
        Console.WriteLine("Math.ceiling(raizCuadrada) : " & Math.Ceiling(raizCuadrada))
        'Función Math.round(numero)--> Devuelve el número entero más cercano
        Console.WriteLine("Math.round(raizCuadrada) : " & Math.Round(raizCuadrada))
        'Función Math.round(numero,cantidad decimales) --> Devuelve el número con la cantidad de decimales indicada
        Console.WriteLine("Math.round(raizCuadrada,4) : " & Math.Round(raizCuadrada, 4))
        Console.WriteLine()
        'La variable raiz cuadrada no se ve modificada por la llamada a las funciones anteriores,
        'ya que estas funciones no modifican la variable original , simplemente generan un nuevo valor
        Console.WriteLine("Raiz de 13 = " & raizCuadrada)

        'Si lo que quiero es modificar la variable original
        raizCuadrada = Math.Round(raizCuadrada)
        Console.WriteLine("Raiz de 13 = " & raizCuadrada)
        Console.WriteLine()
        Console.WriteLine("*********************")
        Console.WriteLine()
        'Esta librería define dos constantes : Math.PI y Math.E
        Console.WriteLine("Constantes librería Math: ")
        Console.WriteLine()
        Console.WriteLine("Pi = " & Math.PI)
        Console.WriteLine("e = " & Math.E)

        'Podemos definir nuestras propias constantes
        Const GRAVEDAD As Double = 9.81
        Dim masa As Double = 23
        Dim peso As Double = masa * GRAVEDAD





        Console.ReadLine()
    End Sub

End Module
