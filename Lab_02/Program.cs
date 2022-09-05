
internal class Program
{
    private static void Main(string[] args)
    {
        //archaic UI
        Console.WriteLine("Hello");
        Console.WriteLine("Enter first number to be multiplied: ");
        string Mult_Number_One = Console.ReadLine() ?? "n/a";
        Console.WriteLine("Enter second number to be multiplied: ");
        string Mult_Number_Two = Console.ReadLine() ?? "n/a";
        //conversions to int32 from string
        int Mult_Number_One_Convert = Convert.ToInt32(Mult_Number_One);
        int Mult_Number_Two_Convert = Convert.ToInt32(Mult_Number_Two);
        // multiply and dispaly output to user
        Console.WriteLine("The product of " + Mult_Number_One_Convert + " and " + Mult_Number_Two_Convert + " is" + "\nResult: " + (Mult_Number_One_Convert * Mult_Number_Two_Convert));


    }
}
 