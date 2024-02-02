using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Staff
    {/// <summary>
    /// описание полей
    /// </summary>
        public int EmployeeId;
        public string FullName;
        public DateTime DateOfBirth;
        public string Position;
        public int Salary;
        /// <summary>
        /// метод
        /// </summary>
        /// <returns></returns>
        public int Age()
        {
                DateTime cd = DateTime.Now;
                int age = cd.Year - DateOfBirth.Year;
                if (cd < DateOfBirth.AddYears(age))
                {
                    age--;
                }
                return age;
            
        }
    }
}
