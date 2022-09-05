
internal class Program
{
    private static void Main(string[] args)
    {
        //archaic UI
        Console.WriteLine("Hello");
        //addition
        Console.WriteLine("Enter first number to be added: ");
        string Number_One = Console.ReadLine() ?? "n/a";
        Console.WriteLine("Enter second number to be added: ");
        string Number_Two = Console.ReadLine() ?? "n/a";
        //conversion from string to int32
        int Number_One_Convert = Convert.ToInt32(Number_One);
        int Number_Two_Convert = Convert.ToInt32(Number_Two);
        //output to user
        Console.WriteLine("The Sum of " + Number_One_Convert + " and " + Number_Two_Convert + " is" + "\nResult: " + (Number_One_Convert + Number_Two_Convert));

        //muliplication
        Console.WriteLine("Enter first number to be multiplied: ");
        string Mult_Number_One = Console.ReadLine() ?? "n/a";
        Console.WriteLine("Enter second number to be multiplied: ");
        string Mult_Number_Two = Console.ReadLine() ?? "n/a";
        //conversions to int32 from string
        int Mult_Number_One_Convert = Convert.ToInt32(Mult_Number_One);
        int Mult_Number_Two_Convert = Convert.ToInt32(Mult_Number_Two);
        // multiply and display output to user
        Console.WriteLine("The product of " + Mult_Number_One_Convert + " and " + Mult_Number_Two_Convert + " is" + "\nResult: " + (Mult_Number_One_Convert * Mult_Number_Two_Convert));

        //modulo
        Console.WriteLine("Enter firt number to be modulated: ");
        string Modulo_Number_One = Console.ReadLine() ?? "n/a";
        Console.WriteLine("Enter second number to be modulated: ");
        string Modulo_Number_Two = Console.ReadLine() ?? "n/a";
        //conversions to int32 from string
        int Modulo_Number_One_Convert = Convert.ToInt32(Modulo_Number_One);
        int Modulo_Number_2_Convert = Convert.ToInt32(Modulo_Number_Two);
        // modulo and display output to user
        Console.WriteLine("The remainder of " + Modulo_Number_One_Convert + " and " + Modulo_Number_2_Convert + " is" + "\nResult: " + (Mult_Number_One_Convert % Mult_Number_Two_Convert));
    }
}
 