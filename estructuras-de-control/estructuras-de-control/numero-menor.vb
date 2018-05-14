Module numero_menor
    Sub main()
        Dim num1, num2, num3 As Int16
        Console.WriteLine("ingrese un numero ")
        num1 = Console.ReadLine()
        Console.WriteLine("ingrese otro numero ")
        num2 = Console.ReadLine()
        Console.WriteLine("ingrese otro numero ")
        num3 = Console.ReadLine()
        If num1 < num2 And num1 < num3 Then
            Console.WriteLine("el primer numero es el menor " & num1)
        ElseIf num2 < num1 And num2 < num3 Then
            Console.WriteLine("el segundo numero es el menor " & num2)
        ElseIf num3 < num1 And num3 < num2 Then
            Console.WriteLine("el tercer numero es el menor " & num3)
        End If

        Console.ReadKey()
    End Sub


End Module
