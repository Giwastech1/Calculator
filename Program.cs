//DisplayMenu();
//function to display the menu.
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
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
        case 1:
            int firstInput = ReadNumber("Enter your first input: ");
            int secondInput = ReadNumber("Enter your second input: ");
            int output = Addition(firstInput, secondInput);
           Console.WriteLine($"The result of {firstInput} + {secondInput} is {output}");
            Console.WriteLine();
        break;
    case 2:
        firstInput = ReadNumber("Enter your first input: ");
        secondInput = ReadNumber("Enter your second input: ");
        output = Substraction(firstInput, secondInput);
        Console.WriteLine($"The result of {firstInput} - {secondInput} is {output}");
        break;
    case 3:
        firstInput = ReadNumber("Enter your first input: ");
        secondInput = ReadNumber("Enter your second input: ");
        output = Multiplication(firstInput, secondInput);
        Console.WriteLine($"The result of {firstInput} x {secondInput} is {output}");
        break;
    case 4:
        firstInput = ReadNumber("Enter your first input: ");
        secondInput = ReadNumber("Enter your second input: ");
        if (secondInput == 0)
        {
                Console.WriteLine("You cannot divide by zero");
                return;
        }
        output = Division(firstInput, secondInput);
        Console.WriteLine($"The result of {firstInput} / {secondInput} is {output}");
            break;
        case 5:
            running = false;
            break;
    default:
        Console.WriteLine("Wrong input");
        break;
}
}


//function to read num from console
static int ReadNumber(string message)
{
    Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
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