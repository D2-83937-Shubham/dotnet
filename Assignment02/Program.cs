namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                int num1 = int.Parse(args[0]);
                int num2 = int.Parse(args[1]);
                int ope = int.Parse(args[2]);

                switch (ope)
                {
                    case 1:
                        int addition = add(num1 , num2);
                        Console.WriteLine("Addition of two numbers is "+addition);
                        break;
                    case 2:
              
                        Console.WriteLine("Substraction of two numbers is "+ sub(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication of two numbers is " + mul(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("Division of two numbers is " + div(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }
            Console.ReadKey();

        }

        static int add(int num1, int num2) { return num1 + num2; }
        static int sub(int num1, int num2) { return num1 - num2; }

        static int mul(int num1, int num2) { return num1 * num2; }

        static int div(int num1, int num2) { return num1 / num2; }

   
        

        
    }
}
