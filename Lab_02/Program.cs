
//archaic UI
Console.WriteLine("Enter first number to be added: ");
string Number_One = Console.ReadLine() ?? "n/a";
Console.WriteLine("Enter second number to be added: ");
string Number_Two = Console.ReadLine() ?? "n/a";
//conversion from string to int32
int Number_One_Convert = Convert.ToInt32(Number_One);
int Number_Two_Convert = Convert.ToInt32(Number_Two);
//output to user
Console.WriteLine("The Sum of " + Number_One_Convert + " and " + Number_Two_Convert + " is" + "\nResult: " + (Number_One_Convert + Number_Two_Convert));
 