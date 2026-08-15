using System.IO.Pipelines;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

bool running = true;
static void DisplayMenu()
    {
        Console.WriteLine("==========================\nCALCULATOR\n==========================");
        Console.WriteLine("What kind of operation will you like to perform ?");
        Console.WriteLine("1. Addittion");
        Console.WriteLine("2. Substraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Exit");
    }
while (running)
{
    DisplayMenu();

    //ask user to input their desire option
    Console.Write("Choose an option: ");
    //int option = Convert.ToInt32(Console.ReadLine());
    string? option = Console.ReadLine();
    if (int.TryParse(option, out int validInput))
    {
        validInput = Convert.ToInt32(option);
    }
    else
    {
        Console.WriteLine("Enter a valid input.");
        continue;
    }
    switch (validInput)
    {
        case 1:
            int firstInput = ReadNumber("Enter your first input: ");
            int secondInput = ReadNumber("Enter your second input: ");
            int output = Addition(firstInput, secondInput);
            Console.WriteLine();
            Console.WriteLine($"The result of {firstInput} + {secondInput} is {output}");
            Console.WriteLine();
            break;
        case 2:
            firstInput = ReadNumber("Enter your first input: ");
            secondInput = ReadNumber("Enter your second input: ");
            output = Substraction(firstInput, secondInput);
            Console.WriteLine();
            Console.WriteLine($"The result of {firstInput} - {secondInput} is {output}");
            break;
        case 3:
            firstInput = ReadNumber("Enter your first input: ");
            secondInput = ReadNumber("Enter your second input: ");
            output = Multiplication(firstInput, secondInput);
            Console.WriteLine();
            Console.WriteLine($"The result of {firstInput} x {secondInput} is {output}");
            Console.WriteLine();
            break;
        case 4:
            firstInput = ReadNumber("Enter your first input: ");
            secondInput = ReadNumber("Enter your second input: ");
            bool notZero = true;
            while (notZero)
            {
                if (secondInput == 0)
                {
                    Console.WriteLine("You cannot divide by zero");
                    secondInput = ReadNumber("Enter your second number: ");
                }
                else
                {
                    notZero = false;
                }
            }
                output = Division(firstInput, secondInput);
                Console.WriteLine();
                Console.WriteLine($"The result of {firstInput} / {secondInput} is {output}");
                Console.WriteLine();
                break;
        case 5:
            running = false;
            break;
        default:
            Console.WriteLine("option does not exist");
            Console.WriteLine();
            break;
    }
}


//function to read num from console.
static int ReadNumber(string message)
{
    bool isNotNumber = true;
    int result = 0;
    while (isNotNumber)
    {
        Console.Write($"{message}");
        string? readFromConsole = Console.ReadLine();
        if (int.TryParse(readFromConsole, out result))
        {
            isNotNumber = false;
        }
        else
        {
            Console.WriteLine("Error input, enter a number");
        }
    }
    return result;
}
//Addition program
static int Addition(int a, int b)
{
    return a + b;
}

//Substraction program
static int Substraction(int a, int b)
{
    return a - b;
}

//Multiplication program
static int Multiplication(int a, int b)
{
    return a * b;
}

 static int Division(int a, int b)
{
    return a / b;
}