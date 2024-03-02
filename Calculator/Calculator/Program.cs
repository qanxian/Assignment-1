// See https://aka.ms/new-console-template for more information

namespace myApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            string num = "";
            char sym;
            int num1,num2;
            int res = 0;

            Console.Write("Please enter the first number: ");
            num = Console.ReadLine();
            num1 = Int32.Parse(num);
            Console.Write("Please enter the second number: ");
            num = Console.ReadLine();
            num2 = Int32.Parse(num);

            Console.Write("Please enter the operator: ");
            sym = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (sym)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
                default:
                    res = 0;
                    break;
            }
            Console.WriteLine("The result of the calculation is: "+res);
        }
    }
}
