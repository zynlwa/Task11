using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task11
{
    internal class Student
    {
        private string _groupno;
        private string _fullname;
        public string Fullname
        {
            get => _fullname;
            set
            {
                if(Regex.IsMatch(value, "^[A-Z][a-z]+ [A-Z][a-z]+$")) 
                    _fullname = value;

                Console.WriteLine("Format duzgun deyil");

            }
        }
            public string GroupNo { 
            get=>_groupno;
            
            set
            {
                if(Regex.IsMatch(value, "[A-Z]{1}[1-9][0-9]{2}$"))
                {
                    _fullname=value;
                }else
                    Console.WriteLine("Duzgun formatda deyil");
              
            }
        }
        public int Age{ get; set; }

      
    }
}
