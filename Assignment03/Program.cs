namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int choice;
            do{
                Console.WriteLine("Enter 1st Number ");
                String num1Value = Console.ReadLine();
                int num1 = int.Parse(num1Value);
                Console.WriteLine("Enter 2nd Number ");
                String num2Value = Console.ReadLine();
                int num2 = int.Parse(num2Value);
                Console.WriteLine("Press 0 for EXIT");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division");
                Console.WriteLine("Enter your choice");
                String choiceValue = Console.ReadLine();
                choice = int.Parse(choiceValue);



                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thank You");
                        break;
                    case 1:
                        int addition = add(num1, num2);
                        Console.WriteLine("Addition of two numbers is " + addition);
                        break;
                    case 2:

                        Console.WriteLine("Substraction of two numbers is " + sub(num1, num2));
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


            } while (choice != 0) ;
            Console.WriteLine("Press Any Key to Exit");
            Console.ReadKey();
        }

        static int add(int num1, int num2) { return num1 + num2; }
        static int sub(int num1, int num2) { return num1 - num2; }

        static int mul(int num1, int num2) { return num1 * num2; }

        static int div(int num1, int num2) { return num1 / num2; }
    }
}
