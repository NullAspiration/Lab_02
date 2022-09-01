Console.WriteLine("Hello");
Console.WriteLine("Enter first number to be added: ");
string Number_One =  Console.ReadLine() ?? "n/a";
Console.WriteLine("Enter second number to be added: ");
string Number_Two = Console.ReadLine() ?? "n/a";

int Number_One_Convert = Convert.ToInt32(Number_One);
int Number_Two_Convert = Convert.ToInt32(Number_Two);

Console.WriteLine("The Sum of " + Number_One_Convert + " and " + Number_Two_Convert + " is" + "\nResult: " + (Number_One_Convert + Number_Two_Convert));
