using Assignment08;

namespace Assignment09
{
    public class Manager : Employee
    {
        private double _Bonus;

        public double Bonus
        {
            get { return _Bonus; }
            set { _Bonus = value; }
        }

        public Manager()
        {
            base.Designation = "Manager";
        }

        public Manager(double bonus)
        {
            _Bonus = bonus;
            base.Designation = "Manager";
        }

        public void AcceptManager()
        {
            base.AcceptPerson();
            Console.WriteLine("Enter Salary");
            base.Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Bonus");
            _Bonus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Dept Type");
            base.DepartmentType = Console.ReadLine();
        }

        public void PrintManager()
        {
            base.PrintEmployee();
            Console.WriteLine("Bonus - "+_Bonus);
        }





    }
}
