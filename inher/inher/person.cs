using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inher
{
    class person
    {
        private string _Name;
        private string _Address;
        private string _phone;
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        private string _GetpersonData()
        {
            return _Name + ";" + _Address + ";" + _phone;
        }
        public string GetPersonData()
        {
            return _GetpersonData().Replace(";", "\n");
        }
        public void Printpersondata()
        {
            Console.WriteLine(GetPersonData());



        }
    }
}

