Module relacion

    Sub Main()
        Dim a, b As Int16
        Console.WriteLine("ingrese primer numero: ")
        a = Console.ReadLine()
        Console.WriteLine("ingrese segundo numero: ")
        b = Console.ReadLine()

        If a > b Then
            Console.WriteLine("el numero " & a & " es mayor ")

        ElseIf a < b Then

            Console.WriteLine("el numero " & b & " es mayor")
        Else
            Console.WriteLine("los numeros son iguales ")
        End If
        Console.ReadKey()
    End Sub

End Module
