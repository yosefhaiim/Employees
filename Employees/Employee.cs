using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Employee
    {
        public Employee(
            int _Code,
            string _Id,
            string _FitstName,
            string _LastName,
            DateTime _BithDay,
            bool _isMale,
            string _Status,
            string _Telephon,
            string _CelPhone,
            string _City,
            string _Street,
            string _Number
            ) 
        {
            Code = _Code;
            ID = _Id;
            FirstName = _FitstName;
            LastName = _LastName;
            Birthday = _BithDay;
            IsMale = _isMale;
            Status = _Status;
            Telephon = _Telephon;
            CelPhone = _CelPhone;
            City = _City;
            Street = _Street;
            Number = _Number;
        }
        public int Code { get; set; }
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FulName { get { return FirstName + " " + LastName; } }
        public DateTime Birthday { get;set; }
        public int Age { get { return DateTime.Now.Year - Birthday.Year; } }
        public bool IsMale { get; set; }
        public string Status { get; set; }
        public string Telephon { get; set; }
        public string CelPhone { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Address { get { return City + " " + Street + " " + Number; } }


    }

}
// חדש העמוד ברשות הרבים

/*namespace HamoodBershutHarabim
{
    internal class Pillar
    {
        public Pillar
            (
            int _width,
            int _high,
            bool _location
            )
        {
            width = _width;
            high = _high;
            location = _location;
        }

        public int width { get; set; }
        public int high { get; set; }
        public bool location { get; set; }
    }

    public String TypeOfPillar()
    {
        switch ()
    }

}*/


