namespace Assignment08
{
    public class Employee : Person
    {
        private int _Id ;
        private double _Salary;
        private string _Designation;
        private string _DepartmentType;
        private static int GenerateId = 1;

        public Employee()
        {
            this._Id = GenerateId;
            GenerateId = GenerateId + 1;
        }

        public Employee(int id, double salary, string designation, string departmentType)
        {
            this._Id = GenerateId;
            GenerateId = GenerateId + 1;
            _Salary = salary;
            _Designation = designation;
            _DepartmentType = departmentType;
        }

        public string DepartmentType
        {
            get { return _DepartmentType; }
            set { _DepartmentType = value; }
        }


        public string Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
        }


        public double Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public void AcceptEmployee()
        {
            base.AcceptPerson();
            Console.WriteLine("Enter Salary");
            _Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Designation");
            _Designation = Console.ReadLine();
            Console.WriteLine("Enter Dept Type");
            _DepartmentType = Console.ReadLine();
            
        }

        public void PrintEmployee()
        {
            base.PrintPerson();
            Console.WriteLine(_Id);
            Console.WriteLine(_Salary);
            Console.WriteLine(_Designation);
            Console.WriteLine(_DepartmentType);
        }

        public override string ToString()
        {
            return base.ToString() + " Id- "+_Id + " Salary- "+_Salary + " Designation- "+_Designation +" Department Type- "+_DepartmentType;
        }

    }


}
