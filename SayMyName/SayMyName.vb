' Miranda Breves
'RCET0265
'Spring 2022
'Say My Name
'url

Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()

        'Variable Declaration
        Dim name As String

        Console.WriteLine("Hello, what's your name?")
        name = Console.ReadLine()

        'Creating a blank space to make the interaction pretty
        Console.WriteLine()

        Console.WriteLine("It's nice to meet you, " & CStr(name) & ".")

        'Creating another blank space for formatting.
        Console.WriteLine()

        Console.WriteLine("Press any key to exit this program.")

        Console.Read()

    End Sub

End Module
