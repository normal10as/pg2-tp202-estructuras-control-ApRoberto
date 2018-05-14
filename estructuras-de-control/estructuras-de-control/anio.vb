Module anio

    Sub main()
        Dim num As Byte
        Console.WriteLine("ingrese un numero de mes: ")
        num = Console.ReadLine()
        If num > 1 And num < 12 Then
            Select Case num
                Case 1
                    Console.WriteLine("el mes es enero ")
                Case 2
                    Console.WriteLine("el mes es febrero ")
                Case 3
                    Console.WriteLine("el mes es marzo ")
                Case 4
                    Console.WriteLine("el mes es abril ")
                Case 5
                    Console.WriteLine("el mes es mayo ")
                Case 6
                    Console.WriteLine("el mes es junio ")
                Case 7
                    Console.WriteLine("el mes es julio ")
                Case 8
                    Console.WriteLine("el mes es agosto ")
                Case 9
                    Console.WriteLine("el mes es septiembre ")
                Case 10
                    Console.WriteLine("el mes es octubre ")
                Case 11
                    Console.WriteLine("el mes es noviembre ")
                Case 12
                    Console.WriteLine("el mes es diciembre ")

            End Select
        Else
            Console.WriteLine("valor no correspondiente")
        End If
        Console.ReadKey()

    End Sub
End Module
