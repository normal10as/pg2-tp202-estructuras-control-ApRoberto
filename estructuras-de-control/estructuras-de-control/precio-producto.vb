Module precio_producto
    Sub main()
        Dim cant As Int16
        Dim pre As Single
        Dim total As Single
        Console.WriteLine("ingrese cantidad de productos ")
        cant = Console.ReadLine()
        Console.WriteLine("ingrese precio unitario ")
        pre = Console.ReadLine()
        If cant >= 10 And cant <= 50 Then
            total = (cant * pre) - (cant * pre * 0.05)
            Console.WriteLine("el precio con un 5% de descuento es $" & total)
        ElseIf cant >= 51 And cant <= 250 Then
            total = (cant * pre) - (cant * pre * 0.1)
            Console.WriteLine("el precio con un 10 % de descuento es $" & total)
        ElseIf cant >= 251 Then
            total = (cant * pre) - (cant * pre * 0.2)
            Console.WriteLine("el precio con un 20% de descuento es $" & total)
        ElseIf cant < 10 Then
            total = cant * pre
            Console.WriteLine("el precio total es de $" & total)

        End If
        Console.ReadKey()
    End Sub

End Module
