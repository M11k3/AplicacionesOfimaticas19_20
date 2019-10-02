Module Ejercicio10
    Sub Main()
        'Leer horas trabajadas en un mes y la tasa a la que se pagan
        Dim horasTrabajadas As Integer
        Dim tasaHora As Double
        Dim salarioBruto, salarioNeto As Double

        'Solicitamos horas trabajadas
        Console.WriteLine("Introduzca las horas trabajadas: ")
        horasTrabajadas = Convert.ToInt32(Console.ReadLine())

        'Solicitamos tasa
        Console.WriteLine("Introduzca tasa : ")
        tasaHora = Convert.ToDouble(Console.ReadLine())

        'Calculamos el salario bruto
        salarioBruto = horasTrabajadas * tasaHora

        'El salario neto es el salario bruto - 21%

        salarioNeto = salarioBruto - 0.21 * salarioBruto

        'Informamos por consola de los dos salarios
        Console.WriteLine("Salario bruto : " & salarioBruto)
        Console.WriteLine("Salario neto : " & salarioNeto)
        Console.ReadLine()
    End Sub
End Module
