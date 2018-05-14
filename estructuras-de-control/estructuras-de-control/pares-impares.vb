Module pares_impares
    Sub main()
        Dim num As Integer
        Dim par As Integer = 0
        Dim impar As Integer = 0
        Dim cont As Integer = 0
        Console.WriteLine("ingrese un numero")
        num = Console.ReadLine()

        Do While num <> 0
            If num > 0 Then
                cont += 1
            ElseIf num Mod 2 = 0 Then
                par += 1
                Console.WriteLine("el numero es par " & num)
            Else
                impar += 1
                Console.WriteLine("el numero es impar ")
            End If
        Loop

        Console.ReadKey()
    End Sub
End Module
