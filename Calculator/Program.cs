namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My first calculator");

            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            Console.Write("Enter the operation number: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case 1:
                    result = Calculator.Add(num1, num2);
                    break;
                case 2:
                    result = Calculator.Subtract(num1, num2);
                    break;
                case 3:
                    result = Calculator.Multiply(num1, num2);
                    break;
                case 4:
                    result = Calculator.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}