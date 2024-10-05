namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator!");
            Console.WriteLine("_________________");
            Console.WriteLine("Enter a and b");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("_________________");
            Console.WriteLine("Chose what to do");
            Console.WriteLine("1. ADD");
            Console.WriteLine("2. SUBTRACT");
            Console.WriteLine("3. MULTIRLY");
            Console.WriteLine("4. DIVIDE");
            Console.WriteLine("5. POWER");
            Console.WriteLine("_________________");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("_________________");
            double result = 0;
            switch (choice)
            {
                case 1: //add
                    result = Arithmetics.Add(a,b);
                    break;
                case 2: //subtract
                    result = Arithmetics.Subtract(a,b);
                    break;
                case 3: //multiply
                    result = Arithmetics.Multiply(a, b);
                    break;
                case 4: //divide
                    result = Arithmetics.Divide(a, b);
                    break;
                case 5: //power
                    result = Arithmetics.Power(a, b);
                    break;
                default: // why?
                    Console.WriteLine("I said number");
                    return;
            }
            Console.WriteLine($"Your reslt is {result}");
        }
    }
}