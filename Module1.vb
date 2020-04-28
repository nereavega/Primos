Module Module1
    Sub main()
        Dim numero As Integer
        Dim resultado As Integer

        Console.WriteLine("Introduzca un número")
        numero = Console.ReadLine()
        resultado = ContadorPrimos(numero)

        Console.WriteLine("El número de primos entre 0 y " + numero + " es: " + resultado)
    End Sub

    Private Function ContadorPrimos(n As Integer) As Integer
        Dim total As Integer = 1
        For i As Integer = 1 To n
            Dim contador As Integer
            Dim div As Integer = i
            Do While div > 0
                If (i Mod div = 0) Then
                    contador = contador + 1
                    div = div - 1
                Else
                    div -= 1
                End If
            Loop
        Next i
        Return total
    End Function
End Module
