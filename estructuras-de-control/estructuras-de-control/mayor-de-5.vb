Module mayor_de_5
    Sub main()
        Dim num1, num2, num3, num4, num5 As Int16
        Console.WriteLine("ingrese primer numero ")
        num1 = Console.ReadLine()
        Console.WriteLine("ingrese segundo numero ")
        num2 = Console.ReadLine()
        Console.WriteLine("ingrese tercero numero ")
        num3 = Console.ReadLine()
        Console.WriteLine("ingrese cuarto numero ")
        num4 = Console.ReadLine()
        Console.WriteLine("ingrese quinto numero ")
        num5 = Console.ReadLine()
        If num1 > num2 And num1 > num3 And num1 > num4 And num1 > num5 Then
            Console.WriteLine("el primer numero es el mayor ")
        ElseIf num2 > num1 And num2 > num3 And num2 > num4 And num2 > num5 Then
            Console.WriteLine("el segundo numero es el mayor ")
        ElseIf num3 > num1 And num3 > num2 And num3 > num4 And num3 > num5 Then
            Console.WriteLine("el tercer numero es el mayor ")
        ElseIf num4 > num1 And num4 > num3 And num4 > num2 And num4 > num5 Then
            Console.WriteLine("el cuarto numero es el mayor ")
        ElseIf num5 > num1 And num5 > num2 And num5 > num3 And num5 > num4 Then
            Console.WriteLine("el quinto numero es el mayor ")

        End If
        Console.ReadKey()
    End Sub
End Module
