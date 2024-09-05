using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Registration
{  
    public class StudentInfoClass
    {
        public delegate string DelegateText();  
        public delegate long DelegateNumber();

        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName() => FirstName;
        public static string GetLastName() => LastName;
        public static string GetMiddleName() => MiddleName;
        public static string GetAddress() => Address;
        public static string GetProgram() => Program;
        public static long GetAge() => Age;
        public static long GetContactNo() => ContactNo;
        public static long GetStudentNo() => StudentNo;
    }

}
