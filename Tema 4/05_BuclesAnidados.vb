Option Strict On
Module Module1

    Sub Main()
        ' 1 1 1 1 1 1 1 1 1 
        ' 2 2 2 2 2 2 2 2 2
        '...
        ' n n n n n n n n n
        Dim n As Integer = 10

        For j As Integer = 1 To n Step 1
            For i As Integer = 1 To 9 Step 1
                Console.Write(j & " ")
            Next i
            Console.WriteLine()
        Next j




        Console.ReadLine()
    End Sub

End Module
