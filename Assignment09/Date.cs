namespace Assignment08
{
    public class Date
    {
        private int _Day;
        private int _Month;
        private int _Year;

        public Date()
        {

        }
        public Date(int day, int month, int year)
        {
            _Day = day;
            _Month = month;
            _Year = year;
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter Day");
            _Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month");
            _Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year");
            _Year = Convert.ToInt32(Console.ReadLine());
            if (IsValid())
            {
                Console.WriteLine("Accepted");
            }
            else
            {
                Console.WriteLine("Date is INVALID !! RE-ENTER");
                AcceptDate();
            }
        }

        public void PrintDate()
        {
            if (IsValid())
            {
                Console.WriteLine(_Day.ToString() + "/" + _Month.ToString() + "/" + _Year.ToString());
            }
            else
            {
                Console.WriteLine("Date is not valid");
            }

        }
        public bool IsValid()
        {
            if (_Day < 1 || _Day > 31)
                return false;
            else if (_Month < 1 || _Month > 12)
                return false;
            else if (_Year < 1 || _Year > 9999)
                return false;
            else return true;

        }
        public int Day { get { return _Day; } set { _Day = value; } }
        public int Month { get { return _Month; } set { _Month = value; } }

        public int Year { get { return _Year; } set { _Year = value; } }

        public override string ToString() { return _Day.ToString() + "/" + _Month.ToString() + "/" + _Year.ToString(); }
    }


}

