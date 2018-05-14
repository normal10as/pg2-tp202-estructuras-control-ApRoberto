Module descuentos_case
    Sub main()
        Dim cant As Int16
        Dim precio As Int16
        Dim total As Int16
        Dim casos As Int16
        Console.WriteLine("ingrese cantidad ")
        cant = Console.ReadLine()
        Console.WriteLine("ingrese precio ")
        precio = Console.ReadLine()
        If cant < 10 Then
            casos = 1
        End If
        If cant > 9 And cant < 50 Then
            casos = 2
        End If
        If cant > 51 And cant < 250 Then
            casos = 3
        End If
        If cant > 251 Then
            casos = 4
        End If
        Select Case casos
            Case 1
                total = (cant * precio)
                Console.WriteLine("el precio unitario  es $" & (total / cant) & vbCrLf)
                Console.WriteLine("el precio total es $" & total)
            Case 2
                total = (cant * precio) - (cant * precio * 0.05)
                Console.WriteLine("el precio unitario es $" & (total / cant) & vbCrLf)
                Console.WriteLine("el precio total $" & total & vbCrLf)
                Console.WriteLine("el descuento es 5%")
            Case 3
                total = (cant * precio) - (cant * precio * 0.1)
                Console.WriteLine("el precio unitario es " & (total / cant) & vbCrLf)
                Console.WriteLine("el precio total es " & total & vbCrLf)
                Console.WriteLine("el descuento es 10% ")
            Case 4
                total = (cant * precio) - (cant * precio * 0.2)
                Console.WriteLine("el precio unitario es " & (total / cant) & vbCrLf)
                Console.WriteLine("el precio total es " & total & vbCrLf)
                Console.WriteLine("el descuento es 20% ")
        End Select
        Console.ReadKey()
    End Sub
End Module
