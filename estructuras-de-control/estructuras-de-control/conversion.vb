Module conversion
    Sub main()
        Dim cant As Int16
        Console.WriteLine("seleccione una medida ")
        Console.WriteLine("(A) pie ")
        Console.WriteLine("(B) yarda ")
        Console.WriteLine("(C) pulgada ")
        Console.WriteLine("(D) metro ")
        Console.WriteLine("(E) salir")
        Dim seleccion As Char = Console.ReadKey.KeyChar
        Console.ReadLine()
        Select Case seleccion
            Case "A"
                Console.WriteLine("ingrese unidades ")
                cant = Console.ReadLine()
                Console.WriteLine("un pie = a " & cant / 3 & " yardas, " & cant * 12 & " pulgadas " & " y " & cant * 0.3048 & " metros")
            Case "B"
                Console.WriteLine("ingrese unidades ")
                cant = Console.ReadLine()
                Console.WriteLine("una yarda = a " & cant * 3 & " pies, " & cant * 36 & " pulgadas " & " y " & cant * 0.9144 & " Metros")
            Case "C"
                Console.WriteLine("ingrese unidades ")
                cant = Console.ReadLine()
                Console.WriteLine("una pulgada = a " & cant * 36 & " yardas, " & cant * 12 & " pies " & " y " & cant / 0.0254 & " metros")
            Case "D"
                Console.WriteLine("ingrese unidades ")
                cant = Console.ReadLine()
                Console.WriteLine("un metro = a " & cant * 0.9144 & " yardas, " & cant / 0.0254 & " pulgadas " & " y " & cant / 0.3048 & " pies")
            Case Is <> "E"
                Console.WriteLine()
        End Select
        Console.ReadKey()
    End Sub
End Module
