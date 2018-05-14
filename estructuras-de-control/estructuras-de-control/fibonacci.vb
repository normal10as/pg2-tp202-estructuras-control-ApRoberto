Module fibonacci
    Sub main()
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim c As Integer
        Console.WriteLine("la secuencia es ")
        While c < 200
            c = a + b
            a = b
            b = c
            Console.WriteLine(c)
        End While
        Console.ReadKey()
    End Sub
End Module
