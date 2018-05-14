Module dias_del_mes
    Enum meses
        enero = 1
        febrero = 2
        marzo = 3
        abril = 4
        mayo = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre = 9
        octubre = 10
        noviembre = 11
        diciembre = 12
    End Enum
    Sub main()
        Dim mes As meses
        Dim año As Int16
        Console.WriteLine("ingrese un mes ")
        mes = Console.ReadLine()
        Console.WriteLine("ingrese año")
        año = Console.ReadLine()

        If mes = 1 Then
            Console.WriteLine("el mes de " & mes.ToString & " tiene 31 dias ")
        ElseIf mes = 2 Then
            If año Mod 400 = 0 Then
                Console.WriteLine("el mes de " & mes.ToString & " tiene 29 dias ")
            Else
                Console.WriteLine("el mes de " & mes.ToString & " tiene 28 dias ")
            End If
        ElseIf mes = 3 Then
                Console.WriteLine("el mes de " & mes.ToString & " tiene 31 dias ")
            ElseIf mes = 4 Then
                Console.WriteLine("el mes de " & mes.ToString & " tiene 30 dias ")
            ElseIf mes = 5 Then
                Console.WriteLine("el mes de " & mes.ToString & " tiene 31 dias ")
            ElseIf mes = 6 Then
                Console.WriteLine("el mes de " & mes.ToString & " tiene 30 dias ")
            ElseIf mes = 7 Then
                Console.WriteLine("el mes de " & mes.ToString & " tiene 31 dias ")
            ElseIf mes = 8 Then
                Console.WriteLine("el mes de " & mes.ToString & " tiene 31 dias ")
            ElseIf mes = 9 Then
                Console.WriteLine("el mes de " & mes.ToString & " tiene 30 dias ")
            ElseIf mes = 10 Then
                Console.WriteLine("el mes de " & mes.ToString & " tiene 31 dias ")
            ElseIf mes = 11 Then
                Console.WriteLine("el mes de " & mes.ToString & " tiene 30 dias ")
            ElseIf mes = 12 Then
                Console.WriteLine("el mes de " & mes.ToString & " tiene 31 dias ")

        End If
        Console.ReadKey()

    End Sub
End Module
