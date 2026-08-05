DisplayMenu();
ChooseOption();
//function to display the menu.
static void DisplayMenu()
{
    Console.WriteLine("==========================\nCALCULATOR\n==========================");
}

//function to choose options of program
static void ChooseOption()
{
    Console.WriteLine("What kind of operation will you like to perform ?");
    Console.WriteLine("1. Addittion");
    Console.WriteLine("2. Substraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");
}

//ask user to input their desire option
Console.Write("Choose an option: ");
int option = Convert.ToInt32(Console.ReadLine());

if (option == 1)
{
    int firstInput = ReadNumber("Enter your first input: ");
    int secondInput = ReadNumber("Enter your first input: ");
    int output = Addition(firstInput, secondInput);
    Console.WriteLine($"The result of {firstInput} + {secondInput} is {output}");
}

if (option == 2)
{
    int firstInput = ReadNumber("Enter your first input: ");
    int secondInput = ReadNumber("Enter your first input: ");
    int output = Substraction(firstInput, secondInput);
    Console.WriteLine($"The result of {firstInput} - {secondInput} is {output}");
}

if (option == 3)
{
     int firstInput = ReadNumber("Enter your first input: ");
    int secondInput = ReadNumber("Enter your second input: ");
    int output = Multiplication(firstInput, secondInput);
    Console.WriteLine($"The result of {firstInput} x {secondInput} is {output}");
}

if (option == 4)
{
    int firstInput = ReadNumber("Enter your first input: ");
    int secondInput = ReadNumber("Enter your second input: ");
    int output = Division(firstInput, secondInput);
    Console.WriteLine($"The result of {firstInput} / {secondInput} is {output}");
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