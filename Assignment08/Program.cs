using System.Xml.Linq;

namespace Assignment08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.AcceptEmployee();
            employee.PrintEmployee();
            Employee employee1 = new Employee();
            employee1.AcceptEmployee();
            employee1.PrintEmployee();
        }
    }


}
