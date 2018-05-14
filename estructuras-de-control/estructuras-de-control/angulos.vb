Module angulos
    Sub main()
        Dim num As Int16
        Dim caso As Byte
        Console.WriteLine("ingrese los grados del angulo: ")
        num = Console.ReadLine()
        If num <> 0 Then

            If num < 90 Then
                caso = 1
            ElseIf num = 90 Then
                caso = 2
            ElseIf num > 90 And num < 180 Then
                caso = 3
            ElseIf num = 180 Then
                caso = 4
            ElseIf num > 180 And num < 361 Then
                caso = 5
            ElseIf num > 360 Then
                caso = 6
            End If
            Select Case caso
                Case 1
                    Console.WriteLine("el angulo es agudo ")
                Case 2
                    Console.WriteLine("el angulo es recto ")
                Case 3
                    Console.WriteLine("el angulo es obtuso ")
                Case 4
                    Console.WriteLine("el angulo es llano ")
                Case 5
                    Console.WriteLine("el angulo es concavo ")
                Case 6
                    Console.WriteLine("error ")
            End Select
        Else
            Console.WriteLine("error")
        End If
        Console.ReadKey()

    End Sub
End Module
