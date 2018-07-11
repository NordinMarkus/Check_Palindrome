Module Module1
    'Skapad av Markus Nordin
    'Kolla om en sträng är Palindrome. Alltså stavas samma åt båda hållen som racecar
    Sub Main()
        Dim testString As New List(Of String)
        Dim word As String = ""
        Dim Buffer() As Char = ""
        Dim MaxWords As Integer = 0
        Dim AntalPalinDrome As Integer = 0
        testString.Add("palindrome")
        testString.Add("racecar")
        testString.Add("anna")
        testString.Add("volvo")
        testString.Add("radar")
        MaxWords = testString.Count
        Console.WriteLine("Kollar igenom en lista av ord" & vbNewLine)
        For Each word In testString
            Buffer = word
            Array.Reverse(Buffer)
            If Buffer = word Then
                AntalPalinDrome = AntalPalinDrome + 1
                Console.WriteLine(Buffer)
            End If
        Next

        Console.WriteLine(vbNewLine & "Hittade " & AntalPalinDrome & " palindromes" & vbNewLine)
        Console.WriteLine("Tryck på en knapp för att fortsätta")
        Console.ReadKey()
    End Sub

End Module
