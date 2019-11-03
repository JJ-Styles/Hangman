Imports System.IO
Module Module1
    Dim letter As String
    Dim correct As Integer = 0
    Dim attempts As Integer = 0
    Dim retry As String = "YES"
    Dim wordlength As Integer


    Sub Main()
        Dim i As Integer
        Dim read As String
        Dim line As Integer = Int(Rnd() * 300)
        Dim filename As String = "I:\Documents\Visual Studio 2013\Projects\Hangman\Hangman\bin\Debug\Random Word List.txt"
        Dim currentfilereader As New StreamReader(filename, line)
        read = System.IO.File.ReadAllLines(filename)(line)
        Dim word(read.Length) As String

        For i = 1 To read.Length
            word(read.Length) = Mid(read, i, 1)
        Next
        Console.WriteLine(word(0))
        Console.ReadLine()

        Do Until retry <> "YES"
            Do Until correct = word.Length Or attempts = 0
                Console.WriteLine("Please Guess A Letter?")
                letter = Console.ReadLine
                If letter = word(0) Then
                    Console.WriteLine("Letter Correct. Press Enter To Continue")
                    Console.ReadLine()
                    attempts = attempts - 1
                    correct = correct + 1
                ElseIf letter <> word(0) Then
                    Console.WriteLine("Letter Incorrect. Press Enter to Continue")
                    Console.ReadLine()
                    attempts = attempts - 1
                End If
            Loop
        Loop
    End Sub
End Module
