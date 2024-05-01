// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
//-------------------------Methods------------------------------------------------

/* Public static---we include static because we are working inside of a main file
 * String- Return Type
 * ReturnHelloUser-Method Name
 * String user-Parameter
 * Public static ReturnHelloUser (string user)
 * 
 * {"Method Body"
 * string greeting =$"Hello,{user}!";
 * return greeting;
 * }*/
//Main Code
string result = ReturnHelloUser("Ramsey");
Console.WriteLine(result);

Console.WriteLine(Adder(2,3));

//room example
int num1 = GetPositiveInput();
Console.WriteLine(num1);
int num2 = GetPositiveInput();
Console.WriteLine(num2);

//Menu
DisplayMenu();

//Methods
static string ReturnHelloUser(string user)
{
    string greeting = $"Hello {user}!";
    return greeting;
}

static int Adder(int x, int y)
{
    return x + y;
}

static int GetPositiveInput()
{
    int result = -1;
    while (result < 0)
    {
        Console.WriteLine("Please enter a positive number.");
        result = int.Parse(Console.ReadLine());
    }

    return result;

}

static void DisplayMenu()
{
    Console.WriteLine("1.See all items");
    Console.WriteLine("2.Buy Item");
    Console.WriteLine("3.Pay");
    Console.WriteLine("4.Quit");
}