using Assignment08;

namespace Assignment09
{
    public class Supervisor : Employee
    {
        private int _Subordinates;

        public int Subordinates
        {
            get { return _Subordinates; }
            set { _Subordinates = value; }
        }

        public Supervisor()
        {
            base.Designation = "Supervisor";
        }

        public Supervisor(int subordinates)
        {
            _Subordinates = subordinates;
            base.Designation = "Supervisor";
        }

        public void AcceptSupvervisor()
        {
            base.AcceptPerson();
            Console.WriteLine("Enter Salary");
            base.Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Dept Type");
            base.DepartmentType = Console.ReadLine();
            Console.WriteLine("Enter Subordinates");
            _Subordinates = Convert.ToInt32(Console.ReadLine());
            
        }

        public void PrintSupervisor()
        {
            base.PrintEmployee();
            Console.WriteLine("Subordinates - " + _Subordinates);
        }





    }
}
