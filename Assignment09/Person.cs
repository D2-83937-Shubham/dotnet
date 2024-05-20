namespace Assignment08
{
    public class Person
    {
        private string _Name;
        private bool _Gender;
        private Date _Birth;
        private string _Address;
        
        public Person()
        {
            Date d = new Date();
            _Birth = d;
        }

        public Person(string name, bool gender, Date birth, string address) 
        {
            Date d = new Date(birth.Day,birth.Month,birth.Year);
            _Birth = d;
            _Name = name;
            _Gender = gender;
            _Address = address;
            
        }

        public void AcceptPerson()
        {
            Console.WriteLine("Enter Name");
            _Name = Console.ReadLine();
            Console.WriteLine("Enter Gender True or false");
            _Gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter For Date");
            _Birth.AcceptDate();
            Console.WriteLine("Enter Address");
            _Address = Console.ReadLine();

        }

        public void PrintPerson()
        {
            Console.WriteLine(ToString());
        }

        public string Address
        {
            get { return _Address; }

        }

        public Date Birth
        {
            get { return _Birth; }

        }

        public bool Gender
        {
            get { return _Gender; }

        }

        public string Name
        {
            get { return _Name; }
        }


        public override string ToString()
        {
            int year = DateTime.Parse(DateTime.Now.ToString()).Year;
            return "Name - " +_Name+ " Gender - "+_Gender+ " BirthDate - "+_Birth+ " Address - "+_Address+ " Age - "+(year - _Birth.Year) ;
        }

    }


}
