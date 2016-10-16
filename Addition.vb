Module modAddition

    Sub Main()
        Dim firstNumber, secondNumber As String 'Line 9
        Dim number1, number2, sumOfNumbers As Integer 'Line 12
        Console.WriteLine("Please Enter The First Integer") 'Line 15
        firstNumber = Console.ReadLine()
        Console.WriteLine("Please Enter The Second Integer")
        secondNumber = Console.ReadLine()
        number1 = firstNumber
        number2 = secondNumber
        sumOfNumbers = number1 + number2
        Console.WriteLine("The Sum is {0}", sumOfNumbers)
    End Sub

End Module

'Line 9 and 12 are declarations,which begin with the keyword Dim.
'The words firstNumber,secondNumber,number1,number2 and sumOfNumber
'are the name of variables or locations in the computer's memory  
'where memory can be stored for use by the program.The declaration in
'line 9 specifies that the variables firstNumber and secondNumber are
'data of type string, which indicates that these variables store
'string of characters. Line 12 indicates that variables store integer 
'values(i.e Whole Number such as 919,-11,0 and 138624).Data types 
'already defined in Visual Basic, such as String and Integer are known
'as Built-in data types or primitive data types. Primitive data type 
'name are keywords.

'A variable name can be a valid identifier. Variables of the same type
'can be declared in seperate statements or they can be declared in one 
'The latter format uses a comma-separated list of variable names.

'Line 15 prompts the user to enter the first integers that will be added
'together.Line 16 obtains the value entered by the user and assigns it to
'variable firstNumber. The argument passed to Write(line 15) is called a 
'prompt, because it directs the user to take a specific action. The method
'ReadLine(Line 16) causes the program to pause and wait for the user input.
'After entering the integer via the keyword. the user presses the Enter key
'to send the integer to the program.

'Technically,the user can send any character to the program as innput.For
'this program, if the user types the non-integer value, such as "hello",a
'runtime error(an error that has its effect at execution time) occurs.
'_______________________________________________________________________________________
'| Microsoft Development Environment                                                    |
'|______________________________________________________________________________________|
'|   /\    An unnhandled exception of Type 'Syatem.InvalidCastException' occured in     |
'|  / !\   microsoft.visualbasic.dll                                                    |
'| /____\                                                                               |
'|        Additional information:Cast from string "hello" to type 'Integer' is not valid|                                                                        
'|                                                                                      |
'|__________     ____________    ___________       ___________                          |
'||Break    |    |Continue   |   | Ignore   |      | Help    |                          |
'||_________|    |___________|   |__________|      |_________|                          |   
'|______________________________________________________________________________________|
'

'Once the user has entered a number and pressed enter,this number is assigned to 
'the variable firstNumber(line 16) with the assignment operator,=.The statement 
'is read as,"firstNumber gets the value returned by method ReadLine of the Console
'class." The assignment operator is called binary operator,because it has two operands
'firstNumber and the value returned by Console.ReadLine.The entire statement is called
'an assignment statement because it assigns the value to the variable.
'
'
'
'
