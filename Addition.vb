'Addition.vb
'Addition program

Module modAddition

    Sub Main()
        
        'Variables for storing the user input
        Dim firstNumber, secondNumber As String 
        
        'Variables used in addition calculation
        Dim number1, number2, sumOfNumbers As Integer
        
        'Read first number from the user
        Console.WriteLine("Please Enter The First Integer")
        
        'Read second number from the user
        firstNumber = Console.ReadLine()
        Console.WriteLine("Please Enter The Second Integer")
        secondNumber = Console.ReadLine()
        
        'convert input values to the integers
        number1 = firstNumber
        number2 = secondNumber
        
        sumOfNumbers = number1 + number2 'Add numbers
        
        'Display results
        Console.WriteLine("The Sum is {0}", sumOfNumbers)
    End Sub

End Module

'Line 9 and 12 are declarations,which begin with the keyword Dim.
'The words firstNumber,secondNumber,number1,number2 and sumOfNumber
I'are the name of variables or locations in the computer's memory  
n'where memory can be stored for use by the program.The declaration in
'line 9 specifies that the variables firstNumber and secondNumber are
'data of type string, which indicates that these variables store
'string of characters. Line 12 indicates that variables store integer 
'values(i.e Whole Number such as 919,-11,0 and 138624).Data types 
'already defined in Visual Basic, such as String and Integer are known
'as Built-in data types or primitive data types. Primitive data type 
'name are keywords.

'A variable name can be a valid identifier. Variables of the same type
I'can be declared in seperate statements or they can be declared in one 
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

'Lines 19-20 prompt the user to enter a second integer and assign the input value to the
'secondNumber.User input from the command window is sent to the console application as a
'String. For example, if the user types the character 7 and 2 and then press Enter, the 
'value returned by ReadLine is "72".To perform arithmetic operations using the input values,
'the Strings first must be converted to the Integer.

'Line 23-24 implicitly convert the two Strings typed by the user to the integer values.Visual
'Basic performs the data-type conversions whenever necessary. In this case, the assignment of
'a String value to an Integer variable(i.e, number1) invokes the conversion because Integer
'variables can accept only integer values. The value obtained by converting the String value in
'the line 23 is assigned to Integer variable number1. In this program, any subsequent references 
'to the value of number1 indicate this Integer value. Likewise,the Integer value obtained by
'converting the String in the line 24 is assigned to the variable number2.The value of number2
'refers to this Integer value in the ensuing discussion.The values stored in the firstNumber and
'secondNumber remain Strings.

'Alternatively, this implicit conversion, can be performed so as to eliminate the need for the 
'String variables.For example,
'      Dim number1 As Integer
'      number1  = Console.ReadLine()
'does not use the String variable (i.e, firstNumber). In this case, Visual Basic knows that the 
'Console.ReadLine returns the string, and the program performs the necessary conversion.When the
'String is both read and converted in the single line of code, the String variable (i.e firstNumber)
'becomes unnecessary.

'The Assignment statement on the line 26 calculates the sum of the Integer variables number1 and 
'number2 and assigns the result to variable sumOfNumbers, using the assignment operator,=.The
'statement is read as, "sumOfNumbers gets the value of number1+number2."Most calculations are performed 
'in Assignment statements.

'After the calculation is completed, line 29 displays the result of the addition
'
'
'
'
'
'
'
'
'
'
'
'
'

