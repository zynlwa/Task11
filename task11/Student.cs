using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
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
                string[]  full=  value.Trim().Split(' ');
                if(full.Length== 2 && !string.IsNullOrWhiteSpace(full[0]) && !string.IsNullOrWhiteSpace(full[1]))
                {
                    _fullname=value;
                    return;
                }else
                    Console.WriteLine("Format duzgun deyil");

            }
        }
            public string GroupNo { 
            get=>_groupno;
            
            set
            {
                if (value.Length == 4) {
                    char firsttLetter = value[0];
                   
                    bool IsDigit = char.IsDigit(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]);
                    if (char.IsUpper(firsttLetter) && IsDigit)
                    {
                        _groupno = value;
                        return;
                    }

                }
                Console.WriteLine("Duzgun daxil edilmeyib");
            }
        }
        public int Age{ get; set; }
        string n = default;
        

    }
}
